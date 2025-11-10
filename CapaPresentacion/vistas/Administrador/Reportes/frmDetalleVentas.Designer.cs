using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Vistas.Administrador.Reportes
{
    partial class frmDetalleVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Agregra = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDFventa = new System.Windows.Forms.Button();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCosto = new System.Windows.Forms.Label();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.lblCostoTotal = new System.Windows.Forms.TextBox();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlConsultaVentas2 = new System.Windows.Forms.Panel();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblCodVenta = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.Agregra.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.pnlConsultaVentas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregra
            // 
            this.Agregra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.Agregra.Name = "Agregra";
            this.Agregra.Size = new System.Drawing.Size(110, 26);
            this.Agregra.Text = "Agregar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPDFventa);
            this.panel1.Controls.Add(this.lblTotalVentaFilt);
            this.panel1.Controls.Add(this.lblDetalleVenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTituloCosto);
            this.panel1.Controls.Add(this.dgvConsultaVentas);
            this.panel1.Controls.Add(this.lblCostoTotal);
            this.panel1.Controls.Add(this.lblTituloTotalVentas);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pnlConsultaVentas2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 538);
            this.panel1.TabIndex = 4;
            // 
            // btnPDFventa
            // 
            this.btnPDFventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFventa.ForeColor = System.Drawing.Color.Black;
            this.btnPDFventa.Location = new System.Drawing.Point(486, 476);
            this.btnPDFventa.Name = "btnPDFventa";
            this.btnPDFventa.Size = new System.Drawing.Size(143, 39);
            this.btnPDFventa.TabIndex = 28;
            this.btnPDFventa.Text = "Imprimir detalle";
            this.btnPDFventa.UseVisualStyleBackColor = true;
            this.btnPDFventa.Click += new System.EventHandler(this.btnPDFventa_Click);
            // 
            // lblTotalVentaFilt
            // 
            this.lblTotalVentaFilt.AutoSize = true;
            this.lblTotalVentaFilt.BackColor = System.Drawing.Color.White;
            this.lblTotalVentaFilt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentaFilt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalVentaFilt.Location = new System.Drawing.Point(135, 488);
            this.lblTotalVentaFilt.Name = "lblTotalVentaFilt";
            this.lblTotalVentaFilt.Size = new System.Drawing.Size(50, 21);
            this.lblTotalVentaFilt.TabIndex = 21;
            this.lblTotalVentaFilt.Text = "$0.00";
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.BackColor = System.Drawing.Color.White;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.ForeColor = System.Drawing.Color.Black;
            this.lblDetalleVenta.Location = new System.Drawing.Point(481, 24);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(126, 25);
            this.lblDetalleVenta.TabIndex = 32;
            this.lblDetalleVenta.Text = "Detalle Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consulta Ventas";
            // 
            // lblTituloCosto
            // 
            this.lblTituloCosto.AutoSize = true;
            this.lblTituloCosto.BackColor = System.Drawing.Color.White;
            this.lblTituloCosto.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCosto.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCosto.Location = new System.Drawing.Point(709, 487);
            this.lblTituloCosto.Name = "lblTituloCosto";
            this.lblTituloCosto.Size = new System.Drawing.Size(102, 20);
            this.lblTituloCosto.TabIndex = 17;
            this.lblTituloCosto.Text = "COSTO TOTAL:";
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.AllowUserToAddRows = false;
            this.dgvConsultaVentas.AllowUserToDeleteRows = false;
            this.dgvConsultaVentas.AllowUserToResizeColumns = false;
            this.dgvConsultaVentas.AllowUserToResizeRows = false;
            this.dgvConsultaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaVentas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvConsultaVentas.Location = new System.Drawing.Point(13, 245);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.ReadOnly = true;
            this.dgvConsultaVentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvConsultaVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(451, 226);
            this.dgvConsultaVentas.TabIndex = 28;
            this.dgvConsultaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaVentas_CellContentClick);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCostoTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(817, 476);
            this.lblCostoTotal.Multiline = true;
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(132, 40);
            this.lblCostoTotal.TabIndex = 17;
            this.lblCostoTotal.Text = "$0.00";
            this.lblCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.BackColor = System.Drawing.Color.White;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(17, 489);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(126, 17);
            this.lblTituloTotalVentas.TabIndex = 22;
            this.lblTituloTotalVentas.Text = "Total ventas filtradas:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 477);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 38);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // pnlConsultaVentas2
            // 
            this.pnlConsultaVentas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsultaVentas2.Controls.Add(this.lblNombreVendedor);
            this.pnlConsultaVentas2.Controls.Add(this.lblCodVenta);
            this.pnlConsultaVentas2.Controls.Add(this.lblDniCliente);
            this.pnlConsultaVentas2.Controls.Add(this.lblApellidoCliente);
            this.pnlConsultaVentas2.Controls.Add(this.lblNombreCliente);
            this.pnlConsultaVentas2.Controls.Add(this.lblTitulo);
            this.pnlConsultaVentas2.Controls.Add(this.dgvDetalleVenta);
            this.pnlConsultaVentas2.Location = new System.Drawing.Point(486, 56);
            this.pnlConsultaVentas2.Name = "pnlConsultaVentas2";
            this.pnlConsultaVentas2.Size = new System.Drawing.Size(463, 415);
            this.pnlConsultaVentas2.TabIndex = 31;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.BackColor = System.Drawing.Color.White;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.ForeColor = System.Drawing.Color.Black;
            this.lblNombreVendedor.Location = new System.Drawing.Point(13, 86);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(106, 17);
            this.lblNombreVendedor.TabIndex = 23;
            this.lblNombreVendedor.Text = "nombre vendedor";
            // 
            // lblCodVenta
            // 
            this.lblCodVenta.AutoSize = true;
            this.lblCodVenta.BackColor = System.Drawing.Color.White;
            this.lblCodVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVenta.ForeColor = System.Drawing.Color.Black;
            this.lblCodVenta.Location = new System.Drawing.Point(352, 76);
            this.lblCodVenta.Name = "lblCodVenta";
            this.lblCodVenta.Size = new System.Drawing.Size(84, 17);
            this.lblCodVenta.TabIndex = 22;
            this.lblCodVenta.Text = "Codigo venta:";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.White;
            this.lblDniCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.Color.Black;
            this.lblDniCliente.Location = new System.Drawing.Point(12, 69);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(65, 17);
            this.lblDniCliente.TabIndex = 21;
            this.lblDniCliente.Text = "dni cliente";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.White;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoCliente.Location = new System.Drawing.Point(13, 52);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(92, 17);
            this.lblApellidoCliente.TabIndex = 20;
            this.lblApellidoCliente.Text = "apellido cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.White;
            this.lblNombreCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 35);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(91, 17);
            this.lblNombreCliente.TabIndex = 19;
            this.lblNombreCliente.Text = "nombre cliente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 20);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Datos Cliente";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AllowUserToResizeColumns = false;
            this.dgvDetalleVenta.AllowUserToResizeRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(-1, 106);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(463, 308);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtpFechaHasta);
            this.panel2.Controls.Add(this.dtpFechaDesde);
            this.panel2.Controls.Add(this.lblfechaHasta);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.txtNombreCliente);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lblFechaDesde);
            this.panel2.Location = new System.Drawing.Point(14, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 183);
            this.panel2.TabIndex = 33;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(211, 28);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(159, 20);
            this.dtpFechaHasta.TabIndex = 30;
            this.dtpFechaHasta.TabStop = false;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(5, 28);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(159, 20);
            this.dtpFechaDesde.TabIndex = 26;
            this.dtpFechaDesde.TabStop = false;
            // 
            // lblfechaHasta
            // 
            this.lblfechaHasta.AutoSize = true;
            this.lblfechaHasta.BackColor = System.Drawing.Color.White;
            this.lblfechaHasta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaHasta.ForeColor = System.Drawing.Color.Black;
            this.lblfechaHasta.Location = new System.Drawing.Point(210, 8);
            this.lblfechaHasta.Name = "lblfechaHasta";
            this.lblfechaHasta.Size = new System.Drawing.Size(80, 17);
            this.lblfechaHasta.TabIndex = 29;
            this.lblfechaHasta.Text = "Fecha Hasta:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(4, 76);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(95, 17);
            this.lblCliente.TabIndex = 23;
            this.lblCliente.Text = "Nombre cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(5, 92);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(159, 20);
            this.txtNombreCliente.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Blue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(7, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 30);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.White;
            this.lblFechaDesde.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.lblFechaDesde.Location = new System.Drawing.Point(4, 8);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(82, 17);
            this.lblFechaDesde.TabIndex = 24;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            this.Agregra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.pnlConsultaVentas2.ResumeLayout(false);
            this.pnlConsultaVentas2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private DateTimePicker dtpFechaHasta;
        private Label lblDetalleVenta;
        private Label label1;
        private DataGridView dgvConsultaVentas;
        private Button btnBuscar;
        private DateTimePicker dtpFechaDesde;
        private Label lblFechaDesde;
        private TextBox txtNombreCliente;
        private Label lblCliente;
        private Label lblTotalVentaFilt;
        private Label lblTituloTotalVentas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblfechaHasta;
        private Panel pnlConsultaVentas2;
        private Label lblDniCliente;
        private Label lblApellidoCliente;
        private Label lblNombreCliente;
        private Label lblTitulo;
        private Label lblTituloCosto;
        private TextBox lblCostoTotal;
        private DataGridView dgvDetalleVenta;
        private Panel panel2;
        private Button btnPDFventa;
        private Label lblCodVenta;
        private Label lblNombreVendedor;
    }
}

