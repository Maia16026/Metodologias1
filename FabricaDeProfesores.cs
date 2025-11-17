using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 9 TP3

public class FabricaDeProfesores : FabricaDeComparables
{
    private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
    private LectorDeDatos lector = new LectorDeDatos();
    public override IComparable CrearAleatorio()
    {
        IEstrategiaDeComparacion estrategia = new ComparacionPorAntiguedad();
        return new Profesor(
            generador.StringAleatorio(10),
            generador.numeroAleatorio(99999999),
            generador.numeroAleatorio(30), // Antigüedad aleatoria de 0 a 29 años
            estrategia);
    }
    public override IComparable CrearPorTeclado()
    {
        Console.WriteLine("Ingrese los datos del profesor:");
        Console.WriteLine("Nombre:");
        string nombre = lector.stringPorTeclado();
        Console.WriteLine("DNI:");
        int dni = lector.numeroPorTeclado();
        Console.WriteLine("Antigüedad (años):");
        int antiguedad = lector.numeroPorTeclado();
        IEstrategiaDeComparacion estrategia = new ComparacionPorAntiguedad();
        return new Profesor(nombre, dni, antiguedad, estrategia);
    }
}
