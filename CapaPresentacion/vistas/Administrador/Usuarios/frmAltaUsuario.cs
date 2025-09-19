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

namespace CapaPresentacion.Vistas.Administrador.Usuarios
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();

        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyNumbers(sender, e, errIngresoDatos);
        }

        private void onlyInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void noWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void onlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyLetters(sender, e, errIngresoDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                errIngresoDatos.SetError(txtDocumento, "Debe ingresar un documento");
                return;
            }

            if (string.IsNullOrEmpty(txtNombreCompleto.Text))
            {
                errIngresoDatos.SetError(txtNombreCompleto, "Debe ingresar un nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errIngresoDatos.SetError(txtCorreo, "Debe ingresar un usuario");
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errIngresoDatos.SetError(txtTelefono, "Debe ingresar una clave");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errIngresoDatos.SetError(txtPassword, "Debe ingresar una clave");
                return;
            }

            if (cboRol.SelectedIndex == -1)
            {
                errIngresoDatos.SetError(cboRol, "Debe ingresar una clave");
                return;
            }

            MessageBox.Show("Usuario registrado con exito.","Registro Exitoso",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Desea limpiar los campos?", "Limpiar Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDocumento.Clear();
                txtNombreCompleto.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtPassword.Clear();
                cboRol.SelectedIndex = -1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Desea cancelar el registro?", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}