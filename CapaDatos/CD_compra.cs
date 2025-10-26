using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_compra
    {

        public DataTable ListarCompras(DateTime fechaDesde, DateTime fechaHasta, string dniProveedor)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string queryBase = @"
                        SELECT 
                            c.cod_compra,
                            (ISNULL(p.nombre,'') + ' ' + ISNULL(p.apellido,'')) AS proveedor,
                            c.fecha_compra AS fecha_compra,
                            c.monto_total AS monto_total
                        FROM compra c
                        INNER JOIN proveedor p ON c.dni_proveedor = p.dni_proveedor";
                    

                    string whereClause = " WHERE c.fecha_compra BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        if (!string.IsNullOrEmpty(dniProveedor))
                        {
                            whereClause += " AND p.dni_proveedor = @dniProveedor";
                            cmd.Parameters.AddWithValue("@dniProveedor", dniProveedor);
                        }

                        cmd.CommandText = queryBase + whereClause + " ORDER BY c.fecha_compra DESC";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_compra.ListarCompras: " + ex.Message, ex);
                }
            }
            return tabla;
        }

        public DataTable ObtenerDetalleCompra(int codCompra)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT 
                    p.nombre AS Producto,
                    (d.subtotal / d.cantidad) AS PrecioCompra,
                    d.cantidad AS Cantidad,
                    d.subtotal AS Subtotal
                FROM detalle_compra d
                INNER JOIN producto p ON d.cod_producto = p.cod_producto
                WHERE d.cod_compra = @codCompra";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codCompra", codCompra);
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_compra.ObtenerDetalleCompra: " + ex.Message, ex);
                }
            }
            return tabla;
        }

        public List<compra> ObtenerCompras()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.compra
                         .Include("proveedor")
                         .Include("usuario")
                         .Include("detalle_compra")
                         .ToList();
            }
        }

        public compra ObtenerCompraPorId(int codCompra)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.compra
                         .Include("proveedor")
                         .Include("usuario")
                         .Include("detalle_compra")
                         .FirstOrDefault(c => c.cod_compra == codCompra);
            }
        }

        public int AgregarCompra(compra compra)
        {
            if (compra == null) throw new ArgumentNullException(nameof(compra));
            if (compra.detalle_compra == null || !compra.detalle_compra.Any())
                throw new Exception("La compra debe contener al menos un detalle.");

            using (var db = new ProyectoTaller2Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        int maxId = 0;
                        if (db.compra.Any()) 
                        {
                            maxId = db.compra.Max(c => c.cod_compra);
                        }
                       
                        compra.cod_compra = maxId + 1;

                        var prov = db.proveedor.Find(compra.dni_proveedor);
                        if (prov == null)
                            throw new Exception($"El proveedor con DNI {compra.dni_proveedor} no existe.");
                        compra.proveedor = prov;

                        var user = db.usuario.Find(compra.dni_usuario);
                        if (user == null)
                            throw new Exception($"El usuario con DNI {compra.dni_usuario} no existe.");
                        compra.usuario = user;

                        decimal totalCalculado = 0m;
                        foreach (var det in compra.detalle_compra)
                        {
                            var prod = db.producto.Find(det.cod_producto);
                            if (prod == null)
                                throw new Exception($"El producto con código {det.cod_producto} no existe.");
                            det.producto = prod;

                            det.cod_compra = compra.cod_compra;

                            totalCalculado += (decimal)det.subtotal;
                        }

                        compra.monto_total = (double)totalCalculado;
                        if (compra.fecha_compra == default(DateTime))
                            compra.fecha_compra = DateTime.Now;

                        db.compra.Add(compra);

                        db.SaveChanges();

                        tran.Commit();
                        return compra.cod_compra; 
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        tran.Rollback();
                        var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", errorMessages);
                        throw new Exception("Error de validación: " + fullErrorMessage, ex);
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                    {
                        tran.Rollback();
                        Exception innerEx = ex;
                        while (innerEx.InnerException != null) { innerEx = innerEx.InnerException; }
                        throw new Exception("Error de Base de Datos: " + innerEx.Message, ex);
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public bool EliminarCompra(int codCompra)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var compra = db.compra.Find(codCompra);
                if (compra == null) return false;

                var detalles = db.detalle_compra.Where(d => d.cod_compra == codCompra).ToList();
                if (detalles.Any())
                {
                    db.detalle_compra.RemoveRange(detalles);
                }

                db.compra.Remove(compra);
                db.SaveChanges();
                return true;
            }
        }

        public DataTable ObtenerDashboardMontoPorDia(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // Consulta base
                    string queryBase = @"
                SELECT 
                    CAST(c.fecha_compra AS DATE) AS Fecha, 
                    SUM(c.monto_total) AS Total
                FROM compra c
                INNER JOIN proveedor p ON c.dni_proveedor = p.dni_proveedor
                WHERE c.fecha_compra BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1)); // Incluye el día completo

                        // Filtro dinámico para Proveedor
                        if (!string.IsNullOrEmpty(nombreProveedor))
                        {
                            queryBase += " AND (p.nombre LIKE @prov OR p.apellido LIKE @prov)";
                            cmd.Parameters.AddWithValue("@prov", "%" + nombreProveedor + "%");
                        }

                        // Filtro dinámico para Producto
                        if (!string.IsNullOrEmpty(nombreProducto))
                        {
                            // Subconsulta para ver si la compra CONTIENE ese producto
                            queryBase += @" AND EXISTS (
                        SELECT 1 
                        FROM detalle_compra dc
                        INNER JOIN producto pr ON dc.cod_producto = pr.cod_producto
                        WHERE dc.cod_compra = c.cod_compra AND pr.nombre LIKE @prod
                    )";
                            cmd.Parameters.AddWithValue("@prod", "%" + nombreProducto + "%");
                        }

                        queryBase += " GROUP BY CAST(c.fecha_compra AS DATE) ORDER BY Fecha";

                        cmd.CommandText = queryBase;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_compra.ObtenerDashboardMontoPorDia: " + ex.Message, ex);
                }
            }
            return tabla;
        }

        public DataTable ObtenerDashboardCategoria(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // Consulta base: une todo para poder filtrar
                    string queryBase = @"
                SELECT 
                    ca.descripcion AS Categoria, 
                    SUM(dc.cantidad) AS Cantidad
                FROM detalle_compra dc
                INNER JOIN producto pr ON dc.cod_producto = pr.cod_producto
                INNER JOIN categoria ca ON pr.id_categoria = ca.id_categoria -- (¡Verifica este 'id_categoria'!)
                INNER JOIN compra c ON dc.cod_compra = c.cod_compra
                INNER JOIN proveedor p ON c.dni_proveedor = p.dni_proveedor
                WHERE c.fecha_compra BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        // Filtro dinámico para Proveedor
                        if (!string.IsNullOrEmpty(nombreProveedor))
                        {
                            queryBase += " AND (p.nombre LIKE @prov OR p.apellido LIKE @prov)";
                            cmd.Parameters.AddWithValue("@prov", "%" + nombreProveedor + "%");
                        }

                        // Filtro dinámico para Producto
                        if (!string.IsNullOrEmpty(nombreProducto))
                        {
                            queryBase += " AND pr.nombre LIKE @prod";
                            cmd.Parameters.AddWithValue("@prod", "%" + nombreProducto + "%");
                        }

                        queryBase += " GROUP BY ca.descripcion ORDER BY Cantidad DESC";

                        cmd.CommandText = queryBase;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_compra.ObtenerDashboardCategoria: " + ex.Message, ex);
                }
            }
            return tabla;
        }


        // Este método solo cuenta el N° de compras 
        public int ObtenerTotalComprasFiltrado(DateTime fechaDesde, DateTime fechaHasta, string nombreProveedor, string nombreProducto)
        {
            int total = 0;
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // 1. Consulta base: solo cuenta los IDs de compra únicos
                    string queryBase = @"
                SELECT COUNT(DISTINCT c.cod_compra)
                FROM compra c
                INNER JOIN proveedor p ON c.dni_proveedor = p.dni_proveedor
                WHERE c.fecha_compra BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        // 2. Filtro dinámico de Proveedor
                        if (!string.IsNullOrEmpty(nombreProveedor))
                        {
                            queryBase += " AND (p.nombre LIKE @prov OR p.apellido LIKE @prov)";
                            cmd.Parameters.AddWithValue("@prov", "%" + nombreProveedor + "%");
                        }

                        // 3. Filtro dinámico de Producto
                        if (!string.IsNullOrEmpty(nombreProducto))
                        {
                            queryBase += @" AND EXISTS (
                        SELECT 1 
                        FROM detalle_compra dc
                        INNER JOIN producto pr ON dc.cod_producto = pr.cod_producto
                        WHERE dc.cod_compra = c.cod_compra AND pr.nombre LIKE @prod
                    )";
                            cmd.Parameters.AddWithValue("@prod", "%" + nombreProducto + "%");
                        }

                        cmd.CommandText = queryBase;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        // 4. ExecuteScalar devuelve un solo valor (nuestro conteo)
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_compra.ObtenerTotalComprasFiltrado: " + ex.Message, ex);
                }
            }
            return total;
        }

    }
}
