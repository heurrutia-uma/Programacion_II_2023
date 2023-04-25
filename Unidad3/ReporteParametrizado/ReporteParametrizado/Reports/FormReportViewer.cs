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
            reportViewer = new ReportViewer()
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            string formTitle = "Vista previa";

            switch (this.RecordType)
            {
                case "customer":
                    formTitle += " - Lista de clientes";
                    break;
                case "employee":
                    formTitle += " - Lista de empleados";
                    break;
                default:
                    formTitle += " - Lista de proveedores";
                    break;
            }
            Text = formTitle;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(800, 600);

            RptEntity.Load(reportViewer.LocalReport, this.ReportDataTable, this.ReportPath);
            reportViewer.RefreshReport();

            base.OnLoad(e);
        }
    }
}
