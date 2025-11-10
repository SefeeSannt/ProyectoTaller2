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
    public partial class frmRegitroCompraRepositor : Form
    {
        private Usuario usuarioActual;
        private CapaEntidad.Proveedor proveedorActual;

        private int idCategoriaTemporal = 0;

        public frmRegitroCompraRepositor(Usuario oUsuario)
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


                var request = new CompraRequest
                {
                    dni_proveedor = this.proveedorActual,
                    fecha_compra = dtpFechaCompra.Value,
                    monto_total = decimal.Parse(txtTotalPagar.Text),
                    detalles = new List<DetalleCompraModel>(),

                    dni_usuario = this.usuarioActual
                }; 

                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
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

                var cnCompra = new CN_compra();
                int codGenerado = cnCompra.RegistrarCompra(request);

                if (codGenerado > 0)
                {
                    MessageBox.Show($"¡Compra registrada (N° {codGenerado}) y stock actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioCompra();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la compra: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<int> idsEnCarrito = new List<int>();
            foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
            {
                if (row.IsNewRow) continue;

                idsEnCarrito.Add(Convert.ToInt32(row.Cells["colCodProducto"].Value));
            }

            using (frmRepositorProductos frm = new frmRepositorProductos(idsEnCarrito,false))
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
                    
                    CapaNegocio.ProveedorModel proveedorElegido = frm.ProveedorSeleccionado;

                    this.proveedorActual = new CapaEntidad.Proveedor
                    {
                       
                        dni_proveedor = proveedorElegido.dni_proveedor,
                        nombre = proveedorElegido.nombre,
                    
                    };

              
                    txtNumProv.Text = this.proveedorActual.dni_proveedor.ToString();
                    txtNombreProv.Text = this.proveedorActual.nombre;
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
        /*
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
         */


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

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 60; 
            dgvRegistroCompras.Columns.Add(btnEliminar);


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

         
            string dni_proveedor = txtNumProv.Text;
            string nombre = txtNombreProv.Text;
            DateTime fechaCompra = dtpFechaCompra.Value;
            int id_categoria = this.idCategoriaTemporal;
            string cod_producto = txtCodProducto.Text;
            string nombre_producto = txtProductoNombre.Text;
            decimal monto_total = decimal.Parse(txtPrecioCompra.Text);
            int cantidad = (int)numUpDCantidad.Value;

            decimal subTotal = monto_total * cantidad;

            dgvRegistroCompras.Rows.Add(
                dni_proveedor, 
                nombre,
                fechaCompra,
                id_categoria,
                cod_producto,
                nombre_producto,
                monto_total,
                cantidad,
                subTotal
            );

            LimpiarCamposProducto();
            CalcularTotalPagar();
        }
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

        private void dgvRegistroCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvRegistroCompras.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este producto de la lista?",
                                                            "Confirmar Eliminación",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
        
                    if (!dgvRegistroCompras.Rows[e.RowIndex].IsNewRow)
                    {
                        dgvRegistroCompras.Rows.RemoveAt(e.RowIndex);

                        CalcularTotalPagar();
                    }
                }
            }
        }
    }
}
