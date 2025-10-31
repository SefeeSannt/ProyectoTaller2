using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public long dni_proveedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email_proveedor { get; set; }
        public long telefono { get; set; }
        public int estado { get; set; }
    }
}
