namespace CapaPresentacion.vistas.Administrador
{
    partial class frmBajaUsuario
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblBusar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.dgvDetalleUsuario = new System.Windows.Forms.DataGridView();
            this.numDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            this.cbFiltrarEstadoCliente = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstadoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(11, 58);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 17);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol";
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.Location = new System.Drawing.Point(11, 105);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(93, 17);
            this.lblBusar.TabIndex = 2;
            this.lblBusar.Text = "Buscar usuario:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(110, 97);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 32);
            this.txtBuscar.TabIndex = 3;
            // 
            // cbRol
            // 
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(110, 57);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(195, 21);
            this.cbRol.TabIndex = 4;
            // 
            // dgvDetalleUsuario
            // 
            this.dgvDetalleUsuario.AllowUserToAddRows = false;
            this.dgvDetalleUsuario.AllowUserToDeleteRows = false;
            this.dgvDetalleUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDocumento,
            this.nombreCompleto,
            this.correo,
            this.telefono,
            this.rol,
            this.accion});
            this.dgvDetalleUsuario.Location = new System.Drawing.Point(14, 173);
            this.dgvDetalleUsuario.Name = "dgvDetalleUsuario";
            this.dgvDetalleUsuario.ReadOnly = true;
            this.dgvDetalleUsuario.RowHeadersVisible = false;
            this.dgvDetalleUsuario.Size = new System.Drawing.Size(918, 289);
            this.dgvDetalleUsuario.TabIndex = 5;
            // 
            // numDocumento
            // 
            this.numDocumento.HeaderText = "Documento";
            this.numDocumento.Name = "numDocumento";
            this.numDocumento.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre completo";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // accion
            // 
            this.accion.HeaderText = "Acción";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(321, 98);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 31);
            this.iconBtnLupaDetalleUser.TabIndex = 6;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
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
            this.lblBajaUsuario.TabIndex = 22;
            this.lblBajaUsuario.Text = "Baja usuario";
            this.lblBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFiltrarEstadoCliente
            // 
            this.cbFiltrarEstadoCliente.FormattingEnabled = true;
            this.cbFiltrarEstadoCliente.Location = new System.Drawing.Point(693, 104);
            this.cbFiltrarEstadoCliente.Name = "cbFiltrarEstadoCliente";
            this.cbFiltrarEstadoCliente.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarEstadoCliente.TabIndex = 33;
            // 
            // lblFiltroEstadoCliente
            // 
            this.lblFiltroEstadoCliente.AutoSize = true;
            this.lblFiltroEstadoCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstadoCliente.Location = new System.Drawing.Point(571, 105);
            this.lblFiltroEstadoCliente.Name = "lblFiltroEstadoCliente";
            this.lblFiltroEstadoCliente.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroEstadoCliente.TabIndex = 32;
            this.lblFiltroEstadoCliente.Text = "Filtrar por estado:";
            // 
            // frmBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.cbFiltrarEstadoCliente);
            this.Controls.Add(this.lblFiltroEstadoCliente);
            this.Controls.Add(this.lblBajaUsuario);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvDetalleUsuario);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaUsuario";
            this.Text = "frmBaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.DataGridView dgvDetalleUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.Label lblBajaUsuario;
        private System.Windows.Forms.ComboBox cbFiltrarEstadoCliente;
        private System.Windows.Forms.Label lblFiltroEstadoCliente;
    }
}