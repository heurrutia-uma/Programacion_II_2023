using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections.Generic;

namespace SQLiteManager
{
    public class SQLiteClient : IDisposable
    {
        protected string SQLiteDatabasePath { get; set; }
        protected SQLiteConnection Connection { get; set; }

        /// <summary>
        /// Método constructor
        /// </summary>
        /// <param name="databasePath">Ruta de la base de datos</param>
        /// <exception cref="ArgumentException">Es lanzado cuando la ruta de la base de datos está vacía.</exception>
        public SQLiteClient(string databasePath)
        {
            if (String.IsNullOrEmpty(databasePath))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(databasePath));

            if (!Path.IsPathRooted(databasePath))
                throw new ArgumentException("La ruta del archivo de base de datos debe ser una ruta absoluta.", nameof(databasePath));

            string filePath = Path.GetFullPath(databasePath);
            string connectionString = $"Data Source={filePath};Version=3;UseUTF16Encoding=True;";

            this.SQLiteDatabasePath = databasePath;
            this.Connection = new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Crea el archivo de base de datos con el nombre y ruta especidicada.
        /// </summary>
        public void CreateDataBaseFile()
        {
            string databasePath = Path.GetDirectoryName(this.SQLiteDatabasePath);

            if (!Directory.Exists(databasePath))
                Directory.CreateDirectory(databasePath);

            SQLiteConnection.CreateFile(this.SQLiteDatabasePath);
        }

        /// <summary>
        /// Ejecuta sentencias SQL
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// DataTable results = client.ExecuteQuery("SELECT * FROM myTable");
        /// </code>
        /// </summary>
        /// <param name="sql">Consulta SQL SELECT</param>
        /// <returns>Task<DataTable></returns>
        /// <exception cref="ArgumentException">Es lanzado cuando la consulta SELECT es vacía o inválida.</exception>
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

        /// <summary>
        /// Ejecuta sentencias SQL
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// var results = client.ExecuteQuery<T>("SELECT * FROM myTable");
        /// </code>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">Consulta SQL SELECT</param>
        /// <returns>List<T></returns>
        /// <exception cref="ArgumentException"></exception>
        public List<T> ExecuteQuery<T>(string sql) where T : new()
        {
            if (String.IsNullOrEmpty(sql))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sql));

            var resultList = new List<T>();
            this.Connection.Open();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, this.Connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new T();
                            var props = typeof(T).GetProperties();

                            foreach (var prop in props)
                            {
                                var propName = prop.Name;
                                var propType = prop.PropertyType;
                                var propValue = reader[propName].ToString();

                                if (propType == typeof(int) && Int32.TryParse(propValue, out int iValue))
                                    prop.SetValue(item, iValue);
                                else if (propType == typeof(decimal) && Decimal.TryParse(propValue, out decimal dValue))
                                    prop.SetValue(item, dValue);
                                else if (propType == typeof(bool) && Boolean.TryParse(propValue, out bool bValue))
                                    prop.SetValue(item, bValue);
                                else if (propType == typeof(DateTime) && DateTime.TryParse(propValue, out DateTime dtValue))
                                    prop.SetValue(item, dtValue);
                                else
                                    prop.SetValue(item, propValue);
                            }

