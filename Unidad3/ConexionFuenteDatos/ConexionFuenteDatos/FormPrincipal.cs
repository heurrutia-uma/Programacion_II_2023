using ConexionFuenteDatos.Entidad;
using ConexionFuenteDatos.Usuario;
using System;
using System.Windows.Forms;

namespace ConexionFuenteDatos
{
    public partial class FormPrincipal : Form
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuarioActual.Text += this.NombreUsuario;
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

        private void MenuItemClientes_Click(object sender, EventArgs e)
        {
            FormEntidadLista formEntidadLista = new FormEntidadLista()
            {
                MdiParent = this,
                TipoEntidad = "Cliente",
                UsuarioID = this.UsuarioID
            };

            formEntidadLista.Show();
        }

        private void MenuItemProveedores_Click(object sender, EventArgs e)
        {
            FormEntidadLista formEntidadLista = new FormEntidadLista()
            {
                MdiParent = this,
                TipoEntidad = "Proveedor",
                UsuarioID = this.UsuarioID
            };

            formEntidadLista.Show();
        }

        private void MenuItemUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarioLista formUsuarioLista = new FormUsuarioLista()
            {
                MdiParent = this,
                UsuarioID = this.UsuarioID
            };

            formUsuarioLista.Show();
        }

        private void MenuItemCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MenuItemMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MenuItemMosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void MenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
