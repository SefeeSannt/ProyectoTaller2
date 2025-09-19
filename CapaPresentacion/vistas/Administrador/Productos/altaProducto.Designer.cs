using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Administrador.Productos
{
    partial class frmAltaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTituloListaProd = new System.Windows.Forms.Label();
            this.dgvRegistrarProducto = new System.Windows.Forms.DataGridView();
            this.lblRegistroProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStockProd = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.cboCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lblRegistrarProducto = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.txtCostoProd = new System.Windows.Forms.TextBox();
            this.cbFiltrarListProd = new System.Windows.Forms.ComboBox();
            this.txtProdList = new System.Windows.Forms.TextBox();
            this.lblFiltroListProd = new System.Windows.Forms.Label();
            this.lblBuscarListProd = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigoProdRegistro = new System.Windows.Forms.Label();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoListProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionRegProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockRegProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-157, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Detalle usuario";
            // 
            // lblTituloListaProd
            // 
            this.lblTituloListaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloListaProd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaProd.ForeColor = System.Drawing.Color.White;
            this.lblTituloListaProd.Location = new System.Drawing.Point(243, 0);
            this.lblTituloListaProd.Name = "lblTituloListaProd";
            this.lblTituloListaProd.Size = new System.Drawing.Size(717, 42);
            this.lblTituloListaProd.TabIndex = 26;
            this.lblTituloListaProd.Text = "Lista de Productos";
            this.lblTituloListaProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRegistrarProducto
            // 
            this.dgvRegistrarProducto.AllowUserToAddRows = false;
            this.dgvRegistrarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrarProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistrarProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistrarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProducto,
            this.codigoListProd,
            this.categoria,
            this.descripcionRegProd,
            this.precioVenta,
            this.colCosto,
            this.stockRegProd});
            this.dgvRegistrarProducto.Location = new System.Drawing.Point(261, 112);
            this.dgvRegistrarProducto.MultiSelect = false;
            this.dgvRegistrarProducto.Name = "dgvRegistrarProducto";
            this.dgvRegistrarProducto.ReadOnly = true;
            this.dgvRegistrarProducto.RowHeadersVisible = false;
            this.dgvRegistrarProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRegistrarProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistrarProducto.RowTemplate.Height = 28;
            this.dgvRegistrarProducto.Size = new System.Drawing.Size(687, 414);
            this.dgvRegistrarProducto.TabIndex = 25;
            // 
            // lblRegistroProducto
            // 
            this.lblRegistroProducto.BackColor = System.Drawing.Color.White;
            this.lblRegistroProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistroProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRegistroProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRegistroProducto.Location = new System.Drawing.Point(0, 0);
            this.lblRegistroProducto.Name = "lblRegistroProducto";
            this.lblRegistroProducto.Size = new System.Drawing.Size(244, 538);
            this.lblRegistroProducto.TabIndex = 24;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.White;
            this.lblNombreProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(9, 62);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(124, 17);
            this.lblNombreProducto.TabIndex = 28;
            this.lblNombreProducto.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.White;
            this.lblCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 17);
            this.lblCategoria.TabIndex = 29;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 192);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 17);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.BackColor = System.Drawing.Color.White;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(11, 235);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(77, 17);
            this.lblPrecioVenta.TabIndex = 31;
            this.lblPrecioVenta.Text = "Precio venta";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.White;
            this.lblCosto.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(9, 278);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 17);
            this.lblCosto.TabIndex = 32;
            this.lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.White;
            this.lblStock.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(12, 331);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(39, 17);
            this.lblStock.TabIndex = 33;
            this.lblStock.Text = "Stock";
            // 
            // txtStockProd
            // 
            this.txtStockProd.Enabled = false;
            this.txtStockProd.Location = new System.Drawing.Point(12, 351);
            this.txtStockProd.Name = "txtStockProd";
            this.txtStockProd.ReadOnly = true;
            this.txtStockProd.Size = new System.Drawing.Size(211, 20);
            this.txtStockProd.TabIndex = 34;
            this.txtStockProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger_KeyPress);
            // 
            // txtPrecioVentaProd
            // 
            this.txtPrecioVentaProd.Enabled = false;
            this.txtPrecioVentaProd.Location = new System.Drawing.Point(12, 255);
            this.txtPrecioVentaProd.Name = "txtPrecioVentaProd";
            this.txtPrecioVentaProd.ReadOnly = true;
            this.txtPrecioVentaProd.Size = new System.Drawing.Size(211, 20);
            this.txtPrecioVentaProd.TabIndex = 35;
            this.txtPrecioVentaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(10, 82);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(210, 20);
            this.txtNombreProd.TabIndex = 38;
            // 
            // cboCategoriaProd
            // 
            this.cboCategoriaProd.FormattingEnabled = true;
            this.cboCategoriaProd.Items.AddRange(new object[] {
            "Pesas"});
            this.cboCategoriaProd.Location = new System.Drawing.Point(12, 168);
            this.cboCategoriaProd.Name = "cboCategoriaProd";
            this.cboCategoriaProd.Size = new System.Drawing.Size(211, 21);
            this.cboCategoriaProd.TabIndex = 39;
            this.cboCategoriaProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noWrite_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 16;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(211, 37);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(13, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 37);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRegistrarProducto
            // 
            this.lblRegistrarProducto.AutoSize = true;
            this.lblRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.lblRegistrarProducto.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarProducto.Location = new System.Drawing.Point(5, 14);
            this.lblRegistrarProducto.Name = "lblRegistrarProducto";
            this.lblRegistrarProducto.Size = new System.Drawing.Size(188, 28);
            this.lblRegistrarProducto.TabIndex = 43;
            this.lblRegistrarProducto.Text = "Registrar Producto";
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(12, 212);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(210, 20);
            this.txtDescripcionProd.TabIndex = 44;
            // 
            // txtCostoProd
            // 
            this.txtCostoProd.Enabled = false;
            this.txtCostoProd.Location = new System.Drawing.Point(12, 298);
            this.txtCostoProd.Name = "txtCostoProd";
            this.txtCostoProd.ReadOnly = true;
            this.txtCostoProd.Size = new System.Drawing.Size(210, 20);
            this.txtCostoProd.TabIndex = 45;
            this.txtCostoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers_KeyPress);
            // 
            // cbFiltrarListProd
            // 
            this.cbFiltrarListProd.FormattingEnabled = true;
            this.cbFiltrarListProd.Location = new System.Drawing.Point(709, 69);
            this.cbFiltrarListProd.Name = "cbFiltrarListProd";
            this.cbFiltrarListProd.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarListProd.TabIndex = 51;
            // 
            // txtProdList
            // 
            this.txtProdList.Location = new System.Drawing.Point(406, 71);
            this.txtProdList.Multiline = true;
            this.txtProdList.Name = "txtProdList";
            this.txtProdList.Size = new System.Drawing.Size(197, 19);
            this.txtProdList.TabIndex = 50;
            // 
            // lblFiltroListProd
            // 
            this.lblFiltroListProd.AutoSize = true;
            this.lblFiltroListProd.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroListProd.Location = new System.Drawing.Point(706, 52);
            this.lblFiltroListProd.Name = "lblFiltroListProd";
            this.lblFiltroListProd.Size = new System.Drawing.Size(43, 17);
            this.lblFiltroListProd.TabIndex = 49;
            this.lblFiltroListProd.Text = "Filtrar:";
            // 
            // lblBuscarListProd
            // 
            this.lblBuscarListProd.AutoSize = true;
            this.lblBuscarListProd.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarListProd.Location = new System.Drawing.Point(403, 55);
            this.lblBuscarListProd.Name = "lblBuscarListProd";
            this.lblBuscarListProd.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarListProd.TabIndex = 48;
            this.lblBuscarListProd.Text = "Buscar:";
            // 
            // iconBtnLupaDetalleUser
            // 
            this.iconBtnLupaDetalleUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconBtnLupaDetalleUser.FlatAppearance.BorderSize = 0;
            this.iconBtnLupaDetalleUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLupaDetalleUser.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnLupaDetalleUser.IconColor = System.Drawing.Color.White;
            this.iconBtnLupaDetalleUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLupaDetalleUser.IconSize = 19;
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(609, 71);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 21);
            this.iconBtnLupaDetalleUser.TabIndex = 47;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 53;
            // 
            // lblCodigoProdRegistro
            // 
            this.lblCodigoProdRegistro.AutoSize = true;
            this.lblCodigoProdRegistro.BackColor = System.Drawing.Color.White;
            this.lblCodigoProdRegistro.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProdRegistro.Location = new System.Drawing.Point(11, 105);
            this.lblCodigoProdRegistro.Name = "lblCodigoProdRegistro";
            this.lblCodigoProdRegistro.Size = new System.Drawing.Size(47, 17);
            this.lblCodigoProdRegistro.TabIndex = 52;
            this.lblCodigoProdRegistro.Text = "Codigo";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // codigoListProd
            // 
            this.codigoListProd.HeaderText = "Código";
            this.codigoListProd.Name = "codigoListProd";
            this.codigoListProd.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // descripcionRegProd
            // 
            this.descripcionRegProd.HeaderText = "Descripcion";
            this.descripcionRegProd.Name = "descripcionRegProd";
            this.descripcionRegProd.ReadOnly = true;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // stockRegProd
            // 
            this.stockRegProd.HeaderText = "Stock";
            this.stockRegProd.Name = "stockRegProd";
            this.stockRegProd.ReadOnly = true;
            // 
            // frmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCodigoProdRegistro);
            this.Controls.Add(this.cbFiltrarListProd);
            this.Controls.Add(this.txtProdList);
            this.Controls.Add(this.lblFiltroListProd);
            this.Controls.Add(this.lblBuscarListProd);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.txtCostoProd);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.lblRegistrarProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboCategoriaProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtPrecioVentaProd);
            this.Controls.Add(this.txtStockProd);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTituloListaProd);
            this.Controls.Add(this.dgvRegistrarProducto);
            this.Controls.Add(this.lblRegistroProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label11;
        private Label lblTituloListaProd;
        private DataGridView dgvRegistrarProducto;
        private Label lblRegistroProducto;
        private Label lblNombreProducto;
        private Label lblCategoria;
        private Label lblDescripcion;
        private Label lblPrecioVenta;
        private Label lblCosto;
        private Label lblStock;
        private TextBox txtStockProd;
        private TextBox txtPrecioVentaProd;
        private TextBox txtNombreProd;
        private ComboBox cboCategoriaProd;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblRegistrarProducto;
        private ErrorProvider errIngresoDatos;
        private TextBox txtCostoProd;
        private TextBox txtDescripcionProd;
        private ComboBox cbFiltrarListProd;
        private TextBox txtProdList;
        private Label lblFiltroListProd;
        private Label lblBuscarListProd;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn codigoListProd;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn descripcionRegProd;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn stockRegProd;
        private TextBox textBox1;
        private Label lblCodigoProdRegistro;
    }
}