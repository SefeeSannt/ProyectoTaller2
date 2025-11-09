using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion.vistas.Administrador.Productos
{
    public partial class frmBajaProducto : Form
    {
        public frmBajaProducto()
        {
            InitializeComponent();

            // Evitar generación automática de columnas
            dgvBajaProducto.AutoGenerateColumns = false;

            // Crear columnas una sola vez
            CrearColumnas();
            this.Load += frmBajaProducto_Load;
            dgvBajaProducto.CellClick += dgvBajaProducto_CellClick;
            dgvBajaProducto.RowPrePaint += dgvBajaProducto_RowPrePaint;
        }

        private void CrearColumnas()
        {
            dgvBajaProducto.Columns.Clear();

            // Columna oculta con el código del producto (necesaria para acciones)
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "cod_producto",
                HeaderText = "Código",
                DataPropertyName = "cod_producto",
                Visible = false
            });

            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "nombre", HeaderText = "Nombre", DataPropertyName = "nombre" });
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "descripcion", HeaderText = "Descripción", DataPropertyName = "descripcion" });
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "categoria", HeaderText = "Categoría", DataPropertyName = "categoria" });
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "precio_vta", HeaderText = "Precio", DataPropertyName = "precio_vta" });
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "costo", HeaderText = "Costo", DataPropertyName = "costo" });
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "stock", HeaderText = "Stock", DataPropertyName = "stock" });

            // Columna oculta con el valor numérico del estado (0/1)
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "estado_raw", HeaderText = "estado_raw", DataPropertyName = "estado_raw", Visible = false });

            // Columna visible con texto "Activo"/"Inactivo"
            dgvBajaProducto.Columns.Add(new DataGridViewTextBoxColumn { Name = "estado", HeaderText = "Estado", DataPropertyName = "estado" });

            // Botón acción al final
            var btn = new DataGridViewButtonColumn
            {
                Name = "AccionBtn",
                HeaderText = "Acción",
                UseColumnTextForButtonValue = false
            };
            dgvBajaProducto.Columns.Add(btn);
        }

        private void cargarDatosProducto()
        {
            var cnProducto = new CN_producto();
            var productos = cnProducto.ObtenerProductos() ?? new List<ProductoModel>();

            var lista = productos.Select(p => new
            {
                p.cod_producto,
                p.nombre,
                p.descripcion,
                categoria = p.id_categoria != null ? p.id_categoria.descripcion : string.Empty,
                p.precio_vta,
                p.costo,
                p.stock,
                estado_raw = p.estado,
                estado = p.estado == 1 ? "Activo" : "Inactivo",
                accion = p.estado == 1 ? "Dar de baja" : "Dar de alta"
            }).ToList();

            dgvBajaProducto.DataSource = lista;

            // rellenar texto de los botones
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < dgvBajaProducto.Rows.Count)
                    dgvBajaProducto.Rows[i].Cells["AccionBtn"].Value = lista[i].accion;
            }
        }

        private void frmBajaProducto_Load(object sender, EventArgs e)
        {
            cargarDatosProducto();
        }

        private void dgvBajaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvBajaProducto.Columns[e.ColumnIndex];
            if (col == null || col.Name != "AccionBtn") return;

            var row = dgvBajaProducto.Rows[e.RowIndex];

            // Intentamos obtener el código desde la columna oculta; si no existe, lo leemos del DataBoundItem
            object codObj = null;
            if (dgvBajaProducto.Columns.Contains("cod_producto"))
            {
                codObj = row.Cells["cod_producto"].Value;
            }
            else
            {
                // Fallback: obtener propiedad cod_producto del objeto enlazado
                var item = row.DataBoundItem;
                if (item != null)
                {
                    var prop = item.GetType().GetProperty("cod_producto");
                    if (prop != null) codObj = prop.GetValue(item);
                }
            }

            // Estado numérico (preferimos la columna oculta)
            object estadoObj = dgvBajaProducto.Columns.Contains("estado_raw") ? row.Cells["estado_raw"].Value : null;

            if (codObj == null || estadoObj == null) return;

            int cod = Convert.ToInt32(codObj);
            int estado = Convert.ToInt32(estadoObj);
            int nuevoEstado = estado == 1 ? 0 : 1;

            var cn = new CN_producto();
            var ok = cn.CambiarEstadoProducto(cod, nuevoEstado);
            if (ok)
            {
                cargarDatosProducto();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el estado del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBajaProducto_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvBajaProducto.Rows[e.RowIndex];

            string estadoRaw = null;
            if (dgvBajaProducto.Columns.Contains("estado_raw"))
            {
                estadoRaw = row.Cells["estado_raw"].Value?.ToString();
            }
            else if (dgvBajaProducto.Columns.Contains("estado"))
            {
                var txt = row.Cells["estado"].Value?.ToString();
                if (txt == "Activo") estadoRaw = "1";
                else if (txt == "Inactivo") estadoRaw = "0";
                else estadoRaw = txt;
            }

            if (estadoRaw == "1")
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            else if (estadoRaw == "0")
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            else
                row.DefaultCellStyle.BackColor = Color.White;
        }
        
        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var negocio = new CN_producto();
            var criterio = txtProducto.Text;

            // 1. Obtenemos la lista filtrada (esto ya lo tenías)
            var productos = negocio.BuscarProductos(criterio);

            // 2. Aplicamos la MISMA transformación que en cargarDatosProducto
            var lista = productos.Select(p => new
            {
                p.cod_producto,
                p.nombre,
                p.descripcion,
                categoria = p.id_categoria != null ? p.id_categoria.descripcion : string.Empty,
                p.precio_vta,
                p.costo,
                p.stock,
                estado_raw = p.estado, // La columna que te faltaba
                estado = p.estado == 1 ? "Activo" : "Inactivo",
                accion = p.estado == 1 ? "Dar de baja" : "Dar de alta"
            }).ToList();

            // 3. Asignamos la lista transformada
            dgvBajaProducto.DataSource = lista;

            // 4. Rellenamos el texto de los botones (importante)
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < dgvBajaProducto.Rows.Count)
                    dgvBajaProducto.Rows[i].Cells["AccionBtn"].Value = lista[i].accion;
            }
        }
    }
}
