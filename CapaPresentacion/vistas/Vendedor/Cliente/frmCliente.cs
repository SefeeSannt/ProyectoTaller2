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
using System.Data.Entity.Core.Common.EntitySql;

namespace CapaPresentacion.Vistas.Vendedor
{
    public partial class frmCliente : Form
    {
        public frmCliente()
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
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var CN_cliente = new CN_cliente();

            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errIngresoDatos.SetError(txtNombre, "El campo Nombre es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errIngresoDatos.SetError(txtApellido,"El campo Apellido es obligatorio");
            }

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errIngresoDatos.SetError(txtDocumento, "El campo Documento es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtDomicilio.Text))
            {
                errIngresoDatos.SetError(txtDomicilio, "El campo Domicilio es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "El campo Telefono es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) ||
                !txtEmail.Text.Contains("@") ||
                !txtEmail.Text.Contains("."))
            {
                errIngresoDatos.SetError(txtEmail, "El email debe tener un formato válido (ejemplo: usuario@dominio.com)");
                return;
            }

            if (txtDocumento.Text.Length < 7 || txtDocumento.Text.Length > 8)
            {
                errIngresoDatos.SetError(txtDocumento, "El campo Documento debe tener entre 7 y 8 dígitos");
                return;
            }

            if (CN_cliente.ClienteExiste(long.Parse(txtDocumento.Text)))
            {
                errIngresoDatos.SetError(txtDocumento, "Ya existe un cliente con este documento registrado");
                return;
            }

            if (CN_cliente.EmailExiste(txtEmail.Text,int.Parse(txtBuscarDni.Text)))
            {
                errIngresoDatos.SetError(txtEmail, "Ya existe un cliente con este email registrado");
                return;
            }

            var nuevoCliente = new ClienteModel
            {
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                dni = long.Parse(txtDocumento.Text),
                domicilio = txtDomicilio.Text,
                telefono = long.Parse(txtTelefono.Text),
                email = txtEmail.Text,
                estado = 1
            };

            try
            {
                var negocio = new CN_cliente();
                negocio.AgregarCliente(nuevoCliente);
                MessageBox.Show("Cliente registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientesEnGrid();

                txtDocumento.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDomicilio.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente ya registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea limpiar la informacion del cliente?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtDocumento.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDomicilio.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea cancelar el registro del cliente?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientesActivos();
            dgvClientes.DataSource = lista;
            FormatearGrilla();
        }
        
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscarDni.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvClientes.DataSource = lista;
            FormatearGrilla();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClientes.AutoGenerateColumns = false;
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

