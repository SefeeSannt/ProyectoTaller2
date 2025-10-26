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
                dgvConsultaCompra.Columns.Clear();
                dgvConsultaCompra.DataSource = null;

                CN_compra objCN = new CN_compra();
                DataTable tablaCompras = objCN.ListarCompras();

                dgvConsultaCompra.AutoGenerateColumns = true;

                dgvConsultaCompra.DataSource = tablaCompras ?? new DataTable();

                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.Width = 40;
                dgvConsultaCompra.Columns.Add(btnVer);

                if (tablaCompras == null || tablaCompras.Columns.Count == 0)
                {
                    
                    return;
                }

                if (dgvConsultaCompra.Columns.Contains("cod_compra"))
                    dgvConsultaCompra.Columns["cod_compra"].Visible = false;

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
            ConfigurarGridDetalle();
        }

        private void dgvConsultaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvConsultaCompra.Columns[e.ColumnIndex].Name == "btnVer")
            {
                int codCompra = Convert.ToInt32(dgvConsultaCompra.Rows[e.RowIndex].Cells["cod_compra"].Value);

                MostrarDetalle(codCompra);
            }

        }



        private void ConfigurarGridDetalle()
        {
            dgvDetalleCompra.AutoGenerateColumns = false;

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioCompra",
                HeaderText = "Precio Compra",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 60
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });
        }



        private void MostrarDetalle(int codCompra)
        {
            try
            {
                CN_compra cn = new CN_compra();

                var compra = cn.ObtenerCompraPorId(codCompra);
                if(compra != null && compra.dni_proveedor != null)
{
                    lblNombreProveedor.Text = compra.dni_proveedor.nombre;
                    lblApellidoProveedor.Text = compra.dni_proveedor.apellido;
                    lblDniProveedor.Text = compra.dni_proveedor.dni_proveedor.ToString();
                }

                DataTable dtDetalle = cn.ObtenerDetalleCompra(codCompra);
                dgvDetalleCompra.DataSource = dtDetalle;

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
    }


}

