using System;
using System.Linq;
using System.Data.Entity;

namespace CapaDatos
{
    public class CD_compra
    {
        public int AgregarCompra(compra compra)
        {
            if (compra == null) throw new ArgumentNullException(nameof(compra));

            using (var db = new ProyectoTaller2Entities())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var prov = db.proveedor.Find(compra.dni_proveedor);
                        if (prov == null) throw new Exception($"Proveedor con dni {compra.dni_proveedor} no existe.");

                        compra.proveedor = prov;

                        if (compra.DetalleCompra == null || !compra.DetalleCompra.Any())
                            throw new Exception("La compra debe contener al menos un detalle.");

                        decimal total = 0m; 

                        foreach (var det in compra.DetalleCompra)
                        {
                            var prod = db.producto.Find(det.cod_producto);
                            if (prod == null) throw new Exception($"Producto con código {det.cod_producto} no existe.");

                            det.producto = prod;

                            if (det.cantidad <= 0) throw new Exception("La cantidad debe ser mayor que 0.");

                            
                            total += det.subtotal;
                        }

                        compra.monto_total = total; //  CAMBIADO A DECIMAL
                        if (compra.fecha_compra == default(DateTime)) compra.fecha_compra = DateTime.Now;

                        db.compra.Add(compra);
                        db.SaveChanges();

                        tran.Commit();
                        return compra.cod_compra;
                    }
                    catch (DbEntityValidationException ex) 
                    {
                        tran.Rollback();
                        var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", errorMessages);
                        throw new Exception("Error de validación: " + fullErrorMessage, ex);
                    }
                    catch (DbUpdateException ex) 
                    {
                        tran.Rollback();

                        Exception innerEx = ex;
                        while (innerEx.InnerException != null)
                        {
                            innerEx = innerEx.InnerException;
                        }

                        throw new Exception("Error de Base de Datos: " + innerEx.Message, ex);
                    }
                    catch (Exception ex) 
                    {
                        tran.Rollback();
                        throw new Exception("Error general al agregar compra: " + ex.GetBaseException().Message, ex);
                    }
                }
            }
        }
        // ... otros métodos ...
    }
}