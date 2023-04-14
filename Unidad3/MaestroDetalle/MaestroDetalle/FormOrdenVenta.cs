using System;
using System.Data;
using System.Windows.Forms;

namespace MaestroDetalle
{
    public partial class FormOrdenVenta : Form
    {
        private static SQLiteDBManager DBManager { get; set; }
        public int OrdenID { get; set; }
        public string Modo { get; set; }

        public FormOrdenVenta()
        {
            InitializeComponent();
        }

        private void FormOrdenVenta_Load(object sender, System.EventArgs e)
        {
            DBManager = new SQLiteDBManager();

            RefrescarDataGrid();
        }

        private void RefrescarDataGrid()
        {
            if (OrdenID != -1 && Modo == "Editar")
            {
                DateTime fecha;

                DataRow registro = DBManager.ExecuteQuery($"SELECT * FROM OrdenVenta WHERE OrdenID = {OrdenID};").Rows[0];

                TxtCliente.Text = registro["NombreCliente"].ToString();
                DTFechaOrden.Value = DateTime.TryParse(registro["FechaOrden"].ToString(), out fecha) ? fecha : DateTime.Now;
                TxtNumeroOrden.Text = registro["NumeroOrden"].ToString();
                TxtContacto.Text = registro["Contacto"].ToString();
                DTFechaEntrega.Value = DateTime.TryParse(registro["FechaEntrega"].ToString(), out fecha) ? fecha : DateTime.Now;
                TxtDireccion.Text = registro["DireccionEnvio"].ToString();
                TxtFechaCreacion.Text = registro["FechaCreacion"].ToString();
                TxtFechaActualizacion.Text = registro["FechaActualizacion"].ToString();

                TxtNumeroOrden.ReadOnly = true;
                DTFechaOrden.Enabled = false;
            }

            var totalOrden = DBManager.ExecuteQuery($"SELECT SUM(PrecioTotal) FROM OrdenVentaDetalle WHERE OrdenID={OrdenID};").Rows[0];

            NumTotalOrden.Value = Decimal.TryParse(totalOrden[0].ToString(), out Decimal total) ? total : 0;

            DataTable dataTable = DBManager.ExecuteQuery($"SELECT * FROM OrdenVentaDetalle WHERE OrdenID={OrdenID};");
            DataGrid.DataSource = dataTable;

            DataGrid.Columns[0].Visible = false;
            DataGrid.Columns[1].Visible = false;
        }

        private int IDRegistroSeleccionado()
        {
            int id = -1;

            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0)
            {
                if (DataGrid.CurrentRow != null)
                {
                    var OrdenDetalleID = DataGrid.CurrentRow.Cells["OrdenDetalleID"].Value;
                    id = Int32.TryParse(OrdenDetalleID.ToString(), out Int32 ordenDetalleID) ? ordenDetalleID : -1;
                }
                else
                {
                    MessageBox.Show("Seleccione una linea.", "", MessageBoxButtons.OK);
                }
            }
            return id;
        }

        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            FormOrdenDetalle formOrdenDetalle = new FormOrdenDetalle()
            {
                OrdenID = OrdenID,
                OrdenDetalleID = -1,
                Modo = "Nuevo"
            };

            formOrdenDetalle.ShowDialog();

            RefrescarDataGrid();
        }

        private void BtnEditar_Click(object sender, System.EventArgs e)
        {
            if (DataGrid.RowCount > 0 && DataGrid.SelectedRows.Count > 0 && IDRegistroSeleccionado() != -1)
            {
                FormOrdenDetalle formOrdenDetalle = new FormOrdenDetalle()
                {
                    OrdenID = OrdenID,
                    OrdenDetalleID = IDRegistroSeleccionado(),
                    Modo = "Editar"
                };

                formOrdenDetalle.ShowDialog();

                RefrescarDataGrid();
            }
        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {
            int id = IDRegistroSeleccionado();

            if (id != -1)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "Maestro - Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM OrdenVentaDetalle WHERE OrdenDetalleID={id};";

                    DBManager.ExecuteNonQuery(sql);

                    RefrescarDataGrid();
                }
            }
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            string sql;

            DateTime fechaOrden = DTFechaOrden.Value;
            DateTime fechaEntrega = DTFechaEntrega.Value;


            if (OrdenID == -1 && Modo == "Nuevo")
            {
                sql = $"INSERT INTO OrdenVenta " +
                    $"(NumeroOrden, FechaOrden, TotalOrden, NombreCliente, " +
                    $"Contacto, FechaEntrega, DireccionEnvio, FechaCreacion) " +
                    $"VALUES ('{TxtNumeroOrden.Text}', '{fechaOrden:yyyy-MM-dd HH:mm:ss}', {NumTotalOrden.Value}, " +
                    $"'{TxtCliente.Text}', '{TxtContacto.Text}', '{fechaEntrega:yyyy-MM-dd HH:mm:ss}', '{TxtDireccion.Text}', " +
                    $"'{DateTime.Now:yyyy-MM-dd HH:mm:ss}');";
                var ID = DBManager.ExecuteNonQuery(sql);

                sql = $"UPDATE OrdenVentaDetalle SET OrdenID={ID} WHERE OrdenID=-1;";
                DBManager.ExecuteNonQuery(sql);

                OrdenID = ID;
                Modo = "Editar";
            }
            else if (OrdenID != -1 && Modo == "Editar")
            {
                sql = $"UPDATE OrdenVenta " +
                    $"SET TotalOrden={NumTotalOrden.Value}, " +
                    $"NombreCliente='{TxtCliente.Text}', " +
                    $"Contacto='{TxtContacto.Text}', " +
                    $"FechaEntrega='{fechaEntrega:yyyy-MM-dd HH:mm:ss}', " +
                    $"DireccionEnvio='{TxtDireccion.Text}', " +
                    $"FechaActualizacion='{DateTime.Now:yyyy-MM-dd HH:mm:ss}';";
                DBManager.ExecuteNonQuery(sql);
            }

            RefrescarDataGrid();
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            var count = DBManager.ExecuteQuery($"SELECT count(*) FROM OrdenVentaDetalle WHERE OrdenID=-1;").Rows[0];
            if (Convert.ToInt32(count[0].ToString()) > 0)
                DBManager.ExecuteNonQuery("DELETE FROM OrdenVentaDetalle WHERE OrdenID=-1;");

            this.Close();
        }
    }
}
