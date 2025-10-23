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

            if (cboProducto.SelectedIndex == -1)
            {
                errIngresoDatos.SetError(cboProducto, "Ingrese un producto");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Ya no necesitas cerrar otros formularios hijos aquí

            // Abre frmListaProductos como un DIÁLOGO.
            // Esto pausa el formulario actual hasta que el usuario
            // seleccione un producto y cierre la lista.

            using (frmRepositorProductos frm = new frmRepositorProductos())
            {
                frm.ShowDialog();

                // Opcional: Después de que se cierre el diálogo,
                // puedes recuperar el producto que el usuario seleccionó.
                // if (frm.DialogResult == DialogResult.OK) { ... }
            }
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            using (frmCompraProveedor frm = new frmCompraProveedor())
            {
                // 1. Abre la lista de proveedores como un diálogo
                DialogResult resultado = frm.ShowDialog();

                // 2. Verifica si el usuario cerró con "OK" (haciendo doble clic)
                if (resultado == DialogResult.OK)
                {
                    // 3. Lee la propiedad pública que creamos en el Paso 1
                    ProveedorModel proveedorElegido = frm.ProveedorSeleccionado;

                    // 4. Asigna los valores a tus TextBoxes
                    txtNumProv.Text = proveedorElegido.dni_proveedor.ToString();

                    // ¡AQUÍ PUEDES RELLENAR OTROS TEXTBOXES!
                    // Por ejemplo, si tuvieras un TextBox txtNombreProv:
                     txtNombreProv.Text = proveedorElegido.nombre;
                }
            }
            // Si el usuario cierra la ventana con la 'X', el resultado no es 'OK'
            // y el código simplemente no hace nada, que es lo que queremos.
            /* using (frmCompraProveedor frm = new frmCompraProveedor())
             {
                 frm.ShowDialog();

                 // Opcional: Después de que se cierre el diálogo,
                 // puedes recuperar el producto que el usuario seleccionó.
                 // if (frm.DialogResult == DialogResult.OK) { ... }
             }*/
        }
    }
}
