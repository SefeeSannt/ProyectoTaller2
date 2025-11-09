using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// alias para evitar ambigüedad entre entidades EF (CapaDatos) y POCOs (CapaEntidad)
using Dat = CapaDatos;
using Ent = CapaEntidad;

namespace CapaNegocio
{
    public class CN_producto
    {
        public Dat.CD_producto oProducto = new Dat.CD_producto();

        public bool ExisteProducto(int codProducto)
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                return db.producto.Any(p => p.cod_producto == codProducto);
            }
        }

        public void AgregarProducto(ProductoModel obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (obj.id_categoria == null || obj.id_categoria.id_categoria == 0)
                throw new ArgumentException("Categoria requerida", nameof(obj));

            var producto = new Dat.producto
            {
                cod_producto = obj.cod_producto,
                nombre = obj.nombre,
                descripcion = obj.descripcion,
                precio_vta = (double)obj.precio_vta,
                costo = (double)obj.costo,
                stock = obj.stock,
                id_categoria = obj.id_categoria.id_categoria,
                estado = obj.estado // si el modelo trae estado
            };

            oProducto.AgregarProducto(producto);
        }

        public List<ProductoModel> ObtenerProductos()
        {
            var productos = oProducto.ObtenerProductos();

            // Obtener diccionario id -> descripcion de categorías
            var categorias = new CN_categoria().ObtenerCategorias()
                              .ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = p.precio_vta.HasValue ? (decimal)p.precio_vta.Value : 0m,
                costo = p.costo.HasValue ? (decimal)p.costo.Value : 0m,
                stock = p.stock.HasValue ? p.stock.Value : 0,
                estado = p.estado,
                id_categoria = new Ent.Categoria
                {
                    id_categoria = p.id_categoria,
                    descripcion = categorias.ContainsKey(p.id_categoria) ? categorias[p.id_categoria] : string.Empty
                }
            }).ToList();
        }

        public List<ProductoModel> ObtenerProductosActivos()
        {
            var productos = oProducto.ObtenerProductosActivos();

            var categorias = new CN_categoria().ObtenerCategorias()
                              .ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = p.precio_vta.HasValue ? (decimal)p.precio_vta.Value : 0m,
                costo = p.costo.HasValue ? (decimal)p.costo.Value : 0m,
                stock = p.stock.HasValue ? p.stock.Value : 0,
                estado = p.estado,
                id_categoria = new Ent.Categoria
                {
                    id_categoria = p.id_categoria,
                    descripcion = categorias.ContainsKey(p.id_categoria) ? categorias[p.id_categoria] : string.Empty
                }
            }).ToList();
        }

        public void ActualizarProducto(ProductoModel obj)
        {
            var producto = new Dat.producto
            {
                cod_producto = obj.cod_producto,
                nombre = obj.nombre,
                descripcion = obj.descripcion,
                precio_vta = (double)obj.precio_vta,
                costo = (double)obj.costo,
                stock = obj.stock,
                estado = obj.estado,
                id_categoria = obj.id_categoria != null ? obj.id_categoria.id_categoria : 0
            };
            oProducto.actualizarProducto(producto);
        }

        // Nuevo: cambia el estado de un producto (0 o 1)
        public bool CambiarEstadoProducto(int codProducto, int nuevoEstado)
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var prod = db.producto.Find(codProducto);
                if (prod == null) return false;
                prod.estado = nuevoEstado;
                db.SaveChanges();
                return true;
            }
        }

        public void ActualizarStockYCostos(int codProducto, decimal nuevoCosto, int cantidadAAgregar)
        {
            decimal nuevoPrecioVenta = nuevoCosto * 1.20m;

            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var productoEnDB = db.producto.FirstOrDefault(p => p.cod_producto == codProducto);

                if (productoEnDB != null)
                {
                    productoEnDB.costo = (double)nuevoCosto;
                    productoEnDB.precio_vta = (double)nuevoPrecioVenta;

                    // Sumamos la cantidad al stock existente (válido para compras)
                    productoEnDB.stock = productoEnDB.stock + cantidadAAgregar;
                }
                else
                {
                    throw new Exception($"No se encontró el producto con código {codProducto} para actualizar.");
                }

                db.SaveChanges();
            }
        }

        // Nuevo método: descontar stock por una venta
        public void ActualizarStockPorVenta(int codProducto, int cantidadVendida)
        {
            if (cantidadVendida <= 0) return;

            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var productoEnDB = db.producto.FirstOrDefault(p => p.cod_producto == codProducto);

                if (productoEnDB == null)
                    throw new Exception($"No se encontró el producto con código {codProducto} para descontar stock.");

                int stockActual = productoEnDB.stock ?? 0;
                int nuevoStock = stockActual - cantidadVendida;

                // Evitamos stock negativo. Ajusta comportamiento si prefieres lanzar excepción.
                if (nuevoStock < 0) nuevoStock = 0;

                productoEnDB.stock = nuevoStock;
                db.SaveChanges();
            }
        }

        public List<ProductoModel> ListarProductosActivosConStock()
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
               
                var listaDeDatos = db.producto
                    .Include("categoria")
                    .Where(p => p.estado == 1 && p.stock > 0)
                    .ToList(); 

                var lista = listaDeDatos
                    .Select(p => new ProductoModel
                    {
                        cod_producto = p.cod_producto,
                        nombre = p.nombre,
                        stock = (int)p.stock,

                        precio_vta = (decimal)p.precio_vta,
                        costo = (decimal)p.costo,

                        estado = p.estado,
                        id_categoria = new Ent.Categoria
                        {
                            id_categoria = p.id_categoria,
                            descripcion = p.categoria?.descripcion
                        }
                    }).ToList(); 

                return lista;
            }
        }

        public List<ProductoModel> BuscarProductosActivos(string criterio)
        {
            var productos = oProducto.BuscarProductosActivos(criterio);
            var categorias = new CN_categoria().ObtenerCategorias()
                              .ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);
            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = p.precio_vta.HasValue ? (decimal)p.precio_vta.Value : 0m,
                costo = p.costo.HasValue ? (decimal)p.costo.Value : 0m,
                stock = p.stock.HasValue ? p.stock.Value : 0,
                estado = p.estado,
                id_categoria = new Ent.Categoria
                {
                    id_categoria = p.id_categoria,
                    descripcion = categorias.ContainsKey(p.id_categoria) ? categorias[p.id_categoria] : string.Empty
                }
            }).ToList();
        }

        public List<ProductoModel> BuscarProductos(string criterio)
        {
          
            var productos = oProducto.BuscarProductos(criterio);

            var categorias = new CN_categoria().ObtenerCategorias()
                                    .ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = p.precio_vta.HasValue ? (decimal)p.precio_vta.Value : 0m,
                costo = p.costo.HasValue ? (decimal)p.costo.Value : 0m,
                stock = p.stock.HasValue ? p.stock.Value : 0,
                estado = p.estado, 
                id_categoria = new Ent.Categoria
                {
                    id_categoria = p.id_categoria,
                    descripcion = categorias.ContainsKey(p.id_categoria) ? categorias[p.id_categoria] : string.Empty
                }
            }).ToList();
        }


        public object ObtenerProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta, string nombreProducto)
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var fechaHastaAjustada = fechaHasta.Date.AddDays(1).AddSeconds(-1);

                var query = db.detalle_venta
                              .Where(dv => dv.venta.fecha_venta >= fechaDesde &&
                                           dv.venta.fecha_venta <= fechaHastaAjustada);

                if (!string.IsNullOrEmpty(nombreProducto))
                {
                    query = query.Where(dv => dv.producto.nombre.StartsWith(nombreProducto));
                }

                var resultado = query
                    .GroupBy(dv => dv.producto.nombre)
                    .Select(g => new
                    {
                        Producto = g.Key,
                        TotalVendido = g.Sum(x => x.cantidad)
                    })
                    .Where(x => x.TotalVendido > 0)
                    .OrderByDescending(x => x.TotalVendido)
                    .Take(10) 
                    .ToList();

                return resultado;
            }
        }

        public object ObtenerDistribucionCategoria(DateTime fechaDesde, DateTime fechaHasta, string nombreProducto)
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var fechaHastaAjustada = fechaHasta.Date.AddDays(1).AddSeconds(-1);

                var query = db.detalle_venta
                              .Where(dv => dv.venta.fecha_venta >= fechaDesde &&
                                           dv.venta.fecha_venta <= fechaHastaAjustada);

                if (!string.IsNullOrEmpty(nombreProducto))
                {
                    query = query.Where(dv => dv.producto.nombre.StartsWith(nombreProducto));
                }

                var resultado = query
                    .GroupBy(dv => dv.producto.categoria.descripcion) 
                    .Select(g => new
                    {
                        Categoria = g.Key,
                        TotalVendido = g.Sum(x => x.cantidad)
                    })
                    .Where(x => x.TotalVendido > 0)
                    .ToList();

                return resultado;
            }
        }

        public int ObtenerTotalCategoriasVendidas(DateTime fechaDesde, DateTime fechaHasta, string nombreProducto)
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var fechaHastaAjustada = fechaHasta.Date.AddDays(1).AddSeconds(-1);

                var query = db.detalle_venta
                              .Where(dv => dv.venta.fecha_venta >= fechaDesde &&
                                           dv.venta.fecha_venta <= fechaHastaAjustada);

                if (!string.IsNullOrEmpty(nombreProducto))
                {
                    query = query.Where(dv => dv.producto.nombre.StartsWith(nombreProducto));
                }

                int total = query
                    .Select(dv => dv.producto.id_categoria)
                    .Distinct()
                    .Count();

                return total;
            }


        }

        public List<ProductoModel> BuscarProductosActivosConStock(string criterio)
        {
            var productos = oProducto.BuscarProductosActivosConStock(criterio);

            var categorias = new CN_categoria().ObtenerCategorias()
                                   .ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = p.precio_vta.HasValue ? (decimal)p.precio_vta.Value : 0m,
                costo = p.costo.HasValue ? (decimal)p.costo.Value : 0m,
                stock = p.stock.HasValue ? p.stock.Value : 0,
                estado = p.estado,
                id_categoria = new Ent.Categoria
                {
                    id_categoria = p.id_categoria,
                    descripcion = categorias.ContainsKey(p.id_categoria) ? categorias[p.id_categoria] : string.Empty
                }
            }).ToList();
        }




    }
}
