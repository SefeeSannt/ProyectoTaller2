using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CompraModel
    {
        public int cod_compra { get; set; }
        public DateTime fecha_compra { get; set; }
        public decimal monto_total { get; set; }
        public proveedor dni_proveedor { get; set; }
        public Usuario dni_usuario { get; set; }

    }
}
