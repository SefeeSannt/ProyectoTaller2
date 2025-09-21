namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    partial class frmBajaProveedor
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
            this.lblBajaProveedor = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusar = new System.Windows.Forms.Label();
            this.dgvBajaProveedores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbFiltrarEstadoCliente = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstadoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBajaProveedor
            // 
            this.lblBajaProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBajaProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBajaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaProveedor.ForeColor = System.Drawing.Color.White;
            this.lblBajaProveedor.Location = new System.Drawing.Point(0, 0);
            this.lblBajaProveedor.Name = "lblBajaProveedor";
            this.lblBajaProveedor.Size = new System.Drawing.Size(960, 42);
            this.lblBajaProveedor.TabIndex = 24;
            this.lblBajaProveedor.Text = "Baja proveedor";
            this.lblBajaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(339, 60);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 32);
            this.iconBtnLupaDetalleUser.TabIndex = 31;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(126, 60);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 32);
            this.txtBuscar.TabIndex = 30;
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.Location = new System.Drawing.Point(12, 64);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(108, 17);
            this.lblBusar.TabIndex = 29;
            this.lblBusar.Text = "Buscar proveedor:";
            // 
            // dgvBajaProveedores
            // 
            this.dgvBajaProveedores.AllowUserToAddRows = false;
            this.dgvBajaProveedores.AllowUserToDeleteRows = false;
            this.dgvBajaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvBajaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBajaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.Documento,
            this.email,
            this.accion});
            this.dgvBajaProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBajaProveedores.Location = new System.Drawing.Point(15, 117);
            this.dgvBajaProveedores.Name = "dgvBajaProveedores";
            this.dgvBajaProveedores.ReadOnly = true;
            this.dgvBajaProveedores.RowHeadersVisible = false;
            this.dgvBajaProveedores.Size = new System.Drawing.Size(933, 356);
            this.dgvBajaProveedores.TabIndex = 32;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
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
            this.cbFiltrarEstadoCliente.Location = new System.Drawing.Point(709, 60);
            this.cbFiltrarEstadoCliente.Name = "cbFiltrarEstadoCliente";
            this.cbFiltrarEstadoCliente.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarEstadoCliente.TabIndex = 34;
            // 
            // lblFiltroEstadoCliente
            // 
            this.lblFiltroEstadoCliente.AutoSize = true;
            this.lblFiltroEstadoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstadoCliente.Location = new System.Drawing.Point(585, 65);
            this.lblFiltroEstadoCliente.Name = "lblFiltroEstadoCliente";
            this.lblFiltroEstadoCliente.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroEstadoCliente.TabIndex = 33;
            this.lblFiltroEstadoCliente.Text = "Filtrar por estado:";
            // 
            // frmBajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.cbFiltrarEstadoCliente);
            this.Controls.Add(this.lblFiltroEstadoCliente);
            this.Controls.Add(this.dgvBajaProveedores);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblBajaProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaProveedor";
            this.Text = "frmBajaProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaProveedor;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.DataGridView dgvBajaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private System.Windows.Forms.ComboBox cbFiltrarEstadoCliente;
        private System.Windows.Forms.Label lblFiltroEstadoCliente;
    }
}