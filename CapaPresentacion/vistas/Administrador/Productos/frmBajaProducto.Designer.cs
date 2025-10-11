namespace CapaPresentacion.vistas.Administrador.Productos
{
    partial class frmBajaProducto
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
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusar = new System.Windows.Forms.Label();
            this.dgvBajaProducto = new System.Windows.Forms.DataGridView();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbFiltrarEstadoCliente = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstadoCliente = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProducto)).BeginInit();
            this.SuspendLayout();
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
            this.lblBajaUsuario.TabIndex = 23;
            this.lblBajaUsuario.Text = "Baja producto";
            this.lblBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(572, 5);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 31);
            this.iconBtnLupaDetalleUser.TabIndex = 28;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(355, 12);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 17);
            this.txtBuscar.TabIndex = 26;
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBusar.Location = new System.Drawing.Point(248, 12);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(101, 17);
            this.lblBusar.TabIndex = 25;
            this.lblBusar.Text = "Buscar producto:";
            // 
            // dgvBajaProducto
            // 
            this.dgvBajaProducto.AllowUserToAddRows = false;
            this.dgvBajaProducto.AllowUserToDeleteRows = false;
            this.dgvBajaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajaProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvBajaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBajaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProducto,
            this.nombreProducto,
            this.categoria,
            this.descripcion,
            this.precio,
            this.accion});
            this.dgvBajaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajaProducto.Location = new System.Drawing.Point(0, 42);
            this.dgvBajaProducto.Name = "dgvBajaProducto";
            this.dgvBajaProducto.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBajaProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBajaProducto.RowHeadersVisible = false;
            this.dgvBajaProducto.Size = new System.Drawing.Size(960, 496);
            this.dgvBajaProducto.TabIndex = 29;
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
            // accion
            // 
            this.accion.HeaderText = "Acción";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            // 
            // cbFiltrarEstadoCliente
            // 
            this.cbFiltrarEstadoCliente.FormattingEnabled = true;
            this.cbFiltrarEstadoCliente.Location = new System.Drawing.Point(783, 11);
            this.cbFiltrarEstadoCliente.Name = "cbFiltrarEstadoCliente";
            this.cbFiltrarEstadoCliente.Size = new System.Drawing.Size(116, 21);
            this.cbFiltrarEstadoCliente.TabIndex = 31;
            // 
            // lblFiltroEstadoCliente
            // 
            this.lblFiltroEstadoCliente.AutoSize = true;
            this.lblFiltroEstadoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFiltroEstadoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstadoCliente.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblFiltroEstadoCliente.Location = new System.Drawing.Point(672, 12);
            this.lblFiltroEstadoCliente.Name = "lblFiltroEstadoCliente";
            this.lblFiltroEstadoCliente.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroEstadoCliente.TabIndex = 30;
            this.lblFiltroEstadoCliente.Text = "Filtrar por estado:";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 19;
            this.iconButton1.Location = new System.Drawing.Point(905, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 31);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmBajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.cbFiltrarEstadoCliente);
            this.Controls.Add(this.lblFiltroEstadoCliente);
            this.Controls.Add(this.dgvBajaProducto);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaProducto";
            this.Text = "frmBajaProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaUsuario;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.DataGridView dgvBajaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private System.Windows.Forms.ComboBox cbFiltrarEstadoCliente;
        private System.Windows.Forms.Label lblFiltroEstadoCliente;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}