using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Modulos
{
    public class AdminArchivosCSV
    {
        private readonly string rutaArchivo;

        public AdminArchivosCSV(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public void CrearArchivo(string[] columnas)
        {
            if (!File.Exists(this.rutaArchivo))
            {
                using (StreamWriter sw = new StreamWriter(this.rutaArchivo))
                {
                    sw.WriteLine(string.Join(",", columnas));
                }
            }
        }

        public DataTable CargarArchivo()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(this.rutaArchivo))
                {
                    string[] nombreColumnas = reader.ReadLine().Split(',');

                    // Añadir las columnas a la tabla de datos
                    foreach (string nombre in nombreColumnas)
                    {
                        dataTable.Columns.Add(nombre);
                    }

                    // Lee el resto del archivo y agregua los datos a la DataTable
                    while (!reader.EndOfStream)
                    {
                        string[] data = reader.ReadLine().Split(',');
                        dataTable.Rows.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            return dataTable;
        }

        public string[] CargarLinea(int indiceFila)
        {
            string[] lineas = File.ReadAllLines(this.rutaArchivo);

            return lineas[indiceFila].Split(',');
        }

        public void EditarLinea(int indiceFila, int indiceColumna, string nuevoValor)
        {
            string[] lineas = File.ReadAllLines(this.rutaArchivo);
            string[] columnas = lineas[indiceFila].Split(',');

            if (indiceColumna >= columnas.Length)
            {
                throw new ArgumentOutOfRangeException("Índice de columna fuera de rango.");
            }

            columnas[indiceColumna] = nuevoValor;
            lineas[indiceFila] = string.Join(",", columnas);

            File.WriteAllLines(this.rutaArchivo, lineas);
        }

        public void BorrarLinea(int indiceFila)
        {
            string[] lineas = File.ReadAllLines(this.rutaArchivo);

            if (indiceFila >= lineas.Length)
            {
                throw new ArgumentOutOfRangeException("Índice de línea fuera de rango.");
            }

            string[] nuevaLineas = new string[lineas.Length - 1];
            int j = 0;

            for (int i = 0; i < lineas.Length; i++)
            {
                if (i != indiceFila)
                {
                    nuevaLineas[j] = lineas[i];
                    j++;
                }
            }

            File.WriteAllLines(this.rutaArchivo, nuevaLineas);
        }

        public void GuardarLinea(string[] contenido)
        {
            string nuevaFila = $"{String.Join(",", contenido)}{Environment.NewLine}";

            File.AppendAllText(this.rutaArchivo, nuevaFila);
        }

        public void BorrarArchivo()
        {
            File.Delete(this.rutaArchivo);
        }
    }
}
