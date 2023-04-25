using ReporteParametrizado.SQL;
using SQLiteManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReporteParametrizado.Listas
{
    public partial class FormEntity : Form
    {
        public string RecordType { get; set; }
        public int RecordId { get; set; }
        public string Mode { get; set; }
        private SQLiteClient SqliteClient { get; set; }

        public FormEntity()
        {
            InitializeComponent();
        }

        private void FormEntity_Load(object sender, EventArgs e)
        {
            switch (this.RecordType)
            {
                case "customer":
                    this.Text = "Cliente";
                    break;
                case "employee":
                    this.Text = "Empleado";
                    break;
                default:
                    this.Text = "Proveedor";
                    break;
            }

            string databasePath = Properties.Settings.Default.DatabasePath;
            this.SqliteClient = new SQLiteClient(databasePath);

            if (this.Mode == "New")
            {
                FormBindingSource.DataSource = new Entity()
                {
                    Type = this.RecordType
                };
            }
            else
            {
                string sql = $"SELECT * FROM entity WHERE id={this.RecordId}";
                List<Entity> data = SqliteClient.ExecuteQuery<Entity>(sql);

                FormBindingSource.DataSource = data;
            }

            TxtType.DataBindings.Add("Text", FormBindingSource, "Type");
            TxtName.DataBindings.Add("Text", FormBindingSource, "Name");
            TxtEmail.DataBindings.Add("Text", FormBindingSource, "Email");
            TxtPhone.DataBindings.Add("Text", FormBindingSource, "Phone");
            TxtAddress.DataBindings.Add("Text", FormBindingSource, "Address");
            TxtCity.DataBindings.Add("Text", FormBindingSource, "City");
            TxtState.DataBindings.Add("Text", FormBindingSource, "State");
            TxtZip.DataBindings.Add("Text", FormBindingSource, "Zip");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FormBindingSource.EndEdit();

            foreach (var item in FormBindingSource.List)
            {
                string name = (string)item.GetType().GetProperty("Name").GetValue(item);
                string email = (string)item.GetType().GetProperty("Email").GetValue(item);
                string phone = (string)item.GetType().GetProperty("Phone").GetValue(item);
                string address = (string)item.GetType().GetProperty("Address").GetValue(item);
                string city = (string)item.GetType().GetProperty("City").GetValue(item);
                string state = (string)item.GetType().GetProperty("State").GetValue(item);
                string zip = (string)item.GetType().GetProperty("Zip").GetValue(item);
                string type = (string)item.GetType().GetProperty("Type").GetValue(item);

                string sql;

                if (this.Mode == "New")
                {
                    sql = $"INSERT INTO entity (name,email,phone,address,city,state,city,zip,type) " +
                        $"VALUES ('{name}','{email}','{phone}','{address}','{city}','{state}','{city}','{zip}','{type}');";

                    var lastId = this.SqliteClient.ExecuteNonQuery(sql);
                }
                else
                {
                    sql = $"UPDATE entity " +
                        $"SET name='{name}'," +
                        $"email='{email}'," +
                        $"phone='{phone}'," +
                        $"address='{address}'," +
                        $"city='{city}'," +
                        $"state='{state}'," +
                        $"city='{city}'," +
                        $"zip='{zip}' WHERE id={this.RecordId}";

                    this.SqliteClient.ExecuteNonQuery(sql);
                }
            }

            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
