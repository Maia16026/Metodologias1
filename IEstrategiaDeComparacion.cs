using System;

namespace practica1MetodologiaCorralMaia;

public interface IEstrategiaDeComparacion
//Ejercico 1 TP2
{
    bool SosIgual(IComparable a1, IComparable a2);
    bool SosMayor(IComparable a1, IComparable a2);
    bool SosMenor(IComparable a1, IComparable a3);

}
