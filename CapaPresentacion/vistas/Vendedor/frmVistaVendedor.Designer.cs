namespace CapaPresentacion.Vistas.Vendedor
{
    partial class frmVistaVendedor
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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiConsultarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.pntCabecera = new System.Windows.Forms.Panel();
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
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
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(960, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegistrarVenta,
            this.consultarVenta});
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconMenuItem1.IconColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(66, 38);
            this.iconMenuItem1.Text = "Venta";
            // 
            // tsmiRegistrarVenta
            // 
            this.tsmiRegistrarVenta.Name = "tsmiRegistrarVenta";
            this.tsmiRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.tsmiRegistrarVenta.Text = "Registrar venta";
            this.tsmiRegistrarVenta.Click += new System.EventHandler(this.tsmiRegistrarVenta_Click);
            // 
            // consultarVenta
            // 
            this.consultarVenta.Name = "consultarVenta";
            this.consultarVenta.Size = new System.Drawing.Size(180, 22);
            this.consultarVenta.Text = "Consultar venta";
            this.consultarVenta.Click += new System.EventHandler(this.consultarVenta_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaCliente,
            this.tsmiListarCliente,
            this.tsmiEditarCliente});
            this.iconMenuItem2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem2.IconColor = System.Drawing.Color.White;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem2.Size = new System.Drawing.Size(73, 38);
            this.iconMenuItem2.Text = "Cliente";
            // 
            // tsmiAltaCliente
            // 
            this.tsmiAltaCliente.Name = "tsmiAltaCliente";
            this.tsmiAltaCliente.Size = new System.Drawing.Size(134, 22);
            this.tsmiAltaCliente.Text = "Registrar";
            this.tsmiAltaCliente.Click += new System.EventHandler(this.tsmiAltaCliente_Click);
            // 
            // tsmiListarCliente
            // 
            this.tsmiListarCliente.Name = "tsmiListarCliente";
            this.tsmiListarCliente.Size = new System.Drawing.Size(134, 22);
            this.tsmiListarCliente.Text = "Consultar";
            this.tsmiListarCliente.Click += new System.EventHandler(this.tsmiListarCliente_Click);
            // 
            // tsmiEditarCliente
            // 
            this.tsmiEditarCliente.Name = "tsmiEditarCliente";
            this.tsmiEditarCliente.Size = new System.Drawing.Size(134, 22);
            this.tsmiEditarCliente.Text = "Editar";
            this.tsmiEditarCliente.Click += new System.EventHandler(this.tsmiEditarCliente_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsultarProd});
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconMenuItem3.IconColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem3.Size = new System.Drawing.Size(88, 38);
            this.iconMenuItem3.Text = "Producto";
            // 
            // tsmiConsultarProd
            // 
            this.tsmiConsultarProd.Name = "tsmiConsultarProd";
            this.tsmiConsultarProd.Size = new System.Drawing.Size(194, 22);
            this.tsmiConsultarProd.Text = "Consultar producto";
            this.tsmiConsultarProd.Click += new System.EventHandler(this.tsmiConsultarProd_Click);
            // 
            // pntCabecera
            // 
            this.pntCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(37)))));
            this.pntCabecera.Controls.Add(this.iconBtnSalir);
            this.pntCabecera.Controls.Add(this.lblNombre);
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
            this.iconBtnSalir.Location = new System.Drawing.Point(855, 20);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Size = new System.Drawing.Size(93, 41);
            this.iconBtnSalir.TabIndex = 15;
            this.iconBtnSalir.Text = "Salir";
            this.iconBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSalir.UseVisualStyleBackColor = false;
            this.iconBtnSalir.Click += new System.EventHandler(this.iconBtnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(647, 30);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "nombreCompleto";
            // 
            // lblTituloAdm
            // 
            this.lblTituloAdm.AutoSize = true;
            this.lblTituloAdm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAdm.ForeColor = System.Drawing.Color.White;
            this.lblTituloAdm.Location = new System.Drawing.Point(564, 30);
            this.lblTituloAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAdm.Name = "lblTituloAdm";
            this.lblTituloAdm.Size = new System.Drawing.Size(79, 19);
            this.lblTituloAdm.TabIndex = 11;
            this.lblTituloAdm.Text = "Vendedor:";
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
            // frmVistaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pntCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmVistaVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVistaVendedor";
            this.Load += new System.EventHandler(this.frmVistaVendedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pntCabecera.ResumeLayout(false);
            this.pntCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiListarCliente;
        private System.Windows.Forms.Panel pntCabecera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTituloAdm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem consultarVenta;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarProd;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarCliente;
    }
}