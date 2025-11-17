using System;

namespace practica1MetodologiaCorralMaia;

//Ejercicio 11 TP1
public abstract class Persona : IComparable
{
    private string nombre;
    private int dni;
    public Persona(string n, int d)
    {
        this.nombre = n;
        this.dni = d;
    }
    public string getNombre()
    {
        return this.nombre;
    }
    public int getDni()
    {
        return this.dni;
    }
    //Se coloca el virtual para que las clases heredadas puedan reescribir el método cambiando su comportamiento
    public virtual bool SosIgual(IComparable c)
    {
        //casteo
        Persona Ppersona = (Persona)c;
        return this.getDni() == Ppersona.getDni();
    }
    public virtual bool SosMenor(IComparable c)
    {
        Persona Ppersona = (Persona)c;
        return this.getDni() < Ppersona.getDni();
    }
    public virtual bool SosMayor(IComparable c)
    {
        Persona Ppersona = (Persona)c;
        return this.getDni() > Ppersona.getDni();
    }
}