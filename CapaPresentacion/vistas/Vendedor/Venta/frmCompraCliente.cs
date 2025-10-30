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
    public partial class frmCompraCliente : Form
    {
        // Esta propiedad guardará el proveedor completo que seleccionemos
        public ClienteModel ClienteSeleccionado { get; private set; }

        public frmCompraCliente()
        {
            InitializeComponent();
        }

       private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientesActivos();
            dgvListaClientes.DataSource = lista;

            dgvListaClientes.Columns["estado"].Visible = false;
        }

        private void frmCompraCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void dgvListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                this.ClienteSeleccionado = dgvListaClientes.Rows[e.RowIndex].DataBoundItem as ClienteModel;

                if (this.ClienteSeleccionado != null)
                {
                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
            }
    }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscarCliente.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvListaClientes.DataSource = lista;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

