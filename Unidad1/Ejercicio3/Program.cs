using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ejercicio3
{
    internal class Program
    {
        static string archivo;

        /// <summary>
        /// Constantes
        /// </summary>
        static readonly int MAX_FILAS = 24;
        static readonly int MAX_COLUMNAS = 80;
        static readonly string LINEA_CARACTERES = new string('-', MAX_COLUMNAS);

        /// <summary>
        /// Función principal.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Registro de Clientes.");
            Console.Write("Ingrese ruta y nombre de archivo: ");
            archivo = CrearArchivo(Console.ReadLine());

            if (!String.IsNullOrEmpty(archivo))
                Menu();
            else
                Console.WriteLine("Ruta o nombre de archivo no válidos.");
        }

        /// <summary>
        /// Método que desplega el menu de opciones.
        /// </summary>
        static void Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1 - Visualizar lista");
                Console.WriteLine("2 - Agregar registro");
                Console.WriteLine("3 - Eliminar registro");
                Console.WriteLine("4 - Salir");
                Console.Write("Seleccione opción: ");
                if (Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            VisualizarLista();
                            break;
                        case 2:
                            AgregarRegistro();
                            break;
                        case 3:
                            EliminarRegistro();
                            break;
                        default:
                            break;
                    }
                }
            } while (opcion >= 1 && opcion <= 3);
        }

        /// <summary>
        /// Función para comprobar la existencia del archivo.
        /// </summary>
        /// <param name="archivo">Ruta y nombre de archivo.</param>
        /// <returns></returns>
        static string CrearArchivo(string archivo)
        {
            string archivoValido = "";

            if (!String.IsNullOrEmpty(archivo))
            {
                string rutaArchivo = ComprobarRuta(archivo);
                string nombreArchivo = Path.GetFileName(archivo);

                archivoValido = ComprobarArchivo(rutaArchivo, nombreArchivo);
            }

            return archivoValido;
        }

        /// <summary>
        /// Método para visualizar los registros en el archivo.
        /// </summary>
        static void VisualizarLista()
        {
            string cabeceraTabla = "|No.  |NOMBRES             |APELLIDOS           |EMAIL                         |";
            string lineaTabla = LINEA_CARACTERES;
            lineaTabla = ReemplazarEn(lineaTabla, 0, '+');
            lineaTabla = ReemplazarEn(lineaTabla, 6, '+');
            lineaTabla = ReemplazarEn(lineaTabla, 27, '+');
            lineaTabla = ReemplazarEn(lineaTabla, 48, '+');
            lineaTabla = ReemplazarEn(lineaTabla, 79, '+');

            int idx = 1;
            int ln = 0;

            using (StreamReader reader = new StreamReader(archivo))
            {
                while (!reader.EndOfStream)
                {
                    if (ln == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(cabeceraTabla);
                        Console.WriteLine(lineaTabla);
                    }

                    string[] linea = reader.ReadLine().Split(',');
                    Console.WriteLine($"|{idx.ToString().PadRight(5)}|{linea[0].PadRight(20)}|{linea[1].PadRight(20)}|{linea[2].PadRight(30)}|");
                    idx++;
                    ln++;
                    
                    if(ln == MAX_FILAS - 4 && !reader.EndOfStream)
                    {
                        ln = 0;
                        Console.WriteLine(lineaTabla);
                        Console.Write("Presione [Enter] para continuar... ");
                        Console.ReadLine();
                    }
                    
                }
            }

            Console.WriteLine(lineaTabla);
            Console.Write("Presione [A]gregar | [B]orrar | [Enter] para salir. ");
            string resp = Console.ReadLine();

            if (resp == "A" || resp == "a")
                AgregarRegistro();
            else if (resp == "B" || resp == "b")
                EliminarRegistro();
            Console.ReadLine();
        }

        /// <summary>
        /// Método para agregar registros al archivo.
        /// </summary>
        static void AgregarRegistro()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Agregar Registro");
                Console.WriteLine("Nota: Dejar campos en blanco para salir.\n");

                Console.Write("Nombres: ");
                string nombre = Console.ReadLine();

                Console.Write("\nApellidos: ");
                string apellido = Console.ReadLine();

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();

                if (!String.IsNullOrEmpty(nombre) && !String.IsNullOrEmpty(apellido) && !String.IsNullOrEmpty(email))
                {
                    File.AppendAllText(archivo, $"{nombre},{apellido},{email}{Environment.NewLine}");
                }
                else
                    break;

            }
        }

        /// <summary>
        /// Método para eliminar un registro en el archivo.
        /// </summary>
        static void EliminarRegistro()
        {
            Console.Clear();
            Console.WriteLine("Borrar registro");
            Console.WriteLine("Nota: Dejar campos en blanco para salir.\n");

            Console.Write("Ingrese el número de la linea a borrar: ");
            int posicion = Int32.TryParse(Console.ReadLine(), out int num) ? num : 0;

            if (posicion > 0)
            {
                List<string> lineas = File.ReadAllLines(archivo).ToList();

                if (posicion <= lineas.Count)
                {
                    lineas.RemoveAt(posicion - 1);

                    File.WriteAllLines(archivo, lineas);
                }
                else
                {
                    Console.WriteLine($"Línea fuera del rango.\nArchivo tiene {lineas.Count} líneas.");
                    Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// Función para comprobar ruta y directorio del archivo.
        /// </summary>
        /// <param name="archivo">Cadena que indique una ruta y nombre de archivo.</param>
        /// <returns></returns>
        static string ComprobarRuta(string archivo)
        {
            string rutaArchivo = Path.GetDirectoryName(archivo);

            if (!String.IsNullOrEmpty(rutaArchivo))
            {
                if (!Directory.Exists(rutaArchivo))
                    Directory.CreateDirectory(rutaArchivo);
            }
            else
                rutaArchivo = Directory.GetCurrentDirectory();

            return rutaArchivo;
        }

        /// <summary>
        /// Función para comprobar la existencia del archivo.
        /// </summary>
        /// <param name="rutaArchivo">Ruta del archivo</param>
        /// <param name="nombreArchivo">Nombre y extensión del archivo</param>
        /// <returns></returns>
        static string ComprobarArchivo(string rutaArchivo, string nombreArchivo)
        {
            string archivoValido;

            if (!File.Exists(Path.Combine(rutaArchivo, nombreArchivo)))
            {
                File.Create(Path.Combine(rutaArchivo, nombreArchivo)).Close();
                archivoValido = Path.Combine(rutaArchivo, nombreArchivo);
            }
            else
                archivoValido = Path.Combine(rutaArchivo, nombreArchivo);

            return archivoValido;
        }

        /// <summary>
        /// Función para reemplazar un caracter por su posición en una cadena.
        /// </summary>
        /// <param name="texto">Texto a evaluar</param>
        /// <param name="indice">Posición</param>
        /// <param name="caracter">Nuevo caracter</param>
        /// <returns></returns>
        static string ReemplazarEn(string texto, int indice, char caracter)
        {
            if (texto == null)
                throw new ArgumentNullException("texto");

            if (indice < 0 || indice >= texto.Length)
                throw new IndexOutOfRangeException("índice no válido");

            StringBuilder strBuilder = new StringBuilder(texto);
            strBuilder[indice] = caracter;
            return strBuilder.ToString();
        }
    }
}
