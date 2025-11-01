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
        public ProductoModel ProductoSeleccionado { get; private set; }
        private List<int> idsAExcluir;

        public frmRepositorProductos(List<int> idsYaEnCarrito)
        {
            InitializeComponent();
            this.idsAExcluir = idsYaEnCarrito;
        }

        private void cargarListaProductoGrid()
        {
            var negocio = new CN_producto();
            var listaCompleta = negocio.ObtenerProductosActivos() ?? new List<ProductoModel>();

            var listaFiltrada = listaCompleta
                .Where(p => !this.idsAExcluir.Contains(p.cod_producto))
                .ToList();

            dgvListaProducto.DataSource = listaFiltrada;

            if (dgvListaProducto.Columns.Contains("estado"))
            {
                dgvListaProducto.Columns["estado"].Visible = false;
            }

        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            cargarListaProductoGrid();
        }

        private void dgvListaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                this.ProductoSeleccionado = dgvListaProducto.Rows[e.RowIndex].DataBoundItem as ProductoModel;

                if (this.ProductoSeleccionado != null)
                {
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
