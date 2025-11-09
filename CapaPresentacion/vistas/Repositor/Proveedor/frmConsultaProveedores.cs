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
            FormatearGrilla();
        }

        private void cargarProveedoresGrid()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ObtenerProveedoresActivos();
            dgvConsultaProveedores.DataSource = lista;
            dgvConsultaProveedores.Columns["estado"].Visible = false;

            FormatearGrilla();

        }


        private void CargarProveedoresActivos()
        {
            var negocio = new CN_proveedor();
            var lista = negocio.ListarProveedoresActivos();
            dgvConsultaProveedores.DataSource = lista;
            FormatearGrilla();
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

        private void FormatearGrilla()
        {
           
            if (dgvConsultaProveedores.Columns.Count == 0) return;

           
            if (dgvConsultaProveedores.Columns.Contains("estado"))
                dgvConsultaProveedores.Columns["estado"].Visible = false;

            if (dgvConsultaProveedores.Columns.Contains("dni_proveedor"))
                dgvConsultaProveedores.Columns["dni_proveedor"].HeaderText = "DNI";

            if (dgvConsultaProveedores.Columns.Contains("nombre"))
                dgvConsultaProveedores.Columns["nombre"].HeaderText = "Nombre";

            if (dgvConsultaProveedores.Columns.Contains("apellido"))
                dgvConsultaProveedores.Columns["apellido"].HeaderText = "Apellido";

            if (dgvConsultaProveedores.Columns.Contains("email_proveedor"))
                dgvConsultaProveedores.Columns["email_proveedor"].HeaderText = "Email";

            if (dgvConsultaProveedores.Columns.Contains("telefono"))
                dgvConsultaProveedores.Columns["telefono"].HeaderText = "Teléfono";
        }
    }
}
