namespace CapaPresentacion.vistas.Administrador.Usuarios
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
            this.lblBusar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDetalleUsuario = new System.Windows.Forms.DataGridView();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.ForeColor = System.Drawing.Color.White;
            this.lblBusar.Location = new System.Drawing.Point(610, 16);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(93, 17);
            this.lblBusar.TabIndex = 2;
            this.lblBusar.Text = "Buscar usuario:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(709, 15);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 19);
            this.txtBuscar.TabIndex = 3;
            // 
            // dgvDetalleUsuario
            // 
            this.dgvDetalleUsuario.AllowUserToAddRows = false;
            this.dgvDetalleUsuario.AllowUserToDeleteRows = false;
            this.dgvDetalleUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleUsuario.Location = new System.Drawing.Point(0, 42);
            this.dgvDetalleUsuario.Name = "dgvDetalleUsuario";
            this.dgvDetalleUsuario.ReadOnly = true;
            this.dgvDetalleUsuario.RowHeadersVisible = false;
            this.dgvDetalleUsuario.Size = new System.Drawing.Size(960, 496);
            this.dgvDetalleUsuario.TabIndex = 5;
            this.dgvDetalleUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajaUsuario);
            this.dgvDetalleUsuario.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDetalleUsuario_RowPrePaint);
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(901, 15);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 20);
            this.iconBtnLupaDetalleUser.TabIndex = 6;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            this.iconBtnLupaDetalleUser.Click += new System.EventHandler(this.iconBtnLupaDetalleUser_Click);
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
            // frmBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvDetalleUsuario);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaUsuario";
            this.Text = "frmBaja";
            this.Load += new System.EventHandler(this.frmBajaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDetalleUsuario;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.Label lblBajaUsuario;
    }
}