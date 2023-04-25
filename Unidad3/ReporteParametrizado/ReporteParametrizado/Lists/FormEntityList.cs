using ReporteParametrizado.Reports;
using SQLiteManager;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReporteParametrizado.Listas
{
    public partial class FormEntityList : Form
    {
        public Form MdiParentForm { get; set; }
        public string RecordType { get; set; }
        private SQLiteClient sqliteClient { get; set; }

        public FormEntityList()
        {
            InitializeComponent();
        }

        private void FormEntityList_Load(object sender, EventArgs e)
        {
            string databasePath = Properties.Settings.Default.DatabasePath;

            this.sqliteClient = new SQLiteClient(databasePath);

            RefreshDataGridView();
        }

        private DataTable GetRecords()
        {
            string filters = String.Empty;

            if (!String.IsNullOrEmpty(TxtBuscar.Text))
            {
                string criteria = TxtBuscar.Text;
                filters = $" AND (name Like '{criteria}%' OR " +
                    $"email Like '{criteria}%' OR " +
                    $"phone Like '{criteria}%' OR " +
                    $"address Like '{criteria}%' OR " +
                    $"city Like '{criteria}%' OR " +
                    $"state Like '{criteria}%' OR " +
                    $"zip Like '{criteria}%')";
            }

            string sql = $"SELECT * FROM entity WHERE type='{this.RecordType}'{filters};";

            return sqliteClient.ExecuteQuery(sql);
        }

        private void RefreshDataGridView()
        {
            GrdViewList.DataSource = GetRecords();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void BtnTodo_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = String.Empty;
            RefreshDataGridView();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormEntity formEntity = new FormEntity()
            {
                RecordType = this.RecordType,
                RecordId = -1,
                Mode = "New"
            };

            formEntity.ShowDialog();

            RefreshDataGridView();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = GetIdFromSelectedRow();

            if (id != -1)
            {
                FormEntity formEntity = new FormEntity()
                {
                    RecordType = this.RecordType,
                    RecordId = id,
                    Mode = "Edit"
                };

                formEntity.ShowDialog();

                RefreshDataGridView();
            }
        }

        private int GetIdFromSelectedRow()
        {
            int id = -1;

            if (GrdViewList.RowCount > 0)
                id = Int32.TryParse(GrdViewList.CurrentRow.Cells["Id"].Value.ToString(), out Int32 entityID) ? entityID : -1;

            return id;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = GetIdFromSelectedRow();

            if (id != -1)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.sqliteClient.ExecuteNonQuery($"DELETE FROM entity WHERE id={id};");
                    RefreshDataGridView();
                }
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                ExportToCsv(GetRecords(), saveFileDialog.FileName);
            }
        }

        public static void ExportToCsv(DataTable dataTable, string filePath)
        {
            string csv = string.Empty;

            // Write the data columns
            foreach (DataColumn column in dataTable.Columns)
            {
                csv += column.ColumnName + ",";
            }
            csv += Environment.NewLine;

            // Write the data rows
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    csv += row[i].ToString().Replace(',', ' ') + ",";
                }
                csv += Environment.NewLine;
            }

            File.WriteAllText(filePath, csv);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string reportPath;

            switch (this.RecordType)
            {
                case "customer":
                    reportPath = @"Reports\RptEntity.rdlc";
                    break;
                case "employee":
                    reportPath = @"Reports\RptEmployee.rdlc";
                    break;
                default:
                    reportPath = @"Reports\RptVendor.rdlc";
                    break;
            }

            FormReportViewer formReportViewer = new FormReportViewer()
            {
                RecordType = this.RecordType,
                ReportDataTable = GetRecords(),
                ReportPath = reportPath,
                MdiParent = this.MdiParentForm
            };

            formReportViewer.Show();
        }
    }
}
