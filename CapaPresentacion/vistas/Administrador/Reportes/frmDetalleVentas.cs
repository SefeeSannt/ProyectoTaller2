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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaPresentacion.Vistas.Administrador.Reportes
{
    public partial class frmDetalleVentas : Form
    {
        public frmDetalleVentas()
        {
            InitializeComponent();
        }


        private void CargarGridVentas(DateTime fechaDesde, DateTime fechaHasta, string dniProveedor)
        {
            try
            {
                dgvConsultaVentas.Columns.Clear();
                dgvConsultaVentas.DataSource = null;

                CN_venta objCN = new CN_venta();
                DataTable tablaVenta = objCN.ListarVentas(fechaDesde, fechaHasta, dniProveedor); // Obtenemos los datos

                dgvConsultaVentas.DataSource = tablaVenta;

                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.Width = 40;
                dgvConsultaVentas.Columns.Add(btnVer);

                if (dgvConsultaVentas.Columns.Contains("cod_venta"))
                    dgvConsultaVentas.Columns["cod_venta"].Visible = false;

                if (dgvConsultaVentas.Columns.Contains("Vendedor"))
                    dgvConsultaVentas.Columns["Vendedor"].HeaderText = "Vendedor";

                decimal totalFiltrado = 0;
                if (tablaVenta != null && tablaVenta.Rows.Count > 0)
                {
                    foreach (DataRow row in tablaVenta.Rows)
                    {
                        totalFiltrado += Convert.ToDecimal(row["monto_total"]);
                    }
                }

                lblTotalVentaFilt.Text = totalFiltrado.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las compras: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;
            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value, txtDniCliente.Text);
       //     ConfigurarGridDetalle();
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

        private void ConfigurarGridDetalle()
        {
            dgvConsultaVentas.AutoGenerateColumns = false;
            dgvConsultaVentas.Columns.Clear();

            dgvConsultaVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Producto",
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvConsultaVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioVenta",
                DataPropertyName = "PrecioVenta",
                HeaderText = "Precio Venta",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });

            dgvConsultaVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 60
            });

            dgvConsultaVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",
                DataPropertyName = "Subtotal",
                HeaderText = "Subtotal",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });
        
        }

        private void MostrarDetalle(int codVenta)
        {
            try
            {
                CN_venta cn = new CN_venta();

                var venta = cn.ObtenerVentaPorId(codVenta);
                if (venta != null && venta.dni_cliente!= null)
                {
                    lblNombreCliente.Text = venta.dni_cliente.nombre;
                    lblApellidoCliente.Text = venta.dni_cliente.apellido;
                    lblDniCliente.Text = venta.dni_cliente.dni_cliente.ToString();
                    lblCodVenta.Text = venta.cod_venta.ToString();
                }

                if (venta.dni_usuario != null)
                {
                    lblNombreVendedor.Text = venta.dni_usuario.nombre;
                }

                lblCodVenta.Text = venta.cod_venta.ToString();

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDetalleVenta.DataSource = null;
            lblCostoTotal.Text = "$0,00";
            lblNombreCliente.Text = "";
            lblApellidoCliente.Text = "";
            lblDniCliente.Text = "";
            lblCodVenta.Text = "";
            lblNombreVendedor.Text = "";


            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value, txtDniCliente.Text);
        }

        private void btnPDFventa_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe seleccionar una venta para ver su detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Detalle_Venta_{DateTime.Now:ddMMyyyy}.pdf";
            savefile.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();


                        var fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                        Paragraph titulo = new Paragraph("Detalle de venta", fontTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(titulo);
                        pdfDoc.Add(Chunk.NEWLINE);

                        var fontTienda = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY);
                        Paragraph nombreTienda = new Paragraph("Tienda ZonaFit", fontTienda);
                        nombreTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(nombreTienda);

                        Paragraph direccionTienda = new Paragraph("9 de Julio 1820", fontTienda);
                        direccionTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(direccionTienda);
                        pdfDoc.Add(Chunk.NEWLINE);


                        var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                        Paragraph subtitulo = new Paragraph("Datos del Cliente/Vendedor", fontHeader);
                        pdfDoc.Add(subtitulo);

                        pdfDoc.Add(new Paragraph($"Cliente: {lblNombreCliente.Text} {lblApellidoCliente.Text}"));
                        pdfDoc.Add(new Paragraph($"DNI: {lblDniCliente.Text}"));
                        pdfDoc.Add(new Paragraph($"Vendedor: {lblNombreVendedor.Text}"));
                        pdfDoc.Add(new Paragraph($"Código de venta: {lblCodVenta.Text}"));

                        pdfDoc.Add(Chunk.NEWLINE);

                        PdfPTable tabla = new PdfPTable(dgvDetalleVenta.Columns.Count);
                        tabla.WidthPercentage = 100;

                        foreach (DataGridViewColumn column in dgvDetalleVenta.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontHeader));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.BackgroundColor = new BaseColor(240, 240, 240); // Un gris claro
                            tabla.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            tabla.AddCell(new Phrase(row.Cells["Producto"].Value.ToString()));
                            tabla.AddCell(new Phrase(Convert.ToDecimal(row.Cells["PrecioVenta"].Value).ToString("C2")));
                            tabla.AddCell(new Phrase(row.Cells["cantidad"].Value.ToString()));
                            tabla.AddCell(new Phrase(Convert.ToDecimal(row.Cells["subtotal"].Value).ToString("C2")));
                        }

                        pdfDoc.Add(tabla);
                        pdfDoc.Add(Chunk.NEWLINE);

                        var fontTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
                        Paragraph total = new Paragraph($"COSTO TOTAL: {lblCostoTotal.Text}", fontTotal);
                        total.Alignment = Element.ALIGN_RIGHT;
                        pdfDoc.Add(total);


                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("Documento PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

