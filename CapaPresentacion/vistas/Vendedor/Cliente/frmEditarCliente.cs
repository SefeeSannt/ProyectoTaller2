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

namespace CapaPresentacion.vistas.Vendedor.Cliente
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void onlyLetters(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyLetters(sender, e, errIngresoDatos);
        }

        private void onlyInteger(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientesActivos();
            dgvClientes.DataSource = lista;
            dgvClientes.Columns["estado"].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea cancelar la edición del cliente?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscarCliente.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvClientes.DataSource = lista;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea limpiar la informacion del cliente?", "Confirmar Limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDocumento.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDomicilio.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();

                MessageBox.Show("Los campos han sido limpiados.", "Limpieza Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var CN_cliente = new CN_cliente();
            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errIngresoDatos.SetError(txtDocumento, "El campo Documento es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errIngresoDatos.SetError(txtNombre, "El campo Nombre es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errIngresoDatos.SetError(txtApellido, "El campo Apellido es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                errIngresoDatos.SetError(txtDomicilio, "El campo Domicilio es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "El campo Teléfono es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errIngresoDatos.SetError(txtEmail, "El campo Email es obligatorio");
                return;
            }
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                errIngresoDatos.SetError(txtEmail, "El campo Email no es válido");
                return;
            }
            if (CN_cliente.EmailExiste(txtEmail.Text))
            {
                errIngresoDatos.SetError(txtEmail, "El email ya está registrado");
                return;
            }

            var clienteModificado = new ClienteModel
            {
                dni = long.Parse(txtDocumento.Text),
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                domicilio = txtDomicilio.Text,
                telefono = long.Parse(txtTelefono.Text),
                email = txtEmail.Text,
                estado = "1"
            };

            try
            {
                var negocio = new CN_cliente();
                negocio.ActualizarCliente(clienteModificado);
                MessageBox.Show("Cliente modificado con éxito.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientesEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                txtDocumento.Text = fila.Cells["dni"].Value?.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["apellido"].Value?.ToString();
                txtDomicilio.Text = fila.Cells["domicilio"].Value?.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value?.ToString();
                txtEmail.Text = fila.Cells["email"].Value?.ToString();
            }
        }
    }
}
