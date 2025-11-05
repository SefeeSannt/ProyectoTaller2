using CapaNegocio;
using CapaPresentacion.Vistas.Administrador.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Administrador
{
    public partial class frmBajaUsuario : Form
    {
        public frmBajaUsuario()
        {
            InitializeComponent();


        }

        private void cargaUsuariosEnGrid()
        {
            var negocio = new CN_usuario();
            var lista = negocio.ObtenerUsuarios() ?? new List<UsuarioModel>();
            dgvDetalleUsuario.AutoGenerateColumns = true;
            dgvDetalleUsuario.DataSource = lista;
            if (dgvDetalleUsuario.Columns.Contains("estado"))
                dgvDetalleUsuario.Columns["estado"].Visible = false;
            if (!dgvDetalleUsuario.Columns.Contains("Accion"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "Accion",
                    HeaderText = "Acción",
                    UseColumnTextForButtonValue = false
                };
                dgvDetalleUsuario.Columns.Add(btnCol);
            }
            bool hasIdEstado = dgvDetalleUsuario.Columns.Contains("estado");
            foreach (DataGridViewRow row in dgvDetalleUsuario.Rows)
            {
                if (!dgvDetalleUsuario.Columns.Contains("Accion")) break;
                var estadoVal = hasIdEstado ? row.Cells["estado"].Value?.ToString() : null;
                row.Cells["Accion"].Value = estadoVal == "1" ? "Dar de baja" : "Dar de alta";
            }
        }

        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var negocio = new CN_usuario();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarUsuarios(criterio) ?? new List<ProveedorModel>();
            dgvDetalleUsuario.DataSource = lista;
        }

        private void frmBajaUsuario_Load(object sender, EventArgs e)
        {
            cargaUsuariosEnGrid();
        }

        private void dgvBajaUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalleUsuario.Columns[e.ColumnIndex].Name == "Accion")
            {
                var row = dgvDetalleUsuario.Rows[e.RowIndex];
                var dni = Convert.ToInt64(row.Cells["dni_usuario"].Value);
                var estado = dgvDetalleUsuario.Columns.Contains("estado") ? row.Cells["estado"].Value?.ToString() : null;

                var negocio = new CN_proveedor();

                if (estado == "1")
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de baja a este usuario?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.bajaProveedor(dni);
                    MessageBox.Show("Usuario dado de baja correctamente.", "Alta usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var result = MessageBox.Show("¿Está seguro que desea dar de alta a este usuario?", "Confirmar Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result != DialogResult.Yes) return;
                    negocio.altaProveedor(dni);
                    MessageBox.Show("Usuario dado de alta correctamente.", "Baja usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cargaUsuariosEnGrid();
            }
        }

        private void dgvUsuario_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvDetalleUsuario.Rows[e.RowIndex];
            var estado = dgvDetalleUsuario.Columns.Contains("estado") ? row.Cells["estado"].Value?.ToString() : null;

            if (estado == "1")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (estado == "0")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.White;
        }

    }
}
