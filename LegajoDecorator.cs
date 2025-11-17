using System;

namespace practica1MetodologiaCorralMaia;

public class LegajoDecorator : AlumnoDecorator
{
    public LegajoDecorator(IAlumno alumno) : base(alumno) { }
    public override string mostrarCalificacion()
    {
        // Formato: Nombre (Legajo/Promedio) Calificación
        string nombre = getNombre();
        string legajo = getLegajo().ToString();
        string promedio = getPromedio().ToString("F1"); //se utiliza para formatear un número (en este caso, un double que representa el promedio) 
        //F: formato que asegura que se muestre un número fijo de decimales, sin notación científica.
        //1: Indica cuántos dígitos deben aparecer después del punto decimal.
        string calificacion = getCalificacion().ToString();
        
        return $"{nombre} ({legajo}/{promedio}) {calificacion}";
    }
}
