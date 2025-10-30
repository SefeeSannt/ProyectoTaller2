using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Vistas.Administrador.Productos
{
    partial class frmListaProductos
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
            this.txtProductoBuscarPor = new System.Windows.Forms.TextBox();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoBuscarPor
            // 
            this.txtProductoBuscarPor.Location = new System.Drawing.Point(666, 15);
            this.txtProductoBuscarPor.Multiline = true;
            this.txtProductoBuscarPor.Name = "txtProductoBuscarPor";
            this.txtProductoBuscarPor.Size = new System.Drawing.Size(197, 19);
            this.txtProductoBuscarPor.TabIndex = 29;
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombre.ForeColor = System.Drawing.Color.White;
            this.lblBuscarNombre.Location = new System.Drawing.Point(611, 17);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarNombre.TabIndex = 27;
            this.lblBuscarNombre.Text = "Buscar:";
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(869, 12);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 21);
            this.iconBtnLupaDetalleUser.TabIndex = 25;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProducto,
            this.nombreProducto,
            this.categoria,
            this.descripcion,
            this.precio,
            this.stock,
            this.eliminar});
            this.dgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProductos.Location = new System.Drawing.Point(0, 42);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.RowHeadersVisible = false;
            this.dgvListaProductos.Size = new System.Drawing.Size(960, 496);
            this.dgvListaProductos.TabIndex = 24;
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Código";
            this.codProducto.Name = "codProducto";
            this.codProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
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
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // lblBajaUsuario
            // 
            this.lblBajaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBajaUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaUsuario.ForeColor = System.Drawing.Color.White;
            this.lblBajaUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblBajaUsuario.Name = "lblBajaUsuario";
            this.lblBajaUsuario.Size = new System.Drawing.Size(960, 42);
            this.lblBajaUsuario.TabIndex = 30;
            this.lblBajaUsuario.Text = "Lista producto";
            this.lblBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.txtProductoBuscarPor);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtProductoBuscarPor;
        private Label lblBuscarNombre;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private DataGridView dgvListaProductos;
        private DataGridViewTextBoxColumn codProducto;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewButtonColumn eliminar;
        private Label lblBajaUsuario;
    }
}