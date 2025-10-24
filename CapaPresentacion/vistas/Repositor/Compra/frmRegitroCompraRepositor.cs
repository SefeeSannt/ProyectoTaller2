using CapaNegocio;
using CapaPresentacion.Helpers;
using CapaPresentacion.vistas.Administrador;
using CapaPresentacion.vistas.Repositor.Compra;
using CapaPresentacion.Vistas.Administrador.Productos;
using CapaPresentacion.Vistas.Repositor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (string.IsNullOrEmpty(txtNumProv.Text))
            {
                errIngresoDatos.SetError(txtNumProv, "Ingrese un numero de documento");
                return;
            }

            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                errIngresoDatos.SetError(txtCodProducto, "Ingrese un codigo de producto");
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

        /*Agrega el producto selecciconado en los txtbox de frmRegistroCompra*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmRepositorProductos frm = new frmRepositorProductos())
            {
                //frm.ShowDialog();
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    ProductoModel productoElegido = frm.ProductoSeleccionado;
                    txtCodProducto.Text = productoElegido.cod_producto.ToString();
                    txtProductoNombre.Text = productoElegido.nombre;
                    txtPrecioCompra.Text = productoElegido.costo.ToString();
                }
            }
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            using (frmCompraProveedor frm = new frmCompraProveedor())
            {
                DialogResult resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    ProveedorModel proveedorElegido = frm.ProveedorSeleccionado;

                    txtNumProv.Text = proveedorElegido.dni_proveedor.ToString();

            
                     txtNombreProv.Text = proveedorElegido.nombre;
                }
            }
         
        }
    }
}
