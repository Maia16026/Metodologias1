using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 1 TP5
public class AlumnoProxy: IAlumno
{
    // El objeto real (Alumno o AlumnoMuyEstudioso) que se cargará 
    private IAlumno alumnoReal = null;
    private string nombre;
    private int dni;
    private int legajo;
    private double promedio;
    private IEstrategiaDeComparacion estrategia;
    private bool esEstudioso;//Marcador para saber que tipo de alumno crear
    private int calificacion;
    public AlumnoProxy(string n, int d, int l, double p, IEstrategiaDeComparacion est, bool esEstudioso)
    {
        this.nombre = n;
        this.dni = d;
        this.legajo = l;
        this.promedio = p;
        this.estrategia = est;
        this.esEstudioso = esEstudioso;
        this.calificacion = 0;
    }
    // Método de carga perezosa 
    private void asegurarAlumn()
    {
        if (alumnoReal == null)
        {
            if (esEstudioso)
            {
                this.alumnoReal = new AlumnoMuyEstudioso(this.nombre, this.dni, this.legajo, this.promedio, this.estrategia);
            }
            else
            {
                this.alumnoReal = new Alumno(this.nombre, this.dni, this.legajo, this.promedio, this.estrategia);
            }
            // Se sincroniza la calificación del proxy al objeto real recién creado
            this.alumnoReal.setCalificacion(this.calificacion);
        }
    }
    //Metodos de la Intefaz IAlumno
    public int responderPregunta(int pregunta)
    {
        // Carga el alumno real antes de delegar la llamada
        asegurarAlumn();
        return this.alumnoReal.responderPregunta(pregunta);
    }
    public string getNombre()
    {
        return this.nombre; 
    }
    public int getLegajo() 
    {
        return this.legajo; 
    }
    public double getPromedio()
    { 
        return this.promedio; 
    }
    // La calificación se maneja en el Proxy para que esté disponible antes de la carga
    public int getCalificacion()
    {
        return this.calificacion; 
    }
    public void setCalificacion(int calificacion)
    {
        this.calificacion = calificacion;
    }
    public string mostrarCalificacion()
    {
        return $"{this.getNombre()} {this.getCalificacion()}";
    }
    public bool SosIgual(IComparable c) 
    { 
        asegurarAlumn(); 
        return this.alumnoReal.SosIgual(c); 
    }
    
    public bool SosMenor(IComparable c) 
    { 
        asegurarAlumn(); 
        return this.alumnoReal.SosMenor(c); 
    }
    public bool SosMayor(IComparable c) 
    { 
        asegurarAlumn();
        return this.alumnoReal.SosMayor(c); 
    }

}
