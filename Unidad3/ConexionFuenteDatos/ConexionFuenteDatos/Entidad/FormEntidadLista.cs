using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConexionFuenteDatos.Entidad
{
    public partial class FormEntidadLista : Form
    {
        public int UsuarioID { get; set; }
        public string TipoEntidad { get; set; }
        private SQLiteDBManager DBManager { get; set; }

        public FormEntidadLista()
        {
            InitializeComponent();

            DBManager = new SQLiteDBManager();
        }

        private void FormEntidadLista_Load(object sender, EventArgs e)
        {
            this.Text = $"Lista {this.TipoEntidad}";
            LblCantidadRegistros.Text = $"Cantidad: 0";

            RegrescarDataGrid();
        }

        private void RegrescarDataGrid()
        {
            DataTable dataTable = ObtenerListaRegistros();
            DataGrid.DataSource = dataTable;

            LblCantidadRegistros.Text = $"Cantidad: {dataTable.Rows.Count}";
        }

        private DataTable ObtenerListaRegistros()
        {
            string filter = String.Empty;

            if (!String.IsNullOrEmpty(TxtBuscar.Text))
                filter = $" AND (Nombre Like '{TxtBuscar.Text}%' OR Apellido Like '{TxtBuscar.Text}%');";

            return this.DBManager.ExecuteQuery($"SELECT * FROM Entidad WHERE Tipo='{this.TipoEntidad}'{filter};");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormEntidad formEntidad = new FormEntidad()
            {
                TipoEntidad = this.TipoEntidad,
                UsuarioID = this.UsuarioID,
                Modo = "nuevo",
                ID = -1
            };

            formEntidad.ShowDialog();

            RegrescarDataGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0)
            {
                int id = Int32.TryParse(DataGrid.CurrentRow.Cells["EntidadID"].Value.ToString(), out Int32 entidadID) ? entidadID : -1;

                FormEntidad formEntidad = new FormEntidad()
                {
                    TipoEntidad = this.TipoEntidad,
                    UsuarioID = this.UsuarioID,
                    Modo = "edit",
                    ID = id
                };

                formEntidad.ShowDialog();

                RegrescarDataGrid();
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (DataGrid.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "Diseño modular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                int id = Int32.TryParse(DataGrid.CurrentRow.Cells["EntidadID"].Value.ToString(), out Int32 entidadID) ? entidadID : -1;

                if (result == DialogResult.Yes && id != -1)
                {
                    string sql = $"DELETE FROM Entidad WHERE EntidadID={id};";
                    DBManager.ExecuteNonQuery(sql);

                    RegrescarDataGrid();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RegrescarDataGrid();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            var dataTable = ObtenerListaRegistros();
            var archivoCSV = ObtenerRutaArchivoCSV();

            if (dataTable.Rows.Count == 0 || String.IsNullOrEmpty(archivoCSV))
            {
                return;
            }

            StringBuilder stringBuilder = new StringBuilder();

            // Obtenemos los nombres de las columnas
            string[] columnas = new string[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                columnas[i] = dataTable.Columns[i].ColumnName;
            }

            // Unimos los nombres de las columnas en un solo string separadas por coma
            string encabezado = String.Join(",", columnas);

            // Se agrega la linea al StringBuilder
            stringBuilder.AppendLine(encabezado);

            // Cargamos las filas
            foreach (DataRow row in dataTable.Rows)
            {
                string[] datos = new string[row.ItemArray.Length];

                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    datos[i] = row.ItemArray[i].ToString().Replace(',', ' '); // Remplazamos cualquier coma en los datos
                }

                // Unimos los datos de cada columna en un solo string separadas por coma
                string fila = string.Join(",", datos);

                // Se agrega la linea al StringBuilder
                stringBuilder.AppendLine(fila);
            }

            // Crea el archivo csv con los datos almacenados en el StringBuilder
            File.WriteAllText(archivoCSV, stringBuilder.ToString()); 
        }

        private string ObtenerRutaArchivoCSV()
        {
            var dialogoGuardar = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar"
            };

            return dialogoGuardar.ShowDialog() == DialogResult.OK ? dialogoGuardar.FileName : null;
        }
    }
}
