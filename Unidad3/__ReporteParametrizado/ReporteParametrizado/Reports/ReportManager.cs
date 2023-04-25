﻿using Microsoft.Reporting.WinForms;
using System.Data;
using System.IO;

namespace ReporteParametrizado.Reports
{
    public  class ReportManager
    {
        public static void Load(LocalReport localReport, DataTable dataTable, string reportPath, ReportParameter parameters = null)
        {
            if (!Path.IsPathRooted(reportPath))
                reportPath = Path.Combine(Directory.GetCurrentDirectory(), reportPath);

            ReportDataSource reportDataSource = new ReportDataSource("DataSetName", dataTable)
            {
                Name = "ReportSource"
            };

            localReport.DataSources.Clear();
            localReport.DataSources.Add(reportDataSource);
            localReport.ReportPath = reportPath;

            //if (parameters != null)
            //{
            //    localReport.SetParameters(parameters);
            //}

            localReport.Refresh();
        }
    }
}
