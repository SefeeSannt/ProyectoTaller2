using CapaPresentacion.vistas.Administrador;
using CapaPresentacion.vistas.Administrador.Usuarios;
using CapaPresentacion.vistas.Repositor.Proveedor;
using CapaPresentacion.Vistas.Administrador;
using CapaPresentacion.Vistas.Administrador.Productos;
using CapaPresentacion.Vistas.Administrador.Reportes;
using CapaPresentacion.Vistas.Administrador.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.vistas.Administrador.Productos;

namespace CapaPresentacion.Vistas.Administrador
{
    public partial class frmVistaAdministrador : Form
    {
        public frmVistaAdministrador(Usuario oUsuario)
        {
            InitializeComponent();
            lblNombre.Text = oUsuario.nombre + " " + oUsuario.apellido;
        }

        private void tsmiListarProd_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmListaProductos();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAltaProd_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmAltaProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        } 
       
        //Funcion load que añade un color backround en el formulario padre del Administrador
        private void FormMDI_Load(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient mdi)
                {
                    // Fondo de color
                    mdi.BackColor = Color.White;
                }
            }
        }

        private void iconBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAltaUsuario_Click_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmAltaUsuario();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiListarUsuarios_Click_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmDetalleUsuario();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiDetalleCompras_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmDetalleCompras();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiDetalleVentas_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmDetalleVentas();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiInfProd_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmInformeProducto ();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiInfCompra_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmInformeCompra();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiInfVenta_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmInformeVentas();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiBajaProducto_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmBajaProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiBajaDeUsuario_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmBajaUsuario();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiEditarUser_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmEditarUsuario();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiEditarProd_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmEditarProducto();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea realizar un backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Backup realizado con éxito", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void altaBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmBajaCliente();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void altaBajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmBajaProveedor();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
