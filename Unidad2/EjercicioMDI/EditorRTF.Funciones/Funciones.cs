using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EditorRTF.Funciones
{
    public struct Fuente
    {
        public List<string> Nombres;
        public List<string> Tamanios;
    }

    public class Funciones
    {
        public static readonly int FUENTE_TAMANIO_INICIAL = 8;
        public static readonly int FUENTE_TAMANIO_FINAL = 72;

        public static Fuente CargarFamiliaFuente()
        {
            Fuente objFuente = new Fuente();

            FontFamily[] familias = FontFamily.Families;
            List<string> fuentes = new List<string>();
            List<string> tamanios = new List<string>();

            foreach (var familia in familias)
            {
                if (familia.IsStyleAvailable(FontStyle.Regular))
                    fuentes.Add(familia.Name);
            }

            int i = FUENTE_TAMANIO_INICIAL;

            while (i <= FUENTE_TAMANIO_FINAL)
            {
                tamanios.Add(i.ToString());

                if (i < 12)
                    i++;
                else if (i >= 12 && i < 48)
                    i += 2;
                else if (i >= 48)
                    i += 24;
            }

            objFuente.Nombres = fuentes;
            objFuente.Tamanios = tamanios;

            return objFuente;
        }
    }

    public class Dialogos
    {
        private static readonly string FILTRO = "Archivo RTF (*.rtf)|*.rtf";

        public static string AbrirArchivo()
        {
            string nombreArchivo = String.Empty;

            OpenFileDialog dialogoAbrir = new OpenFileDialog()
            {
                Filter = FILTRO
            };

            if (dialogoAbrir.ShowDialog() == DialogResult.OK)
                nombreArchivo = dialogoAbrir.FileName;

            return nombreArchivo;
        }

        public static string GuardarArchivoComo()
        {
            string nombreArchivo = String.Empty;

            SaveFileDialog dialogoGuardar = new SaveFileDialog()
            {
                Filter = FILTRO
            };

            if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                nombreArchivo = dialogoGuardar.FileName;

            return nombreArchivo;
        }

        public static Color SeleccionarColorFuente()
        {
            Color color = Color.Empty;

            ColorDialog dialogoColor = new ColorDialog();

            if (dialogoColor.ShowDialog() == DialogResult.OK)
                color = dialogoColor.Color;

            return color;
        }
    }
}
