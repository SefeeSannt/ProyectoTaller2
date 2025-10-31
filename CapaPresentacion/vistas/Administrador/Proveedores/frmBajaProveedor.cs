using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmBajaProveedor : Form
    {
        public frmBajaProveedor()
        {
            InitializeComponent();
        }

        private void cargarProveedorEnGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedores() ?? new List<ProveedorModel>();

            dgvBajaProveedores.AutoGenerateColumns = true;
            dgvBajaProveedores.DataSource = lista;
            if (dgvBajaProveedores.Columns.Contains("estado"))
                dgvBajaProveedores.Columns["estado"].Visible = false;
            if (!dgvBajaProveedores.Columns.Contains("Accion"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "Accion",
                    HeaderText = "Acción",
                    UseColumnTextForButtonValue = false
                };
                dgvBajaProveedores.Columns.Add(btnCol);
            }
            bool hasIdEstado = dgvBajaProveedores.Columns.Contains("estado");
            foreach (DataGridViewRow row in dgvBajaProveedores.Rows)
            {
                if (!dgvBajaProveedores.Columns.Contains("Accion")) break;
                var estadoVal = hasIdEstado ? row.Cells["estado"].Value?.ToString() : null;
                row.Cells["Accion"].Value = estadoVal == "1" ? "Dar de baja" : "Dar de alta";
            }

        }

        private void frmBajaProveedor_Load(object sender, EventArgs e)
        {
            cargarProveedorEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_proveedor();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarProveedores(criterio) ?? new List<ProveedorModel>();
            dgvBajaProveedores.DataSource = lista;
        }

        private void dgvBajaProveedor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBajaProveedores.Columns[e.ColumnIndex].Name == "Accion")
            {
                var row = dgvBajaProveedores.Rows[e.RowIndex];
                var dni = Convert.ToInt64(row.Cells["dni_proveedor"].Value);
                var estado = dgvBajaProveedores.Columns.Contains("estado") ? row.Cells["estado"].Value?.ToString() : null;

                var negocio = new CN_proveedor();

                if (estado == "1")
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de baja a este proveedor?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.bajaProveedor(dni);
                    MessageBox.Show("Proveedor dado de baja correctamente.", "Alta proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de alta a este Proveedor?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.altaProveedor(dni);
                    MessageBox.Show("Proveedor dado de alta correctamente.", "Baja proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cargarProveedorEnGrid();
            }
        }

        private void dgvProveedor_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvBajaProveedores.Rows[e.RowIndex];
            var estado = dgvBajaProveedores.Columns.Contains("estado") ? row.Cells["estado"].Value?.ToString() : null;

            if (estado == "1")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (estado == "0")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.White;
        }
    }
}
