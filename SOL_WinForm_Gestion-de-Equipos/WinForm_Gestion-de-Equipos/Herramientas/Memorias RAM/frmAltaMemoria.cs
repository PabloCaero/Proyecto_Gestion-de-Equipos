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
    public partial class frmAltaMemoria : Form
    {
        public frmAltaMemoria()
        {
            InitializeComponent();
        }

        private void frmAltaMemoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RAM nuevo = new RAM();
            RAMNegocio negocio = new RAMNegocio();

            try
            {
                nuevo.Descripcion = txtNombreMemoria.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("Memoria agregada correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Memoria");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

