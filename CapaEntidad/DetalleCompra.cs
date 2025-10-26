using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        public int cod_detalle { get; set; }     
        public int cod_compra { get; set; }     
        public int cod_producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

    }
}

