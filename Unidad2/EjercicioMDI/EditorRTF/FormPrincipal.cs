using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EditorRTF.Funciones;

namespace EditorRTF
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItemNuevo_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.MdiParent = this;
            editor.Show();
        }

        private void MenuItemAbrir_Click(object sender, EventArgs e)
        {
            string archivo = Funciones.Dialogos.AbrirArchivo();

            if (!String.IsNullOrEmpty(archivo))
            {
                Editor editor = new Editor();
                editor.MdiParent = this;
                editor.Archivo = archivo;
                editor.Show();
            }
        }

        private void MenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
