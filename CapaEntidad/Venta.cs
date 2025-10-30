using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int cod_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal monto_total { get; set; }
        public Usuario dni_usuario { get; set; }
        public Cliente dni_cliente { get; set; }

        public List<DetalleVenta> detalle_venta { get; set; }
    }
}
