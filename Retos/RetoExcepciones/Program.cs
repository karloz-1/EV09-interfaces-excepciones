using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== RETO EXCEPCIONES: validacion de edad ===");

        // Casos de prueba: valido, no numerico, negativo y fuera de rango.
        ProbarEdad("25");
        ProbarEdad("abc");
        ProbarEdad("-5");
        ProbarEdad("150");

        Console.WriteLine("Fin del programa.");
    }

    static void ProbarEdad(string textoEdad)
    {
        Console.WriteLine();
        Console.WriteLine($"Probando el valor: {textoEdad}");

        try
        {
            // int.Parse lanza FormatException si el texto no es un numero.
            int edad = int.Parse(textoEdad);

            if (edad < 0 || edad > 120)
            {
                // throw lanza nuestra excepcion personalizada.
                throw new EdadInvalidaException(edad);
            }

            Console.WriteLine($"Edad valida: {edad} anios.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: la edad debe ser un numero entero.");
        }
        // Filtro: este catch solo atiende edades negativas.
        catch (EdadInvalidaException ex) when (ex.Edad < 0)
        {
            Console.WriteLine($"Error: {ex.Message} No se permiten edades negativas.");
        }
        catch (EdadInvalidaException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Finally: se cerro el proceso de validacion.");
        }
    }
}
