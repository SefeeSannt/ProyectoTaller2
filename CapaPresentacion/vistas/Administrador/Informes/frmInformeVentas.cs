using CapaNegocio;
using CapaPresentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.vistas.Administrador
{
    public partial class frmInformeVentas : Form
    {
        private CN_venta cnVenta = new CN_venta(); 
        public frmInformeVentas()
        {
            InitializeComponent();
        }

        private void txtDni_keyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void cbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void frmInformeVentas_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFechaHasta.Value = DateTime.Now;

            ConfigurarGraficoInicial();

            ConfigurarGraficoTopProductos();

            CargarDatosInforme();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosInforme();

        }

        private void ConfigurarGraficoInicial()
        {
            chVentas.Series.Clear();
            Series serie = chVentas.Series.Add("Productos");
            serie.ChartType = SeriesChartType.Line;
            serie.BorderWidth = 3;
            serie.Color = Color.Red;
            serie.MarkerStyle = MarkerStyle.Circle;
            serie.MarkerSize = 8;

            chVentas.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chVentas.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chVentas.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
        }

        private void CargarGraficoVentas(DataTable dtGrafico)
        {
            ConfigurarGraficoInicial();

            if (dtGrafico.Rows.Count == 0)
            {
                return;
            }

            chVentas.Series["Productos"].XValueMember = "Fecha";
            chVentas.Series["Productos"].YValueMembers = "Total";
            chVentas.DataSource = dtGrafico;
            chVentas.DataBind();

            chVentas.Series["Productos"].XValueType = ChartValueType.Date;
            chVentas.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Auto;
        }

        private void CargarTarjetasResumen(DataTable dtGrafico, int totalVentasCount)
        {
         
            lblTotalVentas.Text = totalVentasCount.ToString();

            decimal montoTotal = 0m;
            foreach (DataRow row in dtGrafico.Rows)
            {
                if (row["Total"] != DBNull.Value)
                {
                    montoTotal += Convert.ToDecimal(row["Total"]);
                }
            }
            lblTotal.Text = montoTotal.ToString("C");

            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value;
                DateTime fechaHasta = dtpFechaHasta.Value;

                int totalProductos = cnVenta.ObtenerTotalProductosVendidosFiltrado(fechaDesde, fechaHasta);
                lblTotalProducto.Text = totalProductos.ToString();
            }
            catch (Exception ex)
            {
                lblTotalProducto.Text = "Error";
                MessageBox.Show("Error al cargar total de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ConfigurarGraficoTopProductos()
        {
           
            chTopProductos.Series.Clear();
            Series serie = chTopProductos.Series.Add("Top 5 Productos");
            serie.ChartType = SeriesChartType.Bar; 
            serie.IsValueShownAsLabel = true; 

          
            chTopProductos.Titles.Clear();
            chTopProductos.Titles.Add("Top 5 Productos Más Vendidos");

          
            chTopProductos.ChartAreas[0].AxisX.Title = "Producto";
            chTopProductos.ChartAreas[0].AxisY.Title = "Cantidad Vendida";
            chTopProductos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chTopProductos.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
        }

        private void CargarGraficoTopProductos(DataTable dtTopProductos)
        {
            ConfigurarGraficoTopProductos();

            if (dtTopProductos.Rows.Count == 0)
            {

                return;
            }

           
            chTopProductos.Series["Top 5 Productos"].XValueMember = "Producto";
            chTopProductos.Series["Top 5 Productos"].YValueMembers = "TotalVendido";
            chTopProductos.DataSource = dtTopProductos;
            chTopProductos.DataBind();
        }

        private void CargarDatosInforme()
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value;
                DateTime fechaHasta = dtpFechaHasta.Value;

                DataTable dtGrafico = cnVenta.ObtenerDashboardMontoPorDia(fechaDesde, fechaHasta);
                int totalVentas = cnVenta.ObtenerTotalComprasFiltrado(fechaDesde, fechaHasta);
                CargarGraficoVentas(dtGrafico);
                CargarTarjetasResumen(dtGrafico, totalVentas);

                DataTable dtTopProductos = cnVenta.ObtenerTop5ProductosVendidos(fechaDesde, fechaHasta);
                CargarGraficoTopProductos(dtTopProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }



}

