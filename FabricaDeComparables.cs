using System;

namespace practica1MetodologiaCorralMaia
{

    //Ejercicio 4 TP3
    // Opciones para indicar qué tipo de comparable queremos utilizar en el main
    public enum TipoComparable
    {
        Numero = 1,
        Alumno = 2,
        Profesor = 3
    }
    public abstract class FabricaDeComparables
    {
        public abstract IComparable CrearAleatorio();
        public abstract IComparable CrearPorTeclado();
        // Método estático que devuelve una instancia de la fábrica
        // concreta correspondiente a opcion
        public static FabricaDeComparables CrearFabrica(TipoComparable opcion)
        {
            switch (opcion)
            {
                case TipoComparable.Numero:
                    return new FabricaDeNumeros();
                case TipoComparable.Alumno:
                    return new FabricaDeAlumnos();
                case TipoComparable.Profesor:
                    return new FabricaDeProfesores();
                default:
                    throw new ArgumentException("Opción de fábrica no soportada: " + opcion);
            }
        }
        public static IComparable CrearAleatorio(TipoComparable opcion)
        {
            var fabrica = CrearFabrica(opcion);
            return fabrica.CrearAleatorio();
        }
        public static IComparable CrearPorTeclado(TipoComparable opcion)
        {
            var fabrica = CrearFabrica(opcion);
            return fabrica.CrearPorTeclado();
        }
    }
}