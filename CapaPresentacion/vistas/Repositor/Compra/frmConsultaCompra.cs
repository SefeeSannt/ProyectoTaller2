using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Repositor
{
    public partial class frmConsultaCompra : Form
    {
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void CargarGridCompras()
        {
            try
            {
                CN_compra objCN = new CN_compra();
                DataTable tablaCompras = objCN.ListarCompras();

                // Asegurarse que el grid permita generar columnas automáticamente
                dgvConsultaCompra.AutoGenerateColumns = true;

                dgvConsultaCompra.DataSource = tablaCompras ?? new DataTable();

                if (tablaCompras == null || tablaCompras.Columns.Count == 0)
                {
                    // No hay columnas o tabla vacía — informar (opcional)
                    // MessageBox.Show("No se encontraron compras.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dgvConsultaCompra.Columns.Contains("proveedor"))
                    dgvConsultaCompra.Columns["proveedor"].HeaderText = "Proveedor";

                if (dgvConsultaCompra.Columns.Contains("fecha_compra"))
                {
                    dgvConsultaCompra.Columns["fecha_compra"].HeaderText = "Fecha de Registro";
                    dgvConsultaCompra.Columns["fecha_compra"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                if (dgvConsultaCompra.Columns.Contains("monto_total"))
                {
                    dgvConsultaCompra.Columns["monto_total"].HeaderText = "Monto Total";
                    dgvConsultaCompra.Columns["monto_total"].DefaultCellStyle.Format = "C2";
                    dgvConsultaCompra.Columns["monto_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dgvConsultaCompra.AutoResizeColumns();
                dgvConsultaCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las compras: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            CargarGridCompras();
        }
    }
}