using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinForm_Gestion_de_Equipos
{
    public partial class frmProcesadores : Form
    {
        private List<CPU> listaCPU;
        public frmProcesadores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProcesadores_Load(object sender, EventArgs e)
        {

            CPUNegocio negocio = new CPUNegocio();
            listaCPU = negocio.listar();
            dgvProcesadores.DataSource = listaCPU;
            
        }

        private void dgvProcesadores_SelectionChanged(object sender, EventArgs e)
        {
            CPU seleccionado = (CPU)dgvProcesadores.CurrentRow.DataBoundItem;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProcesador nuevo = new frmAltaProcesador();
            nuevo.ShowDialog();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CPUNegocio negocio = new CPUNegocio();
            listaCPU = negocio.listar();
            dgvProcesadores.DataSource = listaCPU;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CPU seleccionado = (CPU)dgvProcesadores.CurrentRow.DataBoundItem;
            frmModificarProcesador modificar = new frmModificarProcesador(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CPUNegocio negocio = new CPUNegocio();
            CPU seleccionado = (CPU)dgvProcesadores.CurrentRow.DataBoundItem;
            string nombreTemporal;
            nombreTemporal = seleccionado.Descripcion;
            negocio.eliminar(seleccionado);
            MessageBox.Show("CPU " + nombreTemporal + " eliminado correctamente");
        }
    }
}
