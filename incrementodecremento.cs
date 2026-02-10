// Gabriela A. Ramirez Castillo
// Matrícula: 20250993
// Fecha: 09/02/2026

using System;

class Program
{
    static void Main()
    {
        // declaring and initializing a variable
        int numero = 10;
        Console.WriteLine($"Valor inicial: {numero}");

        // incrementar
        numero++;
        Console.WriteLine($"Después de incrementar (++): {numero}");

        numero += 5;
        Console.WriteLine($"Después de sumar 5 (+=): {numero}");

        // decrementar
        numero--;
        Console.WriteLine($"Después de decrementar (--): {numero}");

        numero -= 3;
        Console.WriteLine($"Después de restar 3 (-=): {numero}");

        // Operaciones matemáticas
        Console.WriteLine($"\nOperaciones con el número {numero}:");
        Console.WriteLine($"Multiplicado por 2: {numero * 2}");
        Console.WriteLine($"Dividido entre 2: {numero / 2}");
        Console.WriteLine($"Módulo de 3: {numero % 3}");
        Console.WriteLine($"Elevado al cuadrado: {numero * numero}");

    }
}