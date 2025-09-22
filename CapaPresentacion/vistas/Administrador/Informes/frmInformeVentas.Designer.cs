namespace CapaPresentacion.vistas.Administrador
{
    partial class frmInformeVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblProdVendidos = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInformeVentas = new System.Windows.Forms.Label();
            this.pnlInfVentas = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCatProducto = new System.Windows.Forms.Label();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.chVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlInfVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chVentas)).BeginInit();
            this.pnlVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlResumen
            // 
            this.pnlResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResumen.Controls.Add(this.lblTotal);
            this.pnlResumen.Controls.Add(this.lblTitulo3);
            this.pnlResumen.Controls.Add(this.iconPictureBox3);
            this.pnlResumen.Controls.Add(this.lblProdVendidos);
            this.pnlResumen.Controls.Add(this.lblTitulo2);
            this.pnlResumen.Controls.Add(this.iconPictureBox2);
            this.pnlResumen.Controls.Add(this.lblTotalVentas);
            this.pnlResumen.Controls.Add(this.lblTitulo1);
            this.pnlResumen.Controls.Add(this.iconPictureBox1);
            this.pnlResumen.Controls.Add(this.label6);
            this.pnlResumen.Location = new System.Drawing.Point(599, 224);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(344, 290);
            this.pnlResumen.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotal.Location = new System.Drawing.Point(95, 245);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0";
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo3.Location = new System.Drawing.Point(95, 232);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(81, 13);
            this.lblTitulo3.TabIndex = 28;
            this.lblTitulo3.Text = "Total de ventas";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 72;
            this.iconPictureBox3.Location = new System.Drawing.Point(6, 213);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(83, 72);
            this.iconPictureBox3.TabIndex = 27;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblProdVendidos
            // 
            this.lblProdVendidos.AutoSize = true;
            this.lblProdVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdVendidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblProdVendidos.Location = new System.Drawing.Point(95, 156);
            this.lblProdVendidos.Name = "lblProdVendidos";
            this.lblProdVendidos.Size = new System.Drawing.Size(23, 25);
            this.lblProdVendidos.TabIndex = 20;
            this.lblProdVendidos.Text = "0";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo2.Location = new System.Drawing.Point(95, 143);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(137, 13);
            this.lblTitulo2.TabIndex = 19;
            this.lblTitulo2.Text = "Total de producto vendidos";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 74;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 122);
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
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo1.Location = new System.Drawing.Point(95, 49);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(81, 13);
            this.lblTitulo1.TabIndex = 11;
            this.lblTitulo1.Text = "Total de ventas";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resumen";
            // 
            // lblInformeVentas
            // 
            this.lblInformeVentas.AutoSize = true;
            this.lblInformeVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeVentas.Location = new System.Drawing.Point(18, 20);
            this.lblInformeVentas.Name = "lblInformeVentas";
            this.lblInformeVentas.Size = new System.Drawing.Size(167, 25);
            this.lblInformeVentas.TabIndex = 14;
            this.lblInformeVentas.Text = "Informe de ventas";
            // 
            // pnlInfVentas
            // 
            this.pnlInfVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfVentas.Controls.Add(this.btnFiltrar);
            this.pnlInfVentas.Controls.Add(this.dtpFechaHasta);
            this.pnlInfVentas.Controls.Add(this.lblFechaHasta);
            this.pnlInfVentas.Controls.Add(this.dtpFechaDesde);
            this.pnlInfVentas.Controls.Add(this.lblFecha);
            this.pnlInfVentas.Controls.Add(this.cbCategoria);
            this.pnlInfVentas.Controls.Add(this.lblCatProducto);
            this.pnlInfVentas.Controls.Add(this.txtCodProd);
            this.pnlInfVentas.Controls.Add(this.lblDni);
            this.pnlInfVentas.Controls.Add(this.txtDni);
            this.pnlInfVentas.Controls.Add(this.lblCodProducto);
            this.pnlInfVentas.Location = new System.Drawing.Point(23, 66);
            this.pnlInfVentas.Name = "pnlInfVentas";
            this.pnlInfVentas.Size = new System.Drawing.Size(920, 136);
            this.pnlInfVentas.TabIndex = 15;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(582, 91);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(142, 32);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaHasta.TabIndex = 20;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(139, 12);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(76, 17);
            this.lblFechaHasta.TabIndex = 19;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(19, 33);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaDesde.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 17);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha desde";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(329, 93);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(218, 21);
            this.cbCategoria.TabIndex = 14;
            this.cbCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCategoria_KeyPress);
            // 
            // lblCatProducto
            // 
            this.lblCatProducto.AutoSize = true;
            this.lblCatProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatProducto.Location = new System.Drawing.Point(326, 73);
            this.lblCatProducto.Name = "lblCatProducto";
            this.lblCatProducto.Size = new System.Drawing.Size(114, 17);
            this.lblCatProducto.TabIndex = 13;
            this.lblCatProducto.Text = "Categoria producto";
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(329, 32);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(218, 20);
            this.txtCodProd.TabIndex = 11;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(16, 73);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(84, 17);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI Vendedor";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(19, 94);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(244, 20);
            this.txtDni.TabIndex = 10;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_keyPress);
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(326, 12);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(98, 17);
            this.lblCodProducto.TabIndex = 6;
            this.lblCodProducto.Text = "Buscar producto";
            // 
            // chVentas
            // 
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX2.IsLabelAutoFit = false;
            chartArea3.AxisX2.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chVentas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chVentas.Legends.Add(legend3);
            this.chVentas.Location = new System.Drawing.Point(19, 43);
            this.chVentas.Name = "chVentas";
            this.chVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Productos";
            this.chVentas.Series.Add(series3);
            this.chVentas.Size = new System.Drawing.Size(517, 228);
            this.chVentas.TabIndex = 9;
            this.chVentas.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ventas";
            // 
            // pnlVentas
            // 
            this.pnlVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVentas.Controls.Add(this.label2);
            this.pnlVentas.Controls.Add(this.chVentas);
            this.pnlVentas.Location = new System.Drawing.Point(23, 224);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(570, 290);
            this.pnlVentas.TabIndex = 16;
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // frmInformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.lblInformeVentas);
            this.Controls.Add(this.pnlInfVentas);
            this.Controls.Add(this.pnlVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeVentas";
            this.Text = "frmInformeVentas";
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlInfVentas.ResumeLayout(false);
            this.pnlInfVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chVentas)).EndInit();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Label lblProdVendidos;
        private System.Windows.Forms.Label lblTitulo2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblTitulo1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInformeVentas;
        private System.Windows.Forms.Panel pnlInfVentas;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Label lblCatProducto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTitulo3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
    }
}