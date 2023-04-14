using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionFuenteDatos.Usuario
{
    public partial class FormUsuario : Form
    {
        public int UsuarioID { get; set; }
        public string Modo { get; set; }
        public int ID { get; set; }
        private static SQLiteDBManager DBManager { get; set; }

        public FormUsuario()
        {
            InitializeComponent();

            DBManager = new SQLiteDBManager();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
