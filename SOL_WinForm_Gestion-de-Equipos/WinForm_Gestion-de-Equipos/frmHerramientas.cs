using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Gestion_de_Equipos
{
    public partial class frmHerramientas : Form
    {
        public frmHerramientas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcesadores_Click(object sender, EventArgs e)
        {
            frmProcesadores procesador = new frmProcesadores();
            procesador.ShowDialog();
        }
    }
}
