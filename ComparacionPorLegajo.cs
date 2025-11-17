using System;

namespace practica1MetodologiaCorralMaia;

class ComparacionPorLegajo : IEstrategiaDeComparacion
//Ejercico 1 TP2
{
    public bool SosIgual(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getLegajo() == ((Alumno)a2).getLegajo();
    }
    public bool SosMayor(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getLegajo() > ((Alumno)a2).getLegajo();
    }
    public bool SosMenor(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getLegajo() < ((Alumno)a2).getLegajo();
    }
}
