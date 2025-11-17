using System;
using System.Collections.Generic;

namespace practica1MetodologiaCorralMaia;

public class NotaEnLetrasDecorator : AlumnoDecorator
{
    private Dictionary<int, string> notasEnLetras = new Dictionary<int, string>()
    {
        {0, "CERO"}, {1, "UNO"}, {2, "DOS"}, {3, "TRES"}, {4, "CUATRO"},
        {5, "CINCO"}, {6, "SEIS"}, {7, "SIETE"}, {8, "OCHO"}, {9, "NUEVE"}, {10, "DIEZ"}
    };
    public NotaEnLetrasDecorator(IAlumno alumno) : base(alumno) { }
    public override string mostrarCalificacion()
    {
        // Se obtiene el resultado de la cadena decorada hasta el momento.
        // Por ejemplo: "Nombre (Legajo/Promedio) 6"
        string resultadoBase = this.alumnoDecorado.mostrarCalificacion();
        // usando el método delegado de IAlumno obtenemos la calificacion numerica
        int calificacion = this.alumnoDecorado.getCalificacion(); 
        
        if (notasEnLetras.ContainsKey(calificacion))
        {
            string puntajeConLetras = $"{calificacion} ({notasEnLetras[calificacion]})";
            
            // Se reemplaza la calificación numérica original en el resultadoBase
            // Se busca la calificación numérica al final de la cadena base.
            // Se asume que la calificación numérica simple es el último elemento antes del cierre de línea.
            //Se convierte la calificación numérica a string para buscarla
            string calificacionNumStr = calificacion.ToString();
            
            //Se busca la última aparición del número (que debería ser el puntaje final)
            int indiceFinal = resultadoBase.LastIndexOf(calificacionNumStr);
            
            if (indiceFinal != -1)
            {
                // Reemplazamos el número (ej: "6") con el nuevo formato (ej: "6 (SEIS)")
                string parteInicial = resultadoBase.Substring(0, indiceFinal);
                string parteFinal = resultadoBase.Substring(indiceFinal + calificacionNumStr.Length);
                return parteInicial + puntajeConLetras + parteFinal;
            }
        }
        
        // Si no se pudo decorar, devuelve el resultado base
        return resultadoBase;
    }
}
