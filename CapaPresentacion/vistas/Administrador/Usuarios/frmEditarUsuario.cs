using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        public void cargarUsuarioEnGrid()
         {
            var negocio = new CN_usuario();
            var lista = negocio.ObtenerUsuariosActivos();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = lista;
            dgvUsuarios.ClearSelection();
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
                return; 
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

            var usuarioModificado = new UsuarioModel
            {
                dni_usuario = long.Parse(txtDocumento.Text),
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                username = txtUsername.Text,
                email_usuario = txtCorreo.Text,
                telefono = long.Parse(txtTelefono.Text),
                password = txtPassword.Text,
                oRol = new Rol { id_rol = Convert.ToInt32(cboRol.SelectedValue) },
                estado = 1
            };

     

            try
            {
                var negocio = new CN_usuario();
                negocio.ActualizarUsuario(usuarioModificado);
                MessageBox.Show("Cliente modificado con éxito.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarUsuarioEnGrid();
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
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UsuarioModel usuarioSeleccionado = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioModel;

             
                if (usuarioSeleccionado != null)
                {
                 
                    txtDocumento.Text = usuarioSeleccionado.dni_usuario.ToString();
                    txtNombre.Text = usuarioSeleccionado.nombre;
                    txtApellido.Text = usuarioSeleccionado.apellido;
                    txtUsername.Text = usuarioSeleccionado.username;
                    txtCorreo.Text = usuarioSeleccionado.email_usuario;
                    txtTelefono.Text = usuarioSeleccionado.telefono.ToString();
                    txtPassword.Text = "";
                    if (usuarioSeleccionado.oRol != null)
                    {
                        
                        cboRol.SelectedValue = usuarioSeleccionado.oRol.id_rol;
                    }
                    else
                    {
                        cboRol.SelectedIndex = -1; 
                    }


                }
            }
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
            cargarUsuarioEnGrid();
        }

        private void CargarRoles()
        {
            CN_rol negocioRol = new CN_rol();
            List<Rol> listaRoles = negocioRol.Listar();
            cboRol.DataSource = listaRoles;
            cboRol.ValueMember = "id_rol";
            cboRol.DisplayMember = "descripcion";
            cboRol.SelectedIndex = -1;
        }
    }
}
