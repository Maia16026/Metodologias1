using System;

namespace practica1MetodologiaCorralMaia;

public interface IObservador
{
    //método que el observable llama para actualizar al observador
    void actualizar(string accion);
}
