using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal numero;

            Console.WriteLine("Programa comprueba si un número dado es positivo o negativo.\n");

            Console.Write("Introduce un número: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine("Número {0:N2} es positivo.", numero);
            else
                Console.WriteLine("Número {0:N2} es negativo.", numero);

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
