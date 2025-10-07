using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion.Vistas.Login
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconBtnIngresar = new FontAwesome.Sharp.IconButton();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNNroDocumento = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei Light", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitulo.Location = new System.Drawing.Point(39, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 60);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Tienda ZonaFit";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFondo.BackgroundImage")));
            this.pnlFondo.Controls.Add(this.iconBtnCancelar);
            this.pnlFondo.Controls.Add(this.iconBtnIngresar);
            this.pnlFondo.Controls.Add(this.lblContrasenia);
            this.pnlFondo.Controls.Add(this.lblNNroDocumento);
            this.pnlFondo.Controls.Add(this.txtClave);
            this.pnlFondo.Controls.Add(this.txtUsername);
            this.pnlFondo.Controls.Add(this.btnSalir);
            this.pnlFondo.Controls.Add(this.lblTitulo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(410, 328);
            this.pnlFondo.TabIndex = 8;
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.Location = new System.Drawing.Point(263, 235);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnCancelar.TabIndex = 14;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.UseVisualStyleBackColor = true;
            this.iconBtnCancelar.Click += new System.EventHandler(this.iconBtnCancelar_Click);
            // 
            // iconBtnIngresar
            // 
            this.iconBtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnIngresar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnIngresar.IconColor = System.Drawing.Color.Black;
            this.iconBtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnIngresar.Location = new System.Drawing.Point(80, 235);
            this.iconBtnIngresar.Name = "iconBtnIngresar";
            this.iconBtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.iconBtnIngresar.TabIndex = 13;
            this.iconBtnIngresar.Text = "Ingresar";
            this.iconBtnIngresar.UseVisualStyleBackColor = true;
            this.iconBtnIngresar.Click += new System.EventHandler(this.iconBtnIngresar_Click);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(185, 176);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(34, 13);
            this.lblContrasenia.TabIndex = 12;
            this.lblContrasenia.Text = "Clave";
            // 
            // lblNNroDocumento
            // 
            this.lblNNroDocumento.AutoSize = true;
            this.lblNNroDocumento.Location = new System.Drawing.Point(174, 132);
            this.lblNNroDocumento.Name = "lblNNroDocumento";
            this.lblNNroDocumento.Size = new System.Drawing.Size(55, 13);
            this.lblNNroDocumento.TabIndex = 11;
            this.lblNNroDocumento.Text = "Username";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(80, 192);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(258, 20);
            this.txtClave.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(80, 148);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(258, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSalir.IconColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.Location = new System.Drawing.Point(366, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(41, 41);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 328);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFondo;
        private FontAwesome.Sharp.IconButton btnSalir;
        private TextBox txtUsername;
        private Label lblContrasenia;
        private Label lblNNroDocumento;
        private TextBox txtClave;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private FontAwesome.Sharp.IconButton iconBtnIngresar;
    }
}

