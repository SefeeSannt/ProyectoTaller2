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

            MessageBox.Show("Proveedor registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
