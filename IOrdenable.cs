using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 8 TP5

public interface IOrdenable
{
    void setOrdenInicio(IOrdenEnAula ordenInicio);
    void setOrdenLlegaAlumno(IOrdenEnAula2 ordenLlegaAlumno);
    void setOrdenAulaLlena(IOrdenEnAula ordenAulaLlena);
}
