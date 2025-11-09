using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_venta
    {
        public DataTable ListarVentas(DateTime fechaDesde, DateTime fechaHasta, string dniCliente)
        {/*
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string queryBase = @"
                        SELECT 
                            v.cod_venta,
                            (ISNULL(c.nombre,'') + ' ' + ISNULL(c.apellido,'')) AS cliente,
                            v.fecha_venta AS fecha_venta,
                            v.monto_total AS monto_total
                        FROM venta v
                        INNER JOIN cliente c ON v.dni_cliente = c.dni_cliente";


                    string whereClause = " WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        if (!string.IsNullOrEmpty(dniCliente))
                        {
                            whereClause += " AND c.dni_cliente = @dniCliente";
                            cmd.Parameters.AddWithValue("@dniCliente", dniCliente);
                        }

                        cmd.CommandText = queryBase + whereClause + " ORDER BY v.fecha_venta DESC";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ListarVentas: " + ex.Message, ex);
                }
            }
            return tabla;*/

            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();

                    // 2. Modificamos la consulta base para UNIR con la tabla 'cliente'
                    string queryBase = @"
                SELECT 
                    v.cod_venta, 
                    (u.nombre + ' ' + u.apellido) AS Vendedor,
                    v.fecha_venta, 
                    v.monto_total
                FROM venta v
                INNER JOIN usuario u ON v.dni_usuario = u.dni_usuario
                INNER JOIN cliente c ON v.dni_cliente = c.dni_cliente"; // <-- ¡JOIN IMPORTANTE!

                    // 3. El filtro de fecha sigue igual
                    string whereClause = " WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        // --- 4. ¡LÓGICA MODIFICADA! ---
                        // Buscamos por nombre O apellido del CLIENTE
                        if (!string.IsNullOrEmpty(nombreCliente))
                        {
                            whereClause += " AND (c.nombre LIKE @nombreCli OR c.apellido LIKE @nombreCli)";
                            cmd.Parameters.AddWithValue("@nombreCli", "%" + nombreCliente + "%");
                        }

                        cmd.CommandText = queryBase + whereClause + " ORDER BY v.fecha_venta DESC";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
               
                    throw new Exception("Error en CD_venta.ListarVentas: " + ex.Message, ex);
                }
            }
        }

        public DataTable ObtenerDetalleVenta(int codVenta)
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
                    (d.subtotal / d.cantidad) AS PrecioVenta,
                    d.cantidad AS Cantidad,
                    d.subtotal AS Subtotal
                FROM detalle_venta d
                INNER JOIN producto p ON d.cod_producto = p.cod_producto
                WHERE d.cod_venta = @codVenta";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@codVenta", codVenta);
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerDetalleVenta: " + ex.Message, ex);
                }
            }
            return tabla;
        }


        public List<venta> ObtenerVentas()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.venta
                         .Include("cliente")
                         .Include("usuario")
                         .Include("detalle_venta")
                         .ToList();
            }
        }

        public venta ObtenerVentaPorId(int codVenta)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.venta
                         .Include("cliente")
                         .Include("usuario")
                         .Include("detalle_venta") 
                         .FirstOrDefault(c => c.cod_venta == codVenta);
            }
        }

        public int AgregarVenta(venta venta)
        {
            if (venta == null) throw new ArgumentNullException(nameof(venta));
            if (venta.detalle_venta == null || !venta.detalle_venta.Any())
                throw new Exception("La venta debe contener al menos un detalle.");

            using (var db = new ProyectoTaller2Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        int maxId = 0;
                        if (db.venta.Any())
                        {
                            maxId = db.venta.Max(c => c.cod_venta);
                        }

                        venta.cod_venta = maxId + 1;

                        var clien = db.cliente.Find(venta.dni_cliente);
                        if (clien == null)
                            throw new Exception($"El cliente con DNI {venta.dni_cliente} no existe.");
                        venta.cliente = clien;

                        var user = db.usuario.Find(venta.dni_usuario);
                        if (user == null)
                            throw new Exception($"El usuario con DNI {venta.dni_usuario} no existe.");
                        venta.usuario = user;

                        decimal totalCalculado = 0m;
                        foreach (var det in venta.detalle_venta)
                        {
                            var prod = db.producto.Find(det.cod_producto);
                            if (prod == null)
                                throw new Exception($"El producto con código {det.cod_producto} no existe.");
                            det.producto = prod;

                            det.cod_venta = venta.cod_venta;

                            totalCalculado += (decimal)det.subtotal;
                        }

                        venta.monto_total = (double)totalCalculado;
                        if (venta.fecha_venta == default(DateTime))
                            venta.fecha_venta = DateTime.Now;

                        db.venta.Add(venta);

                        db.SaveChanges();

                        tran.Commit();
                        return venta.cod_venta;
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

        public bool EliminarVenta(int codVenta)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var venta = db.venta.Find(codVenta);
                if (venta == null) return false;

                var detalles = db.detalle_venta.Where(d => d.cod_venta == codVenta).ToList();
                if (detalles.Any())
                {
                    db.detalle_venta.RemoveRange(detalles);
                }

                db.venta.Remove(venta);
                db.SaveChanges();
                return true;
            }
        }
        /*
        public DataTable ObtenerDashboardMontoPorDia(DateTime fechaDesde, DateTime fechaHasta, string nombreCliente, string nombreProducto)
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
                    CAST(v.fecha_venta AS DATE) AS Fecha, 
                    SUM(v.monto_total) AS Total
                FROM venta v
                INNER JOIN cliente c ON v.dni_cliente = c.dni_cliente
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1)); // Incluye el día completo

                        // Filtro dinámico para Cliente
                        if (!string.IsNullOrEmpty(nombreCliente))
                        {
                            queryBase += " AND (p.nombre LIKE @clien OR p.apellido LIKE @clien)";
                            cmd.Parameters.AddWithValue("@clien", "%" + nombreCliente + "%");
                        }

                        // Filtro dinámico para Producto
                        if (!string.IsNullOrEmpty(nombreProducto))
                        {
                            // Subconsulta para ver si la compra CONTIENE ese producto
                            queryBase += @" AND EXISTS (
                        SELECT 1 
                        FROM detalle_venta dv
                        INNER JOIN producto pr ON dv.cod_producto = pr.cod_producto
                        WHERE dv.cod_venta = c.cod_venta AND pr.nombre LIKE @prod
                    )";
                            cmd.Parameters.AddWithValue("@prod", "%" + nombreProducto + "%");
                        }

                        queryBase += " GROUP BY CAST(v.fecha_venta AS DATE) ORDER BY Fecha";

                        cmd.CommandText = queryBase;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerDashboardMontoPorDia: " + ex.Message, ex);
                }
            }
            return tabla;
        }
        */
        /*
        public DataTable ObtenerDashboardCategoria(DateTime fechaDesde, DateTime fechaHasta, string nombreCliente, string nombreProducto)
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
                    SUM(dv.cantidad) AS Cantidad
                FROM detalle_venta dv
                INNER JOIN producto pr ON dv.cod_producto = pr.cod_producto
                INNER JOIN categoria ca ON pr.id_categoria = ca.id_categoria
                INNER JOIN venta v ON dv.cod_venta = v.cod_venta
                INNER JOIN cliente c ON v.dni_cliente = c.dni_cliente
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        // Filtro dinámico para Cliente
                        if (!string.IsNullOrEmpty(nombreCliente))
                        {
                            queryBase += " AND (p.nombre LIKE @clien OR p.apellido LIKE @clien)";
                            cmd.Parameters.AddWithValue("@clien", "%" + nombreCliente + "%");
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
                    throw new Exception("Error en CD_venta.ObtenerDashboardCategoria: " + ex.Message, ex);
                }
            }
            return tabla;
        }


        // Este método solo cuenta el N° de venta 
        public int ObtenerTotalVentasFiltrado(DateTime fechaDesde, DateTime fechaHasta, string nombreCliente, string nombreProducto)
        {
            int total = 0;
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // 1. Consulta base: solo cuenta los IDs de venta únicos
                    string queryBase = @"
                SELECT COUNT(DISTINCT v.cod_venta)
                FROM venta v
                INNER JOIN cliente c ON v.dni_cliente = c.dni_cliente
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));

                        // 2. Filtro dinámico de Cliente
                        if (!string.IsNullOrEmpty(nombreCliente))
                        {
                            queryBase += " AND (p.nombre LIKE @clien OR p.apellido LIKE @clien)";
                            cmd.Parameters.AddWithValue("@clien", "%" + nombreCliente + "%");
                        }

                        // 3. Filtro dinámico de Producto
                        if (!string.IsNullOrEmpty(nombreProducto))
                        {
                            queryBase += @" AND EXISTS (
                        SELECT 1 
                        FROM detalle_venta dv
                        INNER JOIN producto pr ON dv.cod_producto = pr.cod_producto
                        WHERE dv.cod_venta = v.cod_venta AND pr.nombre LIKE @prod
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
                    throw new Exception("Error en CD_venta.ObtenerTotalVentasFiltrado: " + ex.Message, ex);
                }
            }
            return total;
        }*/




        public DataTable ObtenerDashboardMontoPorDia(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string queryBase = @"
                SELECT 
                    CAST(v.fecha_venta AS DATE) AS Fecha, 
                    SUM(v.monto_total) AS Total
                FROM venta v
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta
                GROUP BY CAST(v.fecha_venta AS DATE) 
                ORDER BY Fecha";

                    using (SqlCommand cmd = new SqlCommand(queryBase, con))
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerDashboardMontoPorDia: " + ex.Message, ex);
                }
            }
            return tabla;
        }

        public int ObtenerTotalVentasFiltrado(DateTime fechaDesde, DateTime fechaHasta)
        {
            int total = 0;
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string queryBase = @"
                SELECT COUNT(DISTINCT v.cod_venta)
                FROM venta v
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand(queryBase, con))
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));
                        cmd.CommandType = CommandType.Text;

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerTotalVentasFiltrado: " + ex.Message, ex);
                }
            }
            return total;
        }

        public int ObtenerTotalProductosVendidosFiltrado(DateTime fechaDesde, DateTime fechaHasta)
        {
            int total = 0;
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // Consulta simplificada: une venta y detalle, filtra por fecha
                    string queryBase = @"
                SELECT ISNULL(SUM(dv.cantidad), 0)
                FROM detalle_venta dv
                INNER JOIN venta v ON dv.cod_venta = v.cod_venta
                WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta";

                    using (SqlCommand cmd = new SqlCommand(queryBase, con))
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));
                        cmd.CommandType = CommandType.Text;

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            total = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerTotalProductosVendidosFiltrado: " + ex.Message, ex);
                }
            }
            return total;
        }

        public DataTable ObtenerTop5ProductosVendidos(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT TOP 5
                            p.nombre AS Producto,
                            SUM(dv.cantidad) AS TotalVendido
                        FROM detalle_venta dv
                        INNER JOIN producto p ON dv.cod_producto = p.cod_producto
                        INNER JOIN venta v ON dv.cod_venta = v.cod_venta
                        WHERE v.fecha_venta BETWEEN @fechaDesde AND @fechaHasta
                        GROUP BY p.nombre
                        ORDER BY TotalVendido DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                        cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date.AddDays(1).AddSeconds(-1));
                        cmd.CommandType = CommandType.Text;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(tabla);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en CD_venta.ObtenerTop5ProductosVendidos: " + ex.Message, ex);
                }
            }
            return tabla;
        }





    }
}
