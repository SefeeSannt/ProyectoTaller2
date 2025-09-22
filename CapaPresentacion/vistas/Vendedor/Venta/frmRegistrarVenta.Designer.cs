namespace CapaPresentacion.Vistas.Vendedor
{
    partial class frmRegistrarVenta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nudQty = new System.Windows.Forms.DomainUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.codigoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarFilaVenta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 489);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 37);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "$0.00";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(10, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 22);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Buscar";
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 15;
            this.iconButton6.Location = new System.Drawing.Point(400, 25);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(96, 23);
            this.iconButton6.TabIndex = 12;
            this.iconButton6.Text = "Borrar";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.producto,
            this.descripcion,
            this.precio,
            this.clmAccion});
            this.dgvResults.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvResults.Location = new System.Drawing.Point(10, 54);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.Size = new System.Drawing.Size(486, 207);
            this.dgvResults.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // clmAccion
            // 
            this.clmAccion.HeaderText = "Accion";
            this.clmAccion.Name = "clmAccion";
            this.clmAccion.ReadOnly = true;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(318, 26);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(76, 22);
            this.nudQty.TabIndex = 11;
            this.nudQty.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(312, 461);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.iconButton6);
            this.groupBox1.Controls.Add(this.dgvResults);
            this.groupBox1.Controls.Add(this.nudQty);
            this.groupBox1.Controls.Add(this.dgvSale);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 458);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(643, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 22);
            this.txtBuscar.TabIndex = 40;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(502, 57);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(420, 204);
            this.dgvClientes.TabIndex = 39;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 19;
            this.btnBuscar.Location = new System.Drawing.Point(840, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 32);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar cliente:";
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSale.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVenta,
            this.productoVenta,
            this.descripcionLista,
            this.precioVenta,
            this.cantidad,
            this.subtotal,
            this.eliminarFilaVenta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSale.Location = new System.Drawing.Point(10, 267);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.Size = new System.Drawing.Size(912, 185);
            this.dgvSale.TabIndex = 26;
            // 
            // codigoVenta
            // 
            this.codigoVenta.HeaderText = "Código";
            this.codigoVenta.Name = "codigoVenta";
            // 
            // productoVenta
            // 
            this.productoVenta.HeaderText = "Producto";
            this.productoVenta.Name = "productoVenta";
            // 
            // descripcionLista
            // 
            this.descripcionLista.HeaderText = "Descripción";
            this.descripcionLista.Name = "descripcionLista";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio";
            this.precioVenta.Name = "precioVenta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // eliminarFilaVenta
            // 
            this.eliminarFilaVenta.HeaderText = "";
            this.eliminarFilaVenta.Name = "eliminarFilaVenta";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 17;
            this.iconButton2.Location = new System.Drawing.Point(12, 489);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(128, 37);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "Cobrar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Red;
            this.btnCancelarVenta.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenta.Location = new System.Drawing.Point(163, 489);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(128, 37);
            this.btnCancelarVenta.TabIndex = 29;
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Datos del cliente:";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(681, 465);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(26, 15);
            this.lblDniCliente.TabIndex = 31;
            this.lblDniCliente.Text = "Dni";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(681, 489);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(681, 514);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Apellido";
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarVenta";
            this.Text = "frmRegistrarVenta";
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DomainUpDown nudQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarFilaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn clmAccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarVenta;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
    }
}