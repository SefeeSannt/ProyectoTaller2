using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

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

        public List<producto> ObtenerProductosActivos(bool conStock)
        {
            try
            {
                using (var db = new ProyectoTaller2Entities()) {
                    IQueryable<producto> consulta = db.producto.Where(p => p.estado == 1);

                    // Si el parámetro es true, agregamos el filtro de stock
                    if (conStock)
                    {
                        consulta = consulta.Where(p => p.stock > 0);
                    }

                    return consulta.ToList();
                }

            }
            catch (Exception)
            {
                return new List<producto>();
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
                    prodExistente.estado = producto.estado;
                    db.SaveChanges();
                }
            }
        }

        public List<producto> BuscarProductosActivos(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.producto
                         .Where(p => p.estado == 1 && 
                                     (p.nombre.Contains(criterio) || 
                                      p.descripcion.Contains(criterio)))
                         .ToList();
            }
        }

        public List<producto> BuscarProductosActivosConStock(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.producto
                         .Where(p => p.estado == 1 &&
                                     p.stock > 0 && 
                                     (p.nombre.Contains(criterio) ||
                                      p.descripcion.Contains(criterio)))
                         .ToList();
            }
        }

        public List<producto> BuscarProductos(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.producto
                         .Where(p => p.nombre.Contains(criterio) || 
                                     p.descripcion.Contains(criterio))
                         .ToList();
            }
        }

    }
}
