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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloCosto = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.TextBox();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultaCompra = new System.Windows.Forms.DataGridView();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtDniProv = new System.Windows.Forms.TextBox();
            this.lblClienteConsVentas = new System.Windows.Forms.Label();
            this.lblDniProveedor = new System.Windows.Forms.Label();
            this.lblApellidoProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.EnableHeadersVisualStyles = false;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(-1, 106);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersVisible = false;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(463, 308);
            this.dgvDetalleCompra.TabIndex = 0;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCompra.EnableHeadersVisualStyles = false;
            this.dgvConsultaCompra.Location = new System.Drawing.Point(15, 252);
            this.dgvConsultaCompra.Name = "dgvConsultaCompra";
            this.dgvConsultaCompra.ReadOnly = true;
            this.dgvConsultaCompra.RowHeadersVisible = false;
            this.dgvConsultaCompra.Size = new System.Drawing.Size(451, 226);
            this.dgvConsultaCompra.TabIndex = 34;
            this.dgvConsultaCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaCompra_CellContentClick);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(217, 31);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(159, 20);
            this.dtpFechaHasta.TabIndex = 16;
            this.dtpFechaHasta.TabStop = false;
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(11, 31);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(159, 20);
            this.dtpFechaDesde.TabIndex = 13;
            this.dtpFechaDesde.TabStop = false;
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
            // txtDniProv
            // 
            this.txtDniProv.Location = new System.Drawing.Point(11, 95);
            this.txtDniProv.Name = "txtDniProv";
            this.txtDniProv.Size = new System.Drawing.Size(159, 20);
            this.txtDniProv.TabIndex = 11;
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
            // lblDniProveedor
            // 
            this.lblDniProveedor.AutoSize = true;
            this.lblDniProveedor.BackColor = System.Drawing.Color.White;
            this.lblDniProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniProveedor.Location = new System.Drawing.Point(12, 69);
            this.lblDniProveedor.Name = "lblDniProveedor";
            this.lblDniProveedor.Size = new System.Drawing.Size(84, 17);
            this.lblDniProveedor.TabIndex = 21;
            this.lblDniProveedor.Text = "dni proveedor";
            // 
            // lblApellidoProveedor
            // 
            this.lblApellidoProveedor.AutoSize = true;
            this.lblApellidoProveedor.BackColor = System.Drawing.Color.White;
            this.lblApellidoProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoProveedor.Location = new System.Drawing.Point(13, 52);
            this.lblApellidoProveedor.Name = "lblApellidoProveedor";
            this.lblApellidoProveedor.Size = new System.Drawing.Size(111, 17);
            this.lblApellidoProveedor.TabIndex = 20;
            this.lblApellidoProveedor.Text = "apellido proveedor";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.BackColor = System.Drawing.Color.White;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 35);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(110, 17);
            this.lblNombreProveedor.TabIndex = 19;
            this.lblNombreProveedor.Text = "nombre proveedor";
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
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.lblfechaHasta);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.lblFechaDesde);
            this.panel1.Controls.Add(this.txtDniProv);
            this.panel1.Controls.Add(this.lblClienteConsVentas);
            this.panel1.Location = new System.Drawing.Point(15, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 183);
            this.panel1.TabIndex = 29;
            // 
            // pnlConsultaVentas2
            // 
            this.pnlConsultaVentas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsultaVentas2.Controls.Add(this.lblDniProveedor);
            this.pnlConsultaVentas2.Controls.Add(this.lblApellidoProveedor);
            this.pnlConsultaVentas2.Controls.Add(this.lblNombreProveedor);
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
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
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
        private System.Windows.Forms.Label lblTotalVentaFilt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTituloCosto;
        private System.Windows.Forms.TextBox lblCostoTotal;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultaCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblfechaHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtDniProv;
        private System.Windows.Forms.Label lblClienteConsVentas;
        private System.Windows.Forms.Label lblDniProveedor;
        private System.Windows.Forms.Label lblApellidoProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDetalleCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlConsultaVentas2;
        private System.Windows.Forms.Button button1;
    }
}