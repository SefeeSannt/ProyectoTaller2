namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmConsultaStock
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
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblBajaUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarPor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPor.Location = new System.Drawing.Point(642, 16);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarPor.TabIndex = 1;
            this.lblBuscarPor.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(697, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 17);
            this.textBox1.TabIndex = 3;
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBuscar.IconSize = 15;
            this.iconBtnBuscar.Location = new System.Drawing.Point(870, 14);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(78, 21);
            this.iconBtnBuscar.TabIndex = 4;
            this.iconBtnBuscar.Text = "Buscar";
            this.iconBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 42);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.Size = new System.Drawing.Size(960, 496);
            this.dgvStock.TabIndex = 5;
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
            this.lblBajaUsuario.TabIndex = 24;
            this.lblBajaUsuario.Text = "Consulta Stock";
            this.lblBajaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.iconBtnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblBajaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaStock";
            this.Text = "frmConsultaStock";
            this.Load += new System.EventHandler(this.frmConsultaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblBajaUsuario;
    }
}