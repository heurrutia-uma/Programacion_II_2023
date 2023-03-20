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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemClientes_Click(object sender, EventArgs e)
        {
            FormListaCliente listaCliente = new FormListaCliente()
            {
                MdiParent = this,
            };

            listaCliente.Show();
        }

        private void MenuItemSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Diseño modular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void MenuItemProveedores_Click(object sender, EventArgs e)
        {
            FormListaProveedores listaProveedor = new FormListaProveedores()
            {
                MdiParent = this,
            };

            listaProveedor.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Diseño modular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();
            }
            else
                e.Cancel = true;
        }
    }
}
