using System;
using System.Collections.Generic;
using CapaEntidad;

namespace CapaNegocio
{
    public class CompraRequest
    {
        public int cod_compra { get; set; }
        public DateTime fecha_compra { get; set; }
        public decimal monto_total { get; set; }
        public Proveedor dni_proveedor { get; set; }
        public Usuario dni_usuario { get; set; }
        public List<DetalleCompraModel> detalles { get; set; } = new List<DetalleCompraModel>();
    }
}
