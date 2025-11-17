using System;
using System.Collections.Generic;

namespace practica1MetodologiaCorralMaia;

//Ejercicio 4 TP1
class Pila : IColeccionable, Iterable, IOrdenable
//Implementa la interfaz IColeccionable para comportarse como colección.
{
    private List<IComparable> lista;
    //Donde se almacenan los comandos de IOrdenable
    private IOrdenEnAula ordenInicio;
    private IOrdenEnAula2 ordenLlegaAlumno;
    private IOrdenEnAula ordenAulaLlena;
    public Pila()
    {
        this.lista = new List<IComparable>();
    }
    //Se implementa IOrdenable con sus setters
    public void setOrdenInicio(IOrdenEnAula ordenInicio)
    {
        this.ordenInicio = ordenInicio;
    }
    public void setOrdenLlegaAlumno(IOrdenEnAula2 ordenLlegaAlumno)
    {
        this.ordenLlegaAlumno = ordenLlegaAlumno;
    }
    
    public void setOrdenAulaLlena(IOrdenEnAula ordenAulaLlena)
    {
        this.ordenAulaLlena = ordenAulaLlena;
    }
    public void Push(IComparable c)
    {
        this.lista.Add(c);
    }
    public IComparable Pop()
    {
        if (this.lista.Count == 0)
        {
            throw new InvalidOperationException("La pila no tiene elementos.");
        }
        //guardo en IndiceElemento su indice
        // Se obtiene el índice del último elemento. La lista es 0-indexada.
        int IndiceElemento = this.lista.Count - 1;
        // Se guarda el último elemento en una variable temporal.
        IComparable elemento = this.lista[IndiceElemento];
        this.lista.RemoveAt(IndiceElemento);
        return elemento;
    }
    // Implementación de la interfaz IColeccionable
    public int cuantos()
    {
        return this.lista.Count;
    }
    public IComparable minimo()
    {
        if (this.lista.Count == 0)
        {
            throw new InvalidOperationException("La pila no tiene  elementos.");
        }
        // Se inicializa la variable 'minimo' con el primer elemento.
        IComparable minimo = this.lista[0];
        // Se itera sobre el resto de los elementos de la lista.
        for (int i = 1; i < this.cuantos(); i++)
        {

            if (this.lista[i].SosMenor(minimo))
            {
                // Si el elemento actual es menor, se actualiza el 'minimo'.
                minimo = this.lista[i];
            }
        }
        return minimo;
    }
    public IComparable maximo()
    {
        if (this.lista.Count == 0)
        {
            throw new InvalidOperationException("La pila no tiene elementos.");
        }
        IComparable maximo = this.lista[0];
        for (int i = 1; i < this.cuantos(); i++)
        {
            if (this.lista[i].SosMayor(maximo))
            {
                maximo = this.lista[i];
            }
        }
        return maximo;

    }
    public void agregar(IComparable c)
    {
        int cantidadAntesDeAgregar = this.lista.Count;
        // se invoca a OrdenInicio
        if (cantidadAntesDeAgregar == 0 && this.ordenInicio != null)
        {
            this.ordenInicio.ejecutar();
        }
        // se invoca a OrdenLlegaAlumno
        if (this.ordenLlegaAlumno != null)
        {
            this.ordenLlegaAlumno.ejecutar(c);
        }
        // Se mantiene la lógica original de la pila
        this.Push(c);
        // se invoca a OrdenAulaLlena
        if (this.lista.Count == 40 && this.ordenAulaLlena != null)
        {
            this.ordenAulaLlena.ejecutar();
        }
    }
    public bool contiene(IComparable c)
    {
        return this.lista.Contains(c);
    }
    public IComparable getElemento(int indice)
    {
        return this.lista[this.lista.Count - 1 - indice];
    }
    // Devuelve un iterador para recorrer la pila
    //Ejercicio 5 TP2
    public Iterador crearIterador()
    {
        return new Iterador(this);
    }


}