using System;
using System.Collections.Generic;
using System.Linq;
using Dat = CapaDatos;

namespace CapaNegocio
{
    public class CN_compraDetalle
    {
        private Dat.CD_detalle_compra _cd = new Dat.CD_detalle_compra();

        public void AgregarDetalles(int codCompra, List<DetalleCompraModel> detalles)
        {
            if (detalles == null || detalles.Count == 0) throw new ArgumentException("detalles vacíos", nameof(detalles));

            var entidades = detalles.Select(d => new Dat.detalle_compra
            {
                cod_compra = codCompra,
                cod_producto = d.cod_producto,
                cantidad = d.cantidad,
       //         precio_compra = (double)d.precio_compra,
                subtotal = (double)d.subtotal
            }).ToList();

            _cd.AgregarDetalles(entidades);
        }

        public List<DetalleCompraModel> ObtenerDetallesPorCompra(int codCompra)
        {
            var datos = _cd.ObtenerDetallesPorCompra(codCompra);
            return datos.Select(d => new DetalleCompraModel
            {
                cod_producto = d.cod_producto,
                cantidad = d.cantidad,
           //     precio_compra = (decimal)d.precio_compra,
                subtotal = (decimal)d.subtotal
            }).ToList();
        }

        public bool EliminarPorCompra(int codCompra)
        {
            return _cd.EliminarDetallesPorCompra(codCompra);
        }
    }
}
