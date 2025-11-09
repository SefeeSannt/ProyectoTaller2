namespace CapaPresentacion.vistas.Repositor.Proveedor
{
    partial class frmEditarProveedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblApellido_proveedor = new System.Windows.Forms.Label();
            this.txtApellido_proveedor = new System.Windows.Forms.TextBox();
            this.lblCorreo_proveedor = new System.Windows.Forms.Label();
            this.txtEmail_proveedor = new System.Windows.Forms.TextBox();
            this.txtTelefono_proveedor = new System.Windows.Forms.TextBox();
            this.lblTelefono_proveedor = new System.Windows.Forms.Label();
            this.lblTituloListaProv = new System.Windows.Forms.Label();
            this.txtNombre_proveedor = new System.Windows.Forms.TextBox();
            this.lblNombre_proveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblBuscarListaProv = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtDni_proveedor = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.dgv_editar_proveedor = new System.Windows.Forms.DataGridView();
            this.lblFondo = new System.Windows.Forms.Label();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editar_proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellido_proveedor
            // 
            this.lblApellido_proveedor.AutoSize = true;
            this.lblApellido_proveedor.BackColor = System.Drawing.Color.White;
            this.lblApellido_proveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido_proveedor.ForeColor = System.Drawing.Color.Black;
            this.lblApellido_proveedor.Location = new System.Drawing.Point(14, 157);
            this.lblApellido_proveedor.Name = "lblApellido_proveedor";
            this.lblApellido_proveedor.Size = new System.Drawing.Size(56, 17);
            this.lblApellido_proveedor.TabIndex = 115;
            this.lblApellido_proveedor.Text = "Apellido:";
            // 
            // txtApellido_proveedor
            // 
            this.txtApellido_proveedor.Location = new System.Drawing.Point(17, 177);
            this.txtApellido_proveedor.Name = "txtApellido_proveedor";
            this.txtApellido_proveedor.Size = new System.Drawing.Size(208, 20);
            this.txtApellido_proveedor.TabIndex = 116;
            // 
            // lblCorreo_proveedor
            // 
            this.lblCorreo_proveedor.AutoSize = true;
            this.lblCorreo_proveedor.BackColor = System.Drawing.Color.White;
            this.lblCorreo_proveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo_proveedor.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo_proveedor.Location = new System.Drawing.Point(14, 209);
            this.lblCorreo_proveedor.Name = "lblCorreo_proveedor";
            this.lblCorreo_proveedor.Size = new System.Drawing.Size(48, 17);
            this.lblCorreo_proveedor.TabIndex = 111;
            this.lblCorreo_proveedor.Text = "Correo:";
            // 
            // txtEmail_proveedor
            // 
            this.txtEmail_proveedor.Location = new System.Drawing.Point(17, 229);
            this.txtEmail_proveedor.Name = "txtEmail_proveedor";
            this.txtEmail_proveedor.Size = new System.Drawing.Size(208, 20);
            this.txtEmail_proveedor.TabIndex = 113;
            // 
            // txtTelefono_proveedor
            // 
            this.txtTelefono_proveedor.Location = new System.Drawing.Point(17, 281);
            this.txtTelefono_proveedor.Name = "txtTelefono_proveedor";
            this.txtTelefono_proveedor.Size = new System.Drawing.Size(208, 20);
            this.txtTelefono_proveedor.TabIndex = 114;
            // 
            // lblTelefono_proveedor
            // 
            this.lblTelefono_proveedor.AutoSize = true;
            this.lblTelefono_proveedor.BackColor = System.Drawing.Color.White;
            this.lblTelefono_proveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono_proveedor.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono_proveedor.Location = new System.Drawing.Point(14, 261);
            this.lblTelefono_proveedor.Name = "lblTelefono_proveedor";
            this.lblTelefono_proveedor.Size = new System.Drawing.Size(59, 17);
            this.lblTelefono_proveedor.TabIndex = 112;
            this.lblTelefono_proveedor.Text = "Telefono:";
            // 
            // lblTituloListaProv
            // 
            this.lblTituloListaProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTituloListaProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloListaProv.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaProv.ForeColor = System.Drawing.Color.White;
            this.lblTituloListaProv.Location = new System.Drawing.Point(244, 0);
            this.lblTituloListaProv.Name = "lblTituloListaProv";
            this.lblTituloListaProv.Size = new System.Drawing.Size(716, 42);
            this.lblTituloListaProv.TabIndex = 110;
            this.lblTituloListaProv.Text = "Lista de Proveedores";
            this.lblTituloListaProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre_proveedor
            // 
            this.txtNombre_proveedor.Location = new System.Drawing.Point(18, 125);
            this.txtNombre_proveedor.Name = "txtNombre_proveedor";
            this.txtNombre_proveedor.Size = new System.Drawing.Size(210, 20);
            this.txtNombre_proveedor.TabIndex = 109;
            // 
            // lblNombre_proveedor
            // 
            this.lblNombre_proveedor.AutoSize = true;
            this.lblNombre_proveedor.BackColor = System.Drawing.Color.White;
            this.lblNombre_proveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_proveedor.Location = new System.Drawing.Point(17, 105);
            this.lblNombre_proveedor.Name = "lblNombre_proveedor";
            this.lblNombre_proveedor.Size = new System.Drawing.Size(55, 17);
            this.lblNombre_proveedor.TabIndex = 108;
            this.lblNombre_proveedor.Text = "Nombre:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(747, 15);
            this.txtProveedor.Multiline = true;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(160, 19);
            this.txtProveedor.TabIndex = 107;
            // 
            // lblBuscarListaProv
            // 
            this.lblBuscarListaProv.AutoSize = true;
            this.lblBuscarListaProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscarListaProv.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarListaProv.ForeColor = System.Drawing.Color.White;
            this.lblBuscarListaProv.Location = new System.Drawing.Point(692, 15);
            this.lblBuscarListaProv.Name = "lblBuscarListaProv";
            this.lblBuscarListaProv.Size = new System.Drawing.Size(49, 17);
            this.lblBuscarListaProv.TabIndex = 106;
            this.lblBuscarListaProv.Text = "Buscar:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 19;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(913, 14);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(41, 21);
            this.btnBuscarProveedor.TabIndex = 105;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 25);
            this.lblTitulo.TabIndex = 104;
            this.lblTitulo.Text = "Editar Proveedor";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 16;
            this.btnLimpiar.Location = new System.Drawing.Point(18, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(211, 37);
            this.btnLimpiar.TabIndex = 103;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(19, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(210, 37);
            this.btnGuardar.TabIndex = 102;
            this.btnGuardar.Text = "Guardar edicion";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDni_proveedor
            // 
            this.txtDni_proveedor.Location = new System.Drawing.Point(16, 82);
            this.txtDni_proveedor.Name = "txtDni_proveedor";
            this.txtDni_proveedor.Size = new System.Drawing.Size(210, 20);
            this.txtDni_proveedor.TabIndex = 101;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.White;
            this.lblDni.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(15, 62);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(98, 17);
            this.lblDni.TabIndex = 100;
            this.lblDni.Text = "Nro Documento:";
            // 
            // dgv_editar_proveedor
            // 
            this.dgv_editar_proveedor.AllowUserToAddRows = false;
            this.dgv_editar_proveedor.AllowUserToDeleteRows = false;
            this.dgv_editar_proveedor.AllowUserToResizeColumns = false;
            this.dgv_editar_proveedor.AllowUserToResizeRows = false;
            this.dgv_editar_proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_editar_proveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_editar_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_editar_proveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_editar_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_editar_proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_editar_proveedor.Location = new System.Drawing.Point(244, 42);
            this.dgv_editar_proveedor.MultiSelect = false;
            this.dgv_editar_proveedor.Name = "dgv_editar_proveedor";
            this.dgv_editar_proveedor.ReadOnly = true;
            this.dgv_editar_proveedor.RowHeadersVisible = false;
            this.dgv_editar_proveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_editar_proveedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_editar_proveedor.RowTemplate.Height = 28;
            this.dgv_editar_proveedor.Size = new System.Drawing.Size(716, 496);
            this.dgv_editar_proveedor.TabIndex = 99;
            this.dgv_editar_proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor);
            // 
            // lblFondo
            // 
            this.lblFondo.BackColor = System.Drawing.Color.White;
            this.lblFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFondo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFondo.Location = new System.Drawing.Point(0, 0);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(244, 538);
            this.lblFondo.TabIndex = 98;
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // frmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.lblApellido_proveedor);
            this.Controls.Add(this.txtApellido_proveedor);
            this.Controls.Add(this.lblCorreo_proveedor);
            this.Controls.Add(this.txtEmail_proveedor);
            this.Controls.Add(this.txtTelefono_proveedor);
            this.Controls.Add(this.lblTelefono_proveedor);
            this.Controls.Add(this.txtNombre_proveedor);
            this.Controls.Add(this.lblNombre_proveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblBuscarListaProv);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDni_proveedor);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.dgv_editar_proveedor);
            this.Controls.Add(this.lblTituloListaProv);
            this.Controls.Add(this.lblFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarProveedor";
            this.Text = "frmEditarProveedor";
            this.Load += new System.EventHandler(this.frmEditarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editar_proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido_proveedor;
        private System.Windows.Forms.TextBox txtApellido_proveedor;
        private System.Windows.Forms.Label lblCorreo_proveedor;
        private System.Windows.Forms.TextBox txtEmail_proveedor;
        private System.Windows.Forms.TextBox txtTelefono_proveedor;
        private System.Windows.Forms.Label lblTelefono_proveedor;
        private System.Windows.Forms.Label lblTituloListaProv;
        private System.Windows.Forms.TextBox txtNombre_proveedor;
        private System.Windows.Forms.Label lblNombre_proveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblBuscarListaProv;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtDni_proveedor;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DataGridView dgv_editar_proveedor;
        private System.Windows.Forms.Label lblFondo;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
    }
}