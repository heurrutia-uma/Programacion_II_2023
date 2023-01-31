using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio3
{
    internal class Program
    {
        static string archivo;

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Registro de Clientes.");
            Console.Write("Ingrese ruta y nombre de archivo: ");
            archivo = CrearAbrirArchivo(Console.ReadLine());
            Menu();
        }

        static void Menu()
        {
            if (!string.IsNullOrEmpty(archivo))
            {

            }
            else
            {
                Console.WriteLine("Ruta o nombre de achivo vacio o inválido.\nPulse Escape [Esc] para salir.");
                while (true) 
                {
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        break;
                }
            }
        }

        static string CrearAbrirArchivo(string archivo)
        {
            string archivoValido = "";

            if (!String.IsNullOrEmpty(archivo))
            {
                string rutaArchivo = Path.GetDirectoryName(archivo);
                string nombreArchivo = Path.GetFileName(archivo);

                if (!String.IsNullOrEmpty(rutaArchivo))
                {
                    if (!Directory.Exists(rutaArchivo))
                        Directory.CreateDirectory(rutaArchivo);
                }
                else
                    rutaArchivo = Directory.GetCurrentDirectory();


                if (!File.Exists(Path.Combine(rutaArchivo, nombreArchivo)))
                {
                    File.Create(Path.Combine(rutaArchivo, nombreArchivo)).Close();
                    archivoValido = Path.Combine(rutaArchivo, nombreArchivo);
                }
                else
                    archivoValido = Path.Combine(rutaArchivo, nombreArchivo);
            }

            return archivoValido;
        }

        static void VisualizarLista()
        { }

        static void AgregarRegistro()
        { }

        static void EliminarRegistro()
        { }

    }
}
