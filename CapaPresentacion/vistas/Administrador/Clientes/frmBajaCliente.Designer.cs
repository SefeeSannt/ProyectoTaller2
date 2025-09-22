namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    partial class frmBajaCliente
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
            this.lblBajaCliente = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBajaCliente
            // 
            this.lblBajaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBajaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBajaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaCliente.ForeColor = System.Drawing.Color.White;
            this.lblBajaCliente.Location = new System.Drawing.Point(0, 0);
            this.lblBajaCliente.Name = "lblBajaCliente";
            this.lblBajaCliente.Size = new System.Drawing.Size(960, 42);
            this.lblBajaCliente.TabIndex = 24;
            this.lblBajaCliente.Text = "Alta/Baja cliente";
            this.lblBajaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 125);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(936, 401);
            this.dgvClientes.TabIndex = 25;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvClientes_RowPrePaint);
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
            this.btnBuscar.Location = new System.Drawing.Point(319, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 33);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(108, 73);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 32);
            this.txtBuscar.TabIndex = 30;
            // 
            // lblBusar
            // 
            this.lblBusar.AutoSize = true;
            this.lblBusar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusar.Location = new System.Drawing.Point(13, 82);
            this.lblBusar.Name = "lblBusar";
            this.lblBusar.Size = new System.Drawing.Size(89, 17);
            this.lblBusar.TabIndex = 29;
            this.lblBusar.Text = "Buscar cliente:";
            // 
            // frmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblBajaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaCliente";
            this.Text = "frmBajaCliente";
            this.Load += new System.EventHandler(this.frmBajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBajaCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusar;
    }
}