using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¡Bienvenido a ");
            Console.WriteLine("Programación II!");
            Console.Write("Ingrese su nombre: ");

            string nombre = Console.ReadLine();
            Console.WriteLine("Buen día, {0}!", nombre);

            Console.WriteLine("\nPulse Escape (Esc) para salir.");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }
    }
}
