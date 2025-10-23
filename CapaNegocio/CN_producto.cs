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


        // (Asegúrate de tener "using Dat = CapaDatos;" y "using System.Linq;")

        public bool ExisteProducto(int codProducto)
        {
            // Usamos el contexto de la base de datos directamente para eficiencia
            using (var db = new Dat.ProyectoTaller2Entities())
            {
                // Any() es muy rápido, devuelve 'true' si encuentra CUALQUIER
                // producto que ya tenga ese código.
                return db.producto.Any(p => p.cod_producto == codProducto);
            }
        }



        /*public void AgregarProducto(ProductoModel obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (obj.id_categoria == null) throw new ArgumentException("Categoria requerida", nameof(obj));

            var producto = new Dat.producto
            {
                cod_producto = obj.cod_producto,
                nombre = obj.nombre,
                descripcion = obj.descripcion,
                // Como el precio/costo/stock se calcularán luego, los dejamos en 0
                precio_vta = 0.0,
                costo = 0.0,
                stock = 0,
                // id_categoria es entero en la entidad de datos
                id_categoria = obj.id_categoria.id_categoria,
                // id_estado no lo seteamos: la BD tiene default = 1
                estado= 1 // Asignamos 1 (activo) explícitamente
            };

            oProducto.AgregarProducto(producto);
        }*/

        public void AgregarProducto(ProductoModel obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (obj.id_categoria == null || obj.id_categoria.id_categoria == 0)
                throw new ArgumentException("Categoria requerida", nameof(obj));

            var producto = new Dat.producto
            {
                // --- LÍNEA MODIFICADA ---
                cod_producto = obj.cod_producto, // <-- ¡Ahora sí tomamos el código del modelo!

                nombre = obj.nombre,
                descripcion = obj.descripcion,

                // Tu modelo usa 'decimal' (0m) y tu BD usa 'double' (0.0)
                // Hacemos la conversión
                precio_vta = (double)obj.precio_vta,
                costo = (double)obj.costo,
                stock = obj.stock,

                id_categoria = obj.id_categoria.id_categoria,
                estado = 1 // Esto ya estaba correcto
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
                stock = (int)p.stock,
                
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
                stock = (int)p.stock,
                estado = p.estado,
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
                    .Where(p => p.estado == 1) // solo activos
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

                return lista;
            }
        }

    }
}
