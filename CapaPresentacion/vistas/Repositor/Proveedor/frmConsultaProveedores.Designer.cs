namespace CapaPresentacion.Vistas.Repositor
{
    partial class frmConsultaProveedores
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
            this.lblConsultaProveedores = new System.Windows.Forms.Label();
            this.lblDocumentoProveedor = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.txt_dni_proveedor = new System.Windows.Forms.TextBox();
            this.txt_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvConsultaProveedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errIngresoDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_listar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaProveedores
            // 
            this.lblConsultaProveedores.AutoSize = true;
            this.lblConsultaProveedores.BackColor = System.Drawing.Color.White;
            this.lblConsultaProveedores.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaProveedores.Location = new System.Drawing.Point(21, 30);
            this.lblConsultaProveedores.Name = "lblConsultaProveedores";
            this.lblConsultaProveedores.Size = new System.Drawing.Size(205, 26);
            this.lblConsultaProveedores.TabIndex = 0;
            this.lblConsultaProveedores.Text = "Consulta proveedores";
            // 
            // lblDocumentoProveedor
            // 
            this.lblDocumentoProveedor.AutoSize = true;
            this.lblDocumentoProveedor.BackColor = System.Drawing.Color.White;
            this.lblDocumentoProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoProveedor.Location = new System.Drawing.Point(229, 48);
            this.lblDocumentoProveedor.Name = "lblDocumentoProveedor";
            this.lblDocumentoProveedor.Size = new System.Drawing.Size(73, 17);
            this.lblDocumentoProveedor.TabIndex = 1;
            this.lblDocumentoProveedor.Text = "Documento";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.BackColor = System.Drawing.Color.White;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(12, 48);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(55, 17);
            this.lblNombreProveedor.TabIndex = 2;
            this.lblNombreProveedor.Text = "Nombre:";
            // 
            // txt_dni_proveedor
            // 
            this.txt_dni_proveedor.Location = new System.Drawing.Point(232, 68);
            this.txt_dni_proveedor.Name = "txt_dni_proveedor";
            this.txt_dni_proveedor.Size = new System.Drawing.Size(126, 20);
            this.txt_dni_proveedor.TabIndex = 5;
            // 
            // txt_nombre_proveedor
            // 
            this.txt_nombre_proveedor.Location = new System.Drawing.Point(13, 68);
            this.txt_nombre_proveedor.Name = "txt_nombre_proveedor";
            this.txt_nombre_proveedor.Size = new System.Drawing.Size(202, 20);
            this.txt_nombre_proveedor.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Blue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 15;
            this.btnBuscar.Location = new System.Drawing.Point(364, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 29);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvConsultaProveedores
            // 
            this.dgvConsultaProveedores.AllowUserToAddRows = false;
            this.dgvConsultaProveedores.AllowUserToDeleteRows = false;
            this.dgvConsultaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConsultaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProveedores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvConsultaProveedores.Location = new System.Drawing.Point(12, 170);
            this.dgvConsultaProveedores.Name = "dgvConsultaProveedores";
            this.dgvConsultaProveedores.ReadOnly = true;
            this.dgvConsultaProveedores.RowHeadersVisible = false;
            this.dgvConsultaProveedores.Size = new System.Drawing.Size(469, 356);
            this.dgvConsultaProveedores.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_listar);
            this.panel1.Controls.Add(this.lblNombreProveedor);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txt_nombre_proveedor);
            this.panel1.Controls.Add(this.txt_dni_proveedor);
            this.panel1.Controls.Add(this.lblDocumentoProveedor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 140);
            this.panel1.TabIndex = 9;
            // 
            // errIngresoDatos
            // 
            this.errIngresoDatos.ContainerControl = this;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(13, 112);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(177, 23);
            this.btn_listar.TabIndex = 9;
            this.btn_listar.Text = "LISTAR PROVEEDORES";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // frmConsultaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 538);
            this.Controls.Add(this.dgvConsultaProveedores);
            this.Controls.Add(this.lblConsultaProveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaProveedores";
            this.Text = "frmConsultaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errIngresoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaProveedores;
        private System.Windows.Forms.Label lblDocumentoProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox txt_dni_proveedor;
        private System.Windows.Forms.TextBox txt_nombre_proveedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvConsultaProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errIngresoDatos;
        private System.Windows.Forms.Button btn_listar;
    }
}