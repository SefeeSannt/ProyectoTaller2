namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmRegistroVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.dgvRegistroVenta = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.gbInfProducto = new System.Windows.Forms.GroupBox();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.numUpDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.gbInforProveedor = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txtNumCliente = new System.Windows.Forms.TextBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTutulo = new System.Windows.Forms.Label();
            this.gbInfCompra = new System.Windows.Forms.GroupBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarP = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVenta)).BeginInit();
            this.gbInfProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCantidad)).BeginInit();
            this.gbInforProveedor.SuspendLayout();
            this.gbInfCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Blue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnRegistrar.IconColor = System.Drawing.Color.White;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 30;
            this.btnRegistrar.Location = new System.Drawing.Point(816, 475);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 51);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Finalizar compra";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalPagar.Location = new System.Drawing.Point(816, 440);
            this.txtTotalPagar.Multiline = true;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(132, 29);
            this.txtTotalPagar.TabIndex = 16;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.Enter += new System.EventHandler(this.txtTotalPagar_Enter);
            this.txtTotalPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noWrite_KeyPress);
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(813, 420);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(83, 17);
            this.lblTotalPagar.TabIndex = 19;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // dgvRegistroVenta
            // 
            this.dgvRegistroVenta.AllowUserToAddRows = false;
            this.dgvRegistroVenta.AllowUserToDeleteRows = false;
            this.dgvRegistroVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistroVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistroVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVenta.EnableHeadersVisualStyles = false;
            this.dgvRegistroVenta.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvRegistroVenta.Location = new System.Drawing.Point(7, 269);
            this.dgvRegistroVenta.Name = "dgvRegistroVenta";
            this.dgvRegistroVenta.ReadOnly = true;
            this.dgvRegistroVenta.RowHeadersVisible = false;
            this.dgvRegistroVenta.Size = new System.Drawing.Size(800, 257);
            this.dgvRegistroVenta.TabIndex = 18;
            this.dgvRegistroVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVenta_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.Green;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(821, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 78);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbInfProducto
            // 
            this.gbInfProducto.Controls.Add(this.txtProductoNombre);
            this.gbInfProducto.Controls.Add(this.txtPrecio);
            this.gbInfProducto.Controls.Add(this.lblPrecioVenta);
            this.gbInfProducto.Controls.Add(this.numUpDCantidad);
            this.gbInfProducto.Controls.Add(this.lblCantidad);
            this.gbInfProducto.Controls.Add(this.txtCodProducto);
            this.gbInfProducto.Controls.Add(this.lblProductos);
            this.gbInfProducto.Controls.Add(this.lblCodProducto);
            this.gbInfProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfProducto.Location = new System.Drawing.Point(11, 132);
            this.gbInfProducto.Name = "gbInfProducto";
            this.gbInfProducto.Size = new System.Drawing.Size(795, 87);
            this.gbInfProducto.TabIndex = 14;
            this.gbInfProducto.TabStop = false;
            this.gbInfProducto.Text = "Información de Producto";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProductoNombre.Location = new System.Drawing.Point(121, 59);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.ReadOnly = true;
            this.txtProductoNombre.Size = new System.Drawing.Size(127, 22);
            this.txtProductoNombre.TabIndex = 14;
            this.txtProductoNombre.TabStop = false;
            this.txtProductoNombre.Enter += new System.EventHandler(this.txtProductoNombre_Enter);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPrecio.Location = new System.Drawing.Point(383, 59);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(114, 22);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(380, 39);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(46, 17);
            this.lblPrecioVenta.TabIndex = 11;
            this.lblPrecioVenta.Text = "Precio:";
            // 
            // numUpDCantidad
            // 
            this.numUpDCantidad.Location = new System.Drawing.Point(503, 60);
            this.numUpDCantidad.Name = "numUpDCantidad";
            this.numUpDCantidad.Size = new System.Drawing.Size(120, 22);
            this.numUpDCantidad.TabIndex = 9;
            this.numUpDCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(500, 39);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 17);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Unidades:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCodProducto.Location = new System.Drawing.Point(19, 58);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(83, 22);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.TabStop = false;
            this.txtCodProducto.Enter += new System.EventHandler(this.txtCodProducto_Enter);
            this.txtCodProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(118, 39);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 17);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Producto";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProducto.Location = new System.Drawing.Point(16, 37);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(86, 17);
            this.lblCodProducto.TabIndex = 0;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // gbInforProveedor
            // 
            this.gbInforProveedor.Controls.Add(this.txtNombreCliente);
            this.gbInforProveedor.Controls.Add(this.lblNombreProveedor);
            this.gbInforProveedor.Controls.Add(this.txtNumCliente);
            this.gbInforProveedor.Controls.Add(this.lblNumDoc);
            this.gbInforProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInforProveedor.Location = new System.Drawing.Point(386, 42);
            this.gbInforProveedor.Name = "gbInforProveedor";
            this.gbInforProveedor.Size = new System.Drawing.Size(421, 87);
            this.gbInforProveedor.TabIndex = 15;
            this.gbInforProveedor.TabStop = false;
            this.gbInforProveedor.Text = "Información Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombreCliente.Location = new System.Drawing.Point(173, 55);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(129, 23);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.TabStop = false;
            this.txtNombreCliente.Enter += new System.EventHandler(this.txtNombreProv_Enter);
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(170, 35);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(55, 17);
            this.lblNombreProveedor.TabIndex = 3;
            this.lblNombreProveedor.Text = "Nombre:";
            // 
            // txtNumCliente
            // 
            this.txtNumCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNumCliente.Location = new System.Drawing.Point(19, 55);
            this.txtNumCliente.Multiline = true;
            this.txtNumCliente.Name = "txtNumCliente";
            this.txtNumCliente.ReadOnly = true;
            this.txtNumCliente.Size = new System.Drawing.Size(129, 23);
            this.txtNumCliente.TabIndex = 2;
            this.txtNumCliente.TabStop = false;
            this.txtNumCliente.Enter += new System.EventHandler(this.txtNumProv_Enter);
            this.txtNumCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(16, 35);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(121, 17);
            this.lblNumDoc.TabIndex = 0;
            this.lblNumDoc.Text = "Número documento:";
            // 
            // lblTutulo
            // 
            this.lblTutulo.AutoSize = true;
            this.lblTutulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutulo.Location = new System.Drawing.Point(2, 11);
            this.lblTutulo.Name = "lblTutulo";
            this.lblTutulo.Size = new System.Drawing.Size(151, 26);
            this.lblTutulo.TabIndex = 13;
            this.lblTutulo.Text = "Registrar Venta";
            // 
            // gbInfCompra
            // 
            this.gbInfCompra.Controls.Add(this.dtpFechaCompra);
            this.gbInfCompra.Controls.Add(this.lblFecha);
            this.gbInfCompra.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfCompra.Location = new System.Drawing.Point(11, 42);
            this.gbInfCompra.Name = "gbInfCompra";
            this.gbInfCompra.Size = new System.Drawing.Size(355, 87);
            this.gbInfCompra.TabIndex = 12;
            this.gbInfCompra.TabStop = false;
            this.gbInfCompra.Text = "Información Venta";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Location = new System.Drawing.Point(19, 53);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCompra.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 17);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Green;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.IconSize = 25;
            this.btnAgregarCliente.Location = new System.Drawing.Point(821, 49);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 80);
            this.btnAgregarCliente.TabIndex = 21;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnRegistrarP
            // 
            this.btnRegistrarP.BackColor = System.Drawing.Color.Green;
            this.btnRegistrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarP.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarP.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnRegistrarP.IconColor = System.Drawing.Color.White;
            this.btnRegistrarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarP.IconSize = 15;
            this.btnRegistrarP.Location = new System.Drawing.Point(682, 225);
            this.btnRegistrarP.Name = "btnRegistrarP";
            this.btnRegistrarP.Size = new System.Drawing.Size(125, 38);
            this.btnRegistrarP.TabIndex = 22;
            this.btnRegistrarP.Text = "Añadir producto";
            this.btnRegistrarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarP.UseVisualStyleBackColor = false;
            this.btnRegistrarP.Click += new System.EventHandler(this.btnRegistrarP_Click);
            // 
            // frmRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.btnRegistrarP);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.dgvRegistroVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbInfProducto);
            this.Controls.Add(this.gbInforProveedor);
            this.Controls.Add(this.lblTutulo);
            this.Controls.Add(this.gbInfCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroVenta";
            this.Text = "frmRegitroCompraRepositor";
            this.Load += new System.EventHandler(this.frmRegitroVentaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVenta)).EndInit();
            this.gbInfProducto.ResumeLayout(false);
            this.gbInfProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDCantidad)).EndInit();
            this.gbInforProveedor.ResumeLayout(false);
            this.gbInforProveedor.PerformLayout();
            this.gbInfCompra.ResumeLayout(false);
            this.gbInfCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.DataGridView dgvRegistroVenta;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.GroupBox gbInfProducto;
        private System.Windows.Forms.NumericUpDown numUpDCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.GroupBox gbInforProveedor;
        private System.Windows.Forms.TextBox txtNumCliente;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTutulo;
        private System.Windows.Forms.GroupBox gbInfCompra;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecio;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtProductoNombre;
        private FontAwesome.Sharp.IconButton btnRegistrarP;
    }
}