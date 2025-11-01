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
using CapaEntidad;


namespace CapaPresentacion.Vistas.Repositor
{
    public partial class frmRegistroVenta : Form
    {
        private Usuario usuarioActual;
        private CapaEntidad.Cliente clienteActual;

        private int idCategoriaTemporal = 0;

        public frmRegistroVenta(Usuario oUsuario)
        {
            InitializeComponent();

            this.usuarioActual = oUsuario;
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
            txtNumCliente.Clear();
            txtNombreCliente.Clear();

            LimpiarCamposProducto();

            dgvRegistroVenta.Rows.Clear();

            CalcularTotalPagar();

            dtpFechaCompra.Value = DateTime.Now;

            txtNumCliente.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dgvRegistroVenta.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto a la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {


                // Construir request de compra desde la grilla
                var request = new VentaRequest
                {
                    dni_cliente = this.clienteActual,
                    fecha_compra = dtpFechaCompra.Value,
                    monto_total = decimal.Parse(txtTotalPagar.Text),
                    detalles = new List<DetalleCompraModel>(),

                    dni_usuario = this.usuarioActual
                }; 

                foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
                {
                    // Orden de las columnas al añadir filas:
                    // 0: dniProveedor, 1: nombreProveedor, 2: fecha, 3: idCategoria,
                    // 4: codProducto, 5: nombreProducto, 6: precioCompra, 7: cantidad, 8: subTotal
                   
                    
                    int codProducto = Convert.ToInt32(row.Cells[4].Value);
                    decimal precioCompra = Convert.ToDecimal(row.Cells[6].Value);
                    int cantidadAAgregar = Convert.ToInt32(row.Cells[7].Value);
                    decimal subTotal = Convert.ToDecimal(row.Cells[8].Value);

                    request.detalles.Add(new DetalleCompraModel
                    {
                        cod_producto = codProducto,
                        cantidad = cantidadAAgregar,
                        precio_compra = precioCompra,
                        subtotal = subTotal
                    });
                }

                var cnVenta = new CN_venta();
                int codGenerado = cnVenta.RegistrarVenta(request);

                if (codGenerado > 0)
                {
                    MessageBox.Show($"¡Venta registrada (N° {codGenerado}) y stock actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioCompra();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*cambios*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            List<int> idsEnCarrito = new List<int>();
            foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
            {
                if (row.IsNewRow) continue;

                idsEnCarrito.Add(Convert.ToInt32(row.Cells["colCodProducto"].Value));
            }

            using (frmRepositorProductos frm = new frmRepositorProductos(idsEnCarrito)) 
            {
                DialogResult resultado = frm.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    ProductoModel productoElegido = frm.ProductoSeleccionado;

                    txtCodProducto.Text = productoElegido.cod_producto.ToString();
                    txtProductoNombre.Text = productoElegido.nombre;
                    txtPrecio.Text = productoElegido.precio_vta.ToString("0.00");

                    this.idCategoriaTemporal = productoElegido.id_categoria.id_categoria;
                }
            }

        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (frmCompraCliente frm = new frmCompraCliente())
            {
                DialogResult resultado = frm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // 1. Obtienes el Modelo (de CapaNegocio)
                    // Asumo que tu popup devuelve este tipo, basado en el error
                    CapaNegocio.ClienteModel clienteElegido = frm.ClienteSeleccionado;

                    // 2. Conviertes el Modelo a la Entidad
                    // (Esta es la corrección)
                    this.clienteActual = new CapaEntidad.Cliente
                    {
                        // Copia las propiedades del modelo a la entidad
                        dni_cliente =clienteElegido.dni,
                        nombre = clienteElegido.nombre,
                        // (Copia cualquier otra propiedad que necesites)
                    };

                    // 3. Actualizas la UI usando la variable 'proveedorActual'
                    txtNumCliente.Text = this.clienteActual.dni_cliente.ToString();
                    txtNombreCliente.Text = this.clienteActual.nombre;
                }
            }
        }
         

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.onlyDecimal(sender, e, errIngresoDatos);
        }

