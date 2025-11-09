namespace CapaPresentacion.vistas.Administrador.Backup
{
    partial class frmvistaBackup
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
            this.btnBuscarCarpeta = new System.Windows.Forms.Button();
            this.txtRutaBackup = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBajaCliente = new System.Windows.Forms.Label();
            this.btnCrearBackup = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCarpeta
            // 
            this.btnBuscarCarpeta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarCarpeta.FlatAppearance.BorderSize = 0;
            this.btnBuscarCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCarpeta.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCarpeta.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCarpeta.Location = new System.Drawing.Point(482, 105);
            this.btnBuscarCarpeta.Name = "btnBuscarCarpeta";
            this.btnBuscarCarpeta.Size = new System.Drawing.Size(135, 33);
            this.btnBuscarCarpeta.TabIndex = 1;
            this.btnBuscarCarpeta.Text = "Buscar carpeta";
            this.btnBuscarCarpeta.UseVisualStyleBackColor = false;
            this.btnBuscarCarpeta.Click += new System.EventHandler(this.btnSeleccionarRuta_Click);
            // 
            // txtRutaBackup
            // 
            this.txtRutaBackup.Location = new System.Drawing.Point(12, 105);
            this.txtRutaBackup.Multiline = true;
            this.txtRutaBackup.Name = "txtRutaBackup";
            this.txtRutaBackup.Size = new System.Drawing.Size(453, 33);
            this.txtRutaBackup.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "RUTA PARA GUARDAR BACK UP";
            // 
            // lblBajaCliente
            // 
            this.lblBajaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBajaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBajaCliente.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBajaCliente.ForeColor = System.Drawing.Color.Brown;
            this.lblBajaCliente.Location = new System.Drawing.Point(0, 0);
            this.lblBajaCliente.Name = "lblBajaCliente";
            this.lblBajaCliente.Size = new System.Drawing.Size(960, 42);
            this.lblBajaCliente.TabIndex = 25;
            this.lblBajaCliente.Text = "BACKUP";
            this.lblBajaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearBackup
            // 
            this.btnCrearBackup.Location = new System.Drawing.Point(845, 110);
            this.btnCrearBackup.Name = "btnCrearBackup";
            this.btnCrearBackup.Size = new System.Drawing.Size(103, 23);
            this.btnCrearBackup.TabIndex = 26;
            this.btnCrearBackup.Text = "Crear backup";
            this.btnCrearBackup.UseVisualStyleBackColor = true;
            this.btnCrearBackup.Click += new System.EventHandler(this.btnCrearBackup_Click);
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(12, 216);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(936, 310);
            this.dgvLogs.TabIndex = 27;
            // 
            // frmvistaBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.btnCrearBackup);
            this.Controls.Add(this.lblBajaCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtRutaBackup);
            this.Controls.Add(this.btnBuscarCarpeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmvistaBackup";
            this.Text = "vista_backup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarCarpeta;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBajaCliente;
        private System.Windows.Forms.Button btnCrearBackup;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}