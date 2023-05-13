using Proyecto.Controlador;
using Proyecto.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemClientes_Click(object sender, EventArgs e)
        {
            FormController.AbrirFormulario(this, new FormClienteLista());
        }
    }
}
