using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class UsuarioModel
    {
        public long dni_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string username { get; set; }
        public long telefono { get; set; }
        public string password { get; set; }
        public string email_usuario { get; set; }

        // estado como int (1 = activo, 0 = inactivo)
        public int estado { get; set; }

        // navegación / id de rol
        public Rol oRol { get; set; }

        // Nueva propiedad que usará la UI para mostrar sólo el nombre del rol
        public string rol_nombre { get; set; }
    }
}
