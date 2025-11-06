using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaPresentacion.Vistas.Repositor
{
    public partial class frmConsultaCompra : Form
    {
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void CargarGridCompras(DateTime fechaDesde, DateTime fechaHasta, string dniProveedor)
        {
            try
            {
                dgvConsultaCompra.Columns.Clear();
                dgvConsultaCompra.DataSource = null;

                CN_compra objCN = new CN_compra();
                DataTable tablaCompras = objCN.ListarCompras(fechaDesde, fechaHasta, dniProveedor); // Obtenemos los datos

                dgvConsultaCompra.DataSource = tablaCompras;

                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer";
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.Width = 40;
                dgvConsultaCompra.Columns.Add(btnVer);

                if (dgvConsultaCompra.Columns.Contains("cod_compra"))
                    dgvConsultaCompra.Columns["cod_compra"].Visible = false;

                if (dgvConsultaCompra.Columns.Contains("Proveedor"))
                    dgvConsultaCompra.Columns["Proveedor"].HeaderText = "Proveedor";

                decimal totalFiltrado = 0;
                if (tablaCompras != null && tablaCompras.Rows.Count > 0)
                {
                    foreach (DataRow row in tablaCompras.Rows)
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

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;
            CargarGridCompras(dtpFechaDesde.Value, dtpFechaHasta.Value, txtDniProv.Text);
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
            dgvDetalleCompra.Columns.Clear();

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Producto",  
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioCompra",  
                DataPropertyName = "PrecioCompra",
                HeaderText = "Precio Compra",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad", 
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 60
            });

            dgvDetalleCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Subtotal",      
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDetalleCompra.DataSource = null;
            lblCostoTotal.Text = "$0,00";
            lblNombreProveedor.Text = "";
            lblApellidoProveedor.Text = "";
            lblDniProveedor.Text = "";
          
         
            CargarGridCompras(dtpFechaDesde.Value, dtpFechaHasta.Value, txtDniProv.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe seleccionar una compra para ver su detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Detalle_Compra_{DateTime.Now:ddMMyyyy}.pdf";
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
                        Paragraph titulo = new Paragraph("Detalle de Compra", fontTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(titulo);
                        pdfDoc.Add(Chunk.NEWLINE);

                        var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);
                        Paragraph subtitulo = new Paragraph("Datos del Proveedor/Repositor", fontHeader);
                        pdfDoc.Add(subtitulo);

                        pdfDoc.Add(new Paragraph($"Nombre: {lblNombreProveedor.Text} {lblApellidoProveedor.Text}"));
                        pdfDoc.Add(new Paragraph($"DNI: {lblDniProveedor.Text}"));
                        pdfDoc.Add(Chunk.NEWLINE);

                        PdfPTable tabla = new PdfPTable(dgvDetalleCompra.Columns.Count);
                        tabla.WidthPercentage = 100;

                        foreach (DataGridViewColumn column in dgvDetalleCompra.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontHeader));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.BackgroundColor = new BaseColor(240, 240, 240); // Un gris claro
                            tabla.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                        {
                            tabla.AddCell(new Phrase(row.Cells["Producto"].Value.ToString()));
                            tabla.AddCell(new Phrase(Convert.ToDecimal(row.Cells["PrecioCompra"].Value).ToString("C2")));
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

