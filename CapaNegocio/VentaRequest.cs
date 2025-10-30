using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class VentaRequest
    {
        public int cod_compra { get; set; }
        public DateTime fecha_compra { get; set; }
        public decimal monto_total { get; set; }
        public Cliente dni_cliente { get; set; }
        public Usuario dni_usuario { get; set; }
        public List<DetalleCompraModel> detalles { get; set; } = new List<DetalleCompraModel>();
    }
}
