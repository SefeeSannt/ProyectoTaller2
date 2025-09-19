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

namespace CapaPresentacion.Vistas.Administrador
{
    public partial class frmVistaAdministrador : Form
    {
        public frmVistaAdministrador()
        {
            InitializeComponent();
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
    }
}
