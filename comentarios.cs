// Gabriela A. Ramirez Castillo
// Matrícula: 20250993
// Fecha: 09/02/2026

using System;

class Program
{
    static void Main()
    {
        // Este es un comentario de una sola línea
        // Los comentarios de una línea empiezan con //

        /*
         * Este es un comentario de
         * varias líneas.
         */

        // Obtener e imprimir la fecha y hora actual del sistema
        DateTime fechaHoraActual = DateTime.Now;

        Console.WriteLine("=== INFORMACIÓN DE FECHA Y HORA DEL SISTEMA ===");
        Console.WriteLine($"Fecha y hora completa: {fechaHoraActual}");
        Console.WriteLine($"Solo fecha: {fechaHoraActual.ToShortDateString()}");
        Console.WriteLine($"Solo hora: {fechaHoraActual.ToShortTimeString()}");
        Console.WriteLine($"Formato largo: {fechaHoraActual.ToLongDateString()}");

        Console.WriteLine("\n=== COMPONENTES INDIVIDUALES ===");
        Console.WriteLine($"Año: {fechaHoraActual.Year}");
        Console.WriteLine($"Mes: {fechaHoraActual.Month}");
        Console.WriteLine($"Día: {fechaHoraActual.Day}");
        Console.WriteLine($"Hora: {fechaHoraActual.Hour}");
        Console.WriteLine($"Minutos: {fechaHoraActual.Minute}");
        Console.WriteLine($"Segundos: {fechaHoraActual.Second}");
        Console.WriteLine($"Día de la semana: {fechaHoraActual.DayOfWeek}");

        // Formato personalizado
        Console.WriteLine($"\nFormato personalizado: {fechaHoraActual.ToString("dd/MM/yyyy HH:mm:ss")}");
    }
}