﻿using System;
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

namespace CapaPresentacion.Vistas.Vendedor
{
    public partial class frmClienteDetalle : Form
    {
        public frmClienteDetalle()
        {
            InitializeComponent();
        }

        private void CargarClientesEnGrid()
        {
            var negocio = new CN_cliente();
            var lista = negocio.ObtenerClientesActivos();
            dgvClientes.DataSource = lista;
            dgvClientes.Columns["estado"].Visible = false;

            lblTotalClientes.Text = $"{negocio.TotalClientes()}";
            lblClientesActivos.Text = $"{negocio.TotalClientesActivos()}";
            lblClientesInactivos.Text = $"{negocio.TotalClientesInactivos()}";
        }

        private void iconBtnLupaDetalleUser_Click(object sender, EventArgs e)
        {
            var negocio = new CN_cliente();
            var criterio = txtBuscar.Text;
            var lista = negocio.BuscarClientesActivos(criterio);
            dgvClientes.DataSource = lista;
        }

        private void frmClienteDetalle_Load(object sender, EventArgs e)
        {
            CargarClientesEnGrid();
        }

    }
}
