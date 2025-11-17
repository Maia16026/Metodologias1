using System;

namespace practica1MetodologiaCorralMaia;

//Ejercicio1 TP1
public interface IComparable
// Contiene tres métodos que indican si un objeto es igual, menor o mayor
{
    bool SosIgual(IComparable c);
    bool SosMenor(IComparable c);
    bool SosMayor(IComparable c);
}