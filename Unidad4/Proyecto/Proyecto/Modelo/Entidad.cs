using Proyecto.Controlador;
using System;
using System.Data;

namespace Proyecto.Modelo
{
    public class Entidad
    {
        public int EntidadID { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string DireccionFacturacion { get; set; }
        public string DireccionEnvio { get; set; }
        public bool Credito { get; set; }
        public decimal LimiteCredito { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaActualizacion { get; set; }
    }

    public class EntidadDatos
    {
        protected SQLiteClient _sqliteClient;

        public EntidadDatos() 
        {
            string databasePath = Properties.Settings.Default.DatabasePath;
            _sqliteClient = new SQLiteClient(databasePath);
        }

        public  DataTable ObtenerRegistros(string filtro = "")
        {
            string clausula = String.Empty;

            if (!String.IsNullOrEmpty(filtro))
                clausula = $"WHERE {filtro}";

            string sql = $"SELECT * FROM Entidad {clausula};";

            return _sqliteClient.ExecuteQuery(sql);
        }

        public int Insertar(Entidad entidad)
        {
            string sql = $"INSERT INTO Entidad (EntidadID, Tipo, Nombre, Apellido, Telefono, Email," +
                $"DireccionFacturacion, DireccionEnvio, Credito, LimiteCredito, FechaCreacion, FechaActualizacion) " +
                $"VALUES ({entidad.EntidadID}, '{entidad.Tipo}', '{entidad.Nombre}', '{entidad.Apellido}', " +
                $"'{entidad.Telefono}', '{entidad.Email}', '{entidad.DireccionFacturacion}', '{entidad.DireccionEnvio}', " +
                $"{entidad.Credito}, {entidad.LimiteCredito}, '{entidad.FechaCreacion}', '{entidad.FechaActualizacion}');";

            return _sqliteClient.ExecuteNonQuery(sql);
        }

        public int Actualizar(Entidad entidad, string filtro = "")
        {
            string clausula = String.Empty;

            if (!String.IsNullOrEmpty(filtro))
                clausula = $"WHERE {filtro}";

            string sql = $"UPDATE Entidad " +
                $"SET Tipo='{entidad.Tipo}', " +
                $"Nombre='{entidad.Nombre}', " +
                $"Apellido='{entidad.Apellido}', " +
                $"Telefono='{entidad.Telefono}', " +
                $"Email='{entidad.Email}'," +
                $"DireccionFacturacion='{entidad.DireccionFacturacion}', " +
                $"DireccionEnvio='{entidad.DireccionEnvio}', " +
                $"Credito={entidad.Credito}, " +
                $"LimiteCredito={entidad.LimiteCredito}, " +
                $"FechaCreacion='{entidad.FechaCreacion}', " +
                $"FechaActualizacion='{entidad.FechaActualizacion}' {clausula};";
            return _sqliteClient.ExecuteNonQuery(sql);
        }

        public int Eliminar(string filtro = "")
        {
            string clausula = String.Empty;

            if (!String.IsNullOrEmpty(filtro))
                clausula = $"WHERE {filtro}";

            string sql = $"DELETE FROM Entidad {clausula};";

            return _sqliteClient.ExecuteNonQuery(sql);
        }
    }
}
