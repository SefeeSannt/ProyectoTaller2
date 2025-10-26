using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int cod_compra { get; set; }
        public DateTime fecha_compra { get; set; }
        public decimal monto_total { get; set; }
        public Usuario dni_usuario { get; set; }
        public Proveedor dni_proveedor { get; set; }

        public List<DetalleCompra> detalle_compra { get; set; }

    }
}
