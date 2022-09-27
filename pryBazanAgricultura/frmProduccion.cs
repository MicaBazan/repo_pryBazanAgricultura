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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader srLocalidad = new StreamReader("./localidad.txt");
            StreamReader srCultivos = new StreamReader("./cultivos.txt");


            char separador = Convert.ToChar(" ");


            while(!srLocalidad.EndOfStream)
            {
                string[] nomLocalidad = srLocalidad.ReadLine().Split(separador);

                lstLocalidad.Items.Add(nomLocalidad[1]);
            }

            srLocalidad.Close();
 

            while(!srCultivos.EndOfStream)
            {
                string[] nomCultivo = srCultivos.ReadLine().Split(separador);

                lstCultivo.Items.Add(nomCultivo[1]);
            }

            srCultivos.Close();


            lstLocalidad.Focus();

            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StreamWriter swProduccion = new StreamWriter("./produccion.txt", true);

            DateTime fecha = dtpFecha.Value.Date;

            swProduccion.WriteLine(fecha +";"+ lstLocalidad.Text +";"+ lstCultivo.Text +";"+ mskToneladas.Text);

            swProduccion.Close();

            MessageBox.Show("Datos cargados correctamente", "Cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);


            lstLocalidad.Text = "";
            lstCultivo.Text = "";
            mskToneladas.Text = "";

            lstLocalidad.Focus();
        }

       

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mskToneladas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}
