using System;

namespace Practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annio;

            Console.WriteLine("Programa comprueba si un año determinado es bisiesto o no.\n");

            Console.Write("Introduce un año: ");
            annio = Convert.ToInt32(Console.ReadLine());

            if ((annio % 4) == 0 && (annio % 100) != 0 || (annio % 400) == 0)
                Console.WriteLine("Año {0} es bisiesto.", annio);
            else
                Console.WriteLine("Año {0} es no bisiesto.", annio);

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
