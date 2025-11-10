using CapaNegocio;
using CapaEntidad;
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
        public Usuario usuarioActual;
        public frmDetalleVentas(Usuario oUsuario)
        {
            InitializeComponent();
            this.usuarioActual = oUsuario;
        }

        /*cambios*/
        private void CargarGridVentas(DateTime fechaDesde, DateTime fechaHasta, string nombreCliente)
        {
            try
            {
                dgvConsultaVentas.Columns.Clear();
                dgvConsultaVentas.DataSource = null;

                CN_venta objCN = new CN_venta();
                DataTable tablaVenta = objCN.ListarVentas(fechaDesde, fechaHasta, nombreCliente);

                dgvConsultaVentas.DataSource = tablaVenta;

                // Añadir botón "Ver"
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "btnVer"; // Solo se necesita una vez
                btnVer.HeaderText = "";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                btnVer.Width = 40;
                dgvConsultaVentas.Columns.Add(btnVer);

                // Ocultar y renombrar columnas
                if (dgvConsultaVentas.Columns.Contains("cod_venta"))
                    dgvConsultaVentas.Columns["cod_venta"].Visible = false;

                // (Asegúrate de que tu SQL en CD_venta devuelva estos alias)
                if (dgvConsultaVentas.Columns.Contains("Vendedor"))
                    dgvConsultaVentas.Columns["Vendedor"].HeaderText = "Vendedor";
                if (dgvConsultaVentas.Columns.Contains("Cliente"))
                    dgvConsultaVentas.Columns["Cliente"].HeaderText = "Cliente";
                if (dgvConsultaVentas.Columns.Contains("fecha_venta"))
                    dgvConsultaVentas.Columns["fecha_venta"].HeaderText = "Fecha Venta";
                if (dgvConsultaVentas.Columns.Contains("monto_total"))
                    dgvConsultaVentas.Columns["monto_total"].HeaderText = "Monto Total";

                // Sumar total
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
                MessageBox.Show("Error al cargar las ventas: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-30);
            dtpFechaHasta.Value = DateTime.Now;

            // --- ORDEN CORREGIDO ---
            ConfigurarGridDetalle(); // 1. Configura el grid de la derecha
            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value, txtNombreCliente.Text); // 2. Carga el grid de la izquierda
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
        /*Se realizaron cambios*/
        private void ConfigurarGridDetalle()
        {
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.Columns.Clear();

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Producto",
                DataPropertyName = "Producto",
                HeaderText = "Producto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // (Asumo que tu SQL de detalle de venta devuelve "PrecioCompra")
            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioCompra",
                DataPropertyName = "PrecioCompra",
                HeaderText = "Precio Venta",
                Width = 100,
                DefaultCellStyle = { Format = "C" }
            });

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad",
                Width = 60
            });

            dgvDetalleVenta.Columns.Add(new DataGridViewTextBoxColumn
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

                // --- ¡CORREGIDO! ---
                if (venta != null)
                {
                    if (venta.dni_cliente != null)
                    {
                        lblNombreCliente.Text = venta.dni_cliente.nombre;
                        lblApellidoCliente.Text = venta.dni_cliente.apellido;
                        lblDniCliente.Text = venta.dni_cliente.dni_cliente.ToString();
                    }
                    if (venta.dni_usuario != null)
                    {
                        lblNombreVendedor.Text = venta.dni_usuario.nombre;
                    }
                    lblCodVenta.Text = venta.cod_venta.ToString();
                }
                else
                {
                    lblNombreCliente.Text = "";
                    lblApellidoCliente.Text = "";
                    lblDniCliente.Text = "";
                    lblCodVenta.Text = "";
                    lblNombreVendedor.Text = "";
                }

                DataTable dtDetalle = cn.ObtenerDetalleVenta(codVenta);
                dgvDetalleVenta.DataSource = dtDetalle;

                decimal costoTotal = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    costoTotal += Convert.ToDecimal(row["Subtotal"]);
                }
                lblCostoTotal.Text = costoTotal.ToString("C");
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


            CargarGridVentas(dtpFechaDesde.Value, dtpFechaHasta.Value, txtNombreCliente.Text);
        }
        /*cambios en el modelo. Datos y estructura incosistentes. Se cambio*/
        private void btnPDFventa_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe seleccionar una venta para ver su detalle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = $"Venta_N°{lblCodVenta.Text}_{DateTime.Now:ddMMyyyy}.pdf";
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

                        // 1. Título y Datos de la Empresa (Tu código)
                        var fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK);
                        Paragraph titulo = new Paragraph("Detalle de Venta", fontTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(titulo);
                        pdfDoc.Add(Chunk.NEWLINE);

                        var fontTienda = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY);
                        Paragraph nombreTienda = new Paragraph("MyFitt", fontTienda);
                        nombreTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(nombreTienda);
                        Paragraph direccionTienda = new Paragraph("9 de julio 1432", fontTienda);
                        direccionTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(direccionTienda);
                        Paragraph cuilTienda = new Paragraph("CUIL: 30-12345678-9", fontTienda);
                        cuilTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(cuilTienda);
                        Paragraph emailTienda = new Paragraph("myfitt@gmail.com", fontTienda);
                        emailTienda.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(emailTienda);
                        pdfDoc.Add(Chunk.NEWLINE);

                        var fontHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                        // 2. Datos del Cliente
                        Paragraph subtitulo = new Paragraph("Datos del Cliente", fontHeader);
                        pdfDoc.Add(subtitulo);

                        // --- ¡ERROR CORREGIDO! ---
                        // El label se llama 'lblNombreCliente', no 'lblCliente'
                        pdfDoc.Add(new Paragraph($"Nombre: {lblNombreCliente.Text} {lblApellidoCliente.Text}"));
                        pdfDoc.Add(new Paragraph($"DNI: {lblDniCliente.Text}"));
                        pdfDoc.Add(new Paragraph($"Código de venta: {lblCodVenta.Text}"));
                        pdfDoc.Add(Chunk.NEWLINE); // Movido aquí

                        // 3. Datos del Vendedor
                        Paragraph subtituloRep = new Paragraph("Datos del Vendedor", fontHeader);
                        pdfDoc.Add(subtituloRep);
                        // Esta línea ahora funciona porque 'usuarioActual' SÍ se guarda en el constructor
                        pdfDoc.Add(new Paragraph($"Nombre: {this.usuarioActual.nombre} {this.usuarioActual.apellido}"));
                        pdfDoc.Add(new Paragraph($"DNI: {this.usuarioActual.dni_usuario.ToString()}"));
                        pdfDoc.Add(Chunk.NEWLINE);

                        // --- ¡ERROR CORREGIDO! ---
                        // 4. Tabla de Detalles
                        // No puedes declarar 'tabla' dos veces
                        PdfPTable tablaDetalles = new PdfPTable(dgvDetalleVenta.Columns.Count);
                        tablaDetalles.WidthPercentage = 100;

                        foreach (DataGridViewColumn column in dgvDetalleVenta.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontHeader));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            tablaDetalles.AddCell(cell);
                        }

                        // --- ¡ERROR CORREGIDO! (Mayúsculas) ---
                        // Nombres deben coincidir con 'ConfigurarGridDetalle'
                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            tablaDetalles.AddCell(new Phrase(row.Cells["Producto"].Value.ToString()));
                            tablaDetalles.AddCell(new Phrase(Convert.ToDecimal(row.Cells["PrecioCompra"].Value).ToString("C2")));
                            tablaDetalles.AddCell(new Phrase(row.Cells["Cantidad"].Value.ToString()));
                            tablaDetalles.AddCell(new Phrase(Convert.ToDecimal(row.Cells["Subtotal"].Value).ToString("C2")));
                        }

                        pdfDoc.Add(tablaDetalles);
                        pdfDoc.Add(Chunk.NEWLINE);

                        // 5. Total
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

