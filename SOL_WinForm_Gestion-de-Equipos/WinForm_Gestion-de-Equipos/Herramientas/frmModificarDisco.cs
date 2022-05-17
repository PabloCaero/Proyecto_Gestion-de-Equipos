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

namespace WinForm_Gestion_de_Equipos.Herramientas
{
    public partial class frmModificarDisco : Form
    {
        private Disco Disco;
        public frmModificarDisco()
        {
            InitializeComponent();
        }

        public frmModificarDisco(Disco seleccionado)
        {
            InitializeComponent();
            Disco = seleccionado;
            txtNombreDisco.Text = Disco.Descripcion;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {

                Disco.Descripcion = txtNombreDisco.Text;

                negocio.modificar(Disco);
                MessageBox.Show("Disco modificada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Disco");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
