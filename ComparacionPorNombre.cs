using System;

namespace practica1MetodologiaCorralMaia;

class ComparacionPorNombre : IEstrategiaDeComparacion
//Ejercico 1 TP2
{
    public bool SosIgual(IComparable a1, IComparable a2)
    {
        return ((Alumno)a1).getNombre() == ((Alumno)a2).getNombre();
    }
    public bool SosMayor(IComparable a1, IComparable a2)
    {
        // El método CompareTo() devuelve un valor menor que 0 si la primera cadena es alfabéticamente menor.
        return ((Alumno)a1).getNombre().CompareTo(((Alumno)a2).getNombre()) < 0;
    }
    public bool SosMenor(IComparable a1, IComparable a2)
    {
        //Se reutiliza el CompareTo()
        return ((Alumno)a1).getNombre().CompareTo(((Alumno)a2).getNombre()) > 0;
    }
}
