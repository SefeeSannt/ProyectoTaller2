namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmVistaRepositor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IcMenuItemCompra = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiComprar = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmAltaProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.pntCabecera = new System.Windows.Forms.Panel();
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.lblNombreRegistro = new System.Windows.Forms.Label();
            this.lblTituloAdm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pntCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(166)))), ((int)(((byte)(54)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IcMenuItemCompra,
            this.iconMenuItem1,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(960, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IcMenuItemCompra
            // 
            this.IcMenuItemCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarCompra,
            this.tsmiConsultarCompra});
            this.IcMenuItemCompra.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcMenuItemCompra.ForeColor = System.Drawing.Color.White;
            this.IcMenuItemCompra.IconChar = FontAwesome.Sharp.IconChar.BagShopping;
            this.IcMenuItemCompra.IconColor = System.Drawing.Color.White;
            this.IcMenuItemCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcMenuItemCompra.IconSize = 50;
            this.IcMenuItemCompra.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.IcMenuItemCompra.Name = "IcMenuItemCompra";
            this.IcMenuItemCompra.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.IcMenuItemCompra.Size = new System.Drawing.Size(80, 38);
            this.IcMenuItemCompra.Text = "Compra";
            // 
            // tsmiRegistrarCompra
            // 
            this.tsmiRegistrarCompra.Name = "tsmiRegistrarCompra";
            this.tsmiRegistrarCompra.Size = new System.Drawing.Size(184, 22);
            this.tsmiRegistrarCompra.Text = "Registrar compra";
            this.tsmiRegistrarCompra.Click += new System.EventHandler(this.tsmiRegistrarCompra_Click);
            // 
            // tsmiConsultarCompra
            // 
            this.tsmiConsultarCompra.Name = "tsmiConsultarCompra";
            this.tsmiConsultarCompra.Size = new System.Drawing.Size(184, 22);
            this.tsmiConsultarCompra.Text = "Consultar compra";
            this.tsmiConsultarCompra.Click += new System.EventHandler(this.tsmiConsultarCompra_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiComprar});
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.iconMenuItem1.IconColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(65, 38);
            this.iconMenuItem1.Text = "Stock";
            // 
            // tsmiComprar
            // 
            this.tsmiComprar.Name = "tsmiComprar";
            this.tsmiComprar.Size = new System.Drawing.Size(180, 22);
            this.tsmiComprar.Text = "Consultar stock";
            this.tsmiComprar.Click += new System.EventHandler(this.tsmiComprar_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAltaProveedor,
            this.tsmiConsultarProveedores});
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconMenuItem3.IconColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem3.Size = new System.Drawing.Size(95, 38);
            this.iconMenuItem3.Text = "Proveedor";
            // 
            // tsmAltaProveedor
            // 
            this.tsmAltaProveedor.Name = "tsmAltaProveedor";
            this.tsmAltaProveedor.Size = new System.Drawing.Size(214, 22);
            this.tsmAltaProveedor.Text = "Dar alta";
            this.tsmAltaProveedor.Click += new System.EventHandler(this.tsmAltaProveedor_Click);
            // 
            // tsmiConsultarProveedores
            // 
            this.tsmiConsultarProveedores.Name = "tsmiConsultarProveedores";
            this.tsmiConsultarProveedores.Size = new System.Drawing.Size(214, 22);
            this.tsmiConsultarProveedores.Text = "Consultar proveedores";
            this.tsmiConsultarProveedores.Click += new System.EventHandler(this.tsmiConsultarProveedores_Click);
            // 
            // pntCabecera
            // 
            this.pntCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(37)))));
            this.pntCabecera.Controls.Add(this.iconBtnSalir);
            this.pntCabecera.Controls.Add(this.lblNombreRegistro);
            this.pntCabecera.Controls.Add(this.lblTituloAdm);
            this.pntCabecera.Controls.Add(this.lblTitulo);
            this.pntCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntCabecera.Location = new System.Drawing.Point(0, 0);
            this.pntCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pntCabecera.Name = "pntCabecera";
            this.pntCabecera.Size = new System.Drawing.Size(960, 70);
            this.pntCabecera.TabIndex = 11;
            // 
            // iconBtnSalir
            // 
            this.iconBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(37)))));
            this.iconBtnSalir.FlatAppearance.BorderSize = 0;
            this.iconBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSalir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSalir.ForeColor = System.Drawing.Color.White;
            this.iconBtnSalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconBtnSalir.IconColor = System.Drawing.Color.White;
            this.iconBtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSalir.IconSize = 35;
            this.iconBtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnSalir.Location = new System.Drawing.Point(848, 14);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Size = new System.Drawing.Size(93, 41);
            this.iconBtnSalir.TabIndex = 13;
            this.iconBtnSalir.Text = "Salir";
            this.iconBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSalir.UseVisualStyleBackColor = false;
            this.iconBtnSalir.Click += new System.EventHandler(this.iconBtnSalir_Click);
            // 
            // lblNombreRegistro
            // 
            this.lblNombreRegistro.AutoSize = true;
            this.lblNombreRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRegistro.ForeColor = System.Drawing.Color.White;
            this.lblNombreRegistro.Location = new System.Drawing.Point(684, 24);
            this.lblNombreRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRegistro.Name = "lblNombreRegistro";
            this.lblNombreRegistro.Size = new System.Drawing.Size(129, 19);
            this.lblNombreRegistro.TabIndex = 12;
            this.lblNombreRegistro.Text = "nombreCompleto";
            // 
            // lblTituloAdm
            // 
            this.lblTituloAdm.AutoSize = true;
            this.lblTituloAdm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdm.ForeColor = System.Drawing.Color.White;
            this.lblTituloAdm.Location = new System.Drawing.Point(601, 24);
            this.lblTituloAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAdm.Name = "lblTituloAdm";
            this.lblTituloAdm.Size = new System.Drawing.Size(75, 19);
            this.lblTituloAdm.TabIndex = 11;
            this.lblTituloAdm.Text = "Repositor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(183, 29);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Tienda zonafitt";
            // 
            // frmVistaRepositor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pntCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmVistaRepositor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaRepositor";
            this.Load += new System.EventHandler(this.frmVistaRepositor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pntCabecera.ResumeLayout(false);
            this.pntCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiComprar;
        private FontAwesome.Sharp.IconMenuItem IcMenuItemCompra;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarCompra;
        private System.Windows.Forms.Panel pntCabecera;
        private System.Windows.Forms.Label lblNombreRegistro;
        private System.Windows.Forms.Label lblTituloAdm;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarProveedores;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarCompra;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmAltaProveedor;
    }
}