using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Repositor.Compra
{
    public partial class frmCompraProveedor : Form
    {
        // Esta propiedad guardará el proveedor completo que seleccionemos
        public ProveedorModel ProveedorSeleccionado { get; private set; }

        public frmCompraProveedor()
        {
            InitializeComponent();
        }

       private void CargarProveedorEnGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedoresActivos();
            dgvListaProveedores.DataSource = lista;

            dgvListaProveedores.Columns["estado"].Visible = false;
        }

        private void frmCompraProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedorEnGrid();
        }

        private void dgvListaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                this.ProveedorSeleccionado = dgvListaProveedores.Rows[e.RowIndex].DataBoundItem as ProveedorModel;

                if (this.ProveedorSeleccionado != null)
                {
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_proveedor();
            var criterio = txtBuscarProv.Text;
            var lista = negocio.BuscarProveedoresActivos2(criterio);
            dgvListaProveedores.DataSource = lista;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

