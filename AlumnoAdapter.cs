using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 3 TP4

// El AlumnoAdapter debe implementar la interfaz que el sistema MDPI espera: Student.
public class AlumnoAdapter : Student, IComparable
{
    //La instancia de la clase Alumno que será adaptada
    private IAlumno AlumnoDec;
    public AlumnoAdapter(IAlumno alumno)
    {
        this.AlumnoDec = alumno;
    }
    //Tipo de "Traduccion" de student a alumno
    public string getName()
    {
        return this.AlumnoDec.getNombre(); 
    }
    public int yourAnswerIs(int question)
    {
        return this.AlumnoDec.responderPregunta(question);
    }
        
    public void setScore(int score)
    {
        this.AlumnoDec.setCalificacion(score); 
    }
    //ShowResult() llama a mostrarCalificacion(), ejecutando toda la cadena de Decorator
    public string showResult()
    {
        return this.AlumnoDec.mostrarCalificacion();
    } 
    public bool equals(Student s)
    {
        // Para comparar se necesita acceder al IAlumno interno del Student 's'.
        // Se asume que el Student 's' es siempre otro AlumnoAdapter (o similar).
        AlumnoAdapter otroAdapter = (AlumnoAdapter)s;
        
        //Se delega la lógica de comparación al IAlumno interno, que usa el patrón Strategy.
        return this.AlumnoDec.SosIgual(otroAdapter.AlumnoDec);
    }

    public bool lessThan(Student s)
    {
        AlumnoAdapter otroAdapter = (AlumnoAdapter)s;
        return this.AlumnoDec.SosMenor(otroAdapter.AlumnoDec);
    }

    public bool greaterThan(Student s)
    {
        AlumnoAdapter otroAdapter = (AlumnoAdapter)s;
        return this.AlumnoDec.SosMayor(otroAdapter.AlumnoDec);
    }
    public bool SosIgual(IComparable c)
    {
        return this.equals((Student)c);
    }

    public bool SosMenor(IComparable c)
    {
        return this.lessThan((Student)c);
    }

    public bool SosMayor(IComparable c)
    {
        return this.greaterThan((Student)c);
    }
}
