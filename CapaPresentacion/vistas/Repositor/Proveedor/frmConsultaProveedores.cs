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

namespace CapaPresentacion.Vistas.Repositor
{
    public partial class frmConsultaProveedores : Form
    {
        public frmConsultaProveedores()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var ask = MessageBox.Show("¿Desea limpiar los campos?", "Limpiar Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                txt_dni_proveedor.Clear();
                txt_nombre_proveedor.Clear();
               
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_proveedor();

            string nombre = txt_nombre_proveedor.Text.Trim();
            string dni = txt_dni_proveedor.Text.Trim();

            var lista = negocio.BuscarProveedoresActivos(nombre, dni);

            dgvConsultaProveedores.DataSource = lista;
        }

        private void cargarProveedoresGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedoresActivos();
            dgvConsultaProveedores.DataSource = lista;
            dgvConsultaProveedores.Columns["estado"].Visible = false;

        }


        private void CargarProveedoresActivos()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ListarProveedoresActivos();
            dgvConsultaProveedores.DataSource = lista;
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            CargarProveedoresActivos();

            txt_nombre_proveedor.Clear();
            txt_dni_proveedor.Clear();
        }

        private void frmConsultaProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
