using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBazanSP1H1
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            bool bandera = false;

            StreamWriter swArCultivo = new StreamWriter("./cultivos.txt", true);
            swArCultivo.Close();

            StreamReader srCultivo = new StreamReader("./cultivos.txt");

            char separador = Convert.ToChar(" ");

            while(!srCultivo.EndOfStream)
            {
                string[] cultivo = srCultivo.ReadLine().Split(separador);

                if(txtIdentificador.Text == cultivo[0])
                {
                    bandera = true;
                }
            }

            srCultivo.Close();

            if(bandera == false)
            {
                StreamWriter swCultivo = new StreamWriter("./cultivos.txt", true);
                swCultivo.WriteLine(txtIdentificador.Text + " " + txtCultivo.Text);
                swCultivo.Close();

                MessageBox.Show("Datos cargados correctamente.", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }

            else
            {
                MessageBox.Show("El numero de identificador ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LimpiarControles();
            }
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void LimpiarControles()
        {
            txtIdentificador.Text = "";
            txtCultivo.Text = "";

            txtIdentificador.Focus();
        }

        private void ControlarCajas()
        {
            if(txtIdentificador.Text != "" && txtCultivo.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void txtCultivo_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void txtIdentificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; // borrar la tecla ingresada
            }
        }
    }
}
