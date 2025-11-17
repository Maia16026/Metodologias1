using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 5 TP3 
public class FabricaDeAlumnos : FabricaDeComparables
{
    private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
    private LectorDeDatos lector = new LectorDeDatos();

    public override IComparable CrearAleatorio()
    {
        IEstrategiaDeComparacion estrategia = new ComparacionPorDni();
        return new Alumno(
            generador.StringAleatorio(10),
            generador.numeroAleatorio(99999999),
            generador.numeroAleatorio(10000),
            (double)generador.numeroAleatorio(11),
            estrategia);
    }
    public override IComparable CrearPorTeclado()
    {
        Console.WriteLine("Ingrese los datos del alumno:");
        Console.WriteLine("Nombre:");
        string nombre = lector.stringPorTeclado();
        Console.WriteLine("DNI:");
        int dni = lector.numeroPorTeclado();
        Console.WriteLine("Legajo:");
        int legajo = lector.numeroPorTeclado();
        Console.WriteLine("Promedio:");
        int promedio = lector.numeroPorTeclado();
        IEstrategiaDeComparacion estrategia = new ComparacionPorDni();
        return new Alumno(nombre, dni, legajo, promedio, estrategia);
    }
}
