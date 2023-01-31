using System;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Programa comprueba si un número entero dado es par.\n");

            Console.Write("Introduce un número entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) == 0)
                Console.WriteLine("Número {0} es par.", numero);
            else
                Console.WriteLine("Número {0} es impar.", numero);

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
