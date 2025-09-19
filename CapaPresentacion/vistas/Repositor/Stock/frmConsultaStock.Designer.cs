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
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvConsultaStock = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconBtnActualizarStock = new FontAwesome.Sharp.IconButton();
            this.iconBtnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconBtnExportar = new FontAwesome.Sharp.IconButton();
            this.iconBtnGenerarPedido = new FontAwesome.Sharp.IconButton();
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
            this.lblBuscarPor.Size = new System.Drawing.Size(70, 17);
            this.lblBuscarPor.TabIndex = 1;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(101, 74);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(231, 21);
            this.cbBuscarPor.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(338, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 3;
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnBuscar.IconSize = 15;
            this.iconBtnBuscar.Location = new System.Drawing.Point(510, 68);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(78, 27);
            this.iconBtnBuscar.TabIndex = 4;
            this.iconBtnBuscar.Text = "Buscar";
            this.iconBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaStock
            // 
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
            this.descripcion,
            this.stockActual,
            this.nivelMinimo,
            this.estado});
            this.dgvConsultaStock.Location = new System.Drawing.Point(-1, 134);
            this.dgvConsultaStock.Name = "dgvConsultaStock";
            this.dgvConsultaStock.RowHeadersVisible = false;
            this.dgvConsultaStock.Size = new System.Drawing.Size(599, 320);
            this.dgvConsultaStock.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // stockActual
            // 
            this.stockActual.HeaderText = "Stock Actual";
            this.stockActual.Name = "stockActual";
            // 
            // nivelMinimo
            // 
            this.nivelMinimo.HeaderText = "Nivel Minímo";
            this.nivelMinimo.Name = "nivelMinimo";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // iconBtnActualizarStock
            // 
            this.iconBtnActualizarStock.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnActualizarStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnActualizarStock.IconColor = System.Drawing.Color.Black;
            this.iconBtnActualizarStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnActualizarStock.Location = new System.Drawing.Point(117, 461);
            this.iconBtnActualizarStock.Name = "iconBtnActualizarStock";
            this.iconBtnActualizarStock.Size = new System.Drawing.Size(185, 29);
            this.iconBtnActualizarStock.TabIndex = 6;
            this.iconBtnActualizarStock.Text = "Actualizar Stock";
            this.iconBtnActualizarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnActualizarStock.UseVisualStyleBackColor = true;
            // 
            // iconBtnCerrar
            // 
            this.iconBtnCerrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCerrar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCerrar.Location = new System.Drawing.Point(319, 496);
            this.iconBtnCerrar.Name = "iconBtnCerrar";
            this.iconBtnCerrar.Size = new System.Drawing.Size(185, 30);
            this.iconBtnCerrar.TabIndex = 8;
            this.iconBtnCerrar.Text = "Cerrar";
            this.iconBtnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCerrar.UseVisualStyleBackColor = true;
            // 
            // iconBtnExportar
            // 
            this.iconBtnExportar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnExportar.IconColor = System.Drawing.Color.Black;
            this.iconBtnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExportar.Location = new System.Drawing.Point(319, 461);
            this.iconBtnExportar.Name = "iconBtnExportar";
            this.iconBtnExportar.Size = new System.Drawing.Size(185, 30);
            this.iconBtnExportar.TabIndex = 9;
            this.iconBtnExportar.Text = "Exportar";
            this.iconBtnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExportar.UseVisualStyleBackColor = true;
            // 
            // iconBtnGenerarPedido
            // 
            this.iconBtnGenerarPedido.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnGenerarPedido.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnGenerarPedido.IconColor = System.Drawing.Color.Black;
            this.iconBtnGenerarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnGenerarPedido.Location = new System.Drawing.Point(117, 496);
            this.iconBtnGenerarPedido.Name = "iconBtnGenerarPedido";
            this.iconBtnGenerarPedido.Size = new System.Drawing.Size(185, 30);
            this.iconBtnGenerarPedido.TabIndex = 10;
            this.iconBtnGenerarPedido.Text = "Generar pedido";
            this.iconBtnGenerarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnGenerarPedido.UseVisualStyleBackColor = true;
            // 
            // frmConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 538);
            this.Controls.Add(this.iconBtnGenerarPedido);
            this.Controls.Add(this.iconBtnExportar);
            this.Controls.Add(this.iconBtnCerrar);
            this.Controls.Add(this.iconBtnActualizarStock);
            this.Controls.Add(this.dgvConsultaStock);
            this.Controls.Add(this.iconBtnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbBuscarPor);
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
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultaStock;
        private FontAwesome.Sharp.IconButton iconBtnActualizarStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelMinimo;
        private FontAwesome.Sharp.IconButton iconBtnCerrar;
        private FontAwesome.Sharp.IconButton iconBtnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private FontAwesome.Sharp.IconButton iconBtnGenerarPedido;
    }
}