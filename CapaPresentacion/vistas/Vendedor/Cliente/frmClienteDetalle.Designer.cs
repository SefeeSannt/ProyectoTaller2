namespace CapaPresentacion.Vistas.Vendedor
{
    partial class frmClienteDetalle
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
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblClienteRegistrados = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientesActivos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClientesInactivos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(120, 489);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(16, 17);
            this.lblTotalClientes.TabIndex = 23;
            this.lblTotalClientes.Text = "0";
            // 
            // lblClienteRegistrados
            // 
            this.lblClienteRegistrados.AutoSize = true;
            this.lblClienteRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRegistrados.Location = new System.Drawing.Point(13, 489);
            this.lblClienteRegistrados.Name = "lblClienteRegistrados";
            this.lblClienteRegistrados.Size = new System.Drawing.Size(101, 17);
            this.lblClienteRegistrados.TabIndex = 22;
            this.lblClienteRegistrados.Text = "Total de clientes:";
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(924, 15);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(32, 19);
            this.iconBtnLupaDetalleUser.TabIndex = 14;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            this.iconBtnLupaDetalleUser.Click += new System.EventHandler(this.iconBtnLupaDetalleUser_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 42);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(960, 496);
            this.dgvClientes.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(761, 15);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 19);
            this.txtBuscar.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(686, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Buscar cliente";
            // 
            // lblClientesActivos
            // 
            this.lblClientesActivos.AutoSize = true;
            this.lblClientesActivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesActivos.Location = new System.Drawing.Point(227, 489);
            this.lblClientesActivos.Name = "lblClientesActivos";
            this.lblClientesActivos.Size = new System.Drawing.Size(16, 17);
            this.lblClientesActivos.TabIndex = 28;
            this.lblClientesActivos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Activos:";
            // 
            // lblClientesInactivos
            // 
            this.lblClientesInactivos.AutoSize = true;
            this.lblClientesInactivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesInactivos.Location = new System.Drawing.Point(336, 489);
            this.lblClientesInactivos.Name = "lblClientesInactivos";
            this.lblClientesInactivos.Size = new System.Drawing.Size(16, 17);
            this.lblClientesInactivos.TabIndex = 30;
            this.lblClientesInactivos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Inactivos:";
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
            this.lblBajaUsuario.TabIndex = 31;
            this.lblBajaUsuario.Text = "Clientes registrados";
            this.lblBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmClienteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.lblClientesInactivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClientesActivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.lblClienteRegistrados);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClienteDetalle";
            this.Text = "frmClienteDetalle";
            this.Load += new System.EventHandler(this.frmClienteDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label lblClienteRegistrados;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientesActivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClientesInactivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBajaUsuario;
    }
}