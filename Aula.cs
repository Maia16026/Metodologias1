using System;

namespace practica1MetodologiaCorralMaia;
//Ejercicio 3 TP5
public class Aula
{
    private Teacher teacher;
    public void Comenzar()
    {
        Console.WriteLine("Iniciando el Aula: Creando al Profesor MDPI.");
        this.teacher = new Teacher();
    }
    //Agrega el alumno al Teacher.
    public void nuevoAlumno(Student alumnoStudent)
    {
        if (this.teacher == null)
        {
            Console.WriteLine("Debe llamar al método Comenzar() antes de agregar alumnos");
            return;
        }
        //agrega al teacher el alumno recibido
        this.teacher.goToClass(alumnoStudent);
    }
    public void claseLista()
    {
        if (this.teacher == null)
        {
            Console.WriteLine("Debe llamar al método Comenzar() antes de agregar alumnos");
            return;
        }
        Console.WriteLine("El profesor da la clase (teachingaclass) y publica los resultados");
        this.teacher.teachingAClass();
    }
}
