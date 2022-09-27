namespace pryBazanSP1H1
{
    partial class frmProduccion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mskToneladas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAceptar.Location = new System.Drawing.Point(168, 311);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 38);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(19, 121);
            this.lstLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(265, 24);
            this.lstLocalidad.TabIndex = 1;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLocalidad.Location = new System.Drawing.Point(15, 97);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(162, 20);
            this.lblLocalidad.TabIndex = 10;
            this.lblLocalidad.Text = "Seleccione localidad";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCultivo.Location = new System.Drawing.Point(15, 160);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(144, 20);
            this.lblCultivo.TabIndex = 12;
            this.lblCultivo.Text = "Seleccione cultivo";
            // 
            // lstCultivo
            // 
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(19, 183);
            this.lstCultivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(265, 24);
            this.lstCultivo.TabIndex = 2;
            this.lstCultivo.SelectedIndexChanged += new System.EventHandler(this.lstCultivo_SelectedIndexChanged);
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblToneladas.Location = new System.Drawing.Point(15, 226);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(86, 20);
            this.lblToneladas.TabIndex = 13;
            this.lblToneladas.Text = "Toneladas";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(19, 53);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFecha.Location = new System.Drawing.Point(15, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(137, 20);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Seleccione fecha";
            // 
            // mskToneladas
            // 
            this.mskToneladas.Location = new System.Drawing.Point(19, 249);
            this.mskToneladas.Name = "mskToneladas";
            this.mskToneladas.Size = new System.Drawing.Size(122, 22);
            this.mskToneladas.TabIndex = 3;
            this.mskToneladas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskToneladas_MaskInputRejected);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 375);
            this.Controls.Add(this.mskToneladas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduccion";
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mskToneladas;
    }
}