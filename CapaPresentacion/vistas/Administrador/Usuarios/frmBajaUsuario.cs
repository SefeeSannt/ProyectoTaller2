using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Administrador.Usuarios
{
    public partial class frmBajaUsuario : Form
    {
        public frmBajaUsuario()
        {
            InitializeComponent();
            dgvDetalleUsuario.CellFormatting += dgvDetalleUsuario_CellFormatting;
        }

        private void cargaUsuariosEnGrid()
        {
            var negocio = new CN_usuario();
            // Usar la capa de negocio (NO la capa de datos) para obtener los usuarios
            var listaUsuarios = negocio.ObtenerUsuarios() ?? new List<UsuarioModel>();

            // Proyectar a un DTO anónimo que el grid mostrará
            var usuarios = listaUsuarios.Select(u => new
            {
                dni = u.dni_usuario,
                nombre = u.nombre,
                apellido = u.apellido,
                email = u.email_usuario,
                telefono = u.telefono,
                rol = u.rol_nombre ?? string.Empty,
                estado = u.estado
            }).ToList();

            dgvDetalleUsuario.AutoGenerateColumns = true;
            dgvDetalleUsuario.DataSource = usuarios;

            // Ajustes visuales: encabezado rol
            if (dgvDetalleUsuario.Columns.Contains("rol"))
                dgvDetalleUsuario.Columns["rol"].HeaderText = "Rol";

            // Evitar duplicar la columna botón
            if (dgvDetalleUsuario.Columns.Contains("Accion"))
                dgvDetalleUsuario.Columns.Remove("Accion");

            // Añadir columna botón al final
            var btnCol = new DataGridViewButtonColumn
            {
                Name = "Accion",
                HeaderText = "Acción",
                UseColumnTextForButtonValue = false
            };
            dgvDetalleUsuario.Columns.Add(btnCol);
            dgvDetalleUsuario.Columns["Accion"].DisplayIndex = dgvDetalleUsuario.Columns.Count - 1;

            // Normalizar nombre de columna DNI para que handler use "dni"
            if (dgvDetalleUsuario.Columns.Contains("dni"))
            {
                dgvDetalleUsuario.Columns["dni"].HeaderText = "DNI";
            }
            else if (dgvDetalleUsuario.Columns.Contains("dni_usuario"))
            {
                dgvDetalleUsuario.Columns["dni_usuario"].HeaderText = "DNI";
                dgvDetalleUsuario.Columns["dni_usuario"].Name = "dni";
            }

            // Rellenar el texto del botón leyendo el valor numérico de 'estado' (sin modificar la celda)
            if (dgvDetalleUsuario.Columns.Contains("estado"))
            {
                dgvDetalleUsuario.Columns["estado"].HeaderText = "Estado";

                foreach (DataGridViewRow row in dgvDetalleUsuario.Rows)
                {
                    var raw = row.Cells["estado"].Value;
                    int estadoInt = 0;
                    if (raw != null && int.TryParse(raw.ToString(), out estadoInt))
                    {
                        if (dgvDetalleUsuario.Columns.Contains("Accion"))
                            row.Cells["Accion"].Value = estadoInt == 1 ? "Dar de baja" : "Dar de alta";
                    }
                    else
                    {
                        if (dgvDetalleUsuario.Columns.Contains("Accion"))
                            row.Cells["Accion"].Value = "Dar de baja";
                    }
                }
            }
            else
            {
                // Si no existe 'estado', botón por defecto
                foreach (DataGridViewRow row in dgvDetalleUsuario.Rows)
                {
                    if (dgvDetalleUsuario.Columns.Contains("Accion"))
                        row.Cells["Accion"].Value = "Dar de baja";
                }
            }
        }

        private void frmBajaUsuario_Load(object sender, EventArgs e)
        {
            cargaUsuariosEnGrid();
        }

        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var criterio = txtBuscar.Text;
            var negocio = new CN_usuario();
            var listaUsuarios = negocio.BuscarUsuarios(criterio) ?? new List<UsuarioModel>();

            var usuarios = listaUsuarios.Select(u => new
            {
                dni = u.dni_usuario,
                nombre = u.nombre,
                apellido = u.apellido,
                email = u.email_usuario,
                telefono = u.telefono,
                rol = u.rol_nombre ?? string.Empty,
                estado = u.estado
            }).ToList();

            dgvDetalleUsuario.AutoGenerateColumns = true;
            dgvDetalleUsuario.DataSource = usuarios;

            if (dgvDetalleUsuario.Columns.Contains("rol"))
                dgvDetalleUsuario.Columns["rol"].HeaderText = "Rol";

            // Añadimos la columna acción y textos igual que en cargaUsuariosEnGrid
            if (dgvDetalleUsuario.Columns.Contains("Accion"))
                dgvDetalleUsuario.Columns.Remove("Accion");

            var btnCol = new DataGridViewButtonColumn
            {
                Name = "Accion",
                HeaderText = "Acción",
                UseColumnTextForButtonValue = false
            };
            dgvDetalleUsuario.Columns.Add(btnCol);
            dgvDetalleUsuario.Columns["Accion"].DisplayIndex = dgvDetalleUsuario.Columns.Count - 1;

            //Asignar textos de botón basado en estado
            if (dgvDetalleUsuario.Columns.Contains("estado"))
            {
                foreach (DataGridViewRow row in dgvDetalleUsuario.Rows)
                {
                    var raw = row.Cells["estado"].Value;
                    int estadoInt = 0;
                    if (raw != null && int.TryParse(raw.ToString(), out estadoInt))
                    {
                        row.Cells["Accion"].Value = estadoInt == 1 ? "Dar de baja" : "Dar de alta";
                    }
                    else
                    {
                        row.Cells["Accion"].Value = "Dar de baja";
                    }
                }
            }
        }

        private void dgvDetalleUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!dgvDetalleUsuario.Columns.Contains("estado")) return;

            if (dgvDetalleUsuario.Columns[e.ColumnIndex].Name == "estado" && e.Value != null)
            {
                int val;
                if (int.TryParse(e.Value.ToString(), out val))
                {
                    e.Value = val == 1 ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvDetalleUsuario_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dgvDetalleUsuario.Rows[e.RowIndex];
            var raw = dgvDetalleUsuario.Columns.Contains("estado") ? row.Cells["estado"].Value : null;

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

        // Handler del click en columna de acción (usa CN_usuario para alternar estado)
        private void dgvBajaUsuario(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!dgvDetalleUsuario.Columns.Contains("Accion")) return;
            if (dgvDetalleUsuario.Columns[e.ColumnIndex].Name != "Accion") return;

            var row = dgvDetalleUsuario.Rows[e.RowIndex];
            var dniObj = row.Cells["dni"].Value;
            var rawEstado = row.Cells["estado"].Value;

            if (dniObj == null || rawEstado == null) return;

            long dni = Convert.ToInt64(dniObj);
            int estadoInt = 0;
            int.TryParse(rawEstado.ToString(), out estadoInt);

            var negocio = new CN_usuario();

            if (estadoInt == 1)
            {
                negocio.BajaUsuario(dni);
            }
            else
            {
                negocio.AltaUsuario(dni);
            }

            cargaUsuariosEnGrid();
        }
    }
}
