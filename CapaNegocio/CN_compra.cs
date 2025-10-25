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

        // Método público que la capa de presentación (el formulario) llamará
        public DataTable ListarCompras()
        {
            // Llama al método de la capa de datos y devuelve los resultados
            return objCD_Compra.ListarCompras();
        }

        // Nuevo: registra compra + detalles y luego actualiza stock/precios
        public int RegistrarCompra(CompraRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (request.detalles == null || request.detalles.Count == 0)
                throw new ArgumentException("La compra debe contener al menos un detalle.", nameof(request));

            // Mapear a entidad EF (CapaDatos)
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
                 //   precio_compra = (double)d.precio_compra,
                    subtotal = (double)d.subtotal
                });
            }

            // Guardar compra (CD_compra.AgregarCompra hace la transacción)
            int codGenerado = objCD_Compra.AgregarCompra(compraEnt);

            // Si se guardó correctamente, actualizar stock y precios
            if (codGenerado > 0)
            {
                var cnProducto = new CN_producto();
                foreach (var d in request.detalles)
                {
                    // Actualiza costo, recalcula precio de venta y suma stock
                    cnProducto.ActualizarStockYCostos(d.cod_producto, d.precio_compra, d.cantidad);
                }
            }

            return codGenerado;
        }
    }
}
