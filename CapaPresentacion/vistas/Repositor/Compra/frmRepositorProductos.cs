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

namespace CapaPresentacion.vistas.Repositor.Compra
{
    public partial class frmRepositorProductos : Form
    {
        public frmRepositorProductos()
        {
            InitializeComponent();
        }

        private void cargarListaProductoGrid()
        {
            var negocio = new CN_producto();
            var lista = negocio.ObtenerProductosActivos () ?? new List<ProductoModel>();
            dgvListaProducto.DataSource = lista;

            if(dgvListaProducto.Columns.Contains("id_estado"))
            {
                dgvListaProducto.Columns["id_estado"].Visible = false;
            }


        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            cargarListaProductoGrid();
        }
    }
}
