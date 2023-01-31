using System;

namespace Practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i, resultado;

            Console.WriteLine("Programa que muestra tabla de multiplicar.\n");

            Console.Write("Ingresa un número\t");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
