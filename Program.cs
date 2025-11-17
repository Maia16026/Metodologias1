using System;
using System.Threading.Tasks;


namespace practica1MetodologiaCorralMaia;

class Program
{
    private static int contadorGeneral = 0;
    static void Main(string[] args)
    {
        //Se crean las fábricas concretas Ejercicio 4 TP3
        FabricaDeComparables fabricaNumeros = FabricaDeComparables.CrearFabrica(TipoComparable.Numero);
        FabricaDeComparables fabricaAlumnos = FabricaDeComparables.CrearFabrica(TipoComparable.Alumno);
        FabricaDeComparables fabricaProfesores = FabricaDeComparables.CrearFabrica(TipoComparable.Profesor);

        Console.WriteLine("Prueba con números:");
        //Se crean las colecciones
        IColeccionable pilaNumeros = new Pila();
        IColeccionable colaNumeros = new Cola();
        IColeccionable conjuntoNumeros = new Conjunto();

        //Se llenan e informan números usando la fábrica de númerosmaia
        Console.WriteLine("Prueba con la Pila de Números");
        llenar(pilaNumeros, fabricaNumeros);
        informar(pilaNumeros, fabricaNumeros);

        Console.WriteLine("Prueba con la Cola de Números");
        llenar(colaNumeros, fabricaNumeros);
        informar(colaNumeros, fabricaNumeros);

        Console.WriteLine("Prueba con el Conjunto de Números");
        llenar(conjuntoNumeros, fabricaNumeros);
        informar(conjuntoNumeros, fabricaNumeros);

        //Prueba con alumnos
        Console.WriteLine("Prueba con Alumnos:");
        //Se crean las colecciones
        IColeccionable pilaAlumnos = new Pila();
        IColeccionable colaAlumnos = new Cola();
        IColeccionable conjuntoAlumnos = new Conjunto();

        //Se Llenan e informan alumnos usando la fábrica de alumnos
        Console.WriteLine("Prueba con la Pila de Alumnos");
        llenar(pilaAlumnos, fabricaAlumnos);
        informar(pilaAlumnos, fabricaAlumnos);

        Console.WriteLine("Prueba con la Cola de Alumnos");
        llenar(colaAlumnos, fabricaAlumnos);
        informar(colaAlumnos, fabricaAlumnos);

        Console.WriteLine("Prueba con el Conjunto de Alumnos");
        llenar(conjuntoAlumnos, fabricaAlumnos);
        informar(conjuntoAlumnos, fabricaAlumnos);

        //Prueba con Profesores
        Console.WriteLine("Prueba con Profesores:");
        // Se crean las colecciones para profesores
        IColeccionable pilaProfesores = new Pila();
        IColeccionable colaProfesores = new Cola();
        IColeccionable conjuntoProfesores = new Conjunto();

        // Se llenan e informan profesores usando la fábrica de profesores
        Console.WriteLine("Prueba con la Pila de Profesores");
        llenar(pilaProfesores, fabricaProfesores);
        informar(pilaProfesores, fabricaProfesores);

        Console.WriteLine("Prueba con la Cola de Profesores");
        llenar(colaProfesores, fabricaProfesores);
        informar(colaProfesores, fabricaProfesores);

        Console.WriteLine("Prueba con el Conjunto de Profesores");
        llenar(conjuntoProfesores, fabricaProfesores);
        informar(conjuntoProfesores, fabricaProfesores);

        //cambio de estrategia Ejercicio 9 TP2    
        Console.WriteLine("Cambio de Estrategia para Alumnos:");
        IColeccionable miColeccion = new Pila();
        llenar(miColeccion, fabricaAlumnos);

        IEstrategiaDeComparacion estrategiaNombre = new ComparacionPorNombre();
        Console.WriteLine("Cambio a estrategia por Nombre");
        CambiarEstrategia(miColeccion, estrategiaNombre);
        informar(miColeccion, fabricaAlumnos);

        IEstrategiaDeComparacion estrategiaPromedio = new ComparacionPorPromedio();
        Console.WriteLine("Cambio a estrategia por Promedio");
        CambiarEstrategia(miColeccion, estrategiaPromedio);
        informar(miColeccion, fabricaAlumnos);

        //Patrón observer Ejercicio 12 y 13 TP3
        //Crear Profesor (Observable)
        Profesor profesor = (Profesor)fabricaProfesores.CrearAleatorio();
        Console.WriteLine($"Profesor Observable creado: {profesor.getNombre()}");

        //Crear 20 Alumnos (Observadores) y añadirlos
        for (int i = 0; i < 20; i++)
        {
            Alumno alumno = (Alumno)fabricaAlumnos.CrearAleatorio();
            profesor.AgregarObsevador(alumno);
        }
        Console.WriteLine("20 alumnos han sido agregados como observadores.");
        //Iniciar el dictado de clases
        DictadoDeClases(profesor);

        //Ejercicio 4, 7 y 8 TP4 Adapter y Decorator
        Console.WriteLine("Prueba del patrón adapter y decorator (MDPI)");
        // Primero se instancia un Teacher
        Teacher profesorMDPI = new Teacher();
        Console.WriteLine("Profesor MDPI instanciado.");
        // Definición de estrategia para la creación de comparables
        IEstrategiaDeComparacion estAlum = new ComparacionPorNombre();

        // Se crean 10 Alumnos (Adaptables Normales) y 10 AlumnosMuyEstudiosos (Adaptables Especiales)
        Console.WriteLine("Creando, Decorando y enviando 20 Students (Adaptadores) a la clase");
        // La variable 'contadorGeneral' se usará para el OrdenDecorator
        int contadorGeneral = 0;
        //10 Alumnos Normales que responden al azar
        for (int i = 0; i < 10; i++)
        {
            contadorGeneral++; //Se incrementa el contador para el OrdenDecorator
            //Se crea un objeto de la clase base
            IAlumno alumnoNormal = new Alumno($"Alumno_Normal_{i + 1}", 100 + i, 2000 + i, 7.0, estAlum);
            //inicio de la cadena de decoradores (sobre IAlumno)
            // Se decora el alumno (IAlumno) con todos los decoradores
            IAlumno alumnoDecorado = alumnoNormal;
            // Se decora sobre el IAlumno
            alumnoDecorado = new LegajoDecorator(alumnoDecorado); // 1. Legajo
            alumnoDecorado = new NotaEnLetrasDecorator(alumnoDecorado); // 2. Letras
            alumnoDecorado = new EstadoAprobacionDecorator(alumnoDecorado); // 3. Estado
            alumnoDecorado = new OrdenDecorator(alumnoDecorado, contadorGeneral); // 4. Orden
            // El Recuadro debe ser el más externo de los decoradores de IAlumno
            IAlumno alumnoDecoradoFinal = new RecuadroDecorator(alumnoDecorado);
            // adaptador final
            // El adaptador envuelve al IAlumno totalmente decorado y lo expone como Student
            Student studentFinal = new AlumnoAdapter(alumnoDecoradoFinal);
            profesorMDPI.goToClass(studentFinal);
        }
        Console.WriteLine("10 Alumnos Normales adaptados y decorados en clase.");
        
        //10 Alumnos muy estudiosos que responden correctamente
        for (int i = 0; i < 10; i++)
        {
            contadorGeneral++; // Incrementamos el contador para el OrdenDecorator
            IAlumno alumnoEstudioso = new AlumnoMuyEstudioso($"Estudioso_{i + 1}", 200 + i, 3000 + i, 9.5, estAlum);
            //inicio dela cadena de decoradores (sobre IAlumno)
            IAlumno alumnoDecorado = alumnoEstudioso;
            // Se decora sobre el IAlumno
            alumnoDecorado = new LegajoDecorator(alumnoDecorado);
            alumnoDecorado = new NotaEnLetrasDecorator(alumnoDecorado);
            alumnoDecorado = new EstadoAprobacionDecorator(alumnoDecorado);
            alumnoDecorado = new OrdenDecorator(alumnoDecorado, contadorGeneral);
            IAlumno alumnoDecoradoFinal = new RecuadroDecorator(alumnoDecorado);
            //Adaptador final
            Student studentFinal = new AlumnoAdapter(alumnoDecoradoFinal);
            profesorMDPI.goToClass(studentFinal);
        }
        Console.WriteLine("10 Alumnos Muy Estudiosos adaptados y decorados en clase.");
        // Se invoca al método teachingAClass
        Console.WriteLine("Inicio de la clase del profesor MDPI (Resultado ordenado y decorado)");
        profesorMDPI.teachingAClass();
        Console.WriteLine("Fin de la clase del profesor MDPI");
        
        //Pilas y colas como invocadores de Comandos
        // se inicializan los Componentes (Receptor e Invocador)
        Pila pilaComoInvocador = new Pila();
        Aula aula = new Aula();
        // se instancian y Setean los Comandos
        IOrdenEnAula ordenInicio = new OrdenInicio(aula);
        IOrdenEnAula2 ordenLlegaAlumno = new OrdenLlegaAlumno(aula);
        IOrdenEnAula ordenAulaLlena = new OrdenAulaLlena(aula);

        pilaComoInvocador.setOrdenInicio(ordenInicio);
        pilaComoInvocador.setOrdenLlegaAlumno(ordenLlegaAlumno);
        pilaComoInvocador.setOrdenAulaLlena(ordenAulaLlena);
        // Parámetro para la creación
        //IEstrategiaDeComparacion estAlum = new ComparacionPorNombre();
        //Está creado arriba.
        // se crean 20 Alumnos Normales
        for (int i = 0; i < 20; i++)
        {
            // se crea el Student adaptado/decorado
            IComparable studentFinal = crearAlumnoAdaptadoDecorado(esEstudioso: false, indice: i, estAlum: estAlum);
            //Agregar a la pila. Esto invoca los comandos.
            pilaComoInvocador.agregar(studentFinal);
        }
        for (int i = 0; i < 20; i++)
        {
            // se crea el Student adaptado/decorado
            IComparable studentFinal = crearAlumnoAdaptadoDecorado(esEstudioso: true, indice: i,estAlum: estAlum);
            // Agrega a la pila
            pilaComoInvocador.agregar(studentFinal); 
        }
        Console.ReadKey();
    }
    //Ejercicio 6 TP3
    public static void llenar(IColeccionable c, FabricaDeComparables opcion)
    {
        for (int i = 0; i < 20; i++)
        {
            IComparable comparable = opcion.CrearAleatorio();
            c.agregar(comparable);
        }
    }
    //Ejercicio 6 TP3
    public static void informar(IColeccionable c, FabricaDeComparables opcion)
    {
        Console.WriteLine("Cantidad de elementos: " + c.cuantos());
        Console.WriteLine("Elemento minimo: " + c.minimo());
        Console.WriteLine("Elemento maximo: " + c.maximo());
        Console.WriteLine("Ingrese un elemento para verificar si está en la colección o no: ");
        IComparable comparable = opcion.CrearPorTeclado();

        if (c.contiene(comparable))
        {
            Console.WriteLine("El elemento leído está en la colección.");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección.");
        }

    }
    //Ejercicio 6 TP2
    public static void ImprimirElementos(IColeccionable c)
    {
        if (c is Iterable iterable)
        {
            Iterador iterador = iterable.crearIterador();
            iterador.primero();
            while (!iterador.fin())
            {
                IComparable elemento = iterador.actual();
                Console.WriteLine(elemento.ToString());
                iterador.siguiente();
            }
        }
        else
        {
            Console.WriteLine("La colección no es iterable");
        }
    }
    //Ejercicio 8 TP2
    public static void CambiarEstrategia(IColeccionable c, IEstrategiaDeComparacion estrategia)
    {
        // Verificamos si la coleccion es iterable antes de intentar iterar
        if (c is Iterable iterable)
        {
            Iterador iterador = iterable.crearIterador();
            iterador.primero();
            while (!iterador.fin())
            {
                IComparable elemento = iterador.actual();
                if (elemento is Alumno alumno)
                {
                    alumno.setEstrategia(estrategia);
                }
                iterador.siguiente();
            }
        }
    }
    //Ejercicio 13 TP3
    public static void DictadoDeClases(Profesor profesor)
    {
        Console.WriteLine("Inicio de dictado de clases: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ronda {i + 1} de 5 ");
            profesor.HablarALaClase();
            profesor.EscribirEnElPizarron();
        }
        Console.WriteLine("Fin de la clase");
    }
    //Ejercicio 10 TP5
    public static IComparable crearAlumnoAdaptadoDecorado(bool esEstudioso, int indice, IEstrategiaDeComparacion estAlum)
    {
        Program.contadorGeneral++;
        IAlumno alumnoBase;
        string nombreBase = esEstudioso ? $"Estudioso_{indice + 1}" : $"Alumno_Normal_{indice + 1}";
        double promedioBase = esEstudioso ? 9.5 : 7.0;
        if (esEstudioso)
        {
            alumnoBase = new AlumnoMuyEstudioso(nombreBase, 200 + indice, 3000 + indice, promedioBase, estAlum);
        }
        else
        {
            alumnoBase = new Alumno(nombreBase, 100 + indice, 2000 + indice, promedioBase, estAlum);
        }
        IAlumno alumnoDecorado = alumnoBase;
        alumnoDecorado = new LegajoDecorator(alumnoDecorado);
        alumnoDecorado = new NotaEnLetrasDecorator(alumnoDecorado);
        alumnoDecorado = new EstadoAprobacionDecorator(alumnoDecorado);
        alumnoDecorado = new OrdenDecorator(alumnoDecorado, Program.contadorGeneral);
        IAlumno alumnoDecoradoFinal = new RecuadroDecorator(alumnoDecorado);
        //Adaptacion
        Student studentFinal = new AlumnoAdapter(alumnoDecoradoFinal);
        // Retorna el objeto Student, compatible con IComparable, que es lo que 'pila.agregar()' espera.
        return (IComparable)studentFinal;
    }
}
