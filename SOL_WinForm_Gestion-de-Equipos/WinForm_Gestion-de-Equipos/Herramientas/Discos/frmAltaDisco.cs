using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace WinForm_Gestion_de_Equipos.Herramientas.Discos
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Disco nuevo = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                nuevo.Descripcion = txtNombreDisco.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("Disco agregada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Disco");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
