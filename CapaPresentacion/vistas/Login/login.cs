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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var vistaAdmin = new frmVistaAdministrador();
            vistaAdmin.Show();
            this.Hide();
            vistaAdmin.FormClosed += (s, args) => this.Show();
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            var vistaRepositor = new frmVistaRepositor();
            vistaRepositor.Show();
            this.Hide();
            vistaRepositor.FormClosed += (s, args) => this.Show();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            var frmVendedor = new frmVistaVendedor();
            frmVendedor.Show();
            this.Hide();
            frmVendedor.FormClosed += (s, args) => this.Show();
        }

       
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        /*Nuevo:Muestra la vista del admin luego de logerame
         SOLO ME DEJA MOSTRAR UNA VISTA, INTENTE USAR UN IF ANIDADO Y NO SE PUDO
         
         */
        private void iconBtnIngresar_Click(object sender, EventArgs e)
        {
           
            // Validar que los campos no estén vacíos
            List<Usuario> TEST = new CN_usuario().Listar();

            //busca un objeto dentro de una lista
            Usuario ousuario = new CN_usuario().Listar().Where(u => u.documento == txtNroDoc.Text && u.clave == txtClave.Text).FirstOrDefault();


            if (ousuario != null)
            {
                // Usuario encontrado → ingresar
                var vistaAdmin = new frmVistaAdministrador();
                vistaAdmin.Show();
                this.Hide();

                vistaAdmin.FormClosed += (s, args) => this.Show();
            }
            else
            {
                // Usuario no encontrado → documento o clave incorrectos
                MessageBox.Show("El documento y/o la clave son incorrectos.",
                                "Error de inicio de sesión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }




    }
        
 }

