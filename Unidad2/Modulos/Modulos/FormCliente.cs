using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulos
{
    public partial class FormCliente : Form
    {
        public string modo;
        public int indiceLinea;
        public AdminArchivosCSV archivoCSV;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (this.modo == "editar")
            {
                string[] datos = archivoCSV.CargarLinea(this.indiceLinea);

                if (datos.Length > 0)
                { 
                    TxtNombres.Text = datos[0];
                    TxtApellidos.Text = datos[1];
                    TxtTelefono.Text = datos[2];
                    TxtEmail.Text = datos[3];
                    TxtDireccion.Text = datos[4];
                }
            }
        }

        private void BtonGuardar_Click(object sender, EventArgs e)
        {
            if (this.modo == "nuevo")
            {
                if (!String.IsNullOrEmpty(TxtNombres.Text) && !String.IsNullOrEmpty(TxtApellidos.Text))
                {
                    string[] nuevaLinea = { TxtNombres.Text, TxtApellidos.Text, TxtTelefono.Text, TxtEmail.Text, TxtDireccion.Text.Replace(',', ' ') };
                    archivoCSV.GuardarLinea(nuevaLinea);

                    this.Close();
                }
            }
            else if (this.modo == "editar")
            {
                if (!String.IsNullOrEmpty(TxtNombres.Text) && !String.IsNullOrEmpty(TxtApellidos.Text))
                {
                    this.archivoCSV.EditarLinea(this.indiceLinea, 0, TxtNombres.Text);
                    this.archivoCSV.EditarLinea(this.indiceLinea, 1, TxtApellidos.Text);
                    this.archivoCSV.EditarLinea(this.indiceLinea, 2, TxtTelefono.Text);
                    this.archivoCSV.EditarLinea(this.indiceLinea, 3, TxtEmail.Text);
                    this.archivoCSV.EditarLinea(this.indiceLinea, 4, TxtDireccion.Text.Replace(',', ' '));

                    this.Close();
                }
            }
        }

        private void BtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
