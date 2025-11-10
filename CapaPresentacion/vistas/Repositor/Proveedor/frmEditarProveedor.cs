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
using CapaPresentacion.Helpers;

namespace CapaPresentacion.vistas.Repositor.Proveedor
{
    public partial class frmEditarProveedor : Form
    {
        public frmEditarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();



            if (string.IsNullOrEmpty(txtDni_proveedor.Text))
            {
                errIngresoDatos.SetError(txtDni_proveedor, "El campo Documento es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre_proveedor.Text))
            {
                errIngresoDatos.SetError(txtNombre_proveedor, "El campo Nombre es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido_proveedor.Text))
            {
                errIngresoDatos.SetError(txtApellido_proveedor, "El campo Apellido es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail_proveedor.Text))
            {
                errIngresoDatos.SetError(txtEmail_proveedor, "El campo Correo es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail_proveedor.Text) ||
                !txtEmail_proveedor.Text.Contains("@") ||
                !txtEmail_proveedor.Text.Contains("."))
            {
                errIngresoDatos.SetError(txtEmail_proveedor, "El email debe tener un formato válido (ejemplo: usuario@dominio.com)");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono_proveedor.Text))
            {
                errIngresoDatos.SetError(txtTelefono_proveedor, "El campo Teléfono es obligatorio");
                return;
            }
            if (txtTelefono_proveedor.Text.Length < 10)
            {
                errIngresoDatos.SetError(txtTelefono_proveedor, "Teléfono incorrecto. Debe tener 10 caracteres.");
                return;
            }

            if (!txtEmail_proveedor.Text.Contains("@") || !txtEmail_proveedor.Text.Contains("."))
            {
                errIngresoDatos.SetError(txtEmail_proveedor, "El email debe tener un formato válido (ejemplo: usuario@dominio.com)");
                return;
            }

            if (txtDni_proveedor.Text.Length < 7 || txtDni_proveedor.Text.Length > 8)
            {
                errIngresoDatos.SetError(txtDni_proveedor, "El campo Documento debe tener entre 7 y 8 dígitos");
                return;
            }
            var CN_proveedor = new CN_proveedor();

            var proveedorModificado = new ProveedorModel
            {
                dni_proveedor = long.Parse(txtDni_proveedor.Text),
                nombre = txtNombre_proveedor.Text,
                apellido = txtApellido_proveedor.Text,
                telefono = long.Parse(txtTelefono_proveedor.Text),
                email_proveedor = txtEmail_proveedor.Text,
                estado = 1
            };

            try
            {
                var negocio = new CN_proveedor();
                negocio.ActualizarProveedor(proveedorModificado);
                MessageBox.Show("Proveedor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedoresEnGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedoresEnGrid();
        }

        private void CargarProveedoresEnGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedoresActivos();
            dgv_editar_proveedor.DataSource = lista;
            FormatearGrilla();
            dgv_editar_proveedor.ClearSelection();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var negocio = new CN_proveedor();
            var criterio = txtProveedor.Text;
            var lista = negocio.BuscarProveedoresActivos2(criterio);
            dgv_editar_proveedor.DataSource = lista;
            FormatearGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea limpiar los campos de edición?", "Confirmar Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtDni_proveedor.Clear();
                txtNombre_proveedor.Clear();
                txtApellido_proveedor.Clear();
                txtEmail_proveedor.Clear();
                txtTelefono_proveedor.Clear();

         
                txtDni_proveedor.ReadOnly = false;
            }
        }

        private void dgvProveedor(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_editar_proveedor.Rows[e.RowIndex];
                txtDni_proveedor.Text = fila.Cells["dni_proveedor"].Value?.ToString();
                txtNombre_proveedor.Text = fila.Cells["nombre"].Value?.ToString();
                txtApellido_proveedor.Text = fila.Cells["apellido"].Value?.ToString();
                txtEmail_proveedor.Text = fila.Cells["email_proveedor"].Value?.ToString();
                txtTelefono_proveedor.Text = fila.Cells["telefono"].Value?.ToString();
            }
        }


        private void FormatearGrilla()
        {
         
            if (dgv_editar_proveedor.Columns.Count == 0) return;

            if (dgv_editar_proveedor.Columns.Contains("estado"))
                dgv_editar_proveedor.Columns["estado"].Visible = false;
        
            if (dgv_editar_proveedor.Columns.Contains("dni_proveedor"))
                dgv_editar_proveedor.Columns["dni_proveedor"].HeaderText = "DNI";

            if (dgv_editar_proveedor.Columns.Contains("nombre"))
                dgv_editar_proveedor.Columns["nombre"].HeaderText = "Nombre";

            if (dgv_editar_proveedor.Columns.Contains("apellido"))
                dgv_editar_proveedor.Columns["apellido"].HeaderText = "Apellido";

            if (dgv_editar_proveedor.Columns.Contains("email_proveedor"))
                dgv_editar_proveedor.Columns["email_proveedor"].HeaderText = "Email";

            if (dgv_editar_proveedor.Columns.Contains("telefono"))
                dgv_editar_proveedor.Columns["telefono"].HeaderText = "Teléfono";
        }
    }
}
