// Gabriela A. Ramirez Castillo
// Matrícula: 20250993
// Fecha: 09/02/2026

using System;

class Program
{
    static void Main()
    {
        // declaring constants
        const double PI = 3.14159265359;
        const string UNIVERSIDAD = "ITLA";
        const int MAX_ESTUDIANTES = 100;

        // printing the constants
        Console.WriteLine($"El valor de PI es: {PI}");
        Console.WriteLine($"Universidad: {UNIVERSIDAD}");
        Console.WriteLine($"Máximo de estudiantes: {MAX_ESTUDIANTES}");

        // triying to change a constant value (this will cause an error)
        // discomment the line below to see the error
        // PI = 3.14; // ERROR: cannot assign a value to 'PI' because it is a 'const'

        Console.WriteLine("\nSi intentas descomentar la línea que intenta cambiar PI,");
        Console.WriteLine("obtendrás un error de compilación que dice:");
    }
}