        private void CargarProductoEnGrid()
        {
            var negocio = new CN_producto();
            var lista = negocio.ObtenerProductosActivos() ?? new List<ProductoModel>();
            dgvRegistroVenta.DataSource = lista;
            if (dgvRegistroVenta.Columns.Contains("id_estado"))
            {
                dgvRegistroVenta.Columns["id_estado"].Visible = false;
            }
        }

        private void frmRegitroVentaCliente_Load(object sender, EventArgs e)
        {

            dgvRegistroVenta.AutoGenerateColumns = false;

            dgvRegistroVenta.Columns.Add("colDNICliente", "DNI Cliente");
            dgvRegistroVenta.Columns["colDNICliente"].Visible = false;
            dgvRegistroVenta.Columns.Add("colNombreCliente", "Nombre Cliente");
            dgvRegistroVenta.Columns["colNombreCliente"].Visible = false;

            dgvRegistroVenta.Columns.Add("colFecha", "Fecha");
            dgvRegistroVenta.Columns["colFecha"].Visible = false;

            dgvRegistroVenta.Columns.Add("colIDCategoria", "ID Categoría");
            dgvRegistroVenta.Columns["colIDCategoria"].Visible = false;

            dgvRegistroVenta.Columns.Add("colCodProducto", "Cod. Producto");
            dgvRegistroVenta.Columns.Add("colProducto", "Producto");
            dgvRegistroVenta.Columns.Add("colPrecioVenta", "Precio Venta");
            dgvRegistroVenta.Columns.Add("colCantidad", "Cantidad");
            dgvRegistroVenta.Columns.Add("colSubTotal", "Sub Total");

            dgvRegistroVenta.Columns["colCodProducto"].Visible = false;
            dgvRegistroVenta.Columns["colPrecioVenta"].DefaultCellStyle.Format = "0.00";
            dgvRegistroVenta.Columns["colSubTotal"].DefaultCellStyle.Format = "0.00";
        }

        private void LimpiarCamposProducto()
        {
            txtCodProducto.Clear();
            txtProductoNombre.Clear();
            txtPrecio.Clear();
            numUpDCantidad.Value = 0; // Asumo que 0 es tu valor mínimo
            this.idCategoriaTemporal = 0;
            txtCodProducto.Focus(); // Pone el cursor de nuevo en el código
        }

        private void CalcularTotalPagar()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
            {
                total += Convert.ToDecimal(row.Cells["colSubTotal"].Value);
            }

            txtTotalPagar.Text = total.ToString("0.00");
        }
        private void btnRegistrarP_Click(object sender, EventArgs e)
        {

            errIngresoDatos.Clear();

            if (string.IsNullOrEmpty(txtNumCliente.Text))
            {
                errIngresoDatos.SetError(txtNumCliente, "Debe seleccionar un proveedor");
                return;
            }
           
            if (string.IsNullOrEmpty(txtCodProducto.Text))
            {
                errIngresoDatos.SetError(txtCodProducto, "Debe seleccionar un producto");
                return;
            }

            if (numUpDCantidad.Value == 0)
            {
                errIngresoDatos.SetError(numUpDCantidad, "La cantidad no puede ser 0");
                return;
            }

         
            string dni_cliente = txtNumCliente.Text;
            string nombre = txtNombreCliente.Text;
            DateTime fechaCompra = dtpFechaCompra.Value;
            int id_categoria = this.idCategoriaTemporal;
            string cod_producto = txtCodProducto.Text;
            string nombre_producto = txtProductoNombre.Text;
            decimal monto_total = decimal.Parse(txtPrecio.Text);
            int cantidad = (int)numUpDCantidad.Value;

            // ---  CALCULAR SUBTOTAL ---
            decimal subTotal = monto_total * cantidad;

            // ---  AÑADIR FILA A LA GRILLA ---
            dgvRegistroVenta.Rows.Add(
                dni_cliente, 
                nombre,
                fechaCompra,
                id_categoria,
                cod_producto,
                nombre_producto,
                monto_total,
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
