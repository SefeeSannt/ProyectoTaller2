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
                    // --- INICIA EL NUEVO BLOQUE TRY...CATCH ---
                    try
                    {
                        // 1. Validar y VINCULAR proveedor
                        var prov = db.proveedor.Find(compra.dni_proveedor);
                        if (prov == null) throw new Exception($"Proveedor con dni {compra.dni_proveedor} no existe.");

                        compra.proveedor = prov;

                        // 2. Validar y VINCULAR productos
                        if (compra.DetalleCompra == null || !compra.DetalleCompra.Any())
                            throw new Exception("La compra debe contener al menos un detalle.");

                        decimal total = 0m; // <-- CAMBIADO A DECIMAL (Ver punto 2)

                        foreach (var det in compra.DetalleCompra)
                        {
                            var prod = db.producto.Find(det.cod_producto);
                            if (prod == null) throw new Exception($"Producto con código {det.cod_producto} no existe.");

                            det.producto = prod;

                            if (det.cantidad <= 0) throw new Exception("La cantidad debe ser mayor que 0.");

                            // Asumo que 'precio_compra' y 'subtotal' son decimal o double
                            total += det.subtotal;
                        }

                        compra.monto_total = total; // <-- CAMBIADO A DECIMAL
                        if (compra.fecha_compra == default(DateTime)) compra.fecha_compra = DateTime.Now;

                        // 3. Insertar
                        db.compra.Add(compra);
                        db.SaveChanges();

                        tran.Commit();
                        return compra.cod_compra;
                    }
                    catch (DbEntityValidationException ex) // Error de validación de EF (antes de SQL)
                    {
                        tran.Rollback();
                        var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", errorMessages);
                        throw new Exception("Error de validación: " + fullErrorMessage, ex);
                    }
                    catch (DbUpdateException ex) // ¡ESTE ES EL ERROR QUE TIENES!
                    {
                        tran.Rollback();

                        // Esto "desenvuelve" el error hasta llegar al mensaje de SQL
                        Exception innerEx = ex;
                        while (innerEx.InnerException != null)
                        {
                            innerEx = innerEx.InnerException;
                        }

                        // Esto te dará el mensaje real (ej: "Conflicto de FOREIGN KEY", "Truncamiento de datos")
                        throw new Exception("Error de Base de Datos: " + innerEx.Message, ex);
                    }
                    catch (Exception ex) // Otros errores
                    {
                        tran.Rollback();
                        throw new Exception("Error general al agregar compra: " + ex.GetBaseException().Message, ex);
                    }
                    // --- FIN DEL NUEVO BLOQUE TRY...CATCH ---
                }
            }
        }
        // ... otros métodos ...
    }
}