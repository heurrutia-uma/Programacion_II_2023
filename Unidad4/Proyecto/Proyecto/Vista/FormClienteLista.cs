using Proyecto.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vista
{
    public partial class FormClienteLista : Form
    {
        public FormClienteLista()
        {
            InitializeComponent();
        }

        private void FormClienteLista_Load(object sender, EventArgs e)
        {
            EntidadDatos entidadDatos = new EntidadDatos();

            string filtro = "Nombre='Hector'";

            DataGridRegistros.DataSource = entidadDatos.ObtenerRegistros(filtro);
        }
    }
}
