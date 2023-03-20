namespace Modulos
{
    partial class FormListaProveedores
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
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.TiraHerramientas = new System.Windows.Forms.ToolStrip();
            this.BtonNuevo = new System.Windows.Forms.ToolStripButton();
            this.BtonEditar = new System.Windows.Forms.ToolStripButton();
            this.BtonBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtonCerrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.TiraHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridLista
            // 
            this.GridLista.AllowUserToAddRows = false;
            this.GridLista.AllowUserToDeleteRows = false;
            this.GridLista.AllowUserToOrderColumns = true;
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridLista.Location = new System.Drawing.Point(0, 25);
            this.GridLista.MultiSelect = false;
            this.GridLista.Name = "GridLista";
            this.GridLista.ReadOnly = true;
            this.GridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridLista.Size = new System.Drawing.Size(800, 425);
            this.GridLista.TabIndex = 3;
            // 
            // TiraHerramientas
            // 
            this.TiraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtonNuevo,
            this.BtonEditar,
            this.BtonBorrar,
            this.toolStripSeparator1,
            this.BtonCerrar});
            this.TiraHerramientas.Location = new System.Drawing.Point(0, 0);
            this.TiraHerramientas.Name = "TiraHerramientas";
            this.TiraHerramientas.Size = new System.Drawing.Size(800, 25);
            this.TiraHerramientas.TabIndex = 2;
            this.TiraHerramientas.Text = "toolStrip1";
            // 
            // BtonNuevo
            // 
            this.BtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtonNuevo.Image = global::Modulos.Properties.Resources.NewConstant_16x;
            this.BtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtonNuevo.Name = "BtonNuevo";
            this.BtonNuevo.Size = new System.Drawing.Size(23, 22);
            this.BtonNuevo.Text = "Nuevo registro";
            this.BtonNuevo.Click += new System.EventHandler(this.BtonNuevo_Click);
            // 
            // BtonEditar
            // 
            this.BtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtonEditar.Image = global::Modulos.Properties.Resources.Edit_grey_16x;
            this.BtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtonEditar.Name = "BtonEditar";
            this.BtonEditar.Size = new System.Drawing.Size(23, 22);
            this.BtonEditar.Text = "Editar registro";
            this.BtonEditar.Click += new System.EventHandler(this.BtonEditar_Click);
            // 
            // BtonBorrar
            // 
            this.BtonBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtonBorrar.Image = global::Modulos.Properties.Resources.Eraser_16x;
            this.BtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtonBorrar.Name = "BtonBorrar";
            this.BtonBorrar.Size = new System.Drawing.Size(23, 22);
            this.BtonBorrar.Text = "Borrar registro";
            this.BtonBorrar.Click += new System.EventHandler(this.BtonBorrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtonCerrar
            // 
            this.BtonCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtonCerrar.Image = global::Modulos.Properties.Resources.Close_16x;
            this.BtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtonCerrar.Name = "BtonCerrar";
            this.BtonCerrar.Size = new System.Drawing.Size(23, 22);
            this.BtonCerrar.Text = "Cerrar";
            this.BtonCerrar.Click += new System.EventHandler(this.BtonCerrar_Click);
            // 
            // FormListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridLista);
            this.Controls.Add(this.TiraHerramientas);
            this.Name = "FormListaProveedores";
            this.Text = "Lista de Proveedores";
            this.Load += new System.EventHandler(this.FormListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.TiraHerramientas.ResumeLayout(false);
            this.TiraHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLista;
        private System.Windows.Forms.ToolStrip TiraHerramientas;
        private System.Windows.Forms.ToolStripButton BtonNuevo;
        private System.Windows.Forms.ToolStripButton BtonEditar;
        private System.Windows.Forms.ToolStripButton BtonBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtonCerrar;
    }
}