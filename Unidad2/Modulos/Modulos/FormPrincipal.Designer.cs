namespace Modulos
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
            this.MenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuListas,
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
            this.MenuItemClientes,
            this.MenuItemProveedores});
            this.MenuListas.Name = "MenuListas";
            this.MenuListas.Size = new System.Drawing.Size(48, 20);
            this.MenuListas.Text = "&Listas";
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
            // MenuItemSalir
            // 
            this.MenuItemSalir.Name = "MenuItemSalir";
            this.MenuItemSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuItemSalir.Text = "&Salir";
            this.MenuItemSalir.Click += new System.EventHandler(this.MenuItemSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseño modular";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuListas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuItemProveedores;
    }
}

