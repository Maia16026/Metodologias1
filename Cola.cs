using System;
using System.Collections.Generic;


namespace practica1MetodologiaCorralMaia;
//Ejercicio 4 TP1
class Cola : IColeccionable, Iterable, IOrdenable
{
    private List<IComparable> lista;
    private IOrdenEnAula ordenInicio;
    private IOrdenEnAula2 ordenLlegaAlumno;
    private IOrdenEnAula ordenAulaLlena;
    public Cola()
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
    public void agregar(IComparable c)
    {
        int cantidadAntesDeAgregar = this.lista.Count;
        //se invoca a OrdenInicio
        if (cantidadAntesDeAgregar == 0 && this.ordenInicio != null)
        {
            this.ordenInicio.ejecutar();
        }
        //se invoca a OrdenLlegaAlumno
        if (this.ordenLlegaAlumno != null)
        {
            this.ordenLlegaAlumno.ejecutar(c);
        }
        this.lista.Add(c);
        //Se invoca a OrdenAulaLlena
        if (this.lista.Count == 40 && this.ordenAulaLlena != null)
        {
            this.ordenAulaLlena.ejecutar();
        }

    }
    public IComparable Pop()
    {
        if (this.lista.Count == 0)
        {
            throw new InvalidOperationException("La cola no tiene elementos.");
        }
        IComparable Elemento1 = this.lista[0];
        this.lista.RemoveAt(0);
        return Elemento1;
    }
    //implementa la interfaz IColeccionable.
    public int cuantos()
    {
        return this.lista.Count;
    }
    public IComparable minimo()
    {
        if (this.lista.Count == 0)
        {
           throw new InvalidOperationException("La cola no tiene elementos.");
        }
        IComparable minimo = this.lista[0];
        for (int i = 1; i < this.cuantos(); i++)
        {
            if (this.lista[i].SosMenor(minimo))
            {
                minimo = this.lista[i];
            }
        }
        return minimo;
    }
    public IComparable maximo()
    {
        if (this.lista.Count == 0)
        {
            throw new InvalidOperationException("La cola no tiene elementos.");
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
    public bool contiene(IComparable c)
    {
        return this.lista.Contains(c);
    }
    public IComparable getElemento(int indice)
    {
        return this.lista[indice];
    }
    //Devuelve un iterador para recorrer la pila
    //Ejercicio 5 TP2
    public Iterador crearIterador()
    {
        return new Iterador(this);
    }

}