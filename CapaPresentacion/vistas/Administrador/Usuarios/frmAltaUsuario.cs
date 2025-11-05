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
using CapaEntidad;

namespace CapaPresentacion.Vistas.Administrador.Usuarios
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
            cargarGrid();
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
            var CN_usuario = new CN_usuario();

            if (string.IsNullOrEmpty(txtDni_usuario.Text))
            {
                errIngresoDatos.SetError(txtDni_usuario, "Debe ingresar un documento");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errIngresoDatos.SetError(txtNombre, "Debe ingresar un nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errIngresoDatos.SetError(txtEmail, "Debe ingresar un usuario");
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
                errIngresoDatos.SetError(cboRol, "Debe ingresar un rol");
                return;
            }

            var usuario = new UsuarioModel
            {
                dni_usuario = long.Parse(txtDni_usuario.Text),
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                email_usuario = txtEmail.Text,
                telefono = long.Parse(txtTelefono.Text),
                password = txtPassword.Text,
                oRol = new Rol { id_rol = cboRol.SelectedIndex + 1 }
            };

            try
            {
                var negocio = new CN_usuario();
                negocio.agregarUsuario(usuario);
                MessageBox.Show("Usuario registrado con exito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarGrid();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                var baseMsg = ex.GetBaseException()?.Message ?? ex.Message;
                var innerMsg = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                var details = string.Concat(baseMsg,
                                         string.IsNullOrEmpty(innerMsg) ? string.Empty : Environment.NewLine + "Inner: " + innerMsg,
                                         Environment.NewLine + "Stack: " + ex.StackTrace);

    #if DEBUG
                MessageBox.Show("Error al registrar el usuario:" + Environment.NewLine + details, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    #else
                // En producción no mostrar detalles sensibles al usuario
                MessageBox.Show("Error al registrar el usuario. Consulte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(details); // o usar un logger
    #endif
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Desea limpiar los campos?", "Limpiar Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                limpiarCampos();
            }
        }

        private void limpiarCampos()
        {
            txtDni_usuario.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtPassword.Clear();
            cboRol.SelectedIndex = -1;
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

        private void cargarGrid()
        {
            var negocio = new CN_usuario();
            var lista = negocio.Listar();
            dgvAltaUsuario.DataSource = lista;
            dgvAltaUsuario.Columns["password"].Visible = false;
            dgvAltaUsuario.Columns["oRol"].Visible = false;
            dgvAltaUsuario.Columns["estado"].Visible = false;
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter1.Fill(this.proyectoTaller2DataSet1.rol);
        }

        
    }
}