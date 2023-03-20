using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulos
{
    public partial class FormListaProveedores : Form
    {
        private AdminArchivosCSV archivoCSV;

        public FormListaProveedores()
        {
            InitializeComponent();
        }

        private void FormListaProveedores_Load(object sender, EventArgs e)
        {
            this.archivoCSV = new AdminArchivosCSV("proveedores.csv");

            string[] columnas = { "Nombres", "Apellidos", "Empresa", "Telefono", "Email", "Direccion" };
            this.archivoCSV.CrearArchivo(columnas);

            RefrescarDataGrid();
        }

        private void BtonNuevo_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor()
            {
                modo = "nuevo",
                indiceLinea = -1,
                archivoCSV = this.archivoCSV
            };

            formProveedor.ShowDialog();

            RefrescarDataGrid();
        }

        private void BtonEditar_Click(object sender, EventArgs e)
        {
            if (GridLista.RowCount > 0)
            {
                int fila = GridLista.SelectedRows[0].Index;

                FormProveedor formProveedor = new FormProveedor()
                {
                    modo = "editar",
                    indiceLinea = fila + 1,
                    archivoCSV = this.archivoCSV
                };

                formProveedor.ShowDialog();

                RefrescarDataGrid();
            }
        }

        private void BtonBorrar_Click(object sender, EventArgs e)
        {
            if (GridLista.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres borrar el registro seleccionado?", "Diseño modular", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int fila = GridLista.SelectedRows[0].Index;

                    this.archivoCSV.BorrarLinea(fila + 1);

                    RefrescarDataGrid();
                }
            }
        }

        private void BtonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarDataGrid()
        {
            DataTable dataTable = this.archivoCSV.CargarArchivo();
            GridLista.DataSource = dataTable;
        }
    }
}
