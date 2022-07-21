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
    public partial class frmAltaOficina : Form
    {
        public frmAltaOficina()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Oficina nuevo = new Oficina();
            OficinaNegocio negocio = new OficinaNegocio();

            try
            {
                nuevo.Nombre = txtNombreOficina.Text;
                nuevo.IDOficina = int.Parse(txtNumeroOficina.Text);

                negocio.agregar(nuevo);
                MessageBox.Show("Oficina agregada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Oficina");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaOficina_Load(object sender, EventArgs e)
        {

        }
    }
}


