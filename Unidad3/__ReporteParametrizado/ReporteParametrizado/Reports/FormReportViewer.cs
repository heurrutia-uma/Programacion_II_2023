using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ReporteParametrizado.Reports
{
    public partial class FormReportViewer : Form
    {
        public string RecordType { get; set; }
        public DataTable ReportDataTable { get; set; }
        public string ReportPath { get; set; }

        private readonly ReportViewer reportViewer;

        public FormReportViewer()
        {
            Text = "Vista previa";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(800, 600);

            reportViewer = new ReportViewer()
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            string reportTitle;

            switch(this.RecordType)
            {
                case "customer":
                    reportTitle = "Lista de Clientes";
                    break;
                case "employee":
                    reportTitle = "Lista de Empleados";
                    break;
                default:
                    reportTitle = "Lista de Proveedores";
                    break;
            }

            ReportParameter parameter = new ReportParameter("ParamTitle", reportTitle);

            ReportManager.Load(reportViewer.LocalReport, this.ReportDataTable, this.ReportPath);
            reportViewer.RefreshReport();

            base.OnLoad(e);
        }
    }
}
