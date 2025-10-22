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

        public void AgregarProducto(ProductoModel obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (obj.id_categoria == null) throw new ArgumentException("Categoria requerida", nameof(obj));

            var producto = new Dat.producto
            {
                nombre = obj.nombre,
                descripcion = obj.descripcion,
                // Como el precio/costo/stock se calcularán luego, los dejamos en 0
                precio_vta = 0.0,
                costo = 0.0,
                stock = 0,
                // id_categoria es entero en la entidad de datos
                id_categoria = obj.id_categoria.id_categoria
                // id_estado no lo seteamos: la BD tiene default = 1
            };

            oProducto.AgregarProducto(producto);
        }

        public List<ProductoModel> ObtenerProductos()
        {
            var productos = oProducto.ObtenerProductos();
            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = (decimal)p.precio_vta,
                costo = (decimal)p.costo,
                stock = p.stock,
                id_estado = new Ent.estado { id_estado = p.id_estado },
                id_categoria = new Ent.Categoria { id_categoria = p.id_categoria }
            }).ToList();
        }

        public List<ProductoModel> ObtenerProductosActivos()
        {
            var productos = oProducto.ObtenerProductosActivos();
            return productos.Select(p => new ProductoModel
            {
                cod_producto = p.cod_producto,
                nombre = p.nombre,
                descripcion = p.descripcion,
                precio_vta = (decimal)p.precio_vta,
                costo = (decimal)p.costo,
                stock = p.stock,
                id_estado = new Ent.estado { id_estado = p.id_estado },
                id_categoria = new Ent.Categoria { id_categoria = p.id_categoria }
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
                id_estado = obj.id_estado != null ? obj.id_estado.id_estado : 1,
                id_categoria = obj.id_categoria != null ? obj.id_categoria.id_categoria : 0
            };
            oProducto.actualizarProducto(producto);
        }
    }
}
