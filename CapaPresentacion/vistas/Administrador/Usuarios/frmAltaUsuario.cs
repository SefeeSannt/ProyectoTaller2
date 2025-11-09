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

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errIngresoDatos.SetError(txtUsername, "El campo apellido es obligatorio");
                return;
            }

            // ... (resto del código) ...
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errIngresoDatos.SetError(txtUsername, "El campo Username es obligatorio");
                return;
            }

            // ... (resto del código) ...

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errIngresoDatos.SetError(txtEmail, "Debe ingresar un email");
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
                username = txtUsername.Text,
                email_usuario = txtEmail.Text,
                telefono = long.Parse(txtTelefono.Text),
                password = txtPassword.Text,
                oRol = new Rol { id_rol = cboRol.SelectedIndex + 1 },
                estado = 1
            };


            try
            {
                var negocio = new CN_usuario();
                negocio.agregarUsuario(usuario);
                MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarGrid();


            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        sb.AppendLine($"Propiedad: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
                MessageBox.Show(sb.ToString(), "Error de Validación DETALLADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtApellido.Clear();
            txtUsername.Clear();
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

        public void cargarGrid()
        {
            var negocio = new CN_usuario();
            var lista = negocio.ObtenerUsuariosActivos();
            dgvAltaUsuario.DataSource = lista;
        
            FormatearGrillaUsuarios(); 
            dgvAltaUsuario.ClearSelection();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter1.Fill(this.proyectoTaller2DataSet1.rol);
        }

        private void FormatearGrillaUsuarios()
        {
        
            if (dgvAltaUsuario.Columns.Count == 0) return;

            if (dgvAltaUsuario.Columns.Contains("password"))
                dgvAltaUsuario.Columns["password"].Visible = false;

            if (dgvAltaUsuario.Columns.Contains("oRol"))
                dgvAltaUsuario.Columns["oRol"].Visible = false;

            if (dgvAltaUsuario.Columns.Contains("estado"))
                dgvAltaUsuario.Columns["estado"].Visible = false;

            if (dgvAltaUsuario.Columns.Contains("dni_usuario"))
                dgvAltaUsuario.Columns["dni_usuario"].HeaderText = "DNI";

            if (dgvAltaUsuario.Columns.Contains("nombre"))
                dgvAltaUsuario.Columns["nombre"].HeaderText = "Nombre";

            if (dgvAltaUsuario.Columns.Contains("apellido"))
                dgvAltaUsuario.Columns["apellido"].HeaderText = "Apellido";

            if (dgvAltaUsuario.Columns.Contains("username"))
                dgvAltaUsuario.Columns["username"].HeaderText = "Usuario";

            if (dgvAltaUsuario.Columns.Contains("email_usuario"))
                dgvAltaUsuario.Columns["email_usuario"].HeaderText = "Email";

            if (dgvAltaUsuario.Columns.Contains("telefono"))
                dgvAltaUsuario.Columns["telefono"].HeaderText = "Teléfono";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_usuario();
            var criterio = txtUserList.Text;
            var lista = negocio.BuscarUsuariosActivos(criterio);

            dgvAltaUsuario.DataSource = lista;
            FormatearGrillaUsuarios();
        }
    }
}