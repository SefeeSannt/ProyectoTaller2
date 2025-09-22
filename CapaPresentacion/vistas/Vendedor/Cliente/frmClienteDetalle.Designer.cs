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
            this.lblClientesReegistrados = new System.Windows.Forms.Label();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientesActivos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClientesInactivos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(130, 512);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(16, 17);
            this.lblTotalClientes.TabIndex = 23;
            this.lblTotalClientes.Text = "0";
            // 
            // lblClienteRegistrados
            // 
            this.lblClienteRegistrados.AutoSize = true;
            this.lblClienteRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteRegistrados.Location = new System.Drawing.Point(23, 512);
            this.lblClienteRegistrados.Name = "lblClienteRegistrados";
            this.lblClienteRegistrados.Size = new System.Drawing.Size(101, 17);
            this.lblClienteRegistrados.TabIndex = 22;
            this.lblClienteRegistrados.Text = "Total de clientes:";
            // 
            // lblClientesReegistrados
            // 
            this.lblClientesReegistrados.AutoSize = true;
            this.lblClientesReegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesReegistrados.Location = new System.Drawing.Point(21, 8);
            this.lblClientesReegistrados.Name = "lblClientesReegistrados";
            this.lblClientesReegistrados.Size = new System.Drawing.Size(197, 26);
            this.lblClientesReegistrados.TabIndex = 15;
            this.lblClientesReegistrados.Text = "Clientes Registrados";
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(183, 101);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(32, 27);
            this.iconBtnLupaDetalleUser.TabIndex = 14;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            this.iconBtnLupaDetalleUser.Click += new System.EventHandler(this.iconBtnLupaDetalleUser_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 134);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(936, 375);
            this.dgvClientes.TabIndex = 13;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 109);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 19);
            this.txtBuscar.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dato del cliente";
            // 
            // lblClientesActivos
            // 
            this.lblClientesActivos.AutoSize = true;
            this.lblClientesActivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesActivos.Location = new System.Drawing.Point(237, 512);
            this.lblClientesActivos.Name = "lblClientesActivos";
            this.lblClientesActivos.Size = new System.Drawing.Size(16, 17);
            this.lblClientesActivos.TabIndex = 28;
            this.lblClientesActivos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Activos:";
            // 
            // lblClientesInactivos
            // 
            this.lblClientesInactivos.AutoSize = true;
            this.lblClientesInactivos.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesInactivos.Location = new System.Drawing.Point(346, 512);
            this.lblClientesInactivos.Name = "lblClientesInactivos";
            this.lblClientesInactivos.Size = new System.Drawing.Size(16, 17);
            this.lblClientesInactivos.TabIndex = 30;
            this.lblClientesInactivos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Inactivos:";
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
            this.Controls.Add(this.lblClientesReegistrados);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvClientes);
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
        private System.Windows.Forms.Label lblClientesReegistrados;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientesActivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClientesInactivos;
        private System.Windows.Forms.Label label5;
    }
}