using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Helpers;

namespace CapaPresentacion.Vistas.Administrador.Productos {

    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void onlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyNumbers(sender, e, errIngresoDatos);
        }

        private void onlyInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void noWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            var result = MessageBox.Show("¿Está seguro que desea limpiar el registro del producto?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtNombreProd.Clear();
                txtDescripcionProd.Clear();
                cboCategoriaProd.SelectedIndex = -1;
                txtPrecioVentaProd.Clear();
                txtCostoProd.Clear();
                txtStockProd.Clear();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrWhiteSpace(txtNombreProd.Text))
            {
                errIngresoDatos.SetError(txtNombreProd, "Debe ingresar un nombre.");
                return;
            }

            if (cboCategoriaProd.SelectedIndex == -1)
            {
                errIngresoDatos.SetError(cboCategoriaProd, "Debe seleccionar una categoría.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProd.Text))
            {
                errIngresoDatos.SetError(txtDescripcionProd, "Debe ingresar una descripción.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioVentaProd.Text))
            {
                errIngresoDatos.SetError(txtPrecioVentaProd, "Debe ingresar un precio de venta.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCostoProd.Text))
            {
                errIngresoDatos.SetError(txtCostoProd, "Debe ingresar un costo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStockProd.Text))
            {
                errIngresoDatos.SetError(txtStockProd, "Debe ingresar un stock.");
                return;
            }

            //guardar en base de datos
            MessageBox.Show("Producto registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();
            var result = MessageBox.Show("¿Está seguro que desea cancelar el registro del producto?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
