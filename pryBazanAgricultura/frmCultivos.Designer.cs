namespace pryBazanSP1H1
{
    partial class frmCultivos
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
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(200, 36);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(89, 22);
            this.txtIdentificador.TabIndex = 0;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            this.txtIdentificador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificador_KeyPress);
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(33, 39);
            this.lblIdentificador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(80, 16);
            this.lblIdentificador.TabIndex = 10;
            this.lblIdentificador.Text = "Identificador";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(287, 169);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(33, 108);
            this.lblCultivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(47, 16);
            this.lblCultivo.TabIndex = 8;
            this.lblCultivo.Text = "Cultivo";
            // 
            // txtCultivo
            // 
            this.txtCultivo.Location = new System.Drawing.Point(200, 105);
            this.txtCultivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(185, 22);
            this.txtCultivo.TabIndex = 1;
            this.txtCultivo.TextChanged += new System.EventHandler(this.txtCultivo_TextChanged);
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 233);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.txtCultivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.Load += new System.EventHandler(this.frmCultivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.TextBox txtCultivo;
    }
}