using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MaestroDetalle
{
    public partial class FormPrincipal : Form
    {
        private static SQLiteDBManager DBManager { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            DBManager = new SQLiteDBManager();

            if (!File.Exists(DBManager.BaseDatosSQLite))
            {
                DBManager.CreateDatabase();
                DBManager.CreateTables();
            }

            RefrescarDataGrid();
        }

        private DataTable CargarRegistros()
        {
            string filter = String.Empty;

            if (!String.IsNullOrEmpty(TxtBuscar.Text))
                filter = $" WHERE NombreCliente Like '{TxtBuscar.Text}%' OR NumeroOrden Like '{TxtBuscar.Text}%'";

            return DBManager.ExecuteQuery($"SELECT * FROM OrdenVenta {filter};");
        }

        private void RefrescarDataGrid()
        {
            DataTable dataTable = CargarRegistros();
            DataGrid.DataSource = dataTable;

            DataGrid.Columns[0].Visible = false;
        }

        private int IDRegistroSeleccionado()
        {
            int id = -1;

            if (DataGrid.RowCount > 0)
                id = Int32.TryParse(DataGrid.CurrentRow.Cells["OrdenID"].Value.ToString(), out Int32 entidadID) ? entidadID : -1;

            return id;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormOrdenVenta formOrdenVenta = new FormOrdenVenta()
            {
                OrdenID = -1,
                Modo = "Nuevo"
            };

            formOrdenVenta.ShowDialog();

            RefrescarDataGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0)
            {
                FormOrdenVenta formOrdenVenta = new FormOrdenVenta()
                {
                    OrdenID = IDRegistroSeleccionado(),
                    Modo = "Editar"
                };

                formOrdenVenta.ShowDialog();

                RefrescarDataGrid();
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int id = IDRegistroSeleccionado();

            if (id != -1)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "Maestro - Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM OrdenVentaDetalle WHERE OrdenID={id};" +
                        $"DELETE FROM OrdenVenta WHERE OrdenID={id};";

                    DBManager.ExecuteNonQuery(sql);

                    RefrescarDataGrid();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RefrescarDataGrid();
        }
    }
}
