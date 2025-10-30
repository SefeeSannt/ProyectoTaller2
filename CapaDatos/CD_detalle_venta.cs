using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_detalle_venta
    {
        public void AgregarDetalles(List<detalle_venta> detalles)
        {
            if (detalles == null || detalles.Count == 0) return;

            using (var db = new ProyectoTaller2Entities())
            {
                foreach (var d in detalles)
                {
                    db.detalle_venta.Add(d);
                }
                db.SaveChanges();
            }
        }

        public List<detalle_venta> ObtenerDetallesPorVenta(int codVenta)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.detalle_venta
                         .Where(d => d.cod_venta == codVenta)
                         .ToList();
            }
        }

        public bool EliminarDetallesPorVenta(int codVenta)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var lista = db.detalle_venta.Where(d => d.cod_venta == codVenta).ToList();
                if (!lista.Any()) return false;
                db.detalle_venta.RemoveRange(lista);
                db.SaveChanges();
                return true;
            }
        }
    }
}
