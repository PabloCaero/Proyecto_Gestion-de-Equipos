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
    public partial class frmMemorias : Form
    {
        private List<RAM> listaRAM;
        public frmMemorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void dgvMemorias_SelectionChanged(object sender, EventArgs e)
        {
            RAM seleccionado = (RAM)dgvMemorias.CurrentRow.DataBoundItem;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaMemoria nuevo = new frmAltaMemoria();
            nuevo.ShowDialog();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RAMNegocio negocio = new RAMNegocio();
            listaRAM = negocio.listar();
            dgvMemorias.DataSource = listaRAM;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RAM seleccionado = (RAM)dgvMemorias.CurrentRow.DataBoundItem;
            frmModificarMemoria modificar = new frmModificarMemoria(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RAMNegocio negocio = new RAMNegocio();
            RAM seleccionado = (RAM)dgvMemorias.CurrentRow.DataBoundItem;
            string nombreTemporal;
            nombreTemporal = seleccionado.Descripcion;
            negocio.eliminar(seleccionado);
            MessageBox.Show("Memoria " + nombreTemporal + " eliminado correctamente");
        }

        private void frmMemorias_Load(object sender, EventArgs e)
        {
            RAMNegocio negocio = new RAMNegocio();
            listaRAM = negocio.listar();
            dgvMemorias.DataSource = listaRAM;
        }

    }
    }

