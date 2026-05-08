# Patrones de Diseño y Metodologías de Programación (TP Final)

Este repositorio contiene la implementación integral del Trabajo Práctico Final para la materia **Metodologías de Programación I** (UNAJ). El proyecto se centra en la resolución de problemas complejos mediante la aplicación de **Patrones de Diseño (GoF)** y principios de diseño orientado a objetos.

## Patrones de Diseño Implementados

El sistema demuestra una comprensión profunda de la arquitectura de software a través de los siguientes patrones:

- **Estructurales:**
    - **Decorator:** Implementado para añadir responsabilidades dinámicas a los alumnos (`AlumnoDecorator`, `NotaEnLetrasDecorator`, `RecuadroDecorator`). 
    - **Adapter:** Adaptación de interfaces para compatibilidad de clases (`AlumnoAdapter`). 
    - **Proxy:** Control de acceso y gestión de recursos (`AlumnoProxy`). 
- **De Comportamiento:**
    - **Strategy:** Intercambio de algoritmos de comparación en tiempo de ejecución (`IEstrategiaDeComparacion`, `ComparacionPorPromedio`, `ComparacionPorDni`). 
    - **Observer:** Sistema de notificación entre objetos (`IObservado`, `IObservador`). 
    - **Iterator:** Recorrido de colecciones sin exponer su estructura interna (`IIterable`, `Iterador`). 
    - **Command:** Encapsulamiento de órdenes en el aula (`IOrdenEnAula`, `OrdenLlegaAlumno`).
- **Creacionales:**
    - **Factory Method:** Centralización de la creación de objetos (`FabricaDeAlumnos`, `FabricaDeProfesores`). 

## Tecnologías y Conceptos Clave

- **Lenguaje:** C# / .NET
- **Interfaces:** Uso intensivo de abstracción para lograr un bajo acoplamiento (`IAlumno`, `IComparable`, `IColeccionable`).
- **Generación de Datos:** Implementación de componentes para simulación de escenarios (`GeneradorDeDatosAleatorios`, `LectorDeDatos`).
- **Colecciones Personalizadas:** Desarrollo de estructuras como `Pila`, `Cola` y `Conjunto` integradas con patrones de iteración.

## Contexto Académico
Este proyecto representa la transición hacia el diseño de software profesional, enfocándose en la reutilización de código, la mantenibilidad y la escalabilidad mediante el uso de interfaces y polimorfismo avanzado.

---
*Ingeniería Informática - Universidad Nacional Arturo Jauretche*
