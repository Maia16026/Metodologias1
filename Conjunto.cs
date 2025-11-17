using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace practica1MetodologiaCorralMaia;
// Ejercicio 3 TP2
class Conjunto : IColeccionable//Ejercicio 4 TP2
{
    private List<IComparable> Elementos;

    public Conjunto()
    {
        this.Elementos = new List<IComparable>();
    }
    public void agregar(IComparable c)
    {
        if (this.pertenece(c) == false)
        {
            this.Elementos.Add(c);
        }
    }
    public bool pertenece(IComparable c)
    {
        foreach (IComparable elemento in this.Elementos)
        {
            if (elemento.SosIgual(c))
            {
                return true;
            }
        }
        return false;
    }
    public int cuantos()
    {
        return this.Elementos.Count;
    }
    //Se coloca un signo de interrogación para avisar que puede devolver un valor nulo.
    public IComparable? minimo()
    {
        if (this.Elementos.Count == 0)
        {
            return null;
        }
        IComparable min = this.Elementos[0];
        for (int i = 1; i < this.Elementos.Count; i++)
        {
            if (this.Elementos[i].SosMenor(min))
            {
                min = this.Elementos[i];
            }
        }
        return min;
    }
    public IComparable? maximo()
    {
        if (this.Elementos.Count == 0)
        {
            return null;
        }
        IComparable max = this.Elementos[0];
        for (int i = 1; i < this.Elementos.Count; i++)
        {
            if (this.Elementos[i].SosMayor(max))
            {
                max = this.Elementos[i];
            }
        }
        return max;
    }
    public bool contiene(IComparable c)
    {
        return this.pertenece(c);
    }
    public IComparable getElemento(int indice)
    {
        return this.Elementos[indice];
    }
    
    
    public Iterador crearIterador()
    {
        return new Iterador(this);
    }

}
