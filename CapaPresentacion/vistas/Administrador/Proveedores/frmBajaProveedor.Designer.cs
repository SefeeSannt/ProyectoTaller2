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
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusar = new System.Windows.Forms.Label();
            this.dgvBajaProveedores = new System.Windows.Forms.DataGridView();
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 19;
            this.btnBuscar.Location = new System.Drawing.Point(924, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(29, 17);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(723, 16);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 17);
            this.txtBuscar.TabIndex = 30;
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.ForeColor = System.Drawing.Color.White;
            this.lblBusar.Location = new System.Drawing.Point(609, 16);
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
            this.dgvBajaProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBajaProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBajaProveedores.Location = new System.Drawing.Point(0, 42);
            this.dgvBajaProveedores.Name = "dgvBajaProveedores";
            this.dgvBajaProveedores.ReadOnly = true;
            this.dgvBajaProveedores.RowHeadersVisible = false;
            this.dgvBajaProveedores.Size = new System.Drawing.Size(960, 496);
            this.dgvBajaProveedores.TabIndex = 32;
            this.dgvBajaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBajaProveedor);
            this.dgvBajaProveedores.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProveedor_RowPrePaint);
            // 
            // frmBajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.dgvBajaProveedores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.lblBajaProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaProveedor";
            this.Text = "frmBajaProveedor";
            this.Load += new System.EventHandler(this.frmBajaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBajaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaProveedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusar;
        private System.Windows.Forms.DataGridView dgvBajaProveedores;
    }
}