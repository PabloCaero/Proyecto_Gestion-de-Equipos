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
    public partial class frmModificarProcesador : Form
    {
        private CPU cpu;
        public frmModificarProcesador()
        {
            InitializeComponent();
        }

        public frmModificarProcesador(CPU seleccionado)
        {
            InitializeComponent();
            cpu = seleccionado;
            txtNombreProcesador.Text = cpu.Descripcion;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CPUNegocio negocio = new CPUNegocio();

            try
            {

                cpu.Descripcion = txtNombreProcesador.Text;

                negocio.modificar(cpu);
                MessageBox.Show("CPU modificado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar CPU");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
