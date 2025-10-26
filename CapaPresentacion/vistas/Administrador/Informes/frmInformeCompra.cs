using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Helpers;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio;

namespace CapaPresentacion.vistas.Administrador
{
    public partial class frmInformeCompra : Form
    {
        public frmInformeCompra()
        {
            InitializeComponent();
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDashboard();
        }

        private void frmInformeCompra_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;
            CargarDashboard();
        }

        private void CargarDashboard()
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value;
                DateTime fechaHasta = dtpFechaHasta.Value;
                string proveedor = txtProveedor.Text;
                string producto = txtProducto.Text;

                CN_compra cn = new CN_compra();

                DataTable dtMonto = cn.ObtenerDashboardMontoPorDia(fechaDesde, fechaHasta, proveedor, producto);
                DataTable dtCategoria = cn.ObtenerDashboardCategoria(fechaDesde, fechaHasta, proveedor, producto);

                int totalCompras = cn.ObtenerTotalComprasFiltrado(fechaDesde, fechaHasta, proveedor, producto);

                PoblarChartLinea(dtMonto);
                PoblarChartDona(dtCategoria);

                lblTotalCompra.Text = totalCompras.ToString();

                lblTotalCategoria.Text = dtCategoria.Rows.Count.ToString();

                decimal montoTotal = 0;
                if (dtMonto.Rows.Count > 0)
                {
                    montoTotal = Convert.ToDecimal(dtMonto.Compute("SUM(Total)", ""));
                }
                lblMontoTotalCompras.Text = montoTotal.ToString("C2");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el dashboard: " + ex.GetBaseException().Message, "Error");
            }

        }


        private void PoblarChartLinea(DataTable dt)
        {
            chCompra.Series.Clear();
            chCompra.DataSource = dt;

            Series serieMonto = chCompra.Series.Add("Monto Total");
            serieMonto.ChartType = SeriesChartType.Line;
            serieMonto.XValueMember = "Fecha";     
            serieMonto.YValueMembers = "Total";           

            serieMonto.BorderWidth = 3;
            serieMonto.Color = Color.Red;
            serieMonto.MarkerStyle = MarkerStyle.Circle;
            serieMonto.MarkerSize = 8;

            ChartArea ca = chCompra.ChartAreas[0];
            ca.AxisX.Title = "Fecha";
            ca.AxisY.Title = "Monto Total ($)";
            ca.AxisX.LabelStyle.Format = "dd/MM";
            ca.AxisY.LabelStyle.Format = "C0"; 

            chCompra.DataBind();
        }

        private void PoblarChartDona(DataTable dt)
        {
            chCategoria.Series.Clear();
            chCategoria.DataSource = dt;

            Series serieCat = chCategoria.Series.Add("Categorias");
            serieCat.ChartType = SeriesChartType.Doughnut; 

            serieCat.XValueMember = "Categoria";
            serieCat.YValueMembers = "Cantidad";

            serieCat.IsValueShownAsLabel = true;

            serieCat.LegendText = "#VALX";

            chCategoria.DataBind();
        }





    }
}
