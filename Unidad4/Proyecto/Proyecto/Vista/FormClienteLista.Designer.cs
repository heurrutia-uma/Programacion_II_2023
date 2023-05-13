namespace Proyecto.Vista
{
    partial class FormClienteLista
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
            this.DataGridRegistros = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridRegistros
            // 
            this.DataGridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridRegistros.Location = new System.Drawing.Point(0, 0);
            this.DataGridRegistros.Name = "DataGridRegistros";
            this.DataGridRegistros.Size = new System.Drawing.Size(800, 450);
            this.DataGridRegistros.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DataGridRegistros);
            this.Name = "FormClienteLista";
            this.Text = "FormClienteLista";
            this.Load += new System.EventHandler(this.FormClienteLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridRegistros;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}