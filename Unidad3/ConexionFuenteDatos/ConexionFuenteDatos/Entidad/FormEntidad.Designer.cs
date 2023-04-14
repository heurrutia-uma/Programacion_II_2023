namespace ConexionFuenteDatos.Entidad
{
    partial class FormEntidad
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
            this.BtonGuardar = new System.Windows.Forms.Button();
            this.BtonCerrar = new System.Windows.Forms.Button();
            this.GrpBoxInfoContacto = new System.Windows.Forms.GroupBox();
            this.TxtDireccionEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDireccionFacturacion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.GrpBoxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.GrpBoxInfoCredito = new System.Windows.Forms.GroupBox();
            this.TxtLimiteCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkCredito = new System.Windows.Forms.CheckBox();
            this.GrpBoxInfoContacto.SuspendLayout();
            this.GrpBoxInfoPersonal.SuspendLayout();
            this.GrpBoxInfoCredito.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtonGuardar
            // 
            this.BtonGuardar.Location = new System.Drawing.Point(353, 416);
            this.BtonGuardar.Name = "BtonGuardar";
            this.BtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtonGuardar.TabIndex = 9;
            this.BtonGuardar.Text = "Guardar";
            this.BtonGuardar.UseVisualStyleBackColor = true;
            this.BtonGuardar.Click += new System.EventHandler(this.BtonGuardar_Click);
            // 
            // BtonCerrar
            // 
            this.BtonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtonCerrar.Location = new System.Drawing.Point(272, 416);
            this.BtonCerrar.Name = "BtonCerrar";
            this.BtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtonCerrar.TabIndex = 10;
            this.BtonCerrar.Text = "Cerrar";
            this.BtonCerrar.UseVisualStyleBackColor = true;
            this.BtonCerrar.Click += new System.EventHandler(this.BtonCerrar_Click);
            // 
            // GrpBoxInfoContacto
            // 
            this.GrpBoxInfoContacto.Controls.Add(this.TxtDireccionEnvio);
            this.GrpBoxInfoContacto.Controls.Add(this.label1);
            this.GrpBoxInfoContacto.Controls.Add(this.TxtDireccionFacturacion);
            this.GrpBoxInfoContacto.Controls.Add(this.LblDireccion);
            this.GrpBoxInfoContacto.Controls.Add(this.TxtEmail);
            this.GrpBoxInfoContacto.Controls.Add(this.LblEmail);
            this.GrpBoxInfoContacto.Controls.Add(this.TxtTelefono);
            this.GrpBoxInfoContacto.Controls.Add(this.LblTelefono);
            this.GrpBoxInfoContacto.Location = new System.Drawing.Point(12, 82);
            this.GrpBoxInfoContacto.Name = "GrpBoxInfoContacto";
            this.GrpBoxInfoContacto.Size = new System.Drawing.Size(424, 269);
            this.GrpBoxInfoContacto.TabIndex = 5;
            this.GrpBoxInfoContacto.TabStop = false;
            this.GrpBoxInfoContacto.Text = "Información de Contacto";
            // 
            // TxtDireccionEnvio
            // 
            this.TxtDireccionEnvio.Location = new System.Drawing.Point(9, 176);
            this.TxtDireccionEnvio.Multiline = true;
            this.TxtDireccionEnvio.Name = "TxtDireccionEnvio";
            this.TxtDireccionEnvio.Size = new System.Drawing.Size(406, 82);
            this.TxtDireccionEnvio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dirección de Envío";
            // 
            // TxtDireccionFacturacion
            // 
            this.TxtDireccionFacturacion.Location = new System.Drawing.Point(9, 73);
            this.TxtDireccionFacturacion.Multiline = true;
            this.TxtDireccionFacturacion.Name = "TxtDireccionFacturacion";
            this.TxtDireccionFacturacion.Size = new System.Drawing.Size(406, 82);
            this.TxtDireccionFacturacion.TabIndex = 7;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(6, 56);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(126, 13);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "Dirección de Facturación";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(115, 33);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 20);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(112, 16);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(9, 33);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 5;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(6, 16);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 0;
            this.LblTelefono.Text = "Telefono";
            // 
            // GrpBoxInfoPersonal
            // 
            this.GrpBoxInfoPersonal.Controls.Add(this.TxtApellidos);
            this.GrpBoxInfoPersonal.Controls.Add(this.LblApellidos);
            this.GrpBoxInfoPersonal.Controls.Add(this.TxtNombres);
            this.GrpBoxInfoPersonal.Controls.Add(this.LblNombres);
            this.GrpBoxInfoPersonal.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxInfoPersonal.Name = "GrpBoxInfoPersonal";
            this.GrpBoxInfoPersonal.Size = new System.Drawing.Size(424, 64);
            this.GrpBoxInfoPersonal.TabIndex = 4;
            this.GrpBoxInfoPersonal.TabStop = false;
            this.GrpBoxInfoPersonal.Text = "Información Personal";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(215, 32);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(200, 20);
            this.TxtApellidos.TabIndex = 2;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(212, 16);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(49, 13);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Apellidos";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(9, 32);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(200, 20);
            this.TxtNombres.TabIndex = 1;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(6, 16);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(49, 13);
            this.LblNombres.TabIndex = 0;
            this.LblNombres.Text = "Nombres";
            // 
            // GrpBoxInfoCredito
            // 
            this.GrpBoxInfoCredito.Controls.Add(this.TxtLimiteCredito);
            this.GrpBoxInfoCredito.Controls.Add(this.label2);
            this.GrpBoxInfoCredito.Controls.Add(this.ChkCredito);
            this.GrpBoxInfoCredito.Location = new System.Drawing.Point(13, 357);
            this.GrpBoxInfoCredito.Name = "GrpBoxInfoCredito";
            this.GrpBoxInfoCredito.Size = new System.Drawing.Size(424, 53);
            this.GrpBoxInfoCredito.TabIndex = 8;
            this.GrpBoxInfoCredito.TabStop = false;
            this.GrpBoxInfoCredito.Text = "Información Crediticia";
            // 
            // TxtLimiteCredito
            // 
            this.TxtLimiteCredito.Location = new System.Drawing.Point(215, 28);
            this.TxtLimiteCredito.Name = "TxtLimiteCredito";
            this.TxtLimiteCredito.Size = new System.Drawing.Size(200, 20);
            this.TxtLimiteCredito.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Límite de credito";
            // 
            // ChkCredito
            // 
            this.ChkCredito.AutoSize = true;
            this.ChkCredito.Location = new System.Drawing.Point(9, 28);
            this.ChkCredito.Name = "ChkCredito";
            this.ChkCredito.Size = new System.Drawing.Size(88, 17);
            this.ChkCredito.TabIndex = 3;
            this.ChkCredito.Text = "Tiene crédito";
            this.ChkCredito.UseVisualStyleBackColor = true;
            // 
            // FormEntidad
            // 
            this.AcceptButton = this.BtonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtonCerrar;
            this.ClientSize = new System.Drawing.Size(449, 449);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBoxInfoCredito);
            this.Controls.Add(this.BtonGuardar);
            this.Controls.Add(this.BtonCerrar);
            this.Controls.Add(this.GrpBoxInfoContacto);
            this.Controls.Add(this.GrpBoxInfoPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEntidad";
            this.Text = "FormEntidad";
            this.Load += new System.EventHandler(this.FormEntidad_Load);
            this.GrpBoxInfoContacto.ResumeLayout(false);
            this.GrpBoxInfoContacto.PerformLayout();
            this.GrpBoxInfoPersonal.ResumeLayout(false);
            this.GrpBoxInfoPersonal.PerformLayout();
            this.GrpBoxInfoCredito.ResumeLayout(false);
            this.GrpBoxInfoCredito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtonGuardar;
        private System.Windows.Forms.Button BtonCerrar;
        private System.Windows.Forms.GroupBox GrpBoxInfoContacto;
        private System.Windows.Forms.TextBox TxtDireccionFacturacion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.GroupBox GrpBoxInfoPersonal;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.TextBox TxtDireccionEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpBoxInfoCredito;
        private System.Windows.Forms.TextBox TxtLimiteCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkCredito;
    }
}