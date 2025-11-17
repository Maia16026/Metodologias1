using System;

namespace practica1MetodologiaCorralMaia;

public class AlumnoMuyEstudioso : Alumno
{
    public AlumnoMuyEstudioso(string n, int d, int l, double p, IEstrategiaDeComparacion estrategia) : base(n, d, l, p, estrategia) { }
    // Sobreescribe el comportamiento para devolver siempre la respuesta correcta
    public override int responderPregunta(int pregunta)
    {
        int respuesta = pregunta % 3;
        if (respuesta == 0)
        {
            return 3;
        }
        else
        {
            return respuesta;
        }
        
    }
}
