using Microsoft.Reporting.WinForms;
using SQLiteManager;
using System.Data;

namespace ReporteClientes
{
    public class RptCustomer
    {
        public static async void Load(LocalReport report, SQLiteClient sqliteClient)
        {
            DataTable dataTable = await sqliteClient.ExecuteQueryAsync("SELECT * FROM customer;");

            ReportDataSource reportDataSource = new ReportDataSource("DataSetName", dataTable)
            {
                Name = "Customer"
            };

            report.DataSources.Clear();
            report.DataSources.Add(reportDataSource);
            report.ReportPath = "RptCustomer.rdlc";
            report.Refresh();
        }
    }
}
