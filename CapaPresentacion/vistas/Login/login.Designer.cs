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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSupervisor = new FontAwesome.Sharp.IconButton();
            this.btnAdmin = new FontAwesome.Sharp.IconButton();
            this.btnVendedor = new FontAwesome.Sharp.IconButton();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei Light", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitulo.Location = new System.Drawing.Point(35, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 60);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Tienda ZonaFit";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSupervisor
            // 
            this.btnSupervisor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSupervisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupervisor.FlatAppearance.BorderSize = 0;
            this.btnSupervisor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupervisor.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnSupervisor.IconColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSupervisor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSupervisor.Location = new System.Drawing.Point(107, 227);
            this.btnSupervisor.Name = "btnSupervisor";
            this.btnSupervisor.Size = new System.Drawing.Size(200, 55);
            this.btnSupervisor.TabIndex = 5;
            this.btnSupervisor.Text = "Repositor";
            this.btnSupervisor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupervisor.UseVisualStyleBackColor = false;
            this.btnSupervisor.Click += new System.EventHandler(this.btnSupervisor_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnAdmin.IconColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(107, 105);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 55);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendedor.FlatAppearance.BorderSize = 0;
            this.btnVendedor.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVendedor.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnVendedor.IconColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendedor.Location = new System.Drawing.Point(107, 166);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(200, 55);
            this.btnVendedor.TabIndex = 3;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.btnSalir);
            this.pnlFondo.Controls.Add(this.lblTitulo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(410, 328);
            this.pnlFondo.TabIndex = 8;
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
            this.Controls.Add(this.btnSupervisor);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnVendedor);
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
        private FontAwesome.Sharp.IconButton btnVendedor;
        private FontAwesome.Sharp.IconButton btnSupervisor;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private System.Windows.Forms.Panel pnlFondo;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}

