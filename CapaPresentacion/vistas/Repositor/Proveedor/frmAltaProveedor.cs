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

namespace CapaPresentacion.Vistas.Repositor.Proveedor
{
    public partial class frmAltaProveedor : Form
    {
        public frmAltaProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();
            var negocio = new CN_proveedor();

            if (string.IsNullOrEmpty(txtDocProveedor.Text))
            {
                errIngresoDatos.SetError(txtDocProveedor, "El campo Documento es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errIngresoDatos.SetError(txtNombre, "El campo nombre es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errIngresoDatos.SetError(txtApellido,"El campo apellido es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errIngresoDatos.SetError(txtEmail,"El campo correo es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "El campo Telefono es obligatorio");
                return;
            }
            if (txtTelefono.Text.Length < 10)
            {
                errIngresoDatos.SetError(txtTelefono, "Teléfono incorrecto. Debe tener 10 caracteres.");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) ||
                !txtEmail.Text.Contains("@") ||
                !txtEmail.Text.Contains("."))
            {
                errIngresoDatos.SetError(txtEmail, "El email debe tener un formato válido (ejemplo: usuario@dominio.com)");
                return;
            }
            if (txtDocProveedor.Text.Length < 7 || txtDocProveedor.Text.Length > 8)
            {
                errIngresoDatos.SetError(txtDocProveedor, "El campo Documento debe tener entre 7 y 8 dígitos");
                return;
            }


            var nuevoProveedor = new ProveedorModel
            {
                dni_proveedor = long.Parse(txtDocProveedor.Text),
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                telefono = long.Parse(txtTelefono.Text),
                email_proveedor = txtEmail.Text.Trim(),
                estado = 1
            };


            if (negocio.VerificarProveedorExistente(nuevoProveedor.dni_proveedor))
            {
                MessageBox.Show("Ya existe un proveedor con ese documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                negocio.AgregarProveedor(nuevoProveedor);
                MessageBox.Show("Proveedor registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProveedorEnGrid();


                txtDocProveedor.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al registrar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea limpiar la informacion del Proveedor?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtDocProveedor.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
        }

        public void cargarProveedorEnGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedoresActivos();
            dgvProveedores.DataSource = lista;
            FormatearGrillaProveedores();
        }

        private void frmAltaProveedor_Load(object sender, EventArgs e)
        {
            dgvProveedores.AutoGenerateColumns = true;
            cargarProveedorEnGrid();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var negocio = new CN_proveedor();
            var criterio = txtBuscarProveedor.Text;
            var lista = negocio.BuscarProveedores(criterio);
            dgvProveedores.DataSource = lista;
            FormatearGrillaProveedores();
        }


        private void FormatearGrillaProveedores()
        {
            if (dgvProveedores.Columns.Count == 0) return;

       
            if (dgvProveedores.Columns.Contains("estado"))
                dgvProveedores.Columns["estado"].Visible = false;

            if (dgvProveedores.Columns.Contains("dni_proveedor"))
                dgvProveedores.Columns["dni_proveedor"].HeaderText = "DNI";

            if (dgvProveedores.Columns.Contains("nombre"))
                dgvProveedores.Columns["nombre"].HeaderText = "Nombre";

            if (dgvProveedores.Columns.Contains("apellido"))
                dgvProveedores.Columns["apellido"].HeaderText = "Apellido";

            if (dgvProveedores.Columns.Contains("email_proveedor"))
                dgvProveedores.Columns["email_proveedor"].HeaderText = "Email";

            if (dgvProveedores.Columns.Contains("telefono"))
                dgvProveedores.Columns["telefono"].HeaderText = "Teléfono";
        }
    }
}
