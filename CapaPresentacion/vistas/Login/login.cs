using CapaEntidad;
using CapaNegocio;
using CapaPresentacion;
using CapaPresentacion.Helpers;
using CapaPresentacion.Vistas.Administrador;
using CapaPresentacion.Vistas.Repositor;
using CapaPresentacion.Vistas.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CapaPresentacion.Vistas.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnIngresar_Click(object sender, EventArgs e)
        {
           
            // Validar que los campos no estén vacíos
            List<Usuario> TEST = new CN_usuario().Listar();

            //busca un objeto dentro de una lista
            Usuario ousuario = new CN_usuario().Listar().Where(u => u.username  == txtUsername.Text && u.password == txtClave.Text).FirstOrDefault();


            if (ousuario != null)
            {
                // Usuario encontrado → ingresar
                switch (ousuario.oRol.id_rol)
                {
                    case 1: // Admin
                        var vistaAdmin = new frmVistaAdministrador(ousuario);
                        vistaAdmin.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtClave.Clear();
                        vistaAdmin.FormClosed += (s, args) => this.Show();
                        break;
                    case 2: // Vendedor
                        var frmVendedor = new frmVistaVendedor(ousuario);
                        frmVendedor.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtClave.Clear();
                        frmVendedor.FormClosed += (s, args) => this.Show();
                        break;
                    case 3: // Repositor
                        var vistaRepositor = new frmVistaRepositor(ousuario);
                        vistaRepositor.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtClave.Clear();
                        vistaRepositor.FormClosed += (s, args) => this.Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario no reconocido.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // Usuario no encontrado → documento o clave incorrectos
                MessageBox.Show("El documento y/o la clave son incorrectos.","Error de inicio de sesión",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }    
}

