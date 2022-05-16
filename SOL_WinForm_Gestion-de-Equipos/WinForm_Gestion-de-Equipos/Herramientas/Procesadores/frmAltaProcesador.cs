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
    public partial class frmAltaProcesador : Form
    {
        public frmAltaProcesador()
        {
            InitializeComponent();
        }

        private void frmAltaProcesador_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CPU nuevo = new CPU();
            CPUNegocio negocio = new CPUNegocio();

            try
            {
                nuevo.Descripcion = txtNombreProcesador.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("CPU agregado correctamente");   
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar CPU");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
