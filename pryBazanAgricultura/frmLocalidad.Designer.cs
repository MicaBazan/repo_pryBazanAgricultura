namespace pryBazanSP1H1
{
    partial class frmLocalidad
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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(221, 108);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(185, 22);
            this.txtLocalidad.TabIndex = 1;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txtLocalidad_TextChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLocalidad.Location = new System.Drawing.Point(27, 110);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(167, 20);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Nombre de localidad:";
            this.lblLocalidad.Click += new System.EventHandler(this.lblLocalidad_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(306, 162);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 4;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIdentificador.Location = new System.Drawing.Point(27, 41);
            this.lblIdentificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(105, 20);
            this.lblIdentificador.TabIndex = 5;
            this.lblIdentificador.Text = "Identificador:";
            this.lblIdentificador.Click += new System.EventHandler(this.lblIdentificador_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(221, 39);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(185, 22);
            this.txtIdentificador.TabIndex = 0;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            this.txtIdentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificador_KeyPress);
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 213);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtLocalidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.frmLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
    }
}