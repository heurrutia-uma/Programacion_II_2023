using Microsoft.Reporting.WinForms;
using SQLiteManager;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ReporteClientes
{
    public partial class FormPrincipal : Form
    {
        private readonly ReportViewer reportViewer;

        public FormPrincipal()
        {
            Text = "Visualizador de reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(800, 600);

            reportViewer = new ReportViewer()
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(reportViewer);
        }

        protected override async void OnLoad(EventArgs e)
        {
            SQLiteClient sqliteClient = new SQLiteClient(@"C:\Temp\customer.db");

            if (!File.Exists(sqliteClient.GetSQLiteDataBasePath()))
            {
                sqliteClient.CreateDataBaseFile();
                await sqliteClient.ExecuteSQLScriptAsync("scriptsql.txt");
            }

            RptCustomer.Load(reportViewer.LocalReport, sqliteClient);
            reportViewer.RefreshReport();

            base.OnLoad(e);
        }
    }
}
