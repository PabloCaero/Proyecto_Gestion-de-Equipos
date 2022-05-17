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

namespace WinForm_Gestion_de_Equipos.Herramientas.Discos
{
    public partial class frmDiscos : Form
    {
        private List<Disco> listaDisco;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco nuevo = new frmAltaDisco();
            nuevo.ShowDialog();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.listar();
            dgvDiscos.DataSource = listaDisco;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmModificarDisco modificar = new frmModificarDisco(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            string nombreTemporal;
            nombreTemporal = seleccionado.Descripcion;
            negocio.eliminar(seleccionado);
            MessageBox.Show("Memoria " + nombreTemporal + " eliminado correctamente");
        }

       

        private void frmDiscos_Load_1(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            listaDisco = negocio.listar();
            dgvDiscos.DataSource = listaDisco;

        }
    }
}
