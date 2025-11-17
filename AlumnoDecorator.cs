using System;
// clase que reemplaza a StudentDecorator de la entrega anterior

namespace practica1MetodologiaCorralMaia;

public abstract class AlumnoDecorator : IAlumno
{
    protected IAlumno alumnoDecorado;
    public AlumnoDecorator(IAlumno alumno)
    {
        this.alumnoDecorado = alumno;
    }
    public virtual string getNombre()
    {
        return alumnoDecorado.getNombre();
    }
    public virtual int getLegajo()
    {
        return alumnoDecorado.getLegajo();
    }
    public virtual double getPromedio()
    {
        return alumnoDecorado.getPromedio();
    }
    public virtual void setCalificacion(int calificacion)
    {
        alumnoDecorado.setCalificacion(calificacion);
    }
    public virtual int getCalificacion()
    {
        return alumnoDecorado.getCalificacion();
    }
    public abstract string mostrarCalificacion();
    public virtual int responderPregunta(int pregunta)
    {
        return alumnoDecorado.responderPregunta(pregunta);
    }
    public bool SosIgual(IComparable c)
    {
        return alumnoDecorado.SosIgual(c);
    }
    public bool SosMenor(IComparable c)
    {
        return alumnoDecorado.SosMenor(c);
    }
    public bool SosMayor(IComparable c)
    {
        return alumnoDecorado.SosMayor(c);
    }
}
