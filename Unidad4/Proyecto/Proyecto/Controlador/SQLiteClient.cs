using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controlador
{
    public class SQLiteClient
    {
        protected SQLiteConnection Connection { get; set; }

        public SQLiteClient(string databasePath) {

            if (String.IsNullOrEmpty(databasePath))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(databasePath));

            string connectionString = $"Data Source={databasePath};Version=3;UseUTF16Encoding=True;";

            Connection = new SQLiteConnection(connectionString);
        }

        public DataTable ExecuteQuery(string sql)
        {
            if (String.IsNullOrEmpty(sql))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sql));

            DataTable dataTable = new DataTable();
            this.Connection.Open();

            try
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                using (SQLiteCommand command = new SQLiteCommand(sql, this.Connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            dataTable.Columns.Add(textInfo.ToTitleCase(reader.GetName(i)));

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
                    }
                }
            }
            finally
            {
                this.Connection.Close();
            }

            return dataTable;
        }

        public int ExecuteNonQuery(string sql)
        {
            if (String.IsNullOrEmpty(sql))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sql));

            this.Connection.Open();
            int affectedRecordsOrInsertedId;

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, this.Connection))
                {
                    affectedRecordsOrInsertedId = command.ExecuteNonQuery();

                    if (sql.StartsWith("INSERT", StringComparison.OrdinalIgnoreCase))
                        affectedRecordsOrInsertedId = (int)this.Connection.LastInsertRowId;
                }
            }
            finally
            {
                this.Connection.Close();
            }

            return affectedRecordsOrInsertedId;
        }
    }
}
