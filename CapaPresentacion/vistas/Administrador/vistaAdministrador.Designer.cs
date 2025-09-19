using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Administrador
{
    partial class frmVistaAdministrador
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
            this.Agregra = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pntCabecera = new System.Windows.Forms.Panel();
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.lblNombreRegistro = new System.Windows.Forms.Label();
            this.lblTituloAdm = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiListarProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAltaProd = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiAltaUsuario_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListarUsuarios_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.tsmiDetalleVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetalleCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregra.SuspendLayout();
            this.pntCabecera.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregra
            // 
            this.Agregra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.Agregra.Name = "Agregra";
            this.Agregra.Size = new System.Drawing.Size(110, 26);
            this.Agregra.Text = "Agregar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
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
            this.pntCabecera.TabIndex = 9;
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
            this.iconBtnSalir.Location = new System.Drawing.Point(864, 14);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Size = new System.Drawing.Size(93, 41);
            this.iconBtnSalir.TabIndex = 14;
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
            this.lblNombreRegistro.Location = new System.Drawing.Point(731, 24);
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
            this.lblTituloAdm.Location = new System.Drawing.Point(624, 24);
            this.lblTituloAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAdm.Name = "lblTituloAdm";
            this.lblTituloAdm.Size = new System.Drawing.Size(108, 19);
            this.lblTituloAdm.TabIndex = 11;
            this.lblTituloAdm.Text = "Administrador";
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(166)))), ((int)(((byte)(54)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem4,
            this.iconMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(960, 52);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiListarProd,
            this.tsmiAltaProd});
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconMenuItem1.IconColor = System.Drawing.Color.White;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem1.Size = new System.Drawing.Size(94, 38);
            this.iconMenuItem1.Text = "Productos";
            // 
            // tsmiListarProd
            // 
            this.tsmiListarProd.Name = "tsmiListarProd";
            this.tsmiListarProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiListarProd.Text = "Listar";
            this.tsmiListarProd.Click += new System.EventHandler(this.tsmiListarProd_Click);
            // 
            // tsmiAltaProd
            // 
            this.tsmiAltaProd.Name = "tsmiAltaProd";
            this.tsmiAltaProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiAltaProd.Text = "Dar de alta";
            this.tsmiAltaProd.Click += new System.EventHandler(this.tsmiAltaProd_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAltaUsuario_Click,
            this.tsmiListarUsuarios_Click});
            this.iconMenuItem4.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem4.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem4.IconColor = System.Drawing.Color.White;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Margin = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.iconMenuItem4.Size = new System.Drawing.Size(84, 38);
            this.iconMenuItem4.Text = "Usuarios";
            // 
            // tsmiAltaUsuario_Click
            // 
            this.tsmiAltaUsuario_Click.Name = "tsmiAltaUsuario_Click";
            this.tsmiAltaUsuario_Click.Size = new System.Drawing.Size(180, 22);
            this.tsmiAltaUsuario_Click.Text = "Dar de alta";
            this.tsmiAltaUsuario_Click.Click += new System.EventHandler(this.tsmiAltaUsuario_Click_Click);
            // 
            // tsmiListarUsuarios_Click
            // 
            this.tsmiListarUsuarios_Click.Name = "tsmiListarUsuarios_Click";
            this.tsmiListarUsuarios_Click.Size = new System.Drawing.Size(180, 22);
            this.tsmiListarUsuarios_Click.Text = "Listar";
            this.tsmiListarUsuarios_Click.Click += new System.EventHandler(this.tsmiListarUsuarios_Click_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDetalleVentas,
            this.tsmiDetalleCompras});
            this.iconMenuItem3.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem3.ForeColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.RectangleList;
            this.iconMenuItem3.IconColor = System.Drawing.Color.White;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(90, 38);
            this.iconMenuItem3.Text = "Reportes";
            // 
            // tsmiDetalleVentas
            // 
            this.tsmiDetalleVentas.Name = "tsmiDetalleVentas";
            this.tsmiDetalleVentas.Size = new System.Drawing.Size(194, 22);
            this.tsmiDetalleVentas.Text = "Detalle de Ventas";
            this.tsmiDetalleVentas.Click += new System.EventHandler(this.tsmiDetalleVentas_Click);
            // 
            // tsmiDetalleCompras
            // 
            this.tsmiDetalleCompras.Name = "tsmiDetalleCompras";
            this.tsmiDetalleCompras.Size = new System.Drawing.Size(194, 22);
            this.tsmiDetalleCompras.Text = "Detalle de Compras";
            this.tsmiDetalleCompras.Click += new System.EventHandler(this.tsmiDetalleCompras_Click);
            // 
            // frmVistaAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pntCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.Agregra.ResumeLayout(false);
            this.pntCabecera.ResumeLayout(false);
            this.pntCabecera.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Agregra;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private Panel pntCabecera;
        private Label lblNombreRegistro;
        private Label lblTituloAdm;
        private Label lblTitulo;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private ToolStripMenuItem tsmiListarProd;
        private ToolStripMenuItem tsmiAltaProd;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private ToolStripMenuItem tsmiDetalleVentas;
        private ToolStripMenuItem tsmiDetalleCompras;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private ToolStripMenuItem tsmiAltaUsuario_Click;
        private ToolStripMenuItem tsmiListarUsuarios_Click;
    }

}
