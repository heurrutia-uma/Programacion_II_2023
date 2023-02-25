using System;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }

        private void BtnAbrirArchivo_Click(object sender, EventArgs e)
        {
            var rutaArchivo = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de Excel (*.xlsx)|*.xlsx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    rutaArchivo = openFileDialog.FileName;

                    using (StreamReader reader = new StreamReader(rutaArchivo))
                    {
                        while(!reader.EndOfStream)
                        {
                            LstListaClientes.Items.Add(reader.ReadLine());
                        }
                    }
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string linea = $"{TxtNombre.Text},{TxtApellido.Text},{TxtEmail.Text}";
            LstListaClientes.Items.Add(linea);
        }
    }
}
