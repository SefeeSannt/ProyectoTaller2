using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmBajaCliente : Form
    {
        public frmBajaCliente()
        {
            InitializeComponent();
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientes() ?? new List<ClienteModel>();
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = lista;
            if (dgvClientes.Columns.Contains("id_estado"))
                dgvClientes.Columns["id_estado"].Visible = false;
            if (!dgvClientes.Columns.Contains("Accion"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "Accion",
                    HeaderText = "Acción",
                    UseColumnTextForButtonValue = false
                };
                dgvClientes.Columns.Add(btnCol);
            }
            bool hasIdEstado = dgvClientes.Columns.Contains("id_estado");
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                if (!dgvClientes.Columns.Contains("Accion")) break;
                var estadoVal = hasIdEstado ? row.Cells["id_estado"].Value?.ToString() : null;
                row.Cells["Accion"].Value = estadoVal == "1" ? "Dar de baja" : "Dar de alta";
            }
        }

        private void frmBajaCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarClientes(criterio) ?? new List<ClienteModel>();
            dgvClientes.DataSource = lista;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.Columns[e.ColumnIndex].Name == "Accion")
            {
                var row = dgvClientes.Rows[e.RowIndex];
                var dni = Convert.ToInt64(row.Cells["dni"].Value);
                var estado = dgvClientes.Columns.Contains("id_estado") ? row.Cells["id_estado"].Value?.ToString() : null;

                var negocio = new CN_cliente();

                if (estado == "1")
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de baja a este cliente?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.BajaCliente(dni);
                    MessageBox.Show("Cliente dado de baja correctamente.", "Alta Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de alta a este cliente?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.AltaCliente(dni);
                    MessageBox.Show("Cliente dado de alta correctamente.", "Baja Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarClientesEnGrid();
            }
        }

        private void dgvClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvClientes.Rows[e.RowIndex];
            var estado = dgvClientes.Columns.Contains("id_estado") ? row.Cells["id_estado"].Value?.ToString() : null;

            if (estado == "1")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (estado == "0")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.White;
        }
    }
}
