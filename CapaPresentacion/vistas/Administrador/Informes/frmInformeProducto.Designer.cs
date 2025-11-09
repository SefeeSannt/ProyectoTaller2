namespace CapaPresentacion.vistas.Administrador
{
    partial class frmInformeProducto
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblInforme = new System.Windows.Forms.Label();
            this.pnlInforme = new System.Windows.Forms.Panel();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.pnlProdVent = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chDistribucionCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCategoria = new System.Windows.Forms.Label();
            this.lblTitulo6 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalProductoVendidos = new System.Windows.Forms.Label();
            this.lblTItulo5 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.chProductosMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlInforme.SuspendLayout();
            this.pnlProdVent.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucionCategoria)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProductosMasVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(12, 9);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(195, 25);
            this.lblInforme.TabIndex = 1;
            this.lblInforme.Text = "Informe de productos";
            // 
            // pnlInforme
            // 
            this.pnlInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInforme.Controls.Add(this.btnBuscar);
            this.pnlInforme.Controls.Add(this.dtpFechaHasta);
            this.pnlInforme.Controls.Add(this.lblFechaHasta);
            this.pnlInforme.Controls.Add(this.dtpFechaDesde);
            this.pnlInforme.Controls.Add(this.lblFecha);
            this.pnlInforme.Controls.Add(this.lblProducto);
            this.pnlInforme.Controls.Add(this.txtProducto);
            this.pnlInforme.Location = new System.Drawing.Point(17, 37);
            this.pnlInforme.Name = "pnlInforme";
            this.pnlInforme.Size = new System.Drawing.Size(920, 80);
            this.pnlInforme.TabIndex = 8;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(142, 33);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 20;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(139, 13);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(76, 17);
            this.lblFechaHasta.TabIndex = 19;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(19, 34);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 17);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha desde";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(275, 13);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 17);
            this.lblProducto.TabIndex = 9;
            this.lblProducto.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(278, 33);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(238, 20);
            this.txtProducto.TabIndex = 10;
            // 
            // pnlProdVent
            // 
            this.pnlProdVent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdVent.Controls.Add(this.chProductosMasVendidos);
            this.pnlProdVent.Controls.Add(this.lblTitulo1);
            this.pnlProdVent.Location = new System.Drawing.Point(17, 123);
            this.pnlProdVent.Name = "pnlProdVent";
            this.pnlProdVent.Size = new System.Drawing.Size(550, 290);
            this.pnlProdVent.TabIndex = 11;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(3, 13);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(226, 25);
            this.lblTitulo1.TabIndex = 12;
            this.lblTitulo1.Text = "Productos mas vendidos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chDistribucionCategoria);
            this.panel3.Controls.Add(this.lblTitulo2);
            this.panel3.Location = new System.Drawing.Point(573, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 290);
            this.panel3.TabIndex = 12;
            // 
            // chDistribucionCategoria
            // 
            chartArea5.Name = "ChartArea1";
            this.chDistribucionCategoria.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chDistribucionCategoria.Legends.Add(legend5);
            this.chDistribucionCategoria.Location = new System.Drawing.Point(15, 42);
            this.chDistribucionCategoria.Name = "chDistribucionCategoria";
            this.chDistribucionCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chDistribucionCategoria.Series.Add(series5);
            this.chDistribucionCategoria.Size = new System.Drawing.Size(300, 195);
            this.chDistribucionCategoria.TabIndex = 14;
            this.chDistribucionCategoria.Text = "chart2";
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalCategoria);
            this.panel4.Controls.Add(this.lblTitulo6);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.lblTotalProductoVendidos);
            this.panel4.Controls.Add(this.lblTItulo5);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Controls.Add(this.lblTotalVentas);
            this.panel4.Controls.Add(this.lblTitulo4);
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Controls.Add(this.lblTitulo3);
            this.panel4.Location = new System.Drawing.Point(17, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 107);
            this.panel4.TabIndex = 13;
            // 
            // lblTotalCategoria
            // 
            this.lblTotalCategoria.AutoSize = true;
            this.lblTotalCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCategoria.Location = new System.Drawing.Point(624, 62);
            this.lblTotalCategoria.Name = "lblTotalCategoria";
            this.lblTotalCategoria.Size = new System.Drawing.Size(23, 25);
            this.lblTotalCategoria.TabIndex = 23;
            this.lblTotalCategoria.Text = "0";
            // 
            // lblTitulo6
            // 
            this.lblTitulo6.AutoSize = true;
            this.lblTitulo6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo6.Location = new System.Drawing.Point(624, 49);
            this.lblTitulo6.Name = "lblTitulo6";
            this.lblTitulo6.Size = new System.Drawing.Size(93, 13);
            this.lblTitulo6.TabIndex = 22;
            this.lblTitulo6.Text = "Total de categoria";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BorderAll;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 72;
            this.iconPictureBox3.Location = new System.Drawing.Point(535, 30);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(83, 72);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblTotalProductoVendidos
            // 
            this.lblTotalProductoVendidos.AutoSize = true;
            this.lblTotalProductoVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductoVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalProductoVendidos.Location = new System.Drawing.Point(350, 62);
            this.lblTotalProductoVendidos.Name = "lblTotalProductoVendidos";
            this.lblTotalProductoVendidos.Size = new System.Drawing.Size(23, 25);
            this.lblTotalProductoVendidos.TabIndex = 20;
            this.lblTotalProductoVendidos.Text = "0";
            // 
            // lblTItulo5
            // 
            this.lblTItulo5.AutoSize = true;
            this.lblTItulo5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTItulo5.Location = new System.Drawing.Point(350, 49);
            this.lblTItulo5.Name = "lblTItulo5";
            this.lblTItulo5.Size = new System.Drawing.Size(137, 13);
            this.lblTItulo5.TabIndex = 19;
            this.lblTItulo5.Text = "Total de producto vendidos";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 74;
            this.iconPictureBox2.Location = new System.Drawing.Point(261, 30);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(83, 74);
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalVentas.Location = new System.Drawing.Point(95, 62);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(23, 25);
            this.lblTotalVentas.TabIndex = 17;
            this.lblTotalVentas.Text = "0";
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo4.Location = new System.Drawing.Point(95, 49);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(81, 13);
            this.lblTitulo4.TabIndex = 11;
            this.lblTitulo4.Text = "Total de ventas";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 74;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 30);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(83, 74);
            this.iconPictureBox1.TabIndex = 16;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(72, 18);
            this.lblTitulo3.TabIndex = 14;
            this.lblTitulo3.Text = "Resumen";
            // 
            // chProductosMasVendidos
            // 
            chartArea6.Name = "ChartArea1";
            this.chProductosMasVendidos.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chProductosMasVendidos.Legends.Add(legend6);
            this.chProductosMasVendidos.Location = new System.Drawing.Point(19, 41);
            this.chProductosMasVendidos.Name = "chProductosMasVendidos";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chProductosMasVendidos.Series.Add(series6);
            this.chProductosMasVendidos.Size = new System.Drawing.Size(497, 233);
            this.chProductosMasVendidos.TabIndex = 13;
            this.chProductosMasVendidos.Text = "chart1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(535, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Búscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmInformeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblInforme);
            this.Controls.Add(this.pnlInforme);
            this.Controls.Add(this.pnlProdVent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeProducto";
            this.Text = "drmInforme";
            this.Load += new System.EventHandler(this.frmInformeProducto_Load_1);
            this.pnlInforme.ResumeLayout(false);
            this.pnlInforme.PerformLayout();
            this.pnlProdVent.ResumeLayout(false);
            this.pnlProdVent.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDistribucionCategoria)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProductosMasVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Panel pnlInforme;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel pnlProdVent;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTotalCategoria;
        private System.Windows.Forms.Label lblTitulo6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label lblTotalProductoVendidos;
        private System.Windows.Forms.Label lblTItulo5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblTitulo4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chDistribucionCategoria;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProductosMasVendidos;
        private System.Windows.Forms.Button btnBuscar;
    }
}