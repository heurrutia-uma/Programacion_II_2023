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
    public partial class FormUsuarioLista : Form
    {
        public int UsuarioID { get; set; }
        private SQLiteDBManager DBManager { get; set; }

        public FormUsuarioLista()
        {
            InitializeComponent();

            DBManager = new SQLiteDBManager();
        }

        private void FormUsuarioLista_Load(object sender, EventArgs e)
        {
            LblCantidadRegistros.Text = $"Cantidad: 0";

            RegrescarDataGrid();
        }

        private void RegrescarDataGrid()
        {
            string filter = String.Empty;

            if (!String.IsNullOrEmpty(TxtBuscar.Text))
                filter = $"WHERE (Nombre Like '{TxtBuscar.Text}%' OR Apellido Like '{TxtBuscar.Text}%' OR NombreUsuario Like '{TxtBuscar.Text}%');";

            DataTable dataTable = DBManager.ExecuteQuery($"SELECT * FROM Usuario {filter};");
            DataGrid.DataSource = dataTable;

            LblCantidadRegistros.Text = $"Cantidad: {dataTable.Rows.Count}";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario= new FormUsuario()
            {
                UsuarioID = this.UsuarioID,
                Modo = "nuevo",
                ID = -1
            };

            formUsuario.ShowDialog();

            RegrescarDataGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0)
            {
                int id = Int32.TryParse(DataGrid.CurrentRow.Cells["UsuarioID"].Value.ToString(), out Int32 usuarioID) ? usuarioID : -1;

                FormUsuario formUsuario = new FormUsuario()
                {
                    UsuarioID = this.UsuarioID,
                    Modo = "edit",
                    ID = id
                };

                formUsuario.ShowDialog();

                RegrescarDataGrid();
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "Diseño modular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                int id = Int32.TryParse(DataGrid.CurrentRow.Cells["UsuarioID"].Value.ToString(), out Int32 usuarioID) ? usuarioID : -1;

                if (result == DialogResult.Yes && id != -1)
                {
                    string sql = $"DELETE FROM Usuario WHERE UsuarioID={id};";
                    DBManager.ExecuteNonQuery(sql);

                    RegrescarDataGrid();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RegrescarDataGrid();
        }
    }
}
