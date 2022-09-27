using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanSP1H1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLocalidad = new frmLocalidad();
            frmLocalidad.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCultivos = new frmCultivos();
            frmCultivos.ShowDialog();
        }

        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmProduccion = new frmProduccion();
            frmProduccion.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultas = new frmConsultas();
            frmConsultas.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
