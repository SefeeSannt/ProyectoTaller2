using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dat = CapaDatos;

namespace CapaNegocio
{
    public class CN_compra
    {
        private CD_compra objCD_Compra = new CD_compra();
        /*
        public DataTable ListarCompras(DateTime fechaDesde, DateTime fechaHasta, string dniProveedor)
        {
            return objCD_Compra.ListarCompras(fechaDesde, fechaHasta, dniProveedor);
        }*/

        public int RegistrarCompra(CompraRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (request.detalles == null || request.detalles.Count == 0)
                throw new ArgumentException("La compra debe contener al menos un detalle.", nameof(request));

            var compraEnt = new Dat.compra
            {
                fecha_compra = request.fecha_compra,
                dni_proveedor = request.dni_proveedor.dni_proveedor,
                monto_total = (double)request.monto_total,

                dni_usuario = request.dni_usuario.dni_usuario
            };

            compraEnt.detalle_compra = new List<Dat.detalle_compra>();
            foreach (var d in request.detalles)
            {
                compraEnt.detalle_compra.Add(new Dat.detalle_compra
                {
                    cod_producto = d.cod_producto,
                    cantidad = d.cantidad,
                    subtotal = (double)d.subtotal
                });
            }

            int codGenerado = objCD_Compra.AgregarCompra(compraEnt);

            if (codGenerado > 0)
            {
                var cnProducto = new CN_producto();
                foreach (var d in request.detalles)
                {
                    cnProducto.ActualizarStockYCostos(d.cod_producto, d.precio_compra, d.cantidad);
                }
            }

            return codGenerado;
        }



        public DataTable ObtenerDetalleCompra(int codCompra)
        {
            return objCD_Compra.ObtenerDetalleCompra(codCompra);
        }

        public DataTable ListarCompras(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor) 
        {
            
            return objCD_Compra.ListarCompras(fechaDesde, fechaHasta, nombreProveedor);
        }


        public CapaEntidad.Compra ObtenerCompraPorId(int codCompra)
        {
          
            CapaDatos.compra compraDeDatos = objCD_Compra.ObtenerCompraPorId(codCompra);

            if (compraDeDatos == null)
            {
                return null;
            }

            var compraEntidad = new CapaEntidad.Compra
            {
                
                cod_compra = compraDeDatos.cod_compra,
                fecha_compra = compraDeDatos.fecha_compra,
                monto_total = (decimal)compraDeDatos.monto_total,

                dni_proveedor = new CapaEntidad.Proveedor
                {
                    dni_proveedor = compraDeDatos.proveedor.dni_proveedor,
                    nombre = compraDeDatos.proveedor.nombre,
                    apellido = compraDeDatos.proveedor.apellido,
                //    domicilio = compraDeDatos.proveedor.domicilio
                },

                dni_usuario = new CapaEntidad.Usuario
                {
                    dni_usuario = compraDeDatos.usuario.dni_usuario,
                    nombre = compraDeDatos.usuario.nombre
                },

                detalle_compra = compraDeDatos.detalle_compra.Select(d => new CapaEntidad.DetalleCompra
                {
                    cod_compra = d.cod_compra,
                    cod_producto = d.cod_producto,
                    cantidad = d.cantidad,
                    subtotal = (decimal)d.subtotal,
                }).ToList()
            };

            return compraEntidad;
        }

        public DataTable ObtenerDashboardMontoPorDia(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            return objCD_Compra.ObtenerDashboardMontoPorDia(fechaDesde, fechaHasta, nombreProveedor, nombreProducto);
        }

        public DataTable ObtenerDashboardCategoria(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            return objCD_Compra.ObtenerDashboardCategoria(fechaDesde, fechaHasta, nombreProveedor, nombreProducto);
        }

        public int ObtenerTotalComprasFiltrado(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            return objCD_Compra.ObtenerTotalComprasFiltrado(fechaDesde, fechaHasta, nombreProveedor, nombreProducto);
        }
    };
}

