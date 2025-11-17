using System;

namespace practica1MetodologiaCorralMaia;

class ComparacionPorDni : IEstrategiaDeComparacion
//Ejercico 1 TP2
{
    public bool SosIgual(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getDni() == ((Alumno)a2).getDni();
    }
    public bool SosMayor( IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getDni() > ((Alumno)a2).getDni();
    }
    public bool SosMenor(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getDni() < ((Alumno)a2).getDni();
    }
}
