using Microsoft.Reporting.WinForms;
using System.Data;
using System.IO;

namespace ReporteParametrizado.Reports
{
    public class RptEntity
    {
        public static void Load(LocalReport localReport, DataTable dataTable, string reportPath)
        {
            if (!Path.IsPathRooted(reportPath))
                reportPath = Path.Combine(Directory.GetCurrentDirectory(), reportPath);

            ReportDataSource reportDataSource = new ReportDataSource("DataSetName", dataTable)
            {
                Name = "ReportSource"
            };

            FileStream fileStream = new FileStream(reportPath, FileMode.Open);

            localReport.LoadReportDefinition(fileStream);
            localReport.DataSources.Clear();
            localReport.DataSources.Add(reportDataSource);
            localReport.Refresh();
        }
    }
}
