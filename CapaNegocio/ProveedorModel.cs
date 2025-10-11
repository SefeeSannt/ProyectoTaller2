using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ProveedorModel
    {
        public long dni_proveedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email_proveedor { get; set; }
        public long telefono { get; set; }
        public int id_estado { get; set; }
    }
}
