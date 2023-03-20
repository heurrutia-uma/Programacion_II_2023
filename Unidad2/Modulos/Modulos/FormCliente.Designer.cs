namespace Modulos
{
    partial class FormCliente
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
            this.GrpBoxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.GrpBoxInfoContacto = new System.Windows.Forms.GroupBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.BtonCerrar = new System.Windows.Forms.Button();
            this.BtonGuardar = new System.Windows.Forms.Button();
            this.GrpBoxInfoPersonal.SuspendLayout();
            this.GrpBoxInfoContacto.SuspendLayout();
            this.SuspendLayout();
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
            this.GrpBoxInfoPersonal.TabIndex = 0;
            this.GrpBoxInfoPersonal.TabStop = false;
            this.GrpBoxInfoPersonal.Text = "Información Personal";
            // 
            // GrpBoxInfoContacto
            // 
            this.GrpBoxInfoContacto.Controls.Add(this.TxtDireccion);
            this.GrpBoxInfoContacto.Controls.Add(this.LblDireccion);
            this.GrpBoxInfoContacto.Controls.Add(this.TxtEmail);
            this.GrpBoxInfoContacto.Controls.Add(this.LblEmail);
            this.GrpBoxInfoContacto.Controls.Add(this.TxtTelefono);
            this.GrpBoxInfoContacto.Controls.Add(this.LblTelefono);
            this.GrpBoxInfoContacto.Location = new System.Drawing.Point(12, 82);
            this.GrpBoxInfoContacto.Name = "GrpBoxInfoContacto";
            this.GrpBoxInfoContacto.Size = new System.Drawing.Size(424, 168);
            this.GrpBoxInfoContacto.TabIndex = 1;
            this.GrpBoxInfoContacto.TabStop = false;
            this.GrpBoxInfoContacto.Text = "Información de Contacto";
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
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(9, 32);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(200, 20);
            this.TxtNombres.TabIndex = 1;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(215, 32);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(200, 20);
            this.TxtApellidos.TabIndex = 3;
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
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(6, 16);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 0;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(9, 33);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(115, 33);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 20);
            this.TxtEmail.TabIndex = 3;
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
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(6, 56);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(9, 73);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(406, 82);
            this.TxtDireccion.TabIndex = 5;
            // 
            // BtonCerrar
            // 
            this.BtonCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtonCerrar.Location = new System.Drawing.Point(280, 256);
            this.BtonCerrar.Name = "BtonCerrar";
            this.BtonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtonCerrar.TabIndex = 2;
            this.BtonCerrar.Text = "Cerrar";
            this.BtonCerrar.UseVisualStyleBackColor = true;
            this.BtonCerrar.Click += new System.EventHandler(this.BtonCerrar_Click);
            // 
            // BtonGuardar
            // 
            this.BtonGuardar.Location = new System.Drawing.Point(361, 256);
            this.BtonGuardar.Name = "BtonGuardar";
            this.BtonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtonGuardar.TabIndex = 3;
            this.BtonGuardar.Text = "Guardar";
            this.BtonGuardar.UseVisualStyleBackColor = true;
            this.BtonGuardar.Click += new System.EventHandler(this.BtonGuardar_Click);
            // 
            // FormCliente
            // 
            this.AcceptButton = this.BtonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtonCerrar;
            this.ClientSize = new System.Drawing.Size(449, 289);
            this.ControlBox = false;
            this.Controls.Add(this.BtonGuardar);
            this.Controls.Add(this.BtonCerrar);
            this.Controls.Add(this.GrpBoxInfoContacto);
            this.Controls.Add(this.GrpBoxInfoPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.GrpBoxInfoPersonal.ResumeLayout(false);
            this.GrpBoxInfoPersonal.PerformLayout();
            this.GrpBoxInfoContacto.ResumeLayout(false);
            this.GrpBoxInfoContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxInfoPersonal;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.GroupBox GrpBoxInfoContacto;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Button BtonCerrar;
        private System.Windows.Forms.Button BtonGuardar;
    }
}