using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.vistas.Administrador.Backup
{
    public partial class frmvistaBackup : Form
    {
        private CN_backup cnBackup = new CN_backup();
        private CN_logBackup cnLogBackup = new CN_logBackup();
        private string emailUsuarioActual;

        public frmvistaBackup(string emailUsuario)
        {
            InitializeComponent();
            this.emailUsuarioActual = emailUsuario;
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            CargarLogs();
        }

        private void CargarLogs()
        {
            try
            {
                dgvLogs.DataSource = cnLogBackup.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message);
            }
        }

        private void btnSeleccionarRuta_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Seleccione la carpeta donde guardará el backup";
                dialog.ShowNewFolderButton = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRutaBackup.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCarpeta = txtRutaBackup.Text;
                if (string.IsNullOrEmpty(rutaCarpeta))
                {
                    MessageBox.Show("Por favor, seleccione una ruta primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombreArchivo = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + "-BKUP_ProyectoTaller2.bak";
                string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

                // 1. Ejecuta el backup (Clase SIN EF)
                cnBackup.CrearBackup(rutaCarpeta);

                // 2. Guarda el log (Clase CON EF)
                cnLogBackup.Agregar(nombreArchivo, this.emailUsuarioActual);

                // 3. Avisa y refresca
                MessageBox.Show($"Backup '{nombreArchivo}' creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLogs();
            }
            catch (Exception ex)
            {
                // ex.Message solo muestra la línea principal del error.
                // ex.ToString() nos da el mensaje, el tipo de error y, lo más importante,
                // el "stack trace" (la pila de llamadas) que nos dice 
                // exactamente en QUÉ ARCHIVO y en QUÉ LÍNEA de código falló.

                string errorCompleto = ex.ToString();

                MessageBox.Show("Se produjo un error detallado: \n\n" + errorCompleto,
                                "Error Detallado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
