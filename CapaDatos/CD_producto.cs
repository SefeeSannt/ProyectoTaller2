using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad; 

namespace CapaDatos
{
    public class CD_producto
    {
        public void AgregarProducto(producto producto)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                db.producto.Add(producto);
                db.SaveChanges();
            }
        }

        public List<producto> ObtenerProductos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.producto.ToList();
            }
        }

        public List<producto> ObtenerProductosActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.producto.Where(p => p.id_estado == 1).ToList();
            }
        }

        public void actualizarProducto(producto producto)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var prodExistente = db.producto.Find(producto.cod_producto);
                if (prodExistente != null)
                {
                    prodExistente.nombre = producto.nombre;
                    prodExistente.descripcion = producto.descripcion;
                    prodExistente.id_estado = producto.id_estado;
                    db.SaveChanges();
                }
            }
        }
    }
}
