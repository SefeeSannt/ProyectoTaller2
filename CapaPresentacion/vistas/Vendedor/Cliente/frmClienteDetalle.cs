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
    public partial class frmClienteDetalle : Form
    {
        public frmClienteDetalle()
        {
            InitializeComponent();
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientesActivos() ?? new List<ClienteModel>();
            dgvClientes.DataSource = lista;

            FormatearGrilla();
  
            lblTotalClientes.Text = $"{negocio.TotalClientes()}";
            lblClientesActivos.Text = $"{negocio.TotalClientesActivos()}";
            lblClientesInactivos.Text = $"{negocio.TotalClientesInactivos()}";
        }

        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvClientes.DataSource = lista;
            FormatearGrilla();
        }

        private void frmClienteDetalle_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void FormatearGrilla()
        {
            if (dgvClientes.Columns.Count == 0) return;

            if (dgvClientes.Columns.Contains("estado"))
                dgvClientes.Columns["estado"].Visible = false;

            if (dgvClientes.Columns.Contains("dni"))
                dgvClientes.Columns["dni"].HeaderText = "DNI";

            if (dgvClientes.Columns.Contains("nombre"))
                dgvClientes.Columns["nombre"].HeaderText = "Nombre";

            if (dgvClientes.Columns.Contains("apellido"))
                dgvClientes.Columns["apellido"].HeaderText = "Apellido";

            if (dgvClientes.Columns.Contains("domicilio"))
                dgvClientes.Columns["domicilio"].HeaderText = "Domicilio";

            if (dgvClientes.Columns.Contains("email"))
                dgvClientes.Columns["email"].HeaderText = "Email";

            if (dgvClientes.Columns.Contains("telefono"))
                dgvClientes.Columns["telefono"].HeaderText = "Teléfono";
        }

    }
}
