using System;

namespace practica1MetodologiaCorralMaia;

//Ejercicio 2 TP1
class Numero : IComparable
// Representa un número entero que puede compararse con otros objetos
{
    int valor;
    public Numero(int valor)
    {
        this.valor = valor;

    }
    public void setvalor(int valor)
    {
        this.valor = valor;
    }
    public int getvalor()
    {
        return this.valor;
    }

    // Implementación de la interfaz IComparable
    public bool SosIgual(IComparable c)
    {
        Numero otroNumero = (Numero)c;
        return this.getvalor() == otroNumero.getvalor();

    }
    public bool SosMenor(IComparable c)
    {
        Numero otroNumero = (Numero)c;
        return this.getvalor() < otroNumero.getvalor();
    }
    public bool SosMayor(IComparable c)
    {
        Numero otroNumero = (Numero)c;
        return this.getvalor() > otroNumero.getvalor();
    }
    //Al imprimir el objeto se muestre directamente su valor en forma de string
    public override string ToString()
    {
        return this.valor.ToString();
    }
    
 }
