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
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Vistas.Administrador.Productos {

    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
            // Asegura que el evento Load esté registrado si el diseñador no lo hace
            this.Load += frmAltaProducto_Load;
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
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
                cboCategoriaProd.SelectedIndex = 0; // placeholder
                txtPrecioVentaProd.Clear();
                txtCostoProd.Clear();
                txtStockProd.Clear();
            }

        }

        private void CargarCategorias()
        {
            try
            {
                var cnCat = new CN_categoria();
                var categorias = cnCat.ObtenerCategorias();

                // Si fallo la consulta o está vacía, mostramos un placeholder informativo
                var lista = new List<Categoria>();
                lista.Add(new Categoria { id_categoria = 0, descripcion = "-- Seleccione categoría --" });

                if (categorias != null && categorias.Count > 0)
                {
                    lista.AddRange(categorias.OrderBy(c => c.descripcion));
                }
                else
                {
                    // Si no hay categorías en BD, añadimos un item informativo
                    // (se controla en btnGuardar para evitar inserciones con id 0)
                }

                // Bind seguro: primero despejar, luego setear Display/Value y DataSource
                cboCategoriaProd.DataSource = null;
                cboCategoriaProd.DisplayMember = "descripcion";
                cboCategoriaProd.ValueMember = "id_categoria";
                cboCategoriaProd.DataSource = lista;
                cboCategoriaProd.SelectedIndex = 0;

                // Opcional: evitar que el usuario escriba en el combo
                cboCategoriaProd.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                // No silencies la excepción: informa al usuario para depurar
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Dejar el combo con placeholder mínimo
                cboCategoriaProd.DataSource = null;
                cboCategoriaProd.Items.Clear();
                cboCategoriaProd.Items.Add("-- Error cargando categorías --");
                cboCategoriaProd.SelectedIndex = 0;
            }
        }
        /*
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            if (string.IsNullOrWhiteSpace(txtNombreProd.Text))
            {
                errIngresoDatos.SetError(txtNombreProd, "Debe ingresar un nombre.");
                return;
            }

            // Validar que se haya seleccionado una categoría distinta al placeholder (id = 0)
            if (cboCategoriaProd.SelectedValue == null
                || !int.TryParse(cboCategoriaProd.SelectedValue.ToString(), out int idCategoria)
                || idCategoria == 0)
            {
                errIngresoDatos.SetError(cboCategoriaProd, "Debe seleccionar una categoría válida.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionProd.Text))
            {
                errIngresoDatos.SetError(txtDescripcionProd, "Debe ingresar una descripción.");
                return;
            }

            var productoModel = new ProductoModel
            {
                nombre = txtNombreProd.Text.Trim(),
                descripcion = txtDescripcionProd.Text.Trim(),
                precio_vta = 0m,
                costo = 0m,
                stock = 0,
                id_categoria = new Categoria { id_categoria = idCategoria }
            };

            try
            {
                var cn = new CN_producto();
                cn.AgregarProducto(productoModel);
                MessageBox.Show("Producto registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProductosEnGrid();
            }
            catch (Exception ex)
            {
                // Mostrar detalles completos para depurar (temporal)
                var msg = new StringBuilder();
                msg.AppendLine("Error al registrar el producto: " + ex.Message);
                if (ex.InnerException != null) msg.AppendLine("InnerException: " + ex.InnerException.Message);
                if (ex.InnerException?.InnerException != null) msg.AppendLine("InnerException.Inner: " + ex.InnerException.InnerException.Message);
                msg.AppendLine();
                msg.AppendLine("StackTrace:");
                msg.AppendLine(ex.ToString());

                // Mostrar en MessageBox y opcionalmente escribir en un fichero o Output window
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();
            var result = MessageBox.Show("¿Está seguro que desea cancelar el registro del producto?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cargarProductosEnGrid()
        {
            try
            {
                var cnProducto = new CN_producto();
                var productos = cnProducto.ObtenerProductos();
                dgvRegistrarProducto.DataSource = null;
                dgvRegistrarProducto.DataSource = productos.Select(p => new
                {
                    p.nombre,
                    p.descripcion,
                    categoria = p.id_categoria.descripcion,
                    p.precio_vta,
                    p.costo,
                    p.stock
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAltaProducto_Load_1(object sender, EventArgs e)
        {
            cargarProductosEnGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errIngresoDatos.Clear();

            // --- VALIDACIÓN 1: CÓDIGO DE PRODUCTO ---
            if (string.IsNullOrWhiteSpace(txtCodProducto.Text))
            {
                errIngresoDatos.SetError(txtCodProducto, "Debe ingresar un código de producto.");
                return;
            }

            if (!int.TryParse(txtCodProducto.Text, out int codigoProducto))
            {
                errIngresoDatos.SetError(txtCodProducto, "El código debe ser un número entero válido.");
                return;
            }

            // --- VALIDACIÓN 2: NOMBRE ---
            if (string.IsNullOrWhiteSpace(txtNombreProd.Text))
            {
                errIngresoDatos.SetError(txtNombreProd, "Debe ingresar un nombre.");
                return;
            }

            // --- VALIDACIÓN 3: CATEGORÍA ---
            if (cboCategoriaProd.SelectedValue == null
                || !int.TryParse(cboCategoriaProd.SelectedValue.ToString(), out int idCategoria)
                || idCategoria == 0)
            {
                errIngresoDatos.SetError(cboCategoriaProd, "Debe seleccionar una categoría válida.");
                return;
            }

            try
            {
                var cn = new CN_producto();

                // --- VALIDACIÓN 4: EXISTENCIA DE CÓDIGO ---
                if (cn.ExisteProducto(codigoProducto))
                {
                    errIngresoDatos.SetError(txtCodProducto, "Ese código de producto ya existe. Por favor, ingrese otro.");
                    return;
                }

                // --- ARMADO DEL MODELO (Ahora con el código) ---
                var productoModel = new ProductoModel
                {
                    cod_producto = codigoProducto,
                    nombre = txtNombreProd.Text.Trim(),
                    descripcion = txtDescripcionProd.Text.Trim(),
                    precio_vta = 0m,
                    costo = 0m,
                    stock = 0,
                    id_categoria = new Categoria { id_categoria = idCategoria }
                };

                cn.AgregarProducto(productoModel);
                MessageBox.Show("Producto registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarProductosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
