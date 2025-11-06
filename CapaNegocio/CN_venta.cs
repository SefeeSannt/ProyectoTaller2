using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dat = CapaDatos;

namespace CapaNegocio
{
    public class CN_venta
    {
        private CD_venta objCD_Venta = new CD_venta();
        public DataTable ListarVentas(DateTime fechaDesde, DateTime fechaHasta, string dniProveedor)
        {
            return objCD_Venta.ListarVentas(fechaDesde, fechaHasta, dniProveedor);
        }

        public int RegistrarVenta(VentaRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (request.detalles == null || request.detalles.Count == 0)
                throw new ArgumentException("La venta debe contener al menos un detalle.", nameof(request));

            var ventaEnt = new Dat.venta
            {
                fecha_venta = request.fecha_compra,
                dni_cliente = request.dni_cliente.dni_cliente,
                monto_total = (double)request.monto_total,

                dni_usuario = request.dni_usuario.dni_usuario
            };

            ventaEnt.detalle_venta = new List<Dat.detalle_venta>();
            foreach (var d in request.detalles)
            {
                ventaEnt.detalle_venta.Add(new Dat.detalle_venta
                {
                    cod_producto = d.cod_producto,
                    cantidad = d.cantidad,
                    subtotal = (double)d.subtotal
                });
            }

            int codGenerado = objCD_Venta.AgregarVenta(ventaEnt);

            if (codGenerado > 0)
            {
                var cnProducto = new CN_producto();
                foreach (var d in request.detalles)
                {
                    cnProducto.ActualizarStockPorVenta(d.cod_producto, d.cantidad);
                }
            }

            return codGenerado;
        }



        public DataTable ObtenerDetalleVenta(int codVenta)
        {
            return objCD_Venta.ObtenerDetalleVenta(codVenta);
        }


        public CapaEntidad.Venta ObtenerVentaPorId(int codVenta)
        {

            CapaDatos.venta ventaDeDatos = objCD_Venta.ObtenerVentaPorId(codVenta);

            if (ventaDeDatos == null)
            {
                return null;
            }

            var ventaEntidad = new CapaEntidad.Venta
            {

                cod_venta = ventaDeDatos.cod_venta,
                fecha_venta = (DateTime)ventaDeDatos.fecha_venta,
                monto_total = (decimal)ventaDeDatos.monto_total,

                dni_cliente = new CapaEntidad.Cliente
                {
                    dni_cliente = ventaDeDatos.cliente.dni_cliente,
                    nombre = ventaDeDatos.cliente.nombre,
                    apellido = ventaDeDatos.cliente.apellido,
                    //    domicilio = ventaDeDatos.cliente.domicilio
                },

                dni_usuario = new CapaEntidad.Usuario
                {
                    dni_usuario = ventaDeDatos.usuario.dni_usuario,
                    nombre = ventaDeDatos.usuario.nombre
                },

                detalle_venta = ventaDeDatos.detalle_venta.Select(d => new CapaEntidad.DetalleVenta
                {
                    cod_venta = d.cod_venta,
                    cod_producto = d.cod_producto,
                    cantidad = d.cantidad,
                    subtotal = (decimal)d.subtotal,
                }).ToList()
            };

            return ventaEntidad;
        }

        public DataTable ObtenerDashboardMontoPorDia(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerDashboardMontoPorDia(fechaDesde, fechaHasta);
        }

        public int ObtenerTotalComprasFiltrado(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerTotalVentasFiltrado(fechaDesde, fechaHasta);
        }

        public int ObtenerTotalProductosVendidosFiltrado(DateTime fechaDesde, DateTime fechaHasta)
        {
            return objCD_Venta.ObtenerTotalProductosVendidosFiltrado(fechaDesde, fechaHasta);
        }




    }
}
