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
    public partial class frmAltaPlacaGrafica : Form
    {
        public frmAltaPlacaGrafica()
        {
            InitializeComponent();
        }

        private void frmAltaPlacaGrafica_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GPU nuevo = new GPU();
            GPUNegocio negocio = new GPUNegocio();

            try
            {
                nuevo.Descripcion = txtNombrePlacaGrafica.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("GPU agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar GPU");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
