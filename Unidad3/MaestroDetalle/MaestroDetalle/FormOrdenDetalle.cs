using System;
using System.Data;
using System.Windows.Forms;

namespace MaestroDetalle
{
    public partial class FormOrdenDetalle : Form
    {
        private static SQLiteDBManager DBManager { get; set; }
        public int OrdenID { get; set; }
        public int OrdenDetalleID { get; set; }
        public string Modo { get; set; }

        public FormOrdenDetalle()
        {
            InitializeComponent();
        }

        private void FormOrdenDetalle_Load(object sender, EventArgs e)
        {
            DBManager = new SQLiteDBManager();

            if (OrdenDetalleID != -1 && Modo == "Editar")
            {
                DataRow registro = DBManager.ExecuteQuery($"SELECT * FROM OrdenVentaDetalle WHERE OrdenDetalleID = {OrdenDetalleID};").Rows[0];

                TxtArticulo.Text = registro["Articulo"].ToString();
                NumCantidad.Value = Decimal.Parse(registro["Cantidad"].ToString());
                NumPrecioUnitario.Value = Decimal.Parse(registro["PrecioUnitario"].ToString());
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string sql;

            decimal cantidad = NumCantidad.Value;
            decimal precioUnitario = NumPrecioUnitario.Value;
            decimal precioTotal = cantidad * precioUnitario;

            if (OrdenDetalleID == -1 && Modo == "Nuevo")
            {
                sql = $"INSERT INTO OrdenVentaDetalle " +
                    $"(OrdenID, Articulo, Cantidad, PrecioUnitario, " +
                    $"PrecioTotal, FechaCreacion) " +
                    $"VALUES ('{OrdenID}', '{TxtArticulo.Text}', {cantidad}, " +
                    $"{precioUnitario}, {precioTotal}, '{DateTime.Now:yyyy-MM-dd HH:mm:ss}');";
                DBManager.ExecuteQuery(sql);
            }
            else if (OrdenDetalleID != -1 && Modo == "Editar")
            {
                sql = $"UPDATE OrdenVentaDetalle " +
                    $"SET Articulo='{TxtArticulo.Text}', " +
                    $"Cantidad={cantidad}, " +
                    $"PrecioUnitario={precioUnitario}, " +
                    $"PrecioTotal={precioTotal}, " +
                    $"FechaActualizacion='{DateTime.Now:yyyy-MM-dd HH:mm:ss}' WHERE OrdenDetalleID={OrdenDetalleID};";
                DBManager.ExecuteNonQuery(sql);
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
