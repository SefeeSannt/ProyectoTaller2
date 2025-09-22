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
            this.lblConsultarStockRepositor = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvConsultaStock = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultarStockRepositor
            // 
            this.lblConsultarStockRepositor.AutoSize = true;
            this.lblConsultarStockRepositor.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarStockRepositor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConsultarStockRepositor.Location = new System.Drawing.Point(7, 21);
            this.lblConsultarStockRepositor.Name = "lblConsultarStockRepositor";
            this.lblConsultarStockRepositor.Size = new System.Drawing.Size(163, 25);
            this.lblConsultarStockRepositor.TabIndex = 0;
            this.lblConsultarStockRepositor.Text = "Consultar Stock";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(25, 77);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarPor.TabIndex = 1;
            this.lblBuscarPor.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(71, 77);
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
            this.iconBtnBuscar.Location = new System.Drawing.Point(243, 72);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(78, 26);
            this.iconBtnBuscar.TabIndex = 4;
            this.iconBtnBuscar.Text = "Buscar";
            this.iconBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaStock
            // 
            this.dgvConsultaStock.AllowUserToAddRows = false;
            this.dgvConsultaStock.AllowUserToDeleteRows = false;
            this.dgvConsultaStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.producto,
            this.descripcion,
            this.stockActual,
            this.nivelMinimo});
            this.dgvConsultaStock.Location = new System.Drawing.Point(12, 134);
            this.dgvConsultaStock.Name = "dgvConsultaStock";
            this.dgvConsultaStock.ReadOnly = true;
            this.dgvConsultaStock.RowHeadersVisible = false;
            this.dgvConsultaStock.Size = new System.Drawing.Size(936, 320);
            this.dgvConsultaStock.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            this.stockActual.ReadOnly = true;
            // 
            // nivelMinimo
            // 
            this.nivelMinimo.HeaderText = "Nivel Minímo";
            this.nivelMinimo.Name = "nivelMinimo";
            this.nivelMinimo.ReadOnly = true;
            // 
            // frmConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.dgvConsultaStock);
            this.Controls.Add(this.iconBtnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblConsultarStockRepositor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaStock";
            this.Text = "frmConsultaStock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarStockRepositor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelMinimo;
    }
}