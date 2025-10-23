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
            // 1. Verificamos que no se hizo clic en el encabezado (fila -1)
            if (e.RowIndex >= 0)
            {
                // 2. Obtenemos el objeto ProveedorModel COMPLETO de la fila seleccionada.
                // (DataBoundItem es la forma correcta de hacerlo, ya que tu DataSource es una Lista)
                this.ProveedorSeleccionado = dgvListaProveedores.Rows[e.RowIndex].DataBoundItem as ProveedorModel;

                // 3. Si se obtuvo correctamente...
                if (this.ProveedorSeleccionado != null)
                {
                    // ...marcamos el resultado como "OK"...
                    this.DialogResult = DialogResult.OK;

                    // ...y cerramos este formulario para volver al principal.
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

