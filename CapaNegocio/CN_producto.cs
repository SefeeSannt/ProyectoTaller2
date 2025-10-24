using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                estado = 1 
            };

            oProducto.AgregarProducto(producto);
        }

        public List<ProductoModel> ObtenerProductos()
        {
            var productos = oProducto.ObtenerProductos();

            var categorias = new CN_categoria().ObtenerCategorias().ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = (decimal)p.precio_vta,
                costo = (decimal)p.costo,
                stock = (int)p.stock,
                
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
                precio_vta = (decimal)p.precio_vta,
                costo = (decimal)p.costo,
                stock = (int)p.stock,
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


        public List<ProductoModel> ListarProductosActivos()
        {
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                var lista = db.producto
                    .Where(p => p.estado == 1) 
                    .Select(p => new ProductoModel
                    {
                    cod_producto = p.cod_producto,
                    nombre = p.nombre,
                    descripcion = p.descripcion,
                    precio_vta = (decimal)p.precio_vta,
                    costo = (decimal)p.costo,
                    stock = (int)p.stock,
                    estado = p.estado,
                    id_categoria = new Ent.Categoria { id_categoria = p.id_categoria }
                }).ToList();

                var categorias = new CN_categoria().ObtenerCategorias().ToDictionary(c => c.id_categoria, c => c.descripcion ?? string.Empty);

                foreach (var item in lista)
                {
                    if (item.id_categoria != null && categorias.ContainsKey(item.id_categoria.id_categoria))
                        item.id_categoria.descripcion = categorias[item.id_categoria.id_categoria];
                }

                return lista;
            }
        }
    }
}
