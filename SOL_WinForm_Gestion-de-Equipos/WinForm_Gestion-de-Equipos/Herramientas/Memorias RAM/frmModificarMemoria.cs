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

namespace WinForm_Gestion_de_Equipos.Herramientas.Memorias_RAM
{
    public partial class frmModificarMemoria : Form
    {
        private RAM RAM;
        public frmModificarMemoria()
        {
            InitializeComponent();
        }

        public frmModificarMemoria(RAM seleccionado)
        {
            InitializeComponent();
            RAM = seleccionado;
            txtNombreMemoria.Text = RAM.Descripcion;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RAMNegocio negocio = new RAMNegocio();

            try
            {

                RAM.Descripcion = txtNombreMemoria.Text;

                negocio.modificar(RAM);
                MessageBox.Show("Memoria modificada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar RAM");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
