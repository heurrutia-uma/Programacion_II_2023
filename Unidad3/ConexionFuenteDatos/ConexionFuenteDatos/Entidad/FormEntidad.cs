using System;
using System.Data;
using System.Windows.Forms;

namespace ConexionFuenteDatos.Entidad
{
    public partial class FormEntidad : Form
    {
        public string TipoEntidad { get; set; }
        public int UsuarioID { get; set; }
        public string Modo { get; set; }
        public int ID { get; set; }
        private static SQLiteDBManager DBManager { get; set; }

        public FormEntidad()
        {
            InitializeComponent();

            DBManager = new SQLiteDBManager();
        }

        private void FormEntidad_Load(object sender, EventArgs e)
        {
            this.Text = this.TipoEntidad;

            if (this.TipoEntidad == "Proveedor")
            { 
                GrpBoxInfoCredito.Visible = false;
            }

            if (this.Modo == "edit")
            {
                DataRow data = DBManager.ExecuteQuery($"SELECT * FROM Entidad WHERE EntidadID = {this.ID};").Rows[0];

                TxtNombres.Text = data["Nombre"].ToString();
                TxtApellidos.Text = data["Apellido"].ToString();
                TxtTelefono.Text = data["Telefono"].ToString();
                TxtEmail.Text = data["Email"].ToString();
                TxtDireccionFacturacion.Text = data["DireccionFacturacion"].ToString();
                TxtDireccionEnvio.Text = data["DireccionEnvio"].ToString();
                ChkCredito.Checked = Convert.ToBoolean(data["Credito"]);
                TxtLimiteCredito.Text = data["LimiteCredito"].ToString();
            }
        }

        private void BtonGuardar_Click(object sender, EventArgs e)
        {
            decimal limiteCredito = Decimal.TryParse(TxtLimiteCredito.Text, out decimal limite) ? limite : 0;

            if (this.Modo == "nuevo")
            {
                string sql = $"INSERT INTO Entidad (" +
                    $"Tipo, Nombre, Apellido, Telefono, Email, " +
                    $"DireccionFacturacion, DireccionEnvio, " +
                    $"Credito, LimiteCredito, UsuarioID, FechaCreacion) " +
                    $"VALUES(" +
                    $"'{this.TipoEntidad}','{TxtNombres.Text}','{TxtApellidos.Text}'," +
                    $"'{TxtTelefono.Text}','{TxtEmail.Text}','{TxtDireccionFacturacion.Text}'," +
                    $"'{TxtDireccionEnvio.Text}',{ChkCredito.Checked}," +
                    $"{limiteCredito}, {this.UsuarioID}, '{DateTime.Now:dd/MM/yyyy HH:mm:ss}');";

                DBManager.ExecuteNonQuery(sql);

                this.Close();
            }
            else if (this.Modo == "edit")
            {
                string sql = $"UPDATE Entidad SET " +
                    $"Nombre='{TxtNombres.Text}', Apellido='{TxtApellidos.Text}', " +
                    $"Telefono='{TxtTelefono.Text}', Email='{TxtEmail.Text}', " +
                    $"DireccionFacturacion='{TxtDireccionFacturacion.Text}', " +
                    $"DireccionEnvio='{TxtDireccionEnvio.Text}', " +
                    $"Credito={ChkCredito.Checked}, " +
                    $"LimiteCredito={limiteCredito}, " +
                    $"UsuarioID={this.UsuarioID}, " +
                    $"FechaActualizacion='{DateTime.Now:dd/MM/yyyy HH:mm:ss}' " +
                    $"WHERE EntidadID = {this.ID};";

                DBManager.ExecuteNonQuery(sql);

                this.Close();
            }
        }

        private void BtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
