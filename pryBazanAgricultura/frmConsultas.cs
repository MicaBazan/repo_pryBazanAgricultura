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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();

            StreamReader srConsulta = new StreamReader("./produccion.txt");

            char separador = Convert.ToChar(";");

            while (!srConsulta.EndOfStream)
            {
                string[] consulta = srConsulta.ReadLine().Split(separador);

                dgvConsulta.Rows.Add(consulta);
            }
        }
    }
}
