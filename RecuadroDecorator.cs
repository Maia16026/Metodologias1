using System;
using System.Text;

namespace practica1MetodologiaCorralMaia;

public class RecuadroDecorator : AlumnoDecorator
{
    public RecuadroDecorator(IAlumno alumno) : base(alumno) { }
    // Implementa el método abstracto de AlumnoDecorator y añade la decoración
    public override string mostrarCalificacion()
    {
        //Se obtiene el resultado del objeto(el siguiente decorador o el Alumno base)
        string resultadoBase = this.alumnoDecorado.mostrarCalificacion(); 
        
        //Se aplica la decoración (Ejemplo de Recuadro)
        string linea = "************************";
        return $"{linea}\n{resultadoBase}\n{linea}";
    }
}
