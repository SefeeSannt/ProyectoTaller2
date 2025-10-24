using CapaNegocio;
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
    public partial class frmConsultaStock : Form
    {
        public frmConsultaStock()
        {
            InitializeComponent();
        }

        private void frmConsultaStock_Load(object sender, EventArgs e)
        {
            dgvStock.AutoGenerateColumns = false;
            ConfigurarGrilla();
            CargarDatos();
        }


        private void ConfigurarGrilla()
        {
            dgvStock.Columns.Clear(); 

          
            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                DataPropertyName = "cod_producto" 
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill 
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoría",
                DataPropertyName = "id_categoria.descripcion"
            });

            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                DataPropertyName = "stock"
            });


            dgvStock.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecio",
                HeaderText = "Precio Venta",
                DataPropertyName = "precio_vta",
                DefaultCellStyle = { Format = "c2" } // Formato de moneda ($0.00)
            });
        }

        private void CargarDatos()
        {
            var cnProducto = new CN_producto();
            dgvStock.DataSource = cnProducto.ListarProductosActivosConStock();
        }
    }
}
