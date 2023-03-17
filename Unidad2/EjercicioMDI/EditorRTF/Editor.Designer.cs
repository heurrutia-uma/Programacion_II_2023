namespace EditorRTF
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            this.ToolArchivo = new System.Windows.Forms.ToolStrip();
            this.BotonGuardar = new System.Windows.Forms.ToolStripButton();
            this.BotonSalir = new System.Windows.Forms.ToolStripButton();
            this.ToolEdicion = new System.Windows.Forms.ToolStrip();
            this.ComboFuente = new System.Windows.Forms.ToolStripComboBox();
            this.ComboTamanio = new System.Windows.Forms.ToolStripComboBox();
            this.BotonNegrita = new System.Windows.Forms.ToolStripButton();
            this.BotonItalica = new System.Windows.Forms.ToolStripButton();
            this.BotonSubrayado = new System.Windows.Forms.ToolStripButton();
            this.BotonColor = new System.Windows.Forms.ToolStripButton();
            this.BotonIzquierda = new System.Windows.Forms.ToolStripButton();
            this.BotonCentro = new System.Windows.Forms.ToolStripButton();
            this.BotonDerecha = new System.Windows.Forms.ToolStripButton();
            this.ContenedorRFT = new System.Windows.Forms.RichTextBox();
            this.MenuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CortarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopiarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PegarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeshacerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolArchivo.SuspendLayout();
            this.ToolEdicion.SuspendLayout();
            this.MenuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolArchivo
            // 
            this.ToolArchivo.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonGuardar,
            this.BotonSalir});
            this.ToolArchivo.Location = new System.Drawing.Point(0, 3);
            this.ToolArchivo.Name = "ToolArchivo";
            this.ToolArchivo.Size = new System.Drawing.Size(58, 25);
            this.ToolArchivo.TabIndex = 1;
            this.ToolArchivo.Text = "Archivo";
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonGuardar.Image = global::EditorRTF.Properties.Resources.Save_16x;
            this.BotonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(23, 22);
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonSalir.Image = global::EditorRTF.Properties.Resources.Close_red_16x;
            this.BotonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(23, 22);
            this.BotonSalir.Text = "Cerrar";
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // ToolEdicion
            // 
            this.ToolEdicion.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolEdicion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboFuente,
            this.ComboTamanio,
            this.BotonNegrita,
            this.BotonItalica,
            this.BotonSubrayado,
            this.BotonColor,
            this.BotonIzquierda,
            this.BotonCentro,
            this.BotonDerecha});
            this.ToolEdicion.Location = new System.Drawing.Point(58, 3);
            this.ToolEdicion.Name = "ToolEdicion";
            this.ToolEdicion.Size = new System.Drawing.Size(419, 25);
            this.ToolEdicion.TabIndex = 2;
            this.ToolEdicion.Text = "Edición";
            // 
            // ComboFuente
            // 
            this.ComboFuente.Name = "ComboFuente";
            this.ComboFuente.Size = new System.Drawing.Size(121, 25);
            this.ComboFuente.Text = "Fuente";
            this.ComboFuente.SelectedIndexChanged += new System.EventHandler(this.ComboFuente_SelectedIndexChanged);
            // 
            // ComboTamanio
            // 
            this.ComboTamanio.Name = "ComboTamanio";
            this.ComboTamanio.Size = new System.Drawing.Size(121, 25);
            this.ComboTamanio.Text = "Tamaño";
            this.ComboTamanio.SelectedIndexChanged += new System.EventHandler(this.ComboTamanio_SelectedIndexChanged);
            // 
            // BotonNegrita
            // 
            this.BotonNegrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonNegrita.Image = global::EditorRTF.Properties.Resources.Bold_16x;
            this.BotonNegrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonNegrita.Name = "BotonNegrita";
            this.BotonNegrita.Size = new System.Drawing.Size(23, 22);
            this.BotonNegrita.Text = "Negrita";
            this.BotonNegrita.Click += new System.EventHandler(this.BotonNegrita_Click);
            // 
            // BotonItalica
            // 
            this.BotonItalica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonItalica.Image = global::EditorRTF.Properties.Resources.Italic_16x;
            this.BotonItalica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonItalica.Name = "BotonItalica";
            this.BotonItalica.Size = new System.Drawing.Size(23, 22);
            this.BotonItalica.Text = "Italica";
            this.BotonItalica.Click += new System.EventHandler(this.BotonItalica_Click);
            // 
            // BotonSubrayado
            // 
            this.BotonSubrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonSubrayado.Image = global::EditorRTF.Properties.Resources.Underline_16x;
            this.BotonSubrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonSubrayado.Name = "BotonSubrayado";
            this.BotonSubrayado.Size = new System.Drawing.Size(23, 22);
            this.BotonSubrayado.Text = "Subrayado";
            this.BotonSubrayado.Click += new System.EventHandler(this.BotonSubrayado_Click);
            // 
            // BotonColor
            // 
            this.BotonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonColor.Image = global::EditorRTF.Properties.Resources.FontColor_16x;
            this.BotonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonColor.Name = "BotonColor";
            this.BotonColor.Size = new System.Drawing.Size(23, 22);
            this.BotonColor.Text = "Color";
            this.BotonColor.Click += new System.EventHandler(this.BotonColor_Click);
            // 
            // BotonIzquierda
            // 
            this.BotonIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonIzquierda.Image = global::EditorRTF.Properties.Resources.TextLeftJustify_16x;
            this.BotonIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonIzquierda.Name = "BotonIzquierda";
            this.BotonIzquierda.Size = new System.Drawing.Size(23, 22);
            this.BotonIzquierda.Text = "Justificado a la izquierda";
            this.BotonIzquierda.Click += new System.EventHandler(this.BotonIzquierda_Click);
            // 
            // BotonCentro
            // 
            this.BotonCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonCentro.Image = global::EditorRTF.Properties.Resources.TextCenter_16x;
            this.BotonCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonCentro.Name = "BotonCentro";
            this.BotonCentro.Size = new System.Drawing.Size(23, 22);
            this.BotonCentro.Text = "Justificado al centro";
            this.BotonCentro.Click += new System.EventHandler(this.BotonCentro_Click);
            // 
            // BotonDerecha
            // 
            this.BotonDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotonDerecha.Image = global::EditorRTF.Properties.Resources.TextRightJustify_16x;
            this.BotonDerecha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonDerecha.Name = "BotonDerecha";
            this.BotonDerecha.Size = new System.Drawing.Size(23, 22);
            this.BotonDerecha.Text = "Justificado a la derecha";
            this.BotonDerecha.Click += new System.EventHandler(this.BotonDerecha_Click);
            // 
            // ContenedorRFT
            // 
            this.ContenedorRFT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenedorRFT.ContextMenuStrip = this.MenuContextual;
            this.ContenedorRFT.Location = new System.Drawing.Point(0, 31);
            this.ContenedorRFT.Name = "ContenedorRFT";
            this.ContenedorRFT.Size = new System.Drawing.Size(784, 530);
            this.ContenedorRFT.TabIndex = 3;
            this.ContenedorRFT.Text = "";
            // 
            // MenuContextual
            // 
            this.MenuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CortarMenuItem,
            this.CopiarMenuItem,
            this.PegarMenuItem,
            this.toolStripSeparator1,
            this.DeshacerMenuItem,
            this.rehacerToolStripMenuItem});
            this.MenuContextual.Name = "MenuContextual";
            this.MenuContextual.Size = new System.Drawing.Size(164, 120);
            // 
            // CortarMenuItem
            // 
            this.CortarMenuItem.Image = global::EditorRTF.Properties.Resources.Cut_16x;
            this.CortarMenuItem.Name = "CortarMenuItem";
            this.CortarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CortarMenuItem.Size = new System.Drawing.Size(163, 22);
            this.CortarMenuItem.Text = "Cortar";
            this.CortarMenuItem.Click += new System.EventHandler(this.CortarMenuItem_Click);
            // 
            // CopiarMenuItem
            // 
            this.CopiarMenuItem.Image = global::EditorRTF.Properties.Resources.Copy_16x;
            this.CopiarMenuItem.Name = "CopiarMenuItem";
            this.CopiarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopiarMenuItem.Size = new System.Drawing.Size(163, 22);
            this.CopiarMenuItem.Text = "Copiar";
            this.CopiarMenuItem.Click += new System.EventHandler(this.CopiarMenuItem_Click);
            // 
            // PegarMenuItem
            // 
            this.PegarMenuItem.Image = global::EditorRTF.Properties.Resources.Paste_16x;
            this.PegarMenuItem.Name = "PegarMenuItem";
            this.PegarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PegarMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PegarMenuItem.Text = "Pegar";
            this.PegarMenuItem.Click += new System.EventHandler(this.PegarMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // DeshacerMenuItem
            // 
            this.DeshacerMenuItem.Image = global::EditorRTF.Properties.Resources.Undo_grey_16x;
            this.DeshacerMenuItem.Name = "DeshacerMenuItem";
            this.DeshacerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.DeshacerMenuItem.Size = new System.Drawing.Size(163, 22);
            this.DeshacerMenuItem.Text = "Deshacer";
            this.DeshacerMenuItem.Click += new System.EventHandler(this.DeshacerMenuItem_Click);
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Image = global::EditorRTF.Properties.Resources.Redo_grey_16x;
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rehacerToolStripMenuItem.Text = "Rehacer";
            this.rehacerToolStripMenuItem.Click += new System.EventHandler(this.rehacerToolStripMenuItem_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ContenedorRFT);
            this.Controls.Add(this.ToolEdicion);
            this.Controls.Add(this.ToolArchivo);
            this.Name = "Editor";
            this.Text = "Archivo nuevo";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ToolArchivo.ResumeLayout(false);
            this.ToolArchivo.PerformLayout();
            this.ToolEdicion.ResumeLayout(false);
            this.ToolEdicion.PerformLayout();
            this.MenuContextual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip ToolArchivo;
        private System.Windows.Forms.ToolStripButton BotonGuardar;
        private System.Windows.Forms.ToolStripButton BotonSalir;
        private System.Windows.Forms.ToolStrip ToolEdicion;
        private System.Windows.Forms.ToolStripComboBox ComboFuente;
        private System.Windows.Forms.ToolStripComboBox ComboTamanio;
        private System.Windows.Forms.ToolStripButton BotonNegrita;
        private System.Windows.Forms.ToolStripButton BotonItalica;
        private System.Windows.Forms.ToolStripButton BotonSubrayado;
        private System.Windows.Forms.ToolStripButton BotonColor;
        private System.Windows.Forms.ToolStripButton BotonIzquierda;
        private System.Windows.Forms.ToolStripButton BotonCentro;
        private System.Windows.Forms.ToolStripButton BotonDerecha;
        private System.Windows.Forms.RichTextBox ContenedorRFT;
        private System.Windows.Forms.ContextMenuStrip MenuContextual;
        private System.Windows.Forms.ToolStripMenuItem CortarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopiarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PegarMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeshacerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
    }
}

