namespace Ejercicio1
{
    partial class FrmLista
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
            this.GrpboxDatos = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblListaClientes = new System.Windows.Forms.Label();
            this.LstListaClientes = new System.Windows.Forms.ListBox();
            this.BtnAbrirArchivo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GrpboxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpboxDatos
            // 
            this.GrpboxDatos.Controls.Add(this.TxtEmail);
            this.GrpboxDatos.Controls.Add(this.LblEmail);
            this.GrpboxDatos.Controls.Add(this.TxtApellido);
            this.GrpboxDatos.Controls.Add(this.LblApellido);
            this.GrpboxDatos.Controls.Add(this.TxtNombre);
            this.GrpboxDatos.Controls.Add(this.LblNombre);
            this.GrpboxDatos.Location = new System.Drawing.Point(12, 12);
            this.GrpboxDatos.Name = "GrpboxDatos";
            this.GrpboxDatos.Size = new System.Drawing.Size(238, 179);
            this.GrpboxDatos.TabIndex = 6;
            this.GrpboxDatos.TabStop = false;
            this.GrpboxDatos.Text = "Datos del cliente";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(17, 142);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(200, 20);
            this.TxtEmail.TabIndex = 11;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(14, 126);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(17, 90);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(200, 20);
            this.TxtApellido.TabIndex = 9;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(14, 74);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 8;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(17, 36);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(14, 20);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "Nombre";
            // 
            // LblListaClientes
            // 
            this.LblListaClientes.AutoSize = true;
            this.LblListaClientes.Location = new System.Drawing.Point(285, 15);
            this.LblListaClientes.Name = "LblListaClientes";
            this.LblListaClientes.Size = new System.Drawing.Size(84, 13);
            this.LblListaClientes.TabIndex = 7;
            this.LblListaClientes.Text = "Lista de Clientes";
            // 
            // LstListaClientes
            // 
            this.LstListaClientes.FormattingEnabled = true;
            this.LstListaClientes.Location = new System.Drawing.Point(288, 31);
            this.LstListaClientes.Name = "LstListaClientes";
            this.LstListaClientes.Size = new System.Drawing.Size(350, 160);
            this.LstListaClientes.TabIndex = 8;
            // 
            // BtnAbrirArchivo
            // 
            this.BtnAbrirArchivo.Location = new System.Drawing.Point(552, 199);
            this.BtnAbrirArchivo.Name = "BtnAbrirArchivo";
            this.BtnAbrirArchivo.Size = new System.Drawing.Size(90, 23);
            this.BtnAbrirArchivo.TabIndex = 9;
            this.BtnAbrirArchivo.Text = "Abrir Archivo";
            this.BtnAbrirArchivo.UseVisualStyleBackColor = true;
            this.BtnAbrirArchivo.Click += new System.EventHandler(this.BtnAbrirArchivo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(175, 199);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 230);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAbrirArchivo);
            this.Controls.Add(this.LstListaClientes);
            this.Controls.Add(this.LblListaClientes);
            this.Controls.Add(this.GrpboxDatos);
            this.Name = "FrmLista";
            this.Text = "Lista de clientes";
            this.GrpboxDatos.ResumeLayout(false);
            this.GrpboxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpboxDatos;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblListaClientes;
        private System.Windows.Forms.ListBox LstListaClientes;
        private System.Windows.Forms.Button BtnAbrirArchivo;
        private System.Windows.Forms.Button BtnAgregar;
    }
}

