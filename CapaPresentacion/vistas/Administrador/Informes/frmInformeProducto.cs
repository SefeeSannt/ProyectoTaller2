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
    public partial class frmInformeProducto : Form
    {
        private CN_producto cnProducto = new CN_producto();
        private CN_venta cnVenta = new CN_venta();

        public frmInformeProducto()
        {
            InitializeComponent();
        }

       

        private void CargarDatosInforme()
        {
            try
            {
                DateTime fechaDesde = dtpFechaDesde.Value.Date;
                DateTime fechaHasta = dtpFechaHasta.Value.Date;
                string nombreProducto = txtProducto.Text.Trim();

                var dataBarras = cnProducto.ObtenerProductosMasVendidos(fechaDesde, fechaHasta, nombreProducto);
                CargarGraficoBarras(dataBarras);

                var dataDona = cnProducto.ObtenerDistribucionCategoria(fechaDesde, fechaHasta, nombreProducto);
                CargarGraficoDona(dataDona);

                lblTotalVentas.Text = cnVenta.ObtenerTotalVentasFiltrado(fechaDesde, fechaHasta, nombreProducto).ToString();
                lblTotalProductoVendidos.Text = cnVenta.ObtenerTotalProductosVendidosFiltrado(fechaDesde, fechaHasta, nombreProducto).ToString();
                lblTotalCategoria.Text = cnProducto.ObtenerTotalCategoriasVendidas(fechaDesde, fechaHasta, nombreProducto).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarGraficoBarrasInicial()
        {
            chProductosMasVendidos.Series.Clear();
            chProductosMasVendidos.Titles.Clear();
            chProductosMasVendidos.Titles.Add("Productos más vendidos");
            chProductosMasVendidos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chProductosMasVendidos.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chProductosMasVendidos.ChartAreas[0].AxisX.Interval = 1; 
        }

        private void CargarGraficoBarras(object dataSource)
        {
            ConfigurarGraficoBarrasInicial();

            Series serie = chProductosMasVendidos.Series.Add("Productos");
            serie.ChartType = SeriesChartType.Column; 
            serie.IsValueShownAsLabel = true;

            chProductosMasVendidos.DataSource = dataSource;
            serie.XValueMember = "Producto";
            serie.YValueMembers = "TotalVendido";

            chProductosMasVendidos.ApplyPaletteColors();
            serie.Palette = ChartColorPalette.Pastel;

            chProductosMasVendidos.DataBind();
        }

        private void ConfigurarGraficoDonaInicial()
        {
            chDistribucionCategoria.Series.Clear();
            chDistribucionCategoria.Titles.Clear();
            chDistribucionCategoria.Titles.Add("Distribución por categoría");
            chDistribucionCategoria.Legends[0].Enabled = true;
        }

        private void CargarGraficoDona(object dataSource)
        {
            ConfigurarGraficoDonaInicial();

            Series serie = chDistribucionCategoria.Series.Add("Categorias");
            serie.ChartType = SeriesChartType.Doughnut; 
            serie.IsValueShownAsLabel = true; 

            chDistribucionCategoria.DataSource = dataSource;
            serie.XValueMember = "Categoria";
            serie.YValueMembers = "TotalVendido";

            serie.Label = "#VALX (#PERCENT{P0})";
            serie.LegendText = "#VALX"; 

            chDistribucionCategoria.DataBind();
        }

        private void frmInformeProducto_Load_1(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;

            ConfigurarGraficoBarrasInicial();
            ConfigurarGraficoDonaInicial();

            CargarDatosInforme();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarDatosInforme();
        }
    }




}

