using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class ventaModel
    {
        public int cod_venta { get; set; }
        public DateTime fecha_venta { get; set; }
        public decimal monto_total { get; set; }
        public Cliente dni_cliente { get; set; }
        public Usuario dni_usuario { get; set; }


    }
}
