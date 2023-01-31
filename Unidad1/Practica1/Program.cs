using System;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerNumero, segundoNumero;

            Console.WriteLine("Programa comprueba enteros iguales.\n");

            Console.Write("Introduce el primer número: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero == segundoNumero)
                Console.WriteLine("Números son iguales.");
            else
                Console.WriteLine("Números no son iguales.");

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
