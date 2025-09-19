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

namespace CapaPresentacion.Vistas.Repositor
{
    public partial class frmRegitroCompraRepositor : Form
    {
        public frmRegitroCompraRepositor()
        {
            InitializeComponent();
        }

        private void onlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyNumbers(sender, e,errIngresoDatos);
        }

        private void onlyInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyInteger(sender, e, errIngresoDatos);
        }

        private void noWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.noWrite(sender, e);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtNumDoc.Text))
            {
                errIngresoDatos.SetError(txtNumDoc, "Ingrese un numero de documento");
                return;
            }

            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                errIngresoDatos.SetError(txtCodProducto, "Ingrese un codigo de producto");
                return;
            }

            if (string.IsNullOrEmpty(txtProductos.Text))
            {
                errIngresoDatos.SetError(txtProductos, "Ingrese un producto");
                return;
            }

            if (string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                errIngresoDatos.SetError(txtPrecioCompra, "Ingrese un precio de compra");
                return;
            }

            

            if (numUpDCantidad.Value == 0)
            {
                errIngresoDatos.SetError(numUpDCantidad, "La cantidad no puede ser 0");
                return;
            }

            MessageBox.Show("Compra registrada con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
