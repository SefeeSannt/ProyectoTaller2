using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using CapaPresentacion.Helpers;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
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

        private void noWrite(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errIngresoDatos.SetError(txtCorreo, "El campo Correo es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "El campo Telefono es obligatorio");
                return;
            }
            if (cboRol.SelectedIndex == -1)
            {
                errIngresoDatos.SetError(cboRol, "Debe seleccionar un rol");
                return;
            }

            MessageBox.Show("Usuario modificado con exito", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea cancelar la edición del usuario?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();
            var result = MessageBox.Show("¿Está seguro que desea limpiar los datos del usuario?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDocumento.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                cboRol.SelectedIndex = -1;
            }
        }
    }
}
