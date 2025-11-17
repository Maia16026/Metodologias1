using System;

namespace practica1MetodologiaCorralMaia;

public interface IObservado
{
    //método para añadir un observador(Alumno)
    void AgregarObsevador(IObservador o);

    //método para eliminar el observador
    void QuitarObservador(IObservador o);

    //método para notificar a todos los observadores
    void notificar(string accion);
}
