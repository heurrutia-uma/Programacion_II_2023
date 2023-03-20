using System;
using System.Data;
using System.Windows.Forms;

namespace Modulos
{
    public partial class FormListaCliente : Form
    {
        private AdminArchivosCSV archivoCSV;

        public FormListaCliente()
        {
            InitializeComponent();
        }

        private void FormListaCliente_Load(object sender, EventArgs e)
        {
            this.archivoCSV = new AdminArchivosCSV("clientes.csv");

            string[] columnas = { "Nombres", "Apellidos", "Telefono", "Email", "Direccion" };
            this.archivoCSV.CrearArchivo(columnas);

            RefrescarDataGrid();
        }

        private void BtonNuevo_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente()
            {
                modo = "nuevo",
                indiceLinea = -1,
                archivoCSV = this.archivoCSV
            };

            formCliente.ShowDialog();

            RefrescarDataGrid();
        }

        private void BtonEditar_Click(object sender, EventArgs e)
        {
            if (GridLista.RowCount > 0)
            {
                int fila = GridLista.SelectedRows[0].Index;

                FormCliente formCliente = new FormCliente()
                {
                    modo = "editar",
                    indiceLinea = fila + 1,
                    archivoCSV = this.archivoCSV
                };

                formCliente.ShowDialog();
            }

            RefrescarDataGrid();
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
