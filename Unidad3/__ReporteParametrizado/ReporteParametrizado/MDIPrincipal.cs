using ReporteParametrizado.Listas;
using SQLiteManager;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteParametrizado
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private async void MDIPrincipal_Load(object sender, EventArgs e)
        {
            await FormLoadAsync();
        }

        private async Task FormLoadAsync()
        {
            string databasePath = Properties.Settings.Default.DatabasePath;

            SQLiteClient sqliteClient = new SQLiteClient(databasePath);

            if (!File.Exists(sqliteClient.GetSQLiteDataBasePath()))
            {
                sqliteClient.CreateDataBaseFile();
                await sqliteClient.ExecuteSQLScriptAsync(@"SQL\Script.txt");
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuItemClientes_Click(object sender, EventArgs e)
        {
            FormEntityList formEntityList = new FormEntityList()
            {
                MdiParent = this,
                Text = "Lista de Clientes",
                RecordType = "customer"
            };

            formEntityList.Show();
        }

        private void MenuItemEmpleados_Click(object sender, EventArgs e)
        {
            FormEntityList formEntityList = new FormEntityList()
            {
                MdiParent = this,
                Text = "Lista de Empleados",
                RecordType = "employee"
            };

            formEntityList.Show();
        }

        private void MenuItemProveedores_Click(object sender, EventArgs e)
        {
            FormEntityList formEntityList = new FormEntityList()
            {
                MdiParent = this,
                Text = "Lista de Proveedores",
                RecordType = "vendor"
            };

            formEntityList.Show();
        }

    }
}
