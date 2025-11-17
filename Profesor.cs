using System;
using System.Collections.Generic;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 8 TP3

public class Profesor : Persona, IComparable, IObservado
{
    private int antiguedad;
    private IEstrategiaDeComparacion estrategia;

    // Lista para almacenar a los observadores (los alumnos)
    private List<IObservador> observadores = new List<IObservador>();
    public Profesor(string n, int d, int a, IEstrategiaDeComparacion e) : base(n, d)
    {
        this.antiguedad = a;
        this.estrategia = e;
    }
    public int GetAntiguedad()
    {
        return this.antiguedad;
    }
    public void setEstrategia(IEstrategiaDeComparacion e)
    {
        this.estrategia = e;
    }
    public void HablarALaClase()
    {
        Console.WriteLine("Hablando de algún tema");
        // Notifica a los observadores sobre la acción "Hablar"
        notificar("hablar"); 
    }
    public void EscribirEnElPizarron()
    {
        Console.WriteLine("Escribiendo en el pizarrón");
        // Notifica a los observadores sobre la acción "Escribir"
        notificar("escribir");
    }
    public bool sosIgual(IComparable c)
    {
        return this.estrategia.SosIgual(this, c);
    }
    public bool sosMenor(IComparable c)
    {
        return this.estrategia.SosMenor(this, c);
    }
    public bool sosMayor(IComparable c)
    {
        return this.estrategia.SosMayor(this, c);
    }
    public override string ToString()
    {
        return $"Profesor: Nombre={this.getNombre}, DNI={this.getDni}, Antiguedad={this.antiguedad}";
    }
    //Ejercicio 12 TP3
    //Implementacion de IObservado
    public void AgregarObsevador(IObservador observador)
    {
        observadores.Add(observador);
    }
    public void QuitarObservador(IObservador observador)
    {
        observadores.Remove(observador);
    }
    public void notificar(string accion)
    {
        // Itera y llama al método actualizar de cada observador
        foreach (IObservador observador in observadores)
        {
            observador.actualizar(accion);
        }
    }
}
