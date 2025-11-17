using System;

namespace practica1MetodologiaCorralMaia;

public class EstadoAprobacionDecorator : AlumnoDecorator
{
    public EstadoAprobacionDecorator(IAlumno alumno) : base(alumno) { }
    public override string mostrarCalificacion()
    {
        //Se obtiene el resultado de la cadena Ddecorada hasta ahora 
        string resultadoBase = this.alumnoDecorado.mostrarCalificacion();

        // se obtiene la calificación numérica 
        int calificacion = this.alumnoDecorado.getCalificacion(); 
        
        string estado;
        if (calificacion >= 7)
            estado = "PROMOCIÓN";
        else if (calificacion >= 4)
            estado = "APROBADO";
        else
            estado = "DESAPROBADO";

        string puntajeConEstado = $"{calificacion} ({estado})";

        // Se reemplaza la calificación numérica en la cadena base.
        // Se convierte la calificación numérica a string para buscarla
        string calificacionNumStr = calificacion.ToString();
        
        //se busca la última aparición del número 
        int indiceFinal = resultadoBase.LastIndexOf(calificacionNumStr);
        
        if (indiceFinal != -1)
        {
            // Se reemplaza el número con el nuevo formato (ej: "6 (APROBADO)")
            string parteInicial = resultadoBase.Substring(0, indiceFinal);
            string parteFinal = resultadoBase.Substring(indiceFinal + calificacionNumStr.Length);
            
            return parteInicial + puntajeConEstado + parteFinal;
        }

        // Si no se pudo decorar, devuelve el resultado base
        return resultadoBase;
    }
}
