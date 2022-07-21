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

namespace WinForm_Gestion_de_Equipos.Herramientas.Oficinas
{
    public partial class frmModificarOficina : Form
    {
        private Oficina oficina;
        public frmModificarOficina()
        {
            InitializeComponent();
        }

        public frmModificarOficina(Oficina seleccionado)
        {
            InitializeComponent();
            oficina = seleccionado;
            txtNombreOficina.Text = oficina.Nombre;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OficinaNegocio negocio = new OficinaNegocio();

            try
            {

                oficina.Nombre = txtNombreOficina.Text;

                negocio.modificar(oficina);
                MessageBox.Show("Oficina modificada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Oficina");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
