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
    public partial class frmModificarPlacaGrafica : Form
    {
        private GPU GPU;
        public frmModificarPlacaGrafica()
        {
            InitializeComponent();
        }

        public frmModificarPlacaGrafica(GPU seleccionado)
        {
            InitializeComponent();
            GPU = seleccionado;
            txtNombrePlacaGrafica.Text = GPU.Descripcion;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            GPUNegocio negocio = new GPUNegocio();

            try
            {

                GPU.Descripcion = txtNombrePlacaGrafica.Text;

                negocio.modificar(GPU);
                MessageBox.Show("GPU modificado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar GPU");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
