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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            bool bandera = false;

            StreamWriter swArLocalidad = new StreamWriter("./localidad.txt", true);
            swArLocalidad.Close();

            StreamReader srLocalidad = new StreamReader("./localidad.txt");

            char separador = Convert.ToChar(" ");

            while (!srLocalidad.EndOfStream)
            {
                string[] localidad = srLocalidad.ReadLine().Split(separador);

                if (txtIdentificador.Text == localidad[0])
                {
                    bandera = true;
                }
            }

            srLocalidad.Close();

            if (bandera == false)
            {
                StreamWriter swCultivo = new StreamWriter("./localidad.txt", true);
                swCultivo.WriteLine(txtIdentificador.Text + " " + txtLocalidad.Text);
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

        private void LimpiarControles()
        {
            txtIdentificador.Text = "";
            txtLocalidad.Text = "";

            txtIdentificador.Focus();
        }

        private void ControlarCajas()
        {
            if(txtIdentificador.Text != "" && txtLocalidad.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }
        private void lblIdentificador_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
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
