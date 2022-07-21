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
    public partial class frmOficinas : Form
    {
        private List<Oficina> listaOficina;
        public frmOficinas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dgvOficinas_SelectionChanged(object sender, EventArgs e)
        {
            Oficina seleccionado = (Oficina)dgvOficinas.CurrentRow.DataBoundItem;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaOficina nuevo = new frmAltaOficina();
            nuevo.ShowDialog();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            OficinaNegocio negocio = new OficinaNegocio();
            listaOficina = negocio.listar();
            dgvOficinas.DataSource = listaOficina;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Oficina seleccionado = (Oficina)dgvOficinas.CurrentRow.DataBoundItem;
            frmModificarOficina modificar = new frmModificarOficina(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OficinaNegocio negocio = new OficinaNegocio();
            Oficina seleccionado = (Oficina)dgvOficinas.CurrentRow.DataBoundItem;
            string nombreTemporal;
            nombreTemporal = seleccionado.Nombre;
            negocio.eliminar(seleccionado);
            MessageBox.Show("Oficina " + nombreTemporal + " eliminado correctamente");
        }

    

        private void frmOficinas_Load_1(object sender, EventArgs e)
        {
            OficinaNegocio negocio = new OficinaNegocio();
            listaOficina = negocio.listar();
            dgvOficinas.DataSource = listaOficina;
        }
    }
}

