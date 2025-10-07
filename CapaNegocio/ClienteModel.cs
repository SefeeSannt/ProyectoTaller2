using System.Data.SqlTypes;
using System.Reflection.Emit;

namespace CapaNegocio
{
    public class ClienteModel
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long dni { get; set; }
        public string domicilio { get; set; }
        public long telefono { get; set; }
        public string email { get; set; }
        public int id_estado { get; set; }
    }
}