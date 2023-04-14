using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace MaestroDetalle
{
    public class SQLiteDBManager
    {
        public string BaseDatosSQLite { get; set; }
        private SQLiteConnection Conexion { get; set; }

        public SQLiteDBManager()
        {
            this.BaseDatosSQLite = Properties.Settings.Default.RutaBaseDatos;
            this.Conexion = new SQLiteConnection($"Data Source={this.BaseDatosSQLite};Version=3;");
        }

        public void CreateDatabase()
        {
            SQLiteConnection.CreateFile(this.BaseDatosSQLite);
        }

        public void CreateTables()
        {
            // Abrimos y leemos archivo .sql con la definicion de las tablas
            StreamReader reader = new StreamReader(@"BaseDatos\\MaestroDetalle.sql");
            string sqlScript = reader.ReadToEnd();

            // Ejecutamos el script de sql
            ExecuteNonQuery(sqlScript);
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dataTable = new DataTable();

            this.Conexion.Open();

            SQLiteCommand command = new SQLiteCommand(sql, this.Conexion);
            SQLiteDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
                dataTable.Columns.Add(reader.GetName(i));

            while (reader.Read())
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var dato = reader[i].ToString();

                    if (DateTime.TryParse(dato, out DateTime fecha))
                        dataRow[i] = fecha;
                    else
                        dataRow[i] = reader[i];
                }
                dataTable.Rows.Add(dataRow);
            }

            reader.Close();

            this.Conexion.Close();

            return dataTable;
        }

        public int ExecuteNonQuery(string sql)
        {
            this.Conexion.Open();

            SQLiteCommand command = new SQLiteCommand(sql, this.Conexion);
            int registrosAfectados = command.ExecuteNonQuery();

            // Obtenemos el último ID de fila insertada
            if (sql.ToUpper().StartsWith("INSERT"))
                registrosAfectados = (int)this.Conexion.LastInsertRowId;

            this.Conexion.Close();

            return registrosAfectados;
        }
    }
}
