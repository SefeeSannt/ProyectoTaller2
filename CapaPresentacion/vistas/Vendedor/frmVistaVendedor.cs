using CapaPresentacion.Vistas.Vendedor;
using CapaPresentacion.Vistas.Administrador.Usuarios;
using CapaPresentacion.Vistas.Vendedor.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Vendedor
{
    public partial class frmVistaVendedor : Form
    {
        public frmVistaVendedor()
        {
            InitializeComponent();
        }

        private void tsmiRegistrarVenta_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmRegistrarVenta();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiAltaCliente_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmCliente();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void tsmiListarCliente_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmClienteDetalle();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void consultarVenta_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmConsultaVenta();

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }

        private void frmVistaVendedor_Load(object sender, EventArgs e)
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

        private void tsmiConsultarProd_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            Form frm = new frmConsultarListadoProductos();

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
