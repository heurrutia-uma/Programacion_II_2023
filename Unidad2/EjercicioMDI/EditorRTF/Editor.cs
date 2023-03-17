using EditorRTF.Funciones;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EditorRTF
{
    public partial class Editor : Form
    {
        public string Archivo { get; set; }

        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            Fuente fuentes = Funciones.Funciones.CargarFamiliaFuente();

            foreach (string fuente in fuentes.Nombres)
                ComboFuente.Items.Add(fuente);

            foreach (string tamanio in fuentes.Tamanios)
                ComboTamanio.Items.Add(tamanio);

            ComboFuente.SelectedItem = ContenedorRFT.Font.Name;
            ComboTamanio.SelectedItem = Convert.ToInt32(ContenedorRFT.Font.Size).ToString();

            AbrirArchivo();
        }

        private void AbrirArchivo()
        {
            if (!String.IsNullOrEmpty(this.Archivo))
            {
                ContenedorRFT.LoadFile(this.Archivo);
            }
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Archivo))
            {
                string archivo = Funciones.Dialogos.GuardarArchivoComo();

                if (!String.IsNullOrEmpty(archivo))
                {
                    this.Archivo = archivo;
                    ContenedorRFT.SaveFile(this.Archivo);
                }
            }
            else
            {
                ContenedorRFT.SaveFile(this.Archivo);
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AplicarEstilo(FontStyle estilo)
        {
            // Recuperar valores de estilo de fuente y tamaño desde los controles combobox.
            string fuenteCombo = ComboFuente.SelectedItem.ToString();
            float tamanioCombo;

            if (ComboTamanio.SelectedItem == null)
                tamanioCombo = (float)Convert.ToDecimal(Funciones.Funciones.FUENTE_TAMANIO_INICIAL);
            else
                tamanioCombo = (float)Convert.ToDecimal(ComboTamanio.SelectedItem);

            // Verificamos que fuente y tamaño aplicar
            string fuente;
            float tamanio;

            if (ContenedorRFT.SelectionFont != null)
            {
                string fuenteSeleccionada = ContenedorRFT.SelectionFont.Name;
                float tamanioSeleccionada = ContenedorRFT.SelectionFont.Size;

                if (fuenteCombo != fuenteSeleccionada)
                    fuente = fuenteCombo;
                else
                    fuente = fuenteSeleccionada;

                if (tamanioCombo != tamanioSeleccionada)
                    tamanio = tamanioCombo;
                else
                    tamanio = tamanioSeleccionada;
            }
            else
            {
                fuente = fuenteCombo;
                tamanio = tamanioCombo;
            }

            // Aplicamos fuente, tamaño y estilo
            ContenedorRFT.SelectionFont = new Font(fuente, tamanio, estilo);
        }

        private void ComboFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo;

            if (ContenedorRFT.SelectionFont == null)
                estilo = FontStyle.Regular;
            else
                estilo = ContenedorRFT.SelectionFont.Style;

            AplicarEstilo(estilo);
        }

        private void ComboTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle estilo;

            if (ContenedorRFT.SelectionFont == null)
                estilo = FontStyle.Regular;
            else
                estilo = ContenedorRFT.SelectionFont.Style;

            AplicarEstilo(estilo);
        }

        private void BotonNegrita_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Bold;

            if (ContenedorRFT.SelectionFont != null)
            {
                estilo = ContenedorRFT.SelectionFont.Style;

                if (ContenedorRFT.SelectionFont.Bold)
                    estilo &= ~FontStyle.Bold;
                else
                    estilo |= FontStyle.Bold;
            }

            AplicarEstilo(estilo);
        }

        private void BotonItalica_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Italic;

            if (ContenedorRFT.SelectionFont != null)
            {
                estilo = ContenedorRFT.SelectionFont.Style;

                if (ContenedorRFT.SelectionFont.Italic)
                    estilo &= ~FontStyle.Italic;
                else
                    estilo |= FontStyle.Italic;
            }

            AplicarEstilo(estilo);
        }

        private void BotonSubrayado_Click(object sender, EventArgs e)
        {
            FontStyle estilo = FontStyle.Underline;

            if (ContenedorRFT.SelectionFont != null)
            {
                estilo = ContenedorRFT.SelectionFont.Style;

                if (ContenedorRFT.SelectionFont.Underline)
                    estilo &= ~FontStyle.Underline;
                else
                    estilo |= FontStyle.Underline;
            }

            AplicarEstilo(estilo);
        }

        private void BotonColor_Click(object sender, EventArgs e)
        {
            Color colorFuente = Funciones.Dialogos.SeleccionarColorFuente();

            if (!colorFuente.IsEmpty && ContenedorRFT.SelectionFont != null)
                ContenedorRFT.SelectionColor = colorFuente;
        }

        private void BotonIzquierda_Click(object sender, EventArgs e)
        {
            ContenedorRFT.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void BotonCentro_Click(object sender, EventArgs e)
        {
            ContenedorRFT.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void BotonDerecha_Click(object sender, EventArgs e)
        {
            ContenedorRFT.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CortarMenuItem_Click(object sender, EventArgs e)
        {
            ContenedorRFT.Cut();
        }

        private void CopiarMenuItem_Click(object sender, EventArgs e)
        {
            ContenedorRFT.Copy();
        }

        private void PegarMenuItem_Click(object sender, EventArgs e)
        {
            if (ContenedorRFT.CanPaste(DataFormats.GetFormat(DataFormats.Text)))
                ContenedorRFT.Paste();
        }

        private void DeshacerMenuItem_Click(object sender, EventArgs e)
        {
            if (ContenedorRFT.CanUndo)
                ContenedorRFT.Undo();
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContenedorRFT.CanRedo)
                ContenedorRFT.Redo();
        }
    }

}
