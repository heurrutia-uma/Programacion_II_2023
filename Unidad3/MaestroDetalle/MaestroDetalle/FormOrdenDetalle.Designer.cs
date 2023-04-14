namespace MaestroDetalle
{
    partial class FormOrdenDetalle
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblArtículo = new System.Windows.Forms.Label();
            this.TxtArticulo = new System.Windows.Forms.TextBox();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Location = new System.Drawing.Point(389, 61);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(80, 30);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(486, 61);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(80, 30);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblArtículo
            // 
            this.LblArtículo.AutoSize = true;
            this.LblArtículo.Location = new System.Drawing.Point(9, 9);
            this.LblArtículo.Name = "LblArtículo";
            this.LblArtículo.Size = new System.Drawing.Size(44, 13);
            this.LblArtículo.TabIndex = 4;
            this.LblArtículo.Text = "Artículo";
            // 
            // TxtArticulo
            // 
            this.TxtArticulo.Location = new System.Drawing.Point(12, 25);
            this.TxtArticulo.Name = "TxtArticulo";
            this.TxtArticulo.Size = new System.Drawing.Size(300, 20);
            this.TxtArticulo.TabIndex = 5;
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Location = new System.Drawing.Point(319, 25);
            this.NumCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(120, 20);
            this.NumCantidad.TabIndex = 6;
            this.NumCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(316, 9);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(49, 13);
            this.LblCantidad.TabIndex = 7;
            this.LblCantidad.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Precio unitario";
            // 
            // NumPrecioUnitario
            // 
            this.NumPrecioUnitario.DecimalPlaces = 2;
            this.NumPrecioUnitario.Location = new System.Drawing.Point(446, 25);
            this.NumPrecioUnitario.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NumPrecioUnitario.Name = "NumPrecioUnitario";
            this.NumPrecioUnitario.Size = new System.Drawing.Size(120, 20);
            this.NumPrecioUnitario.TabIndex = 8;
            this.NumPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormOrdenDetalle
            // 
            this.AcceptButton = this.BtnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(579, 101);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumPrecioUnitario);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.TxtArticulo);
            this.Controls.Add(this.LblArtículo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormOrdenDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.FormOrdenDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblArtículo;
        private System.Windows.Forms.TextBox TxtArticulo;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumPrecioUnitario;
    }
}