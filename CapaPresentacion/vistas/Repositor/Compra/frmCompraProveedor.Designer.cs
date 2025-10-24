namespace CapaPresentacion.vistas.Repositor.Compra
{
    partial class frmCompraProveedor
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
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProv = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.AllowUserToAddRows = false;
            this.dgvListaProveedores.AllowUserToDeleteRows = false;
            this.dgvListaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProveedores.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListaProveedores.Location = new System.Drawing.Point(0, 38);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.ReadOnly = true;
            this.dgvListaProveedores.RowHeadersVisible = false;
            this.dgvListaProveedores.Size = new System.Drawing.Size(736, 412);
            this.dgvListaProveedores.TabIndex = 0;
            this.dgvListaProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellDoubleClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnVolver.IconColor = System.Drawing.Color.Black;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 25;
            this.btnVolver.Location = new System.Drawing.Point(689, 7);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(35, 25);
            this.btnVolver.TabIndex = 34;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtBuscarProv
            // 
            this.txtBuscarProv.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarProv.Multiline = true;
            this.txtBuscarProv.Name = "txtBuscarProv";
            this.txtBuscarProv.Size = new System.Drawing.Size(195, 20);
            this.txtBuscarProv.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 19;
            this.btnBuscar.Location = new System.Drawing.Point(213, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 22);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmCompraProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarProv);
            this.Controls.Add(this.dgvListaProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCompraProveedor";
            this.Load += new System.EventHandler(this.frmCompraProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.TextBox txtBuscarProv;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}