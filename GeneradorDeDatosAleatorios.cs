using System;
using System.Text;

namespace practica1MetodologiaCorralMaia;

public class GeneradorDeDatosAleatorios//Ejercicio 2 TP3
{
    private readonly Random random = new Random();

    public int numeroAleatorio(int max)
    {
        return random.Next(max);
    }
    public string StringAleatorio(int cant)
    {
        const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var resultado = new StringBuilder(cant);
        for (int i = 0; i < cant; i++)
        {
            resultado.Append(caracteres[random.Next(caracteres.Length)]);
        }
        return resultado.ToString();
    }

}
