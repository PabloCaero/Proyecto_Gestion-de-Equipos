using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Gestion_de_Equipos.Herramientas.Discos;
using WinForm_Gestion_de_Equipos.Herramientas.Memorias_RAM;
using WinForm_Gestion_de_Equipos.Herramientas.PlacasGraficas;

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

        private void btnPlacasGraficas_Click(object sender, EventArgs e)
        {
            frmPlacasGraficas placaGrafica = new frmPlacasGraficas();
            placaGrafica.ShowDialog();
        }

        private void btnMemoriasRAM_Click(object sender, EventArgs e)
        {
            frmMemorias memoria = new frmMemorias();
            memoria.ShowDialog();
        }

        private void btnDiscos_Click(object sender, EventArgs e)
        {
            frmDiscos disco = new frmDiscos();
            disco.ShowDialog();
        }
    }
}
