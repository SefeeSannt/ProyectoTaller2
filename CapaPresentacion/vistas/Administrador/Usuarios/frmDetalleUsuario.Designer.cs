namespace CapaPresentacion.Vistas.Administrador.Usuarios
{
    partial class frmDetalleUsuario
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
            this.dgvDetalleUsuario = new System.Windows.Forms.DataGridView();
            this.numDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.iconBtnLupaDetalleUser = new FontAwesome.Sharp.IconButton();
            this.lblUsuariosReegistrados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbFiltrarRol = new System.Windows.Forms.ComboBox();
            this.cbFiltrarEstado = new System.Windows.Forms.ComboBox();
            this.lblUsuariosRegistrados = new System.Windows.Forms.Label();
            this.lblTotalUsuariosRegistrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleUsuario
            // 
            this.dgvDetalleUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDocumento,
            this.nombreCompleto,
            this.correo,
            this.telefono,
            this.rol,
            this.estado});
            this.dgvDetalleUsuario.Location = new System.Drawing.Point(12, 134);
            this.dgvDetalleUsuario.Name = "dgvDetalleUsuario";
            this.dgvDetalleUsuario.RowHeadersVisible = false;
            this.dgvDetalleUsuario.Size = new System.Drawing.Size(936, 365);
            this.dgvDetalleUsuario.TabIndex = 0;
            // 
            // numDocumento
            // 
            this.numDocumento.HeaderText = "Documento";
            this.numDocumento.Name = "numDocumento";
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.HeaderText = "Nombre completo";
            this.nombreCompleto.Name = "nombreCompleto";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
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
            this.iconBtnLupaDetalleUser.Location = new System.Drawing.Point(235, 99);
            this.iconBtnLupaDetalleUser.Name = "iconBtnLupaDetalleUser";
            this.iconBtnLupaDetalleUser.Size = new System.Drawing.Size(41, 21);
            this.iconBtnLupaDetalleUser.TabIndex = 2;
            this.iconBtnLupaDetalleUser.UseVisualStyleBackColor = false;
            // 
            // lblUsuariosReegistrados
            // 
            this.lblUsuariosReegistrados.AutoSize = true;
            this.lblUsuariosReegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosReegistrados.Location = new System.Drawing.Point(12, 9);
            this.lblUsuariosReegistrados.Name = "lblUsuariosReegistrados";
            this.lblUsuariosReegistrados.Size = new System.Drawing.Size(202, 26);
            this.lblUsuariosReegistrados.TabIndex = 3;
            this.lblUsuariosReegistrados.Text = "Usuarios Registrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por Rol:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroEstado.Location = new System.Drawing.Point(527, 80);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(105, 17);
            this.lblFiltroEstado.TabIndex = 6;
            this.lblFiltroEstado.Text = "Filtrar por estado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 19);
            this.textBox1.TabIndex = 7;
            // 
            // cbFiltrarRol
            // 
            this.cbFiltrarRol.FormattingEnabled = true;
            this.cbFiltrarRol.Location = new System.Drawing.Point(299, 97);
            this.cbFiltrarRol.Name = "cbFiltrarRol";
            this.cbFiltrarRol.Size = new System.Drawing.Size(207, 21);
            this.cbFiltrarRol.TabIndex = 8;
            // 
            // cbFiltrarEstado
            // 
            this.cbFiltrarEstado.FormattingEnabled = true;
            this.cbFiltrarEstado.Location = new System.Drawing.Point(530, 97);
            this.cbFiltrarEstado.Name = "cbFiltrarEstado";
            this.cbFiltrarEstado.Size = new System.Drawing.Size(239, 21);
            this.cbFiltrarEstado.TabIndex = 10;
            // 
            // lblUsuariosRegistrados
            // 
            this.lblUsuariosRegistrados.AutoSize = true;
            this.lblUsuariosRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosRegistrados.Location = new System.Drawing.Point(9, 512);
            this.lblUsuariosRegistrados.Name = "lblUsuariosRegistrados";
            this.lblUsuariosRegistrados.Size = new System.Drawing.Size(170, 17);
            this.lblUsuariosRegistrados.TabIndex = 11;
            this.lblUsuariosRegistrados.Text = "Total de usuarios registrados:";
            // 
            // lblTotalUsuariosRegistrados
            // 
            this.lblTotalUsuariosRegistrados.AutoSize = true;
            this.lblTotalUsuariosRegistrados.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuariosRegistrados.Location = new System.Drawing.Point(185, 512);
            this.lblTotalUsuariosRegistrados.Name = "lblTotalUsuariosRegistrados";
            this.lblTotalUsuariosRegistrados.Size = new System.Drawing.Size(16, 17);
            this.lblTotalUsuariosRegistrados.TabIndex = 12;
            this.lblTotalUsuariosRegistrados.Text = "0";
            // 
            // frmDetalleUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 538);
            this.Controls.Add(this.lblTotalUsuariosRegistrados);
            this.Controls.Add(this.lblUsuariosRegistrados);
            this.Controls.Add(this.cbFiltrarEstado);
            this.Controls.Add(this.cbFiltrarRol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFiltroEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuariosReegistrados);
            this.Controls.Add(this.iconBtnLupaDetalleUser);
            this.Controls.Add(this.dgvDetalleUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleUsuario";
            this.Load += new System.EventHandler(this.frmDetalleUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private FontAwesome.Sharp.IconButton iconBtnLupaDetalleUser;
        private System.Windows.Forms.Label lblUsuariosReegistrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbFiltrarRol;
        private System.Windows.Forms.ComboBox cbFiltrarEstado;
        private System.Windows.Forms.Label lblUsuariosRegistrados;
        private System.Windows.Forms.Label lblTotalUsuariosRegistrados;
    }
}