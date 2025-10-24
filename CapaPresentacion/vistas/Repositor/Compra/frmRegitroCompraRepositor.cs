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
        private int idCategoriaTemporal = 0;

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

        private void LimpiarFormularioCompra()
        {
            txtNumProv.Clear();
            txtNombreProv.Clear();

            LimpiarCamposProducto();

            dgvRegistroCompras.Rows.Clear();

            CalcularTotalPagar();

            dtpFechaCompra.Value = DateTime.Now;

            txtNumProv.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dgvRegistroCompras.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var cnProducto = new CN_producto();

                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {

                    int codProducto = Convert.ToInt32(row.Cells["colCodProducto"].Value);

                    decimal nuevoCosto = Convert.ToDecimal(row.Cells["colPrecioCompra"].Value);
                    int cantidadAAgregar = Convert.ToInt32(row.Cells["colCantidad"].Value);

                    cnProducto.ActualizarStockYCostos(codProducto, nuevoCosto, cantidadAAgregar);
                }

                MessageBox.Show("¡Compra registrada y stock actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioCompra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmRepositorProductos frm = new frmRepositorProductos())
            {
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    ProductoModel productoElegido = frm.ProductoSeleccionado;
                    txtCodProducto.Text = productoElegido.cod_producto.ToString();
                    txtProductoNombre.Text = productoElegido.nombre;
                    txtPrecioCompra.Text = productoElegido.costo.ToString();

                    this.idCategoriaTemporal = productoElegido.id_categoria.id_categoria;
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

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyDecimal(sender, e, errIngresoDatos);
        }

        private void CalcularPrecioVenta()
        {
            if (decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra))
            {
               
                decimal precioVenta = precioCompra * 1.20m;

                txtPrecioVenta.Text = precioVenta.ToString("0.00");
                errIngresoDatos.SetError(txtPrecioCompra, ""); // Limpia error si lo hubo
            }
            else
            {
                txtPrecioVenta.Text = "";
            }
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        private void CargarProductoEnGrid()
        {
            var negocio = new CN_producto();
            var lista = negocio.ObtenerProductosActivos() ?? new List<ProductoModel>();
            dgvRegistroCompras.DataSource = lista;
            if (dgvRegistroCompras.Columns.Contains("id_estado"))
            {
                dgvRegistroCompras.Columns["id_estado"].Visible = false;
            }
        }

        private void frmRegitroCompraRepositor_Load(object sender, EventArgs e)
        {

            dgvRegistroCompras.AutoGenerateColumns = false;

            dgvRegistroCompras.Columns.Add("colDNIProveedor", "DNI Proveedor");
            dgvRegistroCompras.Columns["colDNIProveedor"].Visible = false;
            dgvRegistroCompras.Columns.Add("colNombreProveedor", "Nombre Proveedor");
            dgvRegistroCompras.Columns["colNombreProveedor"].Visible = false;

            dgvRegistroCompras.Columns.Add("colFecha", "Fecha");
            dgvRegistroCompras.Columns["colFecha"].Visible = false;

            dgvRegistroCompras.Columns.Add("colIDCategoria", "ID Categoría");
            dgvRegistroCompras.Columns["colIDCategoria"].Visible = false;

            dgvRegistroCompras.Columns.Add("colCodProducto", "Cod. Producto");
            dgvRegistroCompras.Columns.Add("colProducto", "Producto");
            dgvRegistroCompras.Columns.Add("colPrecioCompra", "Precio Compra");
            dgvRegistroCompras.Columns.Add("colCantidad", "Cantidad");
            dgvRegistroCompras.Columns.Add("colSubTotal", "Sub Total");

            dgvRegistroCompras.Columns["colCodProducto"].Visible = false;
            dgvRegistroCompras.Columns["colPrecioCompra"].DefaultCellStyle.Format = "0.00";
            dgvRegistroCompras.Columns["colSubTotal"].DefaultCellStyle.Format = "0.00";
        }

        private void LimpiarCamposProducto()
        {
            txtCodProducto.Clear();
            txtProductoNombre.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            numUpDCantidad.Value = 0; // Asumo que 0 es tu valor mínimo
            this.idCategoriaTemporal = 0;
            txtCodProducto.Focus(); // Pone el cursor de nuevo en el código
        }

        private void CalcularTotalPagar()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colSubTotal"].Value);
            }

            txtTotalPagar.Text = total.ToString("0.00");
        }
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {

            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtNumProv.Text))
            {
                errIngresoDatos.SetError(txtNumProv, "Debe seleccionar un proveedor");
                return;
            }
           
            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                errIngresoDatos.SetError(txtCodProducto, "Debe seleccionar un producto");
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

         
            string dniProveedor = txtNumProv.Text;
            string nombreProveedor = txtNombreProv.Text;
            DateTime fechaCompra = dtpFechaCompra.Value;
            int idCategoria = this.idCategoriaTemporal;
            string codProducto = txtCodProducto.Text;
            string nombreProducto = txtProductoNombre.Text;
            decimal precioCompra = decimal.Parse(txtPrecioCompra.Text);
            int cantidad = (int)numUpDCantidad.Value;

            // ---  CALCULAR SUBTOTAL ---
            decimal subTotal = precioCompra * cantidad;

            // ---  AÑADIR FILA A LA GRILLA ---
            dgvRegistroCompras.Rows.Add(
                dniProveedor, 
                nombreProveedor,
                fechaCompra,
                idCategoria,
                codProducto,
                nombreProducto,
                precioCompra,
                cantidad,
                subTotal
            );

            // --- LIMPIAR CAMPOS Y CALCULAR TOTAL ---
            LimpiarCamposProducto();
            CalcularTotalPagar();
        }
        // --- DESVIA EL FOCO DEL CURSO ESO HACE ENTER---
        private void txtNumProv_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }

        private void txtNombreProv_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }

        private void txtCodProducto_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }

        private void txtProductoNombre_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }

        private void txtTotalPagar_Enter(object sender, EventArgs e)
        {
            btnRegistrar.Focus();
        }
    }
}
