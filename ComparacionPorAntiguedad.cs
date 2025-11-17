using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio TP3

class ComparacionPorAntiguedad : IEstrategiaDeComparacion
{
    public bool SosIgual(IComparable p1, IComparable p2)
    {
        return ((Profesor)p1).GetAntiguedad() == ((Profesor)p2).GetAntiguedad();
    }
    public bool SosMayor(IComparable p1, IComparable p2)
    {
        return ((Profesor)p1).GetAntiguedad() < ((Profesor)p2).GetAntiguedad();
    }
    public bool SosMenor(IComparable p1, IComparable p2)
    { 
        return ((Profesor)p1).GetAntiguedad() > ((Profesor)p2).GetAntiguedad();
    }
}
