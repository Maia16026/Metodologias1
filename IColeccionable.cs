using System;

namespace practica1MetodologiaCorralMaia;

//Ejercicio 3 TP1
public interface IColeccionable
{
    int cuantos();
    IComparable minimo();
    IComparable maximo();
    void agregar(IComparable c);
    bool contiene(IComparable c);
   IComparable getElemento(int indice);

}