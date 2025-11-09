using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Repositor.Proveedor
{
    public partial class frmEditarProducto : Form
    {
        // Producto recibido desde la vista previa (si se abre para editar)
        public ProductoModel ProductoSeleccionado { get; set; }

        public frmEditarProducto()
        {
            InitializeComponent();
            this.Load += frmEditarProducto_Load;

            // Suscribir el evento de doble click en el grid
            this.dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
        }

        // Sobrecarga para abrir el form con el producto a editar
        public frmEditarProducto(ProductoModel producto) : this()
        {
            ProductoSeleccionado = producto;
        }

        public void CargarProductosEnGrid()
        {
            var negocio = new CN_producto();
            var lista = negocio.ObtenerProductos();
            dgvProductos.DataSource = lista;
            FormatearGrillaProductos();
        }

        // Carga las categorías desde la capa de negocio y las enlaza al ComboBox
        private void CargarCategorias()
        {
            try
            {
                var cnCat = new CN_categoria();
                var categorias = cnCat.ObtenerCategorias() ?? new List<Categoria>();

                var lista = new List<Categoria>
                {
                    new Categoria { id_categoria = 0, descripcion = "-- Seleccione categoría --" }
                };

                lista.AddRange(categorias.OrderBy(c => c.descripcion));

                cboCategoriaProd.DataSource = null;
                cboCategoriaProd.DisplayMember = "descripcion";
                cboCategoriaProd.ValueMember = "id_categoria";
                cboCategoriaProd.DataSource = lista;
                cboCategoriaProd.SelectedIndex = 0;
                cboCategoriaProd.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_producto();
            var criterio = txtProducto.Text;
            var lista = negocio.BuscarProductosActivos(criterio);
            dgvProductos.DataSource = lista;

            FormatearGrillaProductos();
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            // Cargar datos base
            CargarCategorias();
            CargarProductosEnGrid();

            // Si se abrió con un producto a editar, rellenar controles y seleccionar categoría
            if (ProductoSeleccionado != null)
            {
                txtCodProducto.Text = ProductoSeleccionado.cod_producto.ToString();
                txtCodProducto.Enabled = false; // no permitir cambiar el código
                txtNombreProd.Text = ProductoSeleccionado.nombre;
                txtDescripcionProd.Text = ProductoSeleccionado.descripcion;

                // Si quieres mostrar también los demás valores (opcional)
                txtPrecioVentaProd.Text = ProductoSeleccionado.precio_vta.ToString("0.00");
                txtCostoProd.Text = ProductoSeleccionado.costo.ToString("0.00");
                txtStockProd.Text = ProductoSeleccionado.stock.ToString();

                // Seleccionar la categoría actual en el ComboBox (usando SelectedValue)
                if (ProductoSeleccionado.id_categoria != null)
                {
                    try
                    {
                        cboCategoriaProd.SelectedValue = ProductoSeleccionado.id_categoria.id_categoria;
                    }
                    catch
                    {
                        // si no existe en la lista, dejar el índice 0
                        cboCategoriaProd.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrWhiteSpace(txtNombreProd.Text))
            {
                errIngresoDatos.SetError(txtNombreProd, "El campo nombre es obligatorio");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcionProd.Text))
            {
                errIngresoDatos.SetError(txtDescripcionProd, "El campo descripcion es obligatorio");
                return;
            }

            if (cboCategoriaProd.SelectedValue == null || !int.TryParse(cboCategoriaProd.SelectedValue.ToString(), out int idCategoria) || idCategoria == 0)
            {
                errIngresoDatos.SetError(cboCategoriaProd, "Debe seleccionar una categoria");
                return;
            }

            if (!int.TryParse(txtCodProducto.Text, out int codProducto))
            {
                errIngresoDatos.SetError(txtCodProducto, "Código de producto inválido");
                return;
            }

            try
            {
                var cnProducto = new CN_producto();

                // Obtener el producto existente desde la capa de negocio (para conservar los campos no editables)
                var existente = cnProducto.ObtenerProductos().FirstOrDefault(p => p.cod_producto == codProducto);
                if (existente == null)
                {
                    MessageBox.Show("No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Construir modelo: conservar valores existentes y solo reemplazar nombre/descripcion/categoría
                var productoModificado = new ProductoModel
                {
                    cod_producto = existente.cod_producto,
                    nombre = txtNombreProd.Text.Trim(),
                    descripcion = txtDescripcionProd.Text.Trim(),
                    precio_vta = existente.precio_vta,
                    costo = existente.costo,
                    stock = existente.stock,
                    estado = existente.estado,
                    id_categoria = new Categoria { id_categoria = idCategoria }
                };

                cnProducto.ActualizarProducto(productoModificado);
                MessageBox.Show("Producto modificado con éxito.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nuevo manejador: carga datos de la fila seleccionada en los controles
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtener el objeto enlazado a la fila (ProductoModel)
            var item = dgvProductos.Rows[e.RowIndex].DataBoundItem as ProductoModel;
            if (item == null) return;

            // Guardar referencia al producto seleccionado (opcional)
            ProductoSeleccionado = item;

            // Rellenar controles
            txtCodProducto.Text = item.cod_producto.ToString();
            txtCodProducto.Enabled = false; // no permitir cambiar el código
            txtNombreProd.Text = item.nombre ?? string.Empty;
            txtDescripcionProd.Text = item.descripcion ?? string.Empty;
            txtPrecioVentaProd.Text = item.precio_vta.ToString("0.00");
            txtCostoProd.Text = item.costo.ToString("0.00");
            txtStockProd.Text = item.stock.ToString();

            // Seleccionar categoría en el ComboBox por SelectedValue (id_categoria)
            try
            {
                if (item.id_categoria != null)
                    cboCategoriaProd.SelectedValue = item.id_categoria.id_categoria;
                else
                    cboCategoriaProd.SelectedIndex = 0;
            }
            catch
            {
                // En caso de que la categoría no exista en la lista, seleccionamos el primer elemento
                cboCategoriaProd.SelectedIndex = 0;
            }
        }



        private void FormatearGrillaProductos()
        {
            if (dgvProductos.Columns.Count == 0) return;

            // --- Ocultamos las columnas que no queremos ver ---
            // Usamos 'Contains' para evitar errores si la columna no existe
            if (dgvProductos.Columns.Contains("cod_producto"))
                dgvProductos.Columns["cod_producto"].Visible = false;

            if (dgvProductos.Columns.Contains("estado"))
                dgvProductos.Columns["estado"].Visible = false;

            if (dgvProductos.Columns.Contains("id_categoria"))
                dgvProductos.Columns["id_categoria"].Visible = false;

            if (dgvProductos.Columns.Contains("nombre"))
                dgvProductos.Columns["nombre"].HeaderText = "Nombre";

            if (dgvProductos.Columns.Contains("descripcion"))
                dgvProductos.Columns["descripcion"].HeaderText = "Descripción";

            if (dgvProductos.Columns.Contains("precio_vta"))
                dgvProductos.Columns["precio_vta"].HeaderText = "Precio Venta";

            if (dgvProductos.Columns.Contains("costo"))
                dgvProductos.Columns["costo"].HeaderText = "Costo";

            if (dgvProductos.Columns.Contains("stock"))
                dgvProductos.Columns["stock"].HeaderText = "Stock";
        }
    }
}
