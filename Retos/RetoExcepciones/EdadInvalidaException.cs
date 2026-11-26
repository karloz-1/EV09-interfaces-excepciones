using System;

// Excepcion personalizada creada para el reto.
public class EdadInvalidaException : Exception
{
    public int Edad { get; }

    public EdadInvalidaException(int edad)
        : base($"La edad {edad} no es valida. Debe estar entre 0 y 120 anios.")
    {
        Edad = edad;
    }
}
