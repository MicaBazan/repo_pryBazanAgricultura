namespace pryBazanSP1H1
{
    partial class frmConsultas
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CULTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONELADAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(663, 244);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 35);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.LOCALIDAD,
            this.CULTIVO,
            this.TONELADAS});
            this.dgvConsulta.Location = new System.Drawing.Point(15, 12);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(747, 213);
            this.dgvConsulta.TabIndex = 4;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.MinimumWidth = 6;
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 125;
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.HeaderText = "LOCALIDAD";
            this.LOCALIDAD.MinimumWidth = 6;
            this.LOCALIDAD.Name = "LOCALIDAD";
            this.LOCALIDAD.Width = 125;
            // 
            // CULTIVO
            // 
            this.CULTIVO.HeaderText = "CULTIVO";
            this.CULTIVO.MinimumWidth = 6;
            this.CULTIVO.Name = "CULTIVO";
            this.CULTIVO.Width = 125;
            // 
            // TONELADAS
            // 
            this.TONELADAS.HeaderText = "TONELADAS";
            this.TONELADAS.MinimumWidth = 6;
            this.TONELADAS.Name = "TONELADAS";
            this.TONELADAS.Width = 125;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(545, 244);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 35);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 291);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CULTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONELADAS;
        private System.Windows.Forms.Button btnListar;
    }
}