using System;

namespace practica1MetodologiaCorralMaia;

public interface IAlumno: IComparable
{
    string getNombre();
    int getLegajo();
    double getPromedio();
    void setCalificacion(int calificacion);
    int getCalificacion();
    string mostrarCalificacion();//metodo a decorar
    int responderPregunta(int pregunta);
}
