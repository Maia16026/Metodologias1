using System;

namespace practica1MetodologiaCorralMaia;

public class Iterador
{
    private IColeccionable c;
    private int indice;
    public Iterador(IColeccionable c)
    {
        this.c = c;
        this.indice = 0;
    }
    public void primero()
    {
        this.indice = 0;
    }
    public void siguiente()
    {
        this.indice++;
    }
    public bool fin()
    {
        return this.indice >= this.c.cuantos();
    }
    public IComparable actual()
    {
        return this.c.getElemento(this.indice);
    }
}
