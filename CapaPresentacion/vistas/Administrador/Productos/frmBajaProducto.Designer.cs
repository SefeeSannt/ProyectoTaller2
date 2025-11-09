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
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblBusar = new System.Windows.Forms.Label();
            this.dgvBajaProducto = new System.Windows.Forms.DataGridView();
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(907, 5);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 31);
            this.iconBtnLupaDetalleUser.TabIndex = 28;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            this.iconBtnLupaDetalleUser.Click += new System.EventHandler(this.iconBtnLupaDetalleUser_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(706, 12);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(195, 17);
            this.txtProducto.TabIndex = 26;
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBusar.Location = new System.Drawing.Point(599, 12);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(101, 17);
            this.lblBusar.TabIndex = 25;
            this.lblBusar.Text = "Buscar producto:";
            // 
            // dgvBajaProducto
            // 
            this.dgvBajaProducto.AllowUserToAddRows = false;
            this.dgvBajaProducto.AllowUserToDeleteRows = false;
            this.dgvBajaProducto.AllowUserToResizeColumns = false;
            this.dgvBajaProducto.AllowUserToResizeRows = false;
            this.dgvBajaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBajaProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvBajaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBajaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBajaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // frmBajaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.dgvBajaProducto);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaProducto";
            this.Text = "frmBajaProducto";
            this.Load += new System.EventHandler(this.frmBajaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaUsuario;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.DataGridView dgvBajaProducto;
    }
}