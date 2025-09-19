using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.Vistas.Vendedor
{
    partial class frmConsultaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblfechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtCliente_Ventas = new System.Windows.Forms.TextBox();
            this.lblClienteConsVentas = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalVentaFilt = new System.Windows.Forms.Label();
            this.lblTituloTotalVentas = new System.Windows.Forms.Label();
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.clienteConsVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagoConsVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConsultaVentas2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.pnlConsultaVentas2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 183);
            this.panel1.TabIndex = 0;
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
            this.lblClienteConsVentas.Size = new System.Drawing.Size(71, 17);
            this.lblClienteConsVentas.TabIndex = 8;
            this.lblClienteConsVentas.Text = "DNI cliente:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 462);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta Ventas";
            // 
            // lblTotalVentaFilt
            // 
            this.lblTotalVentaFilt.AutoSize = true;
            this.lblTotalVentaFilt.BackColor = System.Drawing.Color.White;
            this.lblTotalVentaFilt.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentaFilt.Location = new System.Drawing.Point(139, 468);
            this.lblTotalVentaFilt.Name = "lblTotalVentaFilt";
            this.lblTotalVentaFilt.Size = new System.Drawing.Size(58, 23);
            this.lblTotalVentaFilt.TabIndex = 4;
            this.lblTotalVentaFilt.Text = "$0.00";
            // 
            // lblTituloTotalVentas
            // 
            this.lblTituloTotalVentas.AutoSize = true;
            this.lblTituloTotalVentas.BackColor = System.Drawing.Color.White;
            this.lblTituloTotalVentas.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalVentas.Location = new System.Drawing.Point(16, 474);
            this.lblTituloTotalVentas.Name = "lblTituloTotalVentas";
            this.lblTituloTotalVentas.Size = new System.Drawing.Size(126, 17);
            this.lblTituloTotalVentas.TabIndex = 5;
            this.lblTituloTotalVentas.Text = "Total ventas filtradas:";
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.AllowUserToAddRows = false;
            this.dgvConsultaVentas.AllowUserToDeleteRows = false;
            this.dgvConsultaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteConsVentas,
            this.formaPagoConsVenta,
            this.ventaTotal});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(12, 230);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.ReadOnly = true;
            this.dgvConsultaVentas.RowHeadersVisible = false;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(404, 226);
            this.dgvConsultaVentas.TabIndex = 15;
            // 
            // clienteConsVentas
            // 
            this.clienteConsVentas.HeaderText = "Cliente";
            this.clienteConsVentas.Name = "clienteConsVentas";
            this.clienteConsVentas.ReadOnly = true;
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
            // pnlConsultaVentas2
            // 
            this.pnlConsultaVentas2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsultaVentas2.Controls.Add(this.textBox2);
            this.pnlConsultaVentas2.Controls.Add(this.label3);
            this.pnlConsultaVentas2.Controls.Add(this.label2);
            this.pnlConsultaVentas2.Controls.Add(this.textBox1);
            this.pnlConsultaVentas2.Controls.Add(this.dataGridView1);
            this.pnlConsultaVentas2.Location = new System.Drawing.Point(445, 41);
            this.pnlConsultaVentas2.Name = "pnlConsultaVentas2";
            this.pnlConsultaVentas2.Size = new System.Drawing.Size(503, 459);
            this.pnlConsultaVentas2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProducto,
            this.clmCant,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.Location = new System.Drawing.Point(440, 9);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(140, 28);
            this.lblDetalleVenta.TabIndex = 18;
            this.lblDetalleVenta.Text = "Detalle Venta";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 19;
            // 
            // frmConsultaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.lblTotalVentaFilt);
            this.Controls.Add(this.lblTituloTotalVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlConsultaVentas2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaVenta";
            this.Text = "frmConsultaVenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.pnlConsultaVentas2.ResumeLayout(false);
            this.pnlConsultaVentas2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalVentaFilt;
        private System.Windows.Forms.Label lblTituloTotalVentas;
        private System.Windows.Forms.Label lblClienteConsVentas;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtCliente_Ventas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblfechaHasta;
        private System.Windows.Forms.Panel pnlConsultaVentas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteConsVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagoConsVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}