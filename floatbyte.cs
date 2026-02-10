// Gabriela A. Ramirez Castillo
// Matrícula: 20250993
// Fecha: 09/02/2026

using System;

class Program
{
    static void Main()
    {
        // Declarar un float con valor específico
        float miFloat = 10152466.25f;
        Console.WriteLine($"Valor del float: {miFloat}");

        // Declarar un byte que es igual a 5 + el float

        byte miByte = (byte)(5 + miFloat); 
        Console.WriteLine($"Byte = 5 + float: {miByte}");
        Console.WriteLine("(El valor se friza porque byte solo soporta 0-255)");

        // Demostración del problema
        Console.WriteLine($"\nExplicación:");
        Console.WriteLine($"5 + {miFloat} = {5 + miFloat}");
        Console.WriteLine($"Pero byte solo puede almacenar valores de 0 a 255");
        Console.WriteLine($"Por eso el resultado es: {miByte}");

        // Versión alternativa con un float más pequeño
        float floatPequeno = 100.5f;
        byte byteValido = (byte)(5 + floatPequeno);
        Console.WriteLine($"\nEjemplo con float más pequeño:");
        Console.WriteLine($"5 + {floatPequeno} = {5 + floatPequeno}");
        Console.WriteLine($"Como byte: {byteValido}");
    }
}