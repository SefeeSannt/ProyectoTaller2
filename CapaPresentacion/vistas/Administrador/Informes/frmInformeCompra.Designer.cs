namespace CapaPresentacion.vistas.Administrador
{
    partial class frmInformeCompra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblResumen3 = new System.Windows.Forms.Label();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblMontoTotalCompras = new System.Windows.Forms.Label();
            this.lblTituloT = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalCategoria = new System.Windows.Forms.Label();
            this.lblTituloC = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlDiagramaCategoria = new System.Windows.Forms.Panel();
            this.chCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pnlDiagramaCompra = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.chCompra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblInformeCompra = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.pnlDiagramaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCategoria)).BeginInit();
            this.pnlDiagramaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCompra)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCompra.Location = new System.Drawing.Point(95, 62);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(23, 25);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "0";
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo4.Location = new System.Drawing.Point(95, 49);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(89, 13);
            this.lblTitulo4.TabIndex = 11;
            this.lblTitulo4.Text = "Total de compras";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 28);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(83, 74);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblResumen3
            // 
            this.lblResumen3.AutoSize = true;
            this.lblResumen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen3.Location = new System.Drawing.Point(3, 3);
            this.lblResumen3.Name = "lblResumen3";
            this.lblResumen3.Size = new System.Drawing.Size(92, 24);
            this.lblResumen3.TabIndex = 14;
            this.lblResumen3.Text = "Resumen";
            // 
            // pnlResumen
            // 
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumen.Controls.Add(this.lblMontoTotalCompras);
            this.pnlResumen.Controls.Add(this.lblTituloT);
            this.pnlResumen.Controls.Add(this.iconPictureBox2);
            this.pnlResumen.Controls.Add(this.lblTotalCategoria);
            this.pnlResumen.Controls.Add(this.lblTituloC);
            this.pnlResumen.Controls.Add(this.iconPictureBox3);
            this.pnlResumen.Controls.Add(this.lblTotalCompra);
            this.pnlResumen.Controls.Add(this.lblTitulo4);
            this.pnlResumen.Controls.Add(this.iconPictureBox1);
            this.pnlResumen.Controls.Add(this.lblResumen3);
            this.pnlResumen.Location = new System.Drawing.Point(23, 421);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(920, 107);
            this.pnlResumen.TabIndex = 18;
            // 
            // lblMontoTotalCompras
            // 
            this.lblMontoTotalCompras.AutoSize = true;
            this.lblMontoTotalCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMontoTotalCompras.Location = new System.Drawing.Point(542, 62);
            this.lblMontoTotalCompras.Name = "lblMontoTotalCompras";
            this.lblMontoTotalCompras.Size = new System.Drawing.Size(23, 25);
            this.lblMontoTotalCompras.TabIndex = 26;
            this.lblMontoTotalCompras.Text = "0";
            // 
            // lblTituloT
            // 
            this.lblTituloT.AutoSize = true;
            this.lblTituloT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTituloT.Location = new System.Drawing.Point(542, 49);
            this.lblTituloT.Name = "lblTituloT";
            this.lblTituloT.Size = new System.Drawing.Size(89, 13);
            this.lblTituloT.TabIndex = 25;
            this.lblTituloT.Text = "Total de compras";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 72;
            this.iconPictureBox2.Location = new System.Drawing.Point(453, 30);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(83, 72);
            this.iconPictureBox2.TabIndex = 24;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblTotalCategoria
            // 
            this.lblTotalCategoria.AutoSize = true;
            this.lblTotalCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCategoria.Location = new System.Drawing.Point(323, 62);
            this.lblTotalCategoria.Name = "lblTotalCategoria";
            this.lblTotalCategoria.Size = new System.Drawing.Size(23, 25);
            this.lblTotalCategoria.TabIndex = 23;
            this.lblTotalCategoria.Text = "0";
            // 
            // lblTituloC
            // 
            this.lblTituloC.AutoSize = true;
            this.lblTituloC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTituloC.Location = new System.Drawing.Point(323, 49);
            this.lblTituloC.Name = "lblTituloC";
            this.lblTituloC.Size = new System.Drawing.Size(93, 13);
            this.lblTituloC.TabIndex = 22;
            this.lblTituloC.Text = "Total de categoria";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 72;
            this.iconPictureBox3.Location = new System.Drawing.Point(234, 30);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(83, 72);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            // 
            // pnlDiagramaCategoria
            // 
            this.pnlDiagramaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiagramaCategoria.Controls.Add(this.chCategoria);
            this.pnlDiagramaCategoria.Controls.Add(this.lblTitulo2);
            this.pnlDiagramaCategoria.Location = new System.Drawing.Point(579, 125);
            this.pnlDiagramaCategoria.Name = "pnlDiagramaCategoria";
            this.pnlDiagramaCategoria.Size = new System.Drawing.Size(364, 290);
            this.pnlDiagramaCategoria.TabIndex = 17;
            // 
            // chCategoria
            // 
            chartArea5.Name = "ChartArea1";
            this.chCategoria.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chCategoria.Legends.Add(legend5);
            this.chCategoria.Location = new System.Drawing.Point(15, 42);
            this.chCategoria.Name = "chCategoria";
            this.chCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chCategoria.Series.Add(series5);
            this.chCategoria.Size = new System.Drawing.Size(300, 195);
            this.chCategoria.TabIndex = 14;
            this.chCategoria.Text = "chCategoria";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(10, 13);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo2.TabIndex = 13;
            this.lblTitulo2.Text = "Distribucion por categoria";
            // 
            // pnlDiagramaCompra
            // 
            this.pnlDiagramaCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiagramaCompra.Controls.Add(this.lblTitulo1);
            this.pnlDiagramaCompra.Controls.Add(this.chCompra);
            this.pnlDiagramaCompra.Location = new System.Drawing.Point(23, 125);
            this.pnlDiagramaCompra.Name = "pnlDiagramaCompra";
            this.pnlDiagramaCompra.Size = new System.Drawing.Size(550, 290);
            this.pnlDiagramaCompra.TabIndex = 16;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(3, 13);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(92, 25);
            this.lblTitulo1.TabIndex = 12;
            this.lblTitulo1.Text = "Compras";
            // 
            // chCompra
            // 
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisX2.IsLabelAutoFit = false;
            chartArea6.AxisX2.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.Name = "ChartArea1";
            this.chCompra.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chCompra.Legends.Add(legend6);
            this.chCompra.Location = new System.Drawing.Point(19, 43);
            this.chCompra.Name = "chCompra";
            this.chCompra.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Productos";
            this.chCompra.Series.Add(series6);
            this.chCompra.Size = new System.Drawing.Size(517, 228);
            this.chCompra.TabIndex = 9;
            this.chCompra.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.lblFechaHasta);
            this.panel1.Controls.Add(this.lblProducto);
            this.panel1.Controls.Add(this.txtProducto);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.txtProveedor);
            this.panel1.Location = new System.Drawing.Point(23, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 80);
            this.panel1.TabIndex = 15;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(142, 33);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 16;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(139, 13);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(76, 17);
            this.lblFechaHasta.TabIndex = 15;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(434, 13);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 17);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(437, 33);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(159, 20);
            this.txtProducto.TabIndex = 12;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(260, 13);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(65, 17);
            this.lblProveedor.TabIndex = 9;
            this.lblProveedor.Text = "Proveedor";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(19, 34);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha desde";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(263, 34);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(159, 20);
            this.txtProveedor.TabIndex = 10;
            // 
            // lblInformeCompra
            // 
            this.lblInformeCompra.AutoSize = true;
            this.lblInformeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeCompra.Location = new System.Drawing.Point(18, 11);
            this.lblInformeCompra.Name = "lblInformeCompra";
            this.lblInformeCompra.Size = new System.Drawing.Size(189, 25);
            this.lblInformeCompra.TabIndex = 14;
            this.lblInformeCompra.Text = "Informe de Compras";
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(619, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmInformeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlDiagramaCategoria);
            this.Controls.Add(this.pnlDiagramaCompra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInformeCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeCompra";
            this.Text = "frmInformeCompra";
            this.Load += new System.EventHandler(this.frmInformeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.pnlDiagramaCategoria.ResumeLayout(false);
            this.pnlDiagramaCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCategoria)).EndInit();
            this.pnlDiagramaCompra.ResumeLayout(false);
            this.pnlDiagramaCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblTitulo4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblResumen3;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblTotalCategoria;
        private System.Windows.Forms.Label lblTituloC;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel pnlDiagramaCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCategoria;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel pnlDiagramaCompra;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblInformeCompra;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblMontoTotalCompras;
        private System.Windows.Forms.Label lblTituloT;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
        private System.Windows.Forms.Button btnBuscar;
    }
}