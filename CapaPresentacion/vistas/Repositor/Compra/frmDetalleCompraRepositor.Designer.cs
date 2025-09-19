namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmDetalleCompraRepositor
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
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.codProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo2 = new System.Windows.Forms.Label();
            this.lblDatoSocial = new System.Windows.Forms.Label();
            this.lblDatoDoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDatoFecha = new System.Windows.Forms.Label();
            this.lblDatoNum = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(498, 504);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(70, 25);
            this.lblTotalNum.TabIndex = 28;
            this.lblTotalNum.Text = "$0.00";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProd,
            this.nomProducto,
            this.precioCompra,
            this.precioVenta,
            this.cantidad});
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 267);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.Size = new System.Drawing.Size(548, 234);
            this.dgvDetalle.TabIndex = 27;
            // 
            // codProd
            // 
            this.codProd.HeaderText = "Código producto";
            this.codProd.Name = "codProd";
            this.codProd.ReadOnly = true;
            // 
            // nomProducto
            // 
            this.nomProducto.HeaderText = "Nombre producto";
            this.nomProducto.Name = "nomProducto";
            this.nomProducto.ReadOnly = true;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(12, 51);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(212, 21);
            this.lblSubTitulo.TabIndex = 26;
            this.lblSubTitulo.Text = "Información de la Compra";
            // 
            // lblSubTitulo2
            // 
            this.lblSubTitulo2.AutoSize = true;
            this.lblSubTitulo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo2.Location = new System.Drawing.Point(12, 229);
            this.lblSubTitulo2.Name = "lblSubTitulo2";
            this.lblSubTitulo2.Size = new System.Drawing.Size(208, 21);
            this.lblSubTitulo2.TabIndex = 25;
            this.lblSubTitulo2.Text = "Información de los Productos";
            // 
            // lblDatoSocial
            // 
            this.lblDatoSocial.AutoSize = true;
            this.lblDatoSocial.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoSocial.Location = new System.Drawing.Point(162, 191);
            this.lblDatoSocial.Name = "lblDatoSocial";
            this.lblDatoSocial.Size = new System.Drawing.Size(101, 17);
            this.lblDatoSocial.TabIndex = 24;
            this.lblDatoSocial.Text = "dato razon social";
            // 
            // lblDatoDoc
            // 
            this.lblDatoDoc.AutoSize = true;
            this.lblDatoDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDoc.Location = new System.Drawing.Point(162, 132);
            this.lblDatoDoc.Name = "lblDatoDoc";
            this.lblDatoDoc.Size = new System.Drawing.Size(56, 17);
            this.lblDatoDoc.TabIndex = 23;
            this.lblDatoDoc.Text = "dato doc";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(13, 162);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(138, 17);
            this.lblNumDoc.TabIndex = 22;
            this.lblNumDoc.Text = "Número de documento:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(13, 132);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(117, 17);
            this.lblTipoDoc.TabIndex = 21;
            this.lblTipoDoc.Text = "Tipo de documento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(13, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(13, 191);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(80, 17);
            this.lblRazonSocial.TabIndex = 19;
            this.lblRazonSocial.Text = "Razón social:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(348, 504);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // lblDatoFecha
            // 
            this.lblDatoFecha.AutoSize = true;
            this.lblDatoFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoFecha.Location = new System.Drawing.Point(162, 101);
            this.lblDatoFecha.Name = "lblDatoFecha";
            this.lblDatoFecha.Size = new System.Drawing.Size(67, 17);
            this.lblDatoFecha.TabIndex = 17;
            this.lblDatoFecha.Text = "dato fecha";
            // 
            // lblDatoNum
            // 
            this.lblDatoNum.AutoSize = true;
            this.lblDatoNum.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoNum.Location = new System.Drawing.Point(162, 162);
            this.lblDatoNum.Name = "lblDatoNum";
            this.lblDatoNum.Size = new System.Drawing.Size(79, 17);
            this.lblDatoNum.TabIndex = 16;
            this.lblDatoNum.Text = "dato numero";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(194, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 34);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Ver Detalle";
            // 
            // frmDetalleCompraRepositor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 538);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblSubTitulo2);
            this.Controls.Add(this.lblDatoSocial);
            this.Controls.Add(this.lblDatoDoc);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDatoFecha);
            this.Controls.Add(this.lblDatoNum);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleCompraRepositor";
            this.Text = "frmDetalleCompraRepositor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblSubTitulo2;
        private System.Windows.Forms.Label lblDatoSocial;
        private System.Windows.Forms.Label lblDatoDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDatoFecha;
        private System.Windows.Forms.Label lblDatoNum;
        private System.Windows.Forms.Label lblTitulo;
    }
}