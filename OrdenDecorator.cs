using System;

namespace practica1MetodologiaCorralMaia;

public class OrdenDecorator: AlumnoDecorator
{
    private int numeroOrden;

    public OrdenDecorator(IAlumno alumno, int numero) : base(alumno)
    {
        this.numeroOrden = numero;
    }
    public override string mostrarCalificacion()
    {
        //Se obtiene el resultado de la cadena 
        string resultadoBase = this.alumnoDecorado.mostrarCalificacion(); 
        
        // Se aplica la decoración de orden al inicio.
        // El formato es: 5) (Resto de la información del alumno)
        return $"{this.numeroOrden}) {resultadoBase}";
    }
}
