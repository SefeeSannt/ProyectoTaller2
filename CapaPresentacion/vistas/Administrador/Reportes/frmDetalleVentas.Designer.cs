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
            this.Agregra = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCosto = new System.Windows.Forms.Label();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.lblCostoTotal = new System.Windows.Forms.TextBox();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlConsultaVentas2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatoDni = new System.Windows.Forms.Label();
            this.lblDatoApellido = new System.Windows.Forms.Label();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.lblVendedorConsVentas = new System.Windows.Forms.Label();
            this.txtCliente_Ventas = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.clienteConsVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoConsVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(486, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Imprimir detalle";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dgvConsultaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteConsVentas,
            this.fechaVenta,
            this.formaPagoConsVenta,
            this.ventaTotal,
            this.verDetalle});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(13, 245);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.ReadOnly = true;
            this.dgvConsultaVentas.RowHeadersVisible = false;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(451, 226);
            this.dgvConsultaVentas.TabIndex = 28;
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
            this.pnlConsultaVentas2.Controls.Add(this.label2);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoDni);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoApellido);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoNombre);
            this.pnlConsultaVentas2.Controls.Add(this.lblTitulo);
            this.pnlConsultaVentas2.Controls.Add(this.dgvDetalleVenta);
            this.pnlConsultaVentas2.Location = new System.Drawing.Point(486, 56);
            this.pnlConsultaVentas2.Name = "pnlConsultaVentas2";
            this.pnlConsultaVentas2.Size = new System.Drawing.Size(463, 415);
            this.pnlConsultaVentas2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(352, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Codigo venta:";
            // 
            // lblDatoDni
            // 
            this.lblDatoDni.AutoSize = true;
            this.lblDatoDni.BackColor = System.Drawing.Color.White;
            this.lblDatoDni.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDni.ForeColor = System.Drawing.Color.Black;
            this.lblDatoDni.Location = new System.Drawing.Point(12, 69);
            this.lblDatoDni.Name = "lblDatoDni";
            this.lblDatoDni.Size = new System.Drawing.Size(80, 17);
            this.lblDatoDni.TabIndex = 21;
            this.lblDatoDni.Text = "dni vendedor";
            this.lblDatoDni.Click += new System.EventHandler(this.lblDatoDni_Click);
            // 
            // lblDatoApellido
            // 
            this.lblDatoApellido.AutoSize = true;
            this.lblDatoApellido.BackColor = System.Drawing.Color.White;
            this.lblDatoApellido.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoApellido.ForeColor = System.Drawing.Color.Black;
            this.lblDatoApellido.Location = new System.Drawing.Point(13, 52);
            this.lblDatoApellido.Name = "lblDatoApellido";
            this.lblDatoApellido.Size = new System.Drawing.Size(107, 17);
            this.lblDatoApellido.TabIndex = 20;
            this.lblDatoApellido.Text = "apellido vendedor";
            this.lblDatoApellido.Click += new System.EventHandler(this.lblDatoApellido_Click);
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.AutoSize = true;
            this.lblDatoNombre.BackColor = System.Drawing.Color.White;
            this.lblDatoNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoNombre.ForeColor = System.Drawing.Color.Black;
            this.lblDatoNombre.Location = new System.Drawing.Point(12, 35);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(106, 17);
            this.lblDatoNombre.TabIndex = 19;
            this.lblDatoNombre.Text = "nombre vendedor";
            this.lblDatoNombre.Click += new System.EventHandler(this.lblDatoNombre_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 20);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Datos Vendedor";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProducto,
            this.clmCant,
            this.Subtotal});
            this.dgvDetalleVenta.Location = new System.Drawing.Point(-1, 106);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(463, 308);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            // 
            // clmCant
            // 
            this.clmCant.HeaderText = "Cantidad";
            this.clmCant.Name = "clmCant";
            this.clmCant.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblfechaHasta);
            this.panel2.Controls.Add(this.lblVendedorConsVentas);
            this.panel2.Controls.Add(this.txtCliente_Ventas);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lblFechaDesde);
            this.panel2.Location = new System.Drawing.Point(14, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 183);
            this.panel2.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker2.TabIndex = 30;
            this.dateTimePicker2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.TabStop = false;
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
            this.lblfechaHasta.Click += new System.EventHandler(this.lblfechaHasta_Click);
            // 
            // lblVendedorConsVentas
            // 
            this.lblVendedorConsVentas.AutoSize = true;
            this.lblVendedorConsVentas.BackColor = System.Drawing.Color.White;
            this.lblVendedorConsVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorConsVentas.ForeColor = System.Drawing.Color.Black;
            this.lblVendedorConsVentas.Location = new System.Drawing.Point(4, 76);
            this.lblVendedorConsVentas.Name = "lblVendedorConsVentas";
            this.lblVendedorConsVentas.Size = new System.Drawing.Size(72, 17);
            this.lblVendedorConsVentas.TabIndex = 23;
            this.lblVendedorConsVentas.Text = "DNI vendor:";
            this.lblVendedorConsVentas.Click += new System.EventHandler(this.lblVendedorConsVentas_Click);
            // 
            // txtCliente_Ventas
            // 
            this.txtCliente_Ventas.Location = new System.Drawing.Point(5, 92);
            this.txtCliente_Ventas.Name = "txtCliente_Ventas";
            this.txtCliente_Ventas.Size = new System.Drawing.Size(159, 20);
            this.txtCliente_Ventas.TabIndex = 25;
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
            this.lblFechaDesde.Click += new System.EventHandler(this.lblFechaDesde_Click);
            // 
            // clienteConsVentas
            // 
            this.clienteConsVentas.HeaderText = "Cliente";
            this.clienteConsVentas.Name = "clienteConsVentas";
            this.clienteConsVentas.ReadOnly = true;
            // 
            // fechaVenta
            // 
            this.fechaVenta.HeaderText = "Fecha venta";
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.ReadOnly = true;
            // 
            // formaPagoConsVenta
            // 
            this.formaPagoConsVenta.HeaderText = "Forma de Pago";
            this.formaPagoConsVenta.Name = "formaPagoConsVenta";
            this.formaPagoConsVenta.ReadOnly = true;
            // 
            // ventaTotal
            // 
            this.ventaTotal.HeaderText = "Total";
            this.ventaTotal.Name = "ventaTotal";
            this.ventaTotal.ReadOnly = true;
            // 
            // verDetalle
            // 
            this.verDetalle.HeaderText = "Ver detalle";
            this.verDetalle.Name = "verDetalle";
            this.verDetalle.ReadOnly = true;
            this.verDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.verDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
        private DateTimePicker dateTimePicker2;
        private Label lblDetalleVenta;
        private Label label1;
        private DataGridView dgvConsultaVentas;
        private Button btnBuscar;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaDesde;
        private TextBox txtCliente_Ventas;
        private Label lblVendedorConsVentas;
        private Label lblTotalVentaFilt;
        private Label lblTituloTotalVentas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblfechaHasta;
        private Panel pnlConsultaVentas2;
        private Label lblDatoDni;
        private Label lblDatoApellido;
        private Label lblDatoNombre;
        private Label lblTitulo;
        private Label lblTituloCosto;
        private TextBox lblCostoTotal;
        private DataGridView dgvDetalleVenta;
        private DataGridViewTextBoxColumn clmProducto;
        private DataGridViewTextBoxColumn clmCant;
        private DataGridViewTextBoxColumn Subtotal;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private DataGridViewTextBoxColumn clienteConsVentas;
        private DataGridViewTextBoxColumn fechaVenta;
        private DataGridViewTextBoxColumn formaPagoConsVenta;
        private DataGridViewTextBoxColumn ventaTotal;
        private DataGridViewButtonColumn verDetalle;
    }
}

