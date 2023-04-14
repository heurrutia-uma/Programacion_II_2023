namespace MaestroDetalle
{
    partial class FormOrdenVenta
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GrpInfoGeneral = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTotalOrden = new System.Windows.Forms.NumericUpDown();
            this.DTFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.LblFechaEntrega = new System.Windows.Forms.Label();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.LblContacto = new System.Windows.Forms.Label();
            this.TxtNumeroOrden = new System.Windows.Forms.TextBox();
            this.LblNumeroOrden = new System.Windows.Forms.Label();
            this.DTFechaOrden = new System.Windows.Forms.DateTimePicker();
            this.LblFechaOrden = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.GrpDetalleOrden = new System.Windows.Forms.GroupBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ToolDetalle = new System.Windows.Forms.ToolStrip();
            this.BtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.GrpDatosSistema = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaActualizacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFechaCreacion = new System.Windows.Forms.TextBox();
            this.GrpInfoGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotalOrden)).BeginInit();
            this.GrpDetalleOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ToolDetalle.SuspendLayout();
            this.GrpDatosSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(629, 619);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(80, 30);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(532, 619);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 30);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GrpInfoGeneral
            // 
            this.GrpInfoGeneral.Controls.Add(this.label2);
            this.GrpInfoGeneral.Controls.Add(this.TxtDireccion);
            this.GrpInfoGeneral.Controls.Add(this.label1);
            this.GrpInfoGeneral.Controls.Add(this.NumTotalOrden);
            this.GrpInfoGeneral.Controls.Add(this.DTFechaEntrega);
            this.GrpInfoGeneral.Controls.Add(this.LblFechaEntrega);
            this.GrpInfoGeneral.Controls.Add(this.TxtContacto);
            this.GrpInfoGeneral.Controls.Add(this.LblContacto);
            this.GrpInfoGeneral.Controls.Add(this.TxtNumeroOrden);
            this.GrpInfoGeneral.Controls.Add(this.LblNumeroOrden);
            this.GrpInfoGeneral.Controls.Add(this.DTFechaOrden);
            this.GrpInfoGeneral.Controls.Add(this.LblFechaOrden);
            this.GrpInfoGeneral.Controls.Add(this.TxtCliente);
            this.GrpInfoGeneral.Controls.Add(this.LblCliente);
            this.GrpInfoGeneral.Location = new System.Drawing.Point(12, 12);
            this.GrpInfoGeneral.Name = "GrpInfoGeneral";
            this.GrpInfoGeneral.Size = new System.Drawing.Size(700, 193);
            this.GrpInfoGeneral.TabIndex = 2;
            this.GrpInfoGeneral.TabStop = false;
            this.GrpInfoGeneral.Text = "Información General";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total de la orden";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(10, 122);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(677, 60);
            this.TxtDireccion.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dirección de envío";
            // 
            // NumTotalOrden
            // 
            this.NumTotalOrden.DecimalPlaces = 2;
            this.NumTotalOrden.Location = new System.Drawing.Point(547, 77);
            this.NumTotalOrden.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumTotalOrden.Name = "NumTotalOrden";
            this.NumTotalOrden.ReadOnly = true;
            this.NumTotalOrden.Size = new System.Drawing.Size(140, 20);
            this.NumTotalOrden.TabIndex = 10;
            this.NumTotalOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumTotalOrden.ThousandsSeparator = true;
            // 
            // DTFechaEntrega
            // 
            this.DTFechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.DTFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaEntrega.Location = new System.Drawing.Point(420, 78);
            this.DTFechaEntrega.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTFechaEntrega.Name = "DTFechaEntrega";
            this.DTFechaEntrega.Size = new System.Drawing.Size(120, 20);
            this.DTFechaEntrega.TabIndex = 9;
            // 
            // LblFechaEntrega
            // 
            this.LblFechaEntrega.AutoSize = true;
            this.LblFechaEntrega.Location = new System.Drawing.Point(417, 61);
            this.LblFechaEntrega.Name = "LblFechaEntrega";
            this.LblFechaEntrega.Size = new System.Drawing.Size(91, 13);
            this.LblFechaEntrega.TabIndex = 8;
            this.LblFechaEntrega.Text = "Fecha de entrega";
            // 
            // TxtContacto
            // 
            this.TxtContacto.Location = new System.Drawing.Point(10, 78);
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(400, 20);
            this.TxtContacto.TabIndex = 7;
            // 
            // LblContacto
            // 
            this.LblContacto.AutoSize = true;
            this.LblContacto.Location = new System.Drawing.Point(7, 61);
            this.LblContacto.Name = "LblContacto";
            this.LblContacto.Size = new System.Drawing.Size(83, 13);
            this.LblContacto.TabIndex = 6;
            this.LblContacto.Text = "Contacto/Notas";
            // 
            // TxtNumeroOrden
            // 
            this.TxtNumeroOrden.Location = new System.Drawing.Point(547, 37);
            this.TxtNumeroOrden.Name = "TxtNumeroOrden";
            this.TxtNumeroOrden.Size = new System.Drawing.Size(140, 20);
            this.TxtNumeroOrden.TabIndex = 5;
            // 
            // LblNumeroOrden
            // 
            this.LblNumeroOrden.AutoSize = true;
            this.LblNumeroOrden.Location = new System.Drawing.Point(544, 20);
            this.LblNumeroOrden.Name = "LblNumeroOrden";
            this.LblNumeroOrden.Size = new System.Drawing.Size(46, 13);
            this.LblNumeroOrden.TabIndex = 4;
            this.LblNumeroOrden.Text = "Orden #";
            // 
            // DTFechaOrden
            // 
            this.DTFechaOrden.CustomFormat = "dd/MM/yyyy";
            this.DTFechaOrden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaOrden.Location = new System.Drawing.Point(420, 37);
            this.DTFechaOrden.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTFechaOrden.Name = "DTFechaOrden";
            this.DTFechaOrden.Size = new System.Drawing.Size(120, 20);
            this.DTFechaOrden.TabIndex = 3;
            // 
            // LblFechaOrden
            // 
            this.LblFechaOrden.AutoSize = true;
            this.LblFechaOrden.Location = new System.Drawing.Point(417, 20);
            this.LblFechaOrden.Name = "LblFechaOrden";
            this.LblFechaOrden.Size = new System.Drawing.Size(93, 13);
            this.LblFechaOrden.TabIndex = 2;
            this.LblFechaOrden.Text = "Fecha de la orden";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(10, 37);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(400, 20);
            this.TxtCliente.TabIndex = 1;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(7, 20);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            // 
            // GrpDetalleOrden
            // 
            this.GrpDetalleOrden.Controls.Add(this.DataGrid);
            this.GrpDetalleOrden.Controls.Add(this.ToolDetalle);
            this.GrpDetalleOrden.Location = new System.Drawing.Point(12, 211);
            this.GrpDetalleOrden.Name = "GrpDetalleOrden";
            this.GrpDetalleOrden.Size = new System.Drawing.Size(700, 372);
            this.GrpDetalleOrden.TabIndex = 3;
            this.GrpDetalleOrden.TabStop = false;
            this.GrpDetalleOrden.Text = "Detalle de la orden";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(3, 41);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(694, 328);
            this.DataGrid.TabIndex = 6;
            // 
            // ToolDetalle
            // 
            this.ToolDetalle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregar,
            this.BtnEditar,
            this.BtnEliminar});
            this.ToolDetalle.Location = new System.Drawing.Point(3, 16);
            this.ToolDetalle.Name = "ToolDetalle";
            this.ToolDetalle.Size = new System.Drawing.Size(694, 25);
            this.ToolDetalle.TabIndex = 0;
            this.ToolDetalle.Text = "toolStrip1";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAgregar.Image = global::MaestroDetalle.Properties.Resources.Add_16x;
            this.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(23, 22);
            this.BtnAgregar.Text = "toolStripButton1";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditar.Image = global::MaestroDetalle.Properties.Resources.EditInput_16x;
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(23, 22);
            this.BtnEditar.Text = "toolStripButton2";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = global::MaestroDetalle.Properties.Resources.Eraser_16x1;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(23, 22);
            this.BtnEliminar.Text = "toolStripButton3";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // GrpDatosSistema
            // 
            this.GrpDatosSistema.Controls.Add(this.label4);
            this.GrpDatosSistema.Controls.Add(this.TxtFechaActualizacion);
            this.GrpDatosSistema.Controls.Add(this.label3);
            this.GrpDatosSistema.Controls.Add(this.TxtFechaCreacion);
            this.GrpDatosSistema.Location = new System.Drawing.Point(12, 589);
            this.GrpDatosSistema.Name = "GrpDatosSistema";
            this.GrpDatosSistema.Size = new System.Drawing.Size(301, 60);
            this.GrpDatosSistema.TabIndex = 4;
            this.GrpDatosSistema.TabStop = false;
            this.GrpDatosSistema.Text = "Datos del sistema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha modificación";
            // 
            // TxtFechaActualizacion
            // 
            this.TxtFechaActualizacion.Location = new System.Drawing.Point(152, 32);
            this.TxtFechaActualizacion.Name = "TxtFechaActualizacion";
            this.TxtFechaActualizacion.ReadOnly = true;
            this.TxtFechaActualizacion.Size = new System.Drawing.Size(140, 20);
            this.TxtFechaActualizacion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha creación";
            // 
            // TxtFechaCreacion
            // 
            this.TxtFechaCreacion.Location = new System.Drawing.Point(6, 32);
            this.TxtFechaCreacion.Name = "TxtFechaCreacion";
            this.TxtFechaCreacion.ReadOnly = true;
            this.TxtFechaCreacion.Size = new System.Drawing.Size(140, 20);
            this.TxtFechaCreacion.TabIndex = 0;
            // 
            // FormOrdenVenta
            // 
            this.AcceptButton = this.BtnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(724, 661);
            this.Controls.Add(this.GrpDatosSistema);
            this.Controls.Add(this.GrpDetalleOrden);
            this.Controls.Add(this.GrpInfoGeneral);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrdenVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Venta";
            this.Load += new System.EventHandler(this.FormOrdenVenta_Load);
            this.GrpInfoGeneral.ResumeLayout(false);
            this.GrpInfoGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotalOrden)).EndInit();
            this.GrpDetalleOrden.ResumeLayout(false);
            this.GrpDetalleOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ToolDetalle.ResumeLayout(false);
            this.ToolDetalle.PerformLayout();
            this.GrpDatosSistema.ResumeLayout(false);
            this.GrpDatosSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox GrpInfoGeneral;
        private System.Windows.Forms.GroupBox GrpDetalleOrden;
        private System.Windows.Forms.DateTimePicker DTFechaOrden;
        private System.Windows.Forms.Label LblFechaOrden;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtNumeroOrden;
        private System.Windows.Forms.Label LblNumeroOrden;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.Label LblContacto;
        private System.Windows.Forms.DateTimePicker DTFechaEntrega;
        private System.Windows.Forms.Label LblFechaEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumTotalOrden;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip ToolDetalle;
        private System.Windows.Forms.ToolStripButton BtnAgregar;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.GroupBox GrpDatosSistema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFechaCreacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFechaActualizacion;
    }
}