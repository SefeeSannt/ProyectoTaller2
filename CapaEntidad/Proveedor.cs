using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    }
}