                            resultList.Add(item);
                        }
                    }
                }
            }
            finally
            {
                this.Connection.Close();
            }

            return resultList;
        }


        /// <summary>
        /// Ejecuta sentencias SQL asincronas.
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// DataTable results = await client.ExecuteQueryAsync("SELECT * FROM myTable");
        /// </code>
        /// </summary>
        /// <param name="sql">Consulta SQL SELECT</param>
        /// <returns>Task<DataTable></returns>
        /// <exception cref="ArgumentException">Es lanzado cuando la consulta SELECT es vacía o inválida.</exception>
        public async Task<DataTable> ExecuteQueryAsync(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sql));

            DataTable dataTable = new DataTable();
            await this.Connection.OpenAsync();

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, this.Connection))
                {
                    using (DbDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            dataTable.Columns.Add(reader.GetName(i));

                        while (await reader.ReadAsync())
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

        /// <summary>
        /// Ejecuta sentencias SQL de no consulta.
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// int affectedRows = client.ExecuteNonQuery("UPDATE myTable SET name = 'John' WHERE id = 1");
        /// </code>
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        /// <returns>Task<int></returns>
        /// <exception cref="ArgumentException">Es lanzado cuando el comando SQL es vacío o inválido.</exception>
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

        /// <summary>
        /// Ejecuta sentencias SQL de no consulta asincrona.
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// int affectedRows = await client.ExecuteNonQueryAsync("UPDATE myTable SET name = 'John' WHERE id = 1");
        /// </code>
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        /// <returns>Task<int></returns>
        /// <exception cref="ArgumentException">Es lanzado cuando el comando SQL es vacío o inválido.</exception>
        public async Task<int> ExecuteNonQueryAsync(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                throw new ArgumentException("The parameter cannot be empty.", nameof(sql));

            await this.Connection.OpenAsync();
            int affectedRecordsOrInsertedId;

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, this.Connection))
                {
                    affectedRecordsOrInsertedId = await command.ExecuteNonQueryAsync();

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

        /// <summary>
        /// Ejecuta comandos o consultas SQL contenidas en un script.
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// client.ExecuteSQLScript("myScript.sql");
        /// </code>
        /// </summary>
        /// <param name="sqlScriptPath">Ruta y nombre del archivo con el script SQL.</param>
        /// <returns>Task</returns>
        /// <exception cref="ArgumentException">Es lanzado cuando el parámetro, la ruta o archivo son inválido</exception>
        /// <exception cref="FileNotFoundException">Es lanzado cuando el archivo no fue encontrado.</exception>
        public void ExecuteSQLScript(string sqlScriptPath)
        {
            if (String.IsNullOrEmpty(sqlScriptPath))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sqlScriptPath));

            if (!Path.IsPathRooted(sqlScriptPath))
                sqlScriptPath = Path.Combine(Directory.GetCurrentDirectory(), sqlScriptPath);

            if (!Path.IsPathRooted(sqlScriptPath))
                throw new ArgumentException("La ruta del archivo debe ser una ruta absoluta.", nameof(sqlScriptPath));

            if (sqlScriptPath.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                throw new ArgumentException("La ruta del archivo contiene caracteres no válidos.");

            if (!File.Exists(sqlScriptPath))
                throw new FileNotFoundException("No se pudo encontrar el archivo.", sqlScriptPath);

            using (StreamReader reader = new StreamReader(sqlScriptPath))
            {
                string sqlScript = reader.ReadToEnd();
                ExecuteNonQuery(sqlScript);
            }
        }

        /// <summary>
        /// Ejecuta comandos o consultas SQL contenidas en un script de forma asincrona.
        /// <code>
        /// SQLiteClient client = new SQLiteClient(databasePath, password);
        /// await client.ExecuteSQLScriptAsync("myScript.sql");
        /// </code>
        /// </summary>
        /// <param name="sqlScriptPath">Ruta y nombre del archivo con el script SQL.</param>
        /// <returns>Task</returns>
        /// <exception cref="ArgumentException">Es lanzado cuando el parámetro, la ruta o archivo son inválido</exception>
        /// <exception cref="FileNotFoundException">Es lanzado cuando el archivo no fue encontrado.</exception>
        public async Task ExecuteSQLScriptAsync(string sqlScriptPath)
        {
            if (string.IsNullOrEmpty(sqlScriptPath))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sqlScriptPath));

            if (!Path.IsPathRooted(sqlScriptPath))
                sqlScriptPath = Path.Combine(Directory.GetCurrentDirectory(), sqlScriptPath);

            if (!Path.IsPathRooted(sqlScriptPath))
                throw new ArgumentException("La ruta del archivo debe ser una ruta absoluta.", nameof(sqlScriptPath));

            if (sqlScriptPath.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                throw new ArgumentException("La ruta del archivo contiene caracteres no válidos.");

            if (!File.Exists(sqlScriptPath))
                throw new FileNotFoundException("No se pudo encontrar el archivo.", sqlScriptPath);

            using (StreamReader reader = new StreamReader(sqlScriptPath))
            {
                string sqlScript = await reader.ReadToEndAsync();
                await ExecuteNonQueryAsync(sqlScript);
            }
        }

        /// <summary>
        /// Obtiene un SQLite DataAdapter en base al comandos SELECT pasado como parámetro
        /// </summary>
        /// <param name="sql">Comando SQL</param>
        /// <returns>SQLiteDataAdapter</returns>
        /// <exception cref="ArgumentException">Es lanzado cuando el parámetro está vacio</exception>
        public SQLiteDataAdapter GetAdapter(string sql)
        {
            if (String.IsNullOrEmpty(sql))
                throw new ArgumentException("El parámetro no puede estar vacío.", nameof(sql));

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, this.Connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            return adapter;
        }

        /// <summary>
        /// Obtiene la ruta de la base de datos en uso.
        /// </summary>
        /// <returns>String</returns>
        public string GetSQLiteDataBasePath()
        {
            return this.SQLiteDatabasePath;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Método destructor
        /// </summary>
        ~SQLiteClient()
        {
            Dispose(false);
        }

        /// <summary>
        /// Desecha apropiadamente el objeto Connection.
        /// </summary>
        /// <param name="disposing">Boolean</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing && this.Connection != null)
            {
                this.Connection.Dispose();
                this.Connection = null;
            }
        }
    }
}
