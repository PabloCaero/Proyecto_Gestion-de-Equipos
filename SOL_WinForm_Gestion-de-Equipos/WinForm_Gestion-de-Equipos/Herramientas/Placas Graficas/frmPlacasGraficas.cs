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

namespace WinForm_Gestion_de_Equipos.Herramientas.PlacasGraficas
{
    public partial class frmPlacasGraficas : Form
    {
        private List<GPU> listaGPU;
        public frmPlacasGraficas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void dgvPlacasGraficas_SelectionChanged(object sender, EventArgs e)
        {
            GPU seleccionado = (GPU)dgvPlacasGraficas.CurrentRow.DataBoundItem;
        }
       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPlacaGrafica nuevo = new frmAltaPlacaGrafica();
            nuevo.ShowDialog();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            GPUNegocio negocio = new GPUNegocio();
            listaGPU = negocio.listar();
            dgvPlacasGraficas.DataSource = listaGPU;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GPU seleccionado = (GPU)dgvPlacasGraficas.CurrentRow.DataBoundItem;
            frmModificarPlacaGrafica modificar = new frmModificarPlacaGrafica(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GPUNegocio negocio = new GPUNegocio();
            GPU seleccionado = (GPU)dgvPlacasGraficas.CurrentRow.DataBoundItem;
            string nombreTemporal;
            nombreTemporal = seleccionado.Descripcion;
            negocio.eliminar(seleccionado);
            MessageBox.Show("GPU " + nombreTemporal + " eliminado correctamente");
        }

        private void frmPlacasGraficas_Load(object sender, EventArgs e)
        {
            GPUNegocio negocio = new GPUNegocio();
            listaGPU = negocio.listar();
            dgvPlacasGraficas.DataSource = listaGPU;
        }
    }
}

