using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatos
{
    public class CD_detalle_compra
    {
        public void AgregarDetalles(List<detalle_compra> detalles)
        {
            if (detalles == null || detalles.Count == 0) return;

            using (var db = new ProyectoTaller2Entities())
            {
                foreach (var d in detalles)
                {
                    db.detalle_compra.Add(d);
                }
                db.SaveChanges();
            }
        }

        public List<detalle_compra> ObtenerDetallesPorCompra(int codCompra)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.detalle_compra
                         .Where(d => d.cod_compra == codCompra)
                         .ToList();
            }
        }

        public bool EliminarDetallesPorCompra(int codCompra)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var lista = db.detalle_compra.Where(d => d.cod_compra == codCompra).ToList();
                if (!lista.Any()) return false;
                db.detalle_compra.RemoveRange(lista);
                db.SaveChanges();
                return true;
            }
        }
    }
}
