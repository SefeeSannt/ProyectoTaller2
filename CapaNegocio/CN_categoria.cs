using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_categoria
    {
        public List<Categoria> ObtenerCategorias()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.categoria
                         .Select(c => new Categoria
                         {
                             id_categoria = c.id_categoria,
                             descripcion = c.descripcion
                         })
                         .ToList();
            }
        }
    }
}