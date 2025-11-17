using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 5 TP3 
public class FabricaDeNumeros : FabricaDeComparables
{
    private GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
    private LectorDeDatos lector = new LectorDeDatos();
    public override IComparable CrearAleatorio()
    {
        return new Numero(generador.numeroAleatorio(101));

    }
    public override IComparable CrearPorTeclado()
    {
        Console.WriteLine("Ingrese un número:");
        int valor = lector.numeroPorTeclado();
        return new Numero(valor);
    }
}
