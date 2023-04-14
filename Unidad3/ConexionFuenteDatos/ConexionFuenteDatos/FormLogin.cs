using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ConexionFuenteDatos
{
    public partial class FormLogin : Form
    {
        private static SQLiteDBManager DBManager { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DBManager = new SQLiteDBManager();

            if (!File.Exists(DBManager.BaseDatosSQLite))
            {
                DBManager.CreateDatabase();
                DBManager.CreateTables();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT UsuarioID, Tipo, Nombre, Apellido FROM Usuario " +
                $"WHERE NombreUsuario='{TxtUsuario.Text}' AND ClaveUsuario='{TxtClave.Text}' AND Activo=1";

            DataTable tablaUsuario = DBManager.ExecuteQuery(sql);

            if (tablaUsuario.Rows.Count > 0)
            {
                var usuario = SQLiteDBManager.ConvertirDataRowADiccionario(tablaUsuario.Rows[0]);

                int usuarioID = Convert.ToInt32(usuario["UsuarioID"]);
                string nombreUsuario = $"{usuario["Nombre"]} {usuario["Apellido"]}";

                this.Hide();

                FormPrincipal formPrincipal = new FormPrincipal() 
                {
                    UsuarioID = usuarioID,
                    NombreUsuario = nombreUsuario
                };

                formPrincipal.FormClosed += FormPrincipal_FormClosed;
                formPrincipal.Show();
            }
            else
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Sistema de control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
