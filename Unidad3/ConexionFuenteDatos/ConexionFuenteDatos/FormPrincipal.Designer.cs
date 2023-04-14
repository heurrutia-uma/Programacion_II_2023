namespace ConexionFuenteDatos
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuListas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRelaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.LblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuPrincipal.SuspendLayout();
            this.StatusStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListas,
            this.MenuVentanas,
            this.MenuItemSalir});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuListas
            // 
            this.MenuListas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRelaciones,
            this.MenuItemUsuarios});
            this.MenuListas.Name = "MenuListas";
            this.MenuListas.Size = new System.Drawing.Size(48, 20);
            this.MenuListas.Text = "&Listas";
            // 
            // MenuItemRelaciones
            // 
            this.MenuItemRelaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemClientes,
            this.MenuItemProveedores});
            this.MenuItemRelaciones.Name = "MenuItemRelaciones";
            this.MenuItemRelaciones.Size = new System.Drawing.Size(180, 22);
            this.MenuItemRelaciones.Text = "&Relaciones";
            // 
            // MenuItemClientes
            // 
            this.MenuItemClientes.Name = "MenuItemClientes";
            this.MenuItemClientes.Size = new System.Drawing.Size(139, 22);
            this.MenuItemClientes.Text = "&Clientes";
            this.MenuItemClientes.Click += new System.EventHandler(this.MenuItemClientes_Click);
            // 
            // MenuItemProveedores
            // 
            this.MenuItemProveedores.Name = "MenuItemProveedores";
            this.MenuItemProveedores.Size = new System.Drawing.Size(139, 22);
            this.MenuItemProveedores.Text = "&Proveedores";
            this.MenuItemProveedores.Click += new System.EventHandler(this.MenuItemProveedores_Click);
            // 
            // MenuItemUsuarios
            // 
            this.MenuItemUsuarios.Name = "MenuItemUsuarios";
            this.MenuItemUsuarios.Size = new System.Drawing.Size(180, 22);
            this.MenuItemUsuarios.Text = "&Usuarios";
            this.MenuItemUsuarios.Click += new System.EventHandler(this.MenuItemUsuarios_Click);
            // 
            // MenuVentanas
            // 
            this.MenuVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCascada,
            this.MenuItemMosaicoHorizontal,
            this.MenuItemMosaicoVertical});
            this.MenuVentanas.Name = "MenuVentanas";
            this.MenuVentanas.Size = new System.Drawing.Size(66, 20);
            this.MenuVentanas.Text = "&Ventanas";
            // 
            // MenuItemCascada
            // 
            this.MenuItemCascada.Name = "MenuItemCascada";
            this.MenuItemCascada.Size = new System.Drawing.Size(177, 22);
            this.MenuItemCascada.Text = "Cascada";
            this.MenuItemCascada.Click += new System.EventHandler(this.MenuItemCascada_Click);
            // 
            // MenuItemMosaicoHorizontal
            // 
            this.MenuItemMosaicoHorizontal.Name = "MenuItemMosaicoHorizontal";
            this.MenuItemMosaicoHorizontal.Size = new System.Drawing.Size(177, 22);
            this.MenuItemMosaicoHorizontal.Text = "Mosaico Horizontal";
            this.MenuItemMosaicoHorizontal.Click += new System.EventHandler(this.MenuItemMosaicoHorizontal_Click);
            // 
            // MenuItemMosaicoVertical
            // 
            this.MenuItemMosaicoVertical.Name = "MenuItemMosaicoVertical";
            this.MenuItemMosaicoVertical.Size = new System.Drawing.Size(177, 22);
            this.MenuItemMosaicoVertical.Text = "Mosaico Vertical";
            this.MenuItemMosaicoVertical.Click += new System.EventHandler(this.MenuItemMosaicoVertical_Click);
            // 
            // MenuItemSalir
            // 
            this.MenuItemSalir.Name = "MenuItemSalir";
            this.MenuItemSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuItemSalir.Text = "&Salir";
            this.MenuItemSalir.Click += new System.EventHandler(this.MenuItemSalir_Click);
            // 
            // StatusStripPrincipal
            // 
            this.StatusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUsuarioActual});
            this.StatusStripPrincipal.Location = new System.Drawing.Point(0, 428);
            this.StatusStripPrincipal.Name = "StatusStripPrincipal";
            this.StatusStripPrincipal.Size = new System.Drawing.Size(800, 22);
            this.StatusStripPrincipal.TabIndex = 3;
            this.StatusStripPrincipal.Text = "statusStrip1";
            // 
            // LblUsuarioActual
            // 
            this.LblUsuarioActual.Name = "LblUsuarioActual";
            this.LblUsuarioActual.Size = new System.Drawing.Size(88, 17);
            this.LblUsuarioActual.Text = "Usuario actual: ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusStripPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión de Datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.StatusStripPrincipal.ResumeLayout(false);
            this.StatusStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuListas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRelaciones;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProveedores;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuVentanas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCascada;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMosaicoVertical;
        private System.Windows.Forms.StatusStrip StatusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel LblUsuarioActual;
    }
}

