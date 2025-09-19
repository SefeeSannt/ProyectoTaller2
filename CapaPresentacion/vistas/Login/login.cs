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

       
    }
}
