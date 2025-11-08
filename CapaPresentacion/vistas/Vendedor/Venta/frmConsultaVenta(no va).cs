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

namespace CapaPresentacion.Vistas.Vendedor
{
    public partial class frmConsultaVenta : Form
    {
        public frmConsultaVenta()
        {
            InitializeComponent();
        }

        private void CargarGridVentas(DateTime fechaDesde, DateTime fechaHasta, string dniCliente)
        {
            try
            {
                dgvConsultaVentas.Columns.Clear();
                dgvConsultaVentas.DataSource = null;

                CN_venta objCN = new CN_venta();
                DataTable tablaVentas = objCN.ListarVentas(fechaDesde, fechaHasta, dniCliente); // Obtenemos los datos

                dgvConsultaVentas.DataSource = tablaVentas;

                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.Width = 40;
                dgvConsultaVentas.Columns.Add(btnVer);

                if (dgvConsultaVentas.Columns.Contains("cod_venta"))
                    dgvConsultaVentas.Columns["cod_venta"].Visible = false;

                // El alias en la consulta es "cliente" (minúsculas)
                if (dgvConsultaVentas.Columns.Contains("cliente"))
                    dgvConsultaVentas.Columns["cliente"].HeaderText = "Cliente";

                decimal totalFiltrado = 0;
                if (tablaVentas != null && tablaVentas.Rows.Count > 0)
                {
                    foreach (DataRow row in tablaVentas.Rows)
                    {
                        totalFiltrado += Convert.ToDecimal(row["monto_total"]);
                    }
                }

                lblTotalVentaFilt.Text = totalFiltrado.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGridDetalle()
        {
            dgvDetalleVenta.AutoGenerateColumns = false;

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioVenta",
                HeaderText = "Precio",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 60
            });

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });
        }

        private void frmConsultaVenta_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;
            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value,txtDniCliente.Text);
            ConfigurarGridDetalle();
        }

        private void MostrarDetalle(int codVenta)
        {
            try
            {
                CN_venta cn = new CN_venta();

                var venta = cn.ObtenerVentaPorId(codVenta);
                if (venta != null && venta.dni_cliente != null)
                {
                    lblNombreCliente.Text = venta.dni_cliente.nombre;
                    lblApellidoCliente.Text = venta.dni_cliente.apellido;
                    lblDniCliente.Text = venta.dni_cliente.dni_cliente.ToString();
                }

                DataTable dtDetalle = cn.ObtenerDetalleVenta(codVenta);
                dgvDetalleVenta.DataSource = dtDetalle;

                decimal costoTotal = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    costoTotal += Convert.ToDecimal(row["Subtotal"]);
                }

                lblCostoTotal.Text = costoTotal.ToString("C"); // Formato Moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + ex.GetBaseException().Message, "Error");
            }
        }

        private void dgvConsultaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvConsultaVentas.Columns[e.ColumnIndex].Name == "btnVer")
            {
                int codVenta = Convert.ToInt32(dgvConsultaVentas.Rows[e.RowIndex].Cells["cod_venta"].Value);

                MostrarDetalle(codVenta);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDetalleVenta.DataSource = null;
            lblCostoTotal.Text = "$0,00";
            lblNombreCliente.Text = "";
            lblApellidoCliente.Text = "";
            lblDniCliente.Text = "";


            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value, txtDniCliente.Text);
        }
    }
}
