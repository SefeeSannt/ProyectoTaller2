using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class ProductoModel
    {
        public int cod_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio_vta { get; set; }
        public decimal costo { get; set; }
        public int stock { get; set; }
        public int estado { get; set; }
        public Categoria id_categoria { get; set; }
    }
}
