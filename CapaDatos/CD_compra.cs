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

        public DataTable ListarCompras()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                try
                {
                    con.Open();
                    // Uso de nombre + apellido (campos presentes en tu entidad proveedor)
                    string query = @"
                        SELECT 
                            c.cod_compra,
                            (ISNULL(p.nombre,'') + ' ' + ISNULL(p.apellido,'')) AS proveedor,
                            c.fecha_compra AS fecha_compra,
                            c.monto_total AS monto_total
                        FROM compra c
                        INNER JOIN proveedor p ON c.dni_proveedor = p.dni_proveedor
                        ORDER BY c.fecha_compra DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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
    }
}
