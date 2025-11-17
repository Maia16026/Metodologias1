using System;

namespace practica1MetodologiaCorralMaia;

//Ejercicio 8 TP1
class ColeccionMultiple : IColeccionable
{
    private IColeccionable Pila;
    private IColeccionable Cola;
    public ColeccionMultiple(IColeccionable p, IColeccionable c)
    {
        this.Pila = p;
        this.Cola = c;
    }
    public int cuantos()
    {
        return this.Pila.cuantos() + this.Cola.cuantos();
    }

    public IComparable minimo()
    {

        IComparable minPila = this.Pila.minimo();
        IComparable minCola = this.Cola.minimo();
        if (minPila == null && minCola == null)
        {
            throw new InvalidOperationException("Las colecciones no contienen elementos.");
        }
        else if (minPila == null)
        {
            return minCola;
        }
        else if (minCola == null)
        {
            return minPila;
        }
        else
        {
            if (minPila.SosMenor(minCola))
            {
                return minPila;
            }
            else
            {
                return minCola;
            }
        }


    }
    public IComparable maximo()
    {

        IComparable maxPila = this.Pila.maximo();
        IComparable maxCola = this.Cola.maximo();
        if (maxPila == null && maxCola == null)
        {
            throw new InvalidOperationException("Las colecciones no contienen elementos.");
        }
        else if (maxPila == null)
        {
            return maxCola;
        }
        else if (maxCola == null)
        {
            return maxPila;
        }
        else
        {
            if (maxPila.SosMayor(maxCola))
            {
                return maxPila;
            }
            else
            {
                return maxCola;
            }
        }

    }
    public void agregar(IComparable c)
    {

    }


    public bool contiene(IComparable c)
    {
        return this.Pila.contiene(c) || this.Cola.contiene(c);
    }
    public IComparable getElemento(int indice)
    {
        // Logica para devolver el elemento de la pila o la cola segun el indice
        if (indice < this.Pila.cuantos())
        {
            return this.Pila.getElemento(indice);
        }
        else
        {
            int indiceEnCola = indice - this.Pila.cuantos();
            return this.Cola.getElemento(indiceEnCola);
        }
    }
}