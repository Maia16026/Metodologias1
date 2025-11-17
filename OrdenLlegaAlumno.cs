using System;

namespace practica1MetodologiaCorralMaia;

public class OrdenLlegaAlumno: IOrdenEnAula2
{
    private Aula aula;
    public OrdenLlegaAlumno(Aula aula)
    {
        this.aula = aula;
    }
    public void ejecutar(IComparable c)
    {
        Console.WriteLine("Ejecutando OrdenLlegaAlumno");
        //Se verifica si el comparable es un student
        if (c is Student alumnoStudent)
        {
            this.aula.nuevoAlumno(alumnoStudent);
            Console.WriteLine($"Alumno '{alumnoStudent.getName()}' agregado al aula.");
        }
        else
        {
            Console.WriteLine("El parámetro recibido no es un objeto Student.");
        }
    }
}
