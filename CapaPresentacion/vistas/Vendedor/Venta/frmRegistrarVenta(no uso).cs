using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Helpers;
using CapaNegocio;

namespace CapaPresentacion.Vistas.Vendedor
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea cancelar la venta actual?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (lblDniCliente.Text == "Dni")
            {
                MessageBox.Show("Por favor, seleccione un cliente antes de agregar productos.", "Cliente No Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Funcionalidad de agregar productos no implementada aún.", "Funcionalidad Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargarGridClientes()
        {
            try
            {
                var negocio = new CN_cliente();
                var listaClientes = negocio.ObtenerClientesActivos();
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvClientes.DataSource = lista;
        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cargarGridClientes();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblApellido.Text = dgvClientes.CurrentRow.Cells["apellido"].Value.ToString();
            lblNombre.Text = dgvClientes.CurrentRow.Cells["nombre"].Value.ToString();
            lblDniCliente.Text = dgvClientes.CurrentRow.Cells["dni"].Value.ToString();
        }
    }
}
