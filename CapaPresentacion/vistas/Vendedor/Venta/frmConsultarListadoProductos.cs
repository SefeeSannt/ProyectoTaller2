using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Vistas.Vendedor.Venta
{
    public partial class frmConsultarListadoProductos : Form
    {
        public frmConsultarListadoProductos()
        {
            InitializeComponent();
        }

        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var negocio = new CN_producto();
            var criterio = txtBuscarProd.Text;
            var lista = negocio.BuscarProductosActivos(criterio);
            dgvListaProductos.DataSource = lista;
        }

        private void cargarProductosEnGrid()
        {
            var negocio = new CN_producto();
            var lista = negocio.ObtenerProductosActivos() ?? new List<ProductoModel>();
            dgvListaProductos.DataSource = lista;
            if (dgvListaProductos.Columns.Contains("estado"))
            {
                dgvListaProductos.Columns["estado"].Visible = false;
            }
            if (dgvListaProductos.Columns.Contains("id_categoria"))
            {
                dgvListaProductos.Columns["id_categoria"].Visible = false;
            }
        }

        private void frmConsultarListadoProductos_Load(object sender, EventArgs e)
        {
            cargarProductosEnGrid();
        }
    }
}
