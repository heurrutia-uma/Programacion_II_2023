using System;

namespace Practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;

            Console.WriteLine("Introduzca un número para sumar.\nPulse -1 para Terminar el programa");
            
            while (true)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == -1)
                {
                    break;
                }
                int acumulado = suma;
                suma += numero;
                Console.WriteLine("\n{0} + {1} = {2}", acumulado, numero, suma);
            }

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
