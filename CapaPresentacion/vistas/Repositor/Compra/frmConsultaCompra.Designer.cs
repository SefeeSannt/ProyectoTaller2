namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmConsultaCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloCosto = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.TextBox();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultaCompra = new System.Windows.Forms.DataGridView();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoConsVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtCliente_Ventas = new System.Windows.Forms.TextBox();
            this.lblClienteConsVentas = new System.Windows.Forms.Label();
            this.lblDatoDomicilio = new System.Windows.Forms.Label();
            this.lblDatoDni = new System.Windows.Forms.Label();
            this.lblDatoApellido = new System.Windows.Forms.Label();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDetalleCompra = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConsultaVentas2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCompra)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlConsultaVentas2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            this.dgvDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProducto,
            this.clmProducto,
            this.categoria,
            this.clmCant,
            this.Subtotal});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(-1, 106);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(463, 308);
            this.dgvDetalleCompra.TabIndex = 0;
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Código producto";
            this.codProducto.Name = "codProducto";
            this.codProducto.ReadOnly = true;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
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
            // lblTotalVentaFilt
            // 
            this.lblTotalVentaFilt.AutoSize = true;
            this.lblTotalVentaFilt.BackColor = System.Drawing.Color.White;
            this.lblTotalVentaFilt.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentaFilt.Location = new System.Drawing.Point(142, 490);
            this.lblTotalVentaFilt.Name = "lblTotalVentaFilt";
            this.lblTotalVentaFilt.Size = new System.Drawing.Size(65, 25);
            this.lblTotalVentaFilt.TabIndex = 32;
            this.lblTotalVentaFilt.Text = "$0.00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 484);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 38);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // lblTituloCosto
            // 
            this.lblTituloCosto.AutoSize = true;
            this.lblTituloCosto.BackColor = System.Drawing.Color.White;
            this.lblTituloCosto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCosto.Location = new System.Drawing.Point(728, 493);
            this.lblTituloCosto.Name = "lblTituloCosto";
            this.lblTituloCosto.Size = new System.Drawing.Size(85, 17);
            this.lblTituloCosto.TabIndex = 17;
            this.lblTituloCosto.Text = "COSTO TOTAL:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCostoTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(819, 482);
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
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(19, 496);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(126, 17);
            this.lblTituloTotalVentas.TabIndex = 33;
            this.lblTituloTotalVentas.Text = "Total ventas filtradas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Consulta Compras";
            // 
            // dgvConsultaCompra
            // 
            this.dgvConsultaCompra.AllowUserToAddRows = false;
            this.dgvConsultaCompra.AllowUserToDeleteRows = false;
            this.dgvConsultaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedor,
            this.fechaInicio,
            this.fechaFin,
            this.formaPagoConsVenta,
            this.ventaTotal,
            this.verDetalle});
            this.dgvConsultaCompra.Location = new System.Drawing.Point(15, 252);
            this.dgvConsultaCompra.Name = "dgvConsultaCompra";
            this.dgvConsultaCompra.ReadOnly = true;
            this.dgvConsultaCompra.RowHeadersVisible = false;
            this.dgvConsultaCompra.Size = new System.Drawing.Size(451, 226);
            this.dgvConsultaCompra.TabIndex = 34;
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            this.proveedor.ReadOnly = true;
            // 
            // fechaInicio
            // 
            this.fechaInicio.HeaderText = "Fecha inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.HeaderText = "Fecha fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 31);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.TabStop = false;
            // 
            // lblfechaHasta
            // 
            this.lblfechaHasta.AutoSize = true;
            this.lblfechaHasta.BackColor = System.Drawing.Color.White;
            this.lblfechaHasta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaHasta.Location = new System.Drawing.Point(216, 11);
            this.lblfechaHasta.Name = "lblfechaHasta";
            this.lblfechaHasta.Size = new System.Drawing.Size(80, 17);
            this.lblfechaHasta.TabIndex = 15;
            this.lblfechaHasta.Text = "Fecha Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Blue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(13, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 30);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.TabStop = false;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.White;
            this.lblFechaDesde.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(10, 11);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(82, 17);
            this.lblFechaDesde.TabIndex = 9;
            this.lblFechaDesde.Text = "Fecha desde:";
            // 
            // txtCliente_Ventas
            // 
            this.txtCliente_Ventas.Location = new System.Drawing.Point(11, 95);
            this.txtCliente_Ventas.Name = "txtCliente_Ventas";
            this.txtCliente_Ventas.Size = new System.Drawing.Size(159, 20);
            this.txtCliente_Ventas.TabIndex = 11;
            // 
            // lblClienteConsVentas
            // 
            this.lblClienteConsVentas.AutoSize = true;
            this.lblClienteConsVentas.BackColor = System.Drawing.Color.White;
            this.lblClienteConsVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteConsVentas.Location = new System.Drawing.Point(10, 79);
            this.lblClienteConsVentas.Name = "lblClienteConsVentas";
            this.lblClienteConsVentas.Size = new System.Drawing.Size(90, 17);
            this.lblClienteConsVentas.TabIndex = 8;
            this.lblClienteConsVentas.Text = "DNI proveedor:";
            // 
            // lblDatoDomicilio
            // 
            this.lblDatoDomicilio.AutoSize = true;
            this.lblDatoDomicilio.BackColor = System.Drawing.Color.White;
            this.lblDatoDomicilio.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDomicilio.Location = new System.Drawing.Point(12, 86);
            this.lblDatoDomicilio.Name = "lblDatoDomicilio";
            this.lblDatoDomicilio.Size = new System.Drawing.Size(117, 17);
            this.lblDatoDomicilio.TabIndex = 22;
            this.lblDatoDomicilio.Text = "domicilio proveedor";
            // 
            // lblDatoDni
            // 
            this.lblDatoDni.AutoSize = true;
            this.lblDatoDni.BackColor = System.Drawing.Color.White;
            this.lblDatoDni.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDni.Location = new System.Drawing.Point(12, 69);
            this.lblDatoDni.Name = "lblDatoDni";
            this.lblDatoDni.Size = new System.Drawing.Size(84, 17);
            this.lblDatoDni.TabIndex = 21;
            this.lblDatoDni.Text = "dni proveedor";
            // 
            // lblDatoApellido
            // 
            this.lblDatoApellido.AutoSize = true;
            this.lblDatoApellido.BackColor = System.Drawing.Color.White;
            this.lblDatoApellido.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoApellido.Location = new System.Drawing.Point(13, 52);
            this.lblDatoApellido.Name = "lblDatoApellido";
            this.lblDatoApellido.Size = new System.Drawing.Size(111, 17);
            this.lblDatoApellido.TabIndex = 20;
            this.lblDatoApellido.Text = "apellido proveedor";
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.AutoSize = true;
            this.lblDatoNombre.BackColor = System.Drawing.Color.White;
            this.lblDatoNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoNombre.Location = new System.Drawing.Point(12, 35);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(110, 17);
            this.lblDatoNombre.TabIndex = 19;
            this.lblDatoNombre.Text = "nombre proveedor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 23);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Datos Proveedor";
            // 
            // lblDetalleCompra
            // 
            this.lblDetalleCompra.AutoSize = true;
            this.lblDetalleCompra.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCompra.Location = new System.Drawing.Point(483, 16);
            this.lblDetalleCompra.Name = "lblDetalleCompra";
            this.lblDetalleCompra.Size = new System.Drawing.Size(160, 28);
            this.lblDetalleCompra.TabIndex = 36;
            this.lblDetalleCompra.Text = "Detalle Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.lblfechaHasta);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblFechaDesde);
            this.panel1.Controls.Add(this.txtCliente_Ventas);
            this.panel1.Controls.Add(this.lblClienteConsVentas);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 183);
            this.panel1.TabIndex = 29;
            // 
            // pnlConsultaVentas2
            // 
            this.pnlConsultaVentas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoDomicilio);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoDni);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoApellido);
            this.pnlConsultaVentas2.Controls.Add(this.lblDatoNombre);
            this.pnlConsultaVentas2.Controls.Add(this.lblTitulo);
            this.pnlConsultaVentas2.Controls.Add(this.dgvDetalleCompra);
            this.pnlConsultaVentas2.Location = new System.Drawing.Point(488, 63);
            this.pnlConsultaVentas2.Name = "pnlConsultaVentas2";
            this.pnlConsultaVentas2.Size = new System.Drawing.Size(463, 415);
            this.pnlConsultaVentas2.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Imprimir detalle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalVentaFilt);
            this.Controls.Add(this.lblTituloTotalVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultaCompra);
            this.Controls.Add(this.lblTituloCosto);
            this.Controls.Add(this.lblDetalleCompra);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlConsultaVentas2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaCompra";
            this.Text = "frmDetalleCompraRepositor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlConsultaVentas2.ResumeLayout(false);
            this.pnlConsultaVentas2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label lblTotalVentaFilt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTituloCosto;
        private System.Windows.Forms.TextBox lblCostoTotal;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoConsVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTotal;
        private System.Windows.Forms.DataGridViewButtonColumn verDetalle;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblfechaHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtCliente_Ventas;
        private System.Windows.Forms.Label lblClienteConsVentas;
        private System.Windows.Forms.Label lblDatoDomicilio;
        private System.Windows.Forms.Label lblDatoDni;
        private System.Windows.Forms.Label lblDatoApellido;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlConsultaVentas2;
        private System.Windows.Forms.Button button1;
    }
}