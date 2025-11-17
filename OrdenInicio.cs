using System;

namespace practica1MetodologiaCorralMaia;

public class OrdenInicio: IOrdenEnAula
{
    private Aula aula;
    //Necesita de una referencia al receptor
    public OrdenInicio(Aula aula)
    {
        this.aula = aula;
    }
    //Ejecuta comenzar
    public void ejecutar()
    {
        Console.WriteLine("Ejecutando OrdenInicio");
        this.aula.Comenzar();
    }

}
