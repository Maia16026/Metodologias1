using System;

namespace practica1MetodologiaCorralMaia;

public class OrdenAulaLlena: IOrdenEnAula
{
    private Aula aula;
    public OrdenAulaLlena(Aula aula)
    {
        this.aula = aula;
    }
    public void ejecutar()
    {
        Console.WriteLine("Ejecutado OrdenAulaLlena");
        this.aula.claseLista();
    }
}
