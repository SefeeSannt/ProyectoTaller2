using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmBajaCliente : Form
    {
        public frmBajaCliente()
        {
            InitializeComponent();

            // Suscribimos formateo (muestra 'Activo'/'Inactivo' sin tocar el valor real)
            dgvClientes.CellFormatting += dgvClientes_CellFormatting;
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientes() ?? new List<ClienteModel>();

            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = lista;

            // Evitar duplicar la columna botón
            if (dgvClientes.Columns.Contains("Accion"))
                dgvClientes.Columns.Remove("Accion");

            // Añadir columna botón al final
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "Accion",
                HeaderText = "Acción",
                UseColumnTextForButtonValue = false
            };
            dgvClientes.Columns.Add(btnCol);
            dgvClientes.Columns["Accion"].DisplayIndex = dgvClientes.Columns.Count - 1;

            // Rellenar el texto del botón leyendo el valor numérico de 'estado' (sin modificar la celda)
            if (dgvClientes.Columns.Contains("estado"))
            {
                dgvClientes.Columns["estado"].HeaderText = "Estado";

                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    var raw = row.Cells["estado"].Value;
                    int estadoInt = 0;
                    if (raw != null && int.TryParse(raw.ToString(), out estadoInt))
                    {
                        if (dgvClientes.Columns.Contains("Accion"))
                            row.Cells["Accion"].Value = estadoInt == 1 ? "Dar de baja" : "Dar de alta";
                    }
                    else
                    {
                        if (dgvClientes.Columns.Contains("Accion"))
                            row.Cells["Accion"].Value = "Dar de baja";
                    }
                }
            }
            else
            {
                // Si no existe 'estado', botón por defecto
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    if (dgvClientes.Columns.Contains("Accion"))
                        row.Cells["Accion"].Value = "Dar de baja";
                }
            }
        }

        private void frmBajaCliente_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarClientes(criterio) ?? new List<ClienteModel>();
            dgvClientes.DataSource = lista;
            // Reaplicar la lógica de botones/estado
            CargarClientesEnGrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!dgvClientes.Columns.Contains("Accion")) return;
            if (dgvClientes.Columns[e.ColumnIndex].Name != "Accion") return;

            var row = dgvClientes.Rows[e.RowIndex];
            var dniObj = row.Cells["dni"].Value;
            var rawEstado = row.Cells["estado"].Value;

            if (dniObj == null || rawEstado == null) return;

            long dni = Convert.ToInt64(dniObj);
            int estadoInt = 0;
            int.TryParse(rawEstado.ToString(), out estadoInt);

            var negocio = new CN_cliente();

            // Sin confirmaciones: alternamos estado y recargamos
            if (estadoInt == 1)
            {
                negocio.BajaCliente(dni);
            }
            else
            {
                negocio.AltaCliente(dni);
            }

            CargarClientesEnGrid();
        }

        private void dgvClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvClientes.Rows[e.RowIndex];
            var raw = dgvClientes.Columns.Contains("estado") ? row.Cells["estado"].Value : null;

            int estadoInt = 0;
            if (raw != null && int.TryParse(raw.ToString(), out estadoInt))
            {
                if (estadoInt == 1)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        // Formatea visualmente la celda 'estado' sin modificar el valor subyacente
        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
            {
                int val;
                if (int.TryParse(e.Value.ToString(), out val))
                {
                    e.Value = val == 1 ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
