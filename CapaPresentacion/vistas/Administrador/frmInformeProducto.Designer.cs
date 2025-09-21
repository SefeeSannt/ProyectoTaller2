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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblInforme = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlInforme = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlProdVent = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCat = new System.Windows.Forms.Label();
            this.lblTitulo6 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalProd = new System.Windows.Forms.Label();
            this.lblTItulo5 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.pnlInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chProductos)).BeginInit();
            this.pnlProdVent.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCategoria)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(541, 13);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(119, 17);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Filtrar por categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // pnlInforme
            // 
            this.pnlInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInforme.Controls.Add(this.lblProducto);
            this.pnlInforme.Controls.Add(this.dateTimePicker1);
            this.pnlInforme.Controls.Add(this.lblFecha);
            this.pnlInforme.Controls.Add(this.comboBox1);
            this.pnlInforme.Controls.Add(this.textBox1);
            this.pnlInforme.Controls.Add(this.lblCategoria);
            this.pnlInforme.Location = new System.Drawing.Point(17, 37);
            this.pnlInforme.Name = "pnlInforme";
            this.pnlInforme.Size = new System.Drawing.Size(920, 80);
            this.pnlInforme.TabIndex = 8;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 10;
            // 
            // chProductos
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.IsLabelAutoFit = false;
            chartArea1.AxisX2.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chProductos.Legends.Add(legend1);
            this.chProductos.Location = new System.Drawing.Point(19, 43);
            this.chProductos.Name = "chProductos";
            this.chProductos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Productos";
            this.chProductos.Series.Add(series1);
            this.chProductos.Size = new System.Drawing.Size(517, 228);
            this.chProductos.TabIndex = 9;
            this.chProductos.Text = "chart1";
            // 
            // pnlProdVent
            // 
            this.pnlProdVent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProdVent.Controls.Add(this.lblTitulo1);
            this.pnlProdVent.Controls.Add(this.chProductos);
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
            this.panel3.Controls.Add(this.chCategoria);
            this.panel3.Controls.Add(this.lblTitulo2);
            this.panel3.Location = new System.Drawing.Point(573, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 290);
            this.panel3.TabIndex = 12;
            // 
            // chCategoria
            // 
            chartArea2.Name = "ChartArea1";
            this.chCategoria.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chCategoria.Legends.Add(legend2);
            this.chCategoria.Location = new System.Drawing.Point(15, 42);
            this.chCategoria.Name = "chCategoria";
            this.chCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chCategoria.Series.Add(series2);
            this.chCategoria.Size = new System.Drawing.Size(300, 195);
            this.chCategoria.TabIndex = 14;
            this.chCategoria.Text = "chart2";
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
            this.panel4.Controls.Add(this.lblTotalCat);
            this.panel4.Controls.Add(this.lblTitulo6);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.lblTotalProd);
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
            // lblTotalCat
            // 
            this.lblTotalCat.AutoSize = true;
            this.lblTotalCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalCat.Location = new System.Drawing.Point(624, 62);
            this.lblTotalCat.Name = "lblTotalCat";
            this.lblTotalCat.Size = new System.Drawing.Size(23, 25);
            this.lblTotalCat.TabIndex = 23;
            this.lblTotalCat.Text = "0";
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
            // lblTotalProd
            // 
            this.lblTotalProd.AutoSize = true;
            this.lblTotalProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTotalProd.Location = new System.Drawing.Point(350, 62);
            this.lblTotalProd.Name = "lblTotalProd";
            this.lblTotalProd.Size = new System.Drawing.Size(23, 25);
            this.lblTotalProd.TabIndex = 20;
            this.lblTotalProd.Text = "0";
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
            this.pnlInforme.ResumeLayout(false);
            this.pnlInforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chProductos)).EndInit();
            this.pnlProdVent.ResumeLayout(false);
            this.pnlProdVent.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chCategoria)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlInforme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProductos;
        private System.Windows.Forms.Panel pnlProdVent;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTotalCat;
        private System.Windows.Forms.Label lblTitulo6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label lblTotalProd;
        private System.Windows.Forms.Label lblTItulo5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblTitulo4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chCategoria;
    }
}