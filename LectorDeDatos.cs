using System;

namespace practica1MetodologiaCorralMaia;

public class LectorDeDatos//Ejercicio 3 TP3
{
    //mplemente la clase LectorDeDatos. 
    //LectorDeDatos 
    //numeroPorTeclado()  devuelve un número leído por teclado 
    //stringPorTeclado()  devuelve un string leído por teclado
    public int numeroPorTeclado()
    {
        string entrada = Console.ReadLine();
        try
        {
            return int.Parse(entrada);
        }
        catch (FormatException)
        {
            throw new FormatException("La entrada no es un numero valido.");
        }
    }
    public string stringPorTeclado()
    {
        return Console.ReadLine();
    }
}
