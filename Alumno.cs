using System;

namespace practica1MetodologiaCorralMaia;

// Ejercicio 12 TP1
public class Alumno : Persona, IComparable, IObservador, IAlumno
{
    private int Legajo;
    private double Promedio;
    IEstrategiaDeComparacion estrategia;
    private int calificacion;

    // Lista de frases para la distracción Ejercicio 11 TP3
    private static readonly string[] frasesDistraccion = new string[]
    {
        "Mirando el celular",
        "Dibujando en el margen de la carpeta",
        "Tirando aviones de papel"
    };
    // Objeto Random para seleccionar la distracción
    private Random random = new Random();

    public Alumno(string n, int d, int l, double p, IEstrategiaDeComparacion estrategia) : base(n, d)
    {
        this.Legajo = l;
        this.Promedio = p;
        this.estrategia = estrategia;
        this.calificacion = 0;
    }
    public int getLegajo()
    {
        return this.Legajo;
    }
    public double getPromedio()
    {
        return this.Promedio;
    }
    //Agrega un set para el ejercicio 8 tp2
    public void setEstrategia(IEstrategiaDeComparacion estrategia)
    {
        this.estrategia = estrategia;
    }
    //Ejercicio 1 TP4
    public int getCalificacion()
    {
        return this.calificacion;
    }
    public void setCalificacion(int calificacion)
    {
        this.calificacion = calificacion;
    }
    //Se coloca virtual para respetar el polimorfismo en la clase AlumnoMuyEstudioso
    public virtual int responderPregunta(int pregunta)
    {
        // Next(min, max) devuelve un número entre min y max.
        return this.random.Next(1, 4);
    }
    public string mostrarCalificacion()
    { 
        return $"{this.getNombre()} {this.calificacion}"; 
    }
    //Ejercicio 15
    //override sobrescribe el comportamiento. En lugar de devolver el nombre del tipo, el método devuelve la cadena definida.
    public override string ToString()
    {
        return $"Nombre: {this.getNombre()}, DNI: {this.getDni()}, Legajo: {this.Legajo}, Promedio: {this.Promedio}";
    }
    //se sobrescriben los métodos de comparación para usar el promedio
    public override bool SosIgual(IComparable c)
    {
        return this.estrategia.SosIgual(this, (Alumno)c);
    }
    public override bool SosMenor(IComparable c)
    {
        return this.estrategia.SosMenor(this, (Alumno)c);
    }
    public override bool SosMayor(IComparable c)
    {
        return this.estrategia.SosMayor(this, (Alumno)c);
    }
    //Ejercicio 11 TP3
    public void PrestarAtencion()
    {
        Console.WriteLine("Prestando atención");
    }
    public void distraerse()
    {
        //genera un indice aleatorio entre 0 y el numero de frases -1
        int indice = this.random.Next(frasesDistraccion.Length);
        //imprime la frase seleccionada
        Console.WriteLine(frasesDistraccion[indice]);
    }
    //Implementacion de IObservador
    public void actualizar(string accion)
    {
        Console.Write($"El alumno {this.getNombre()} reacciona: ");
        // El alumno reacciona dependiendo de la acción notificada
        if (accion == "hablar")
        {
            PrestarAtencion();
        }
        else if (accion == "escribir")
        {
            distraerse();
        }
    }
    
}
