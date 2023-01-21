using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero, segundoNumero;

            Console.Write("Introduce el primer número: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los números ingresados son: {0} y {1}.", primerNumero, segundoNumero );

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
