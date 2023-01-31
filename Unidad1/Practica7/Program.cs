using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, resultado;
            i = 1;

            Console.WriteLine("Programa que muestra tabla de multiplicar.\n");

            Console.Write("Ingresa un número\t");
            int tabla = Convert.ToInt32(Console.ReadLine());

            do
            {
                resultado = tabla * i;
                Console.WriteLine("{0} x {1} = {2}", tabla, i, resultado);
                i++;
            }
            while (i <= 10);

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
