using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dat = CapaDatos;

namespace CapaNegocio
{
    public class CN_ventaDetalle
    {
        private Dat.CD_detalle_compra _cd = new Dat.CD_detalle_compra();

        public void AgregarDetalles (int codVenta, List<DetalleVentaModel> detalles)
        {
            if(detalles == null || detalles.Count == 0) throw new ArgumentException("detalles vacíos", nameof(detalles));
            var entidades = detalles.Select(d => new Dat.detalle_venta
            {
                cod_venta = codVenta,
                cod_producto = d.cod_producto,
                cantidad = d.cantidad,
               // precio_venta = (double)d.precio_venta,
                subtotal = (double)d.subtotal
            }).ToList();

        }

        public List<DetalleVentaModel> ObtenerDetallesPorVenta(int codVenta)
        {
            var datos = _cd.ObtenerDetallesPorCompra(codVenta);
            return datos.Select(d => new DetalleVentaModel
            {
                cod_producto = d.cod_producto,
                cantidad = d.cantidad,
               // precio_venta = (decimal)d.precio_venta,
                subtotal = (decimal)d.subtotal
            }).ToList();
        }

        public bool EliminarPorVenta(int codVenta)
        {
            return _cd.EliminarDetallesPorCompra(codVenta);
        }


    }
}
