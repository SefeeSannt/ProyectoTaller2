using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_cliente
    {
        public void AgregarCliente(cliente cliente)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                db.cliente.Add(cliente);
                db.SaveChanges();
            }
        }

        public List<cliente> ObtenerClientes()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.ToList();
            }
        }

        public List<cliente> BuscarClientes(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente
                         .Where(c => c.nombre.Contains(criterio) ||
                                     c.apellido.Contains(criterio) ||
                                     c.dni.ToString().Contains(criterio) ||
                                     c.domicilio.Contains(criterio) ||
                                     c.email.Contains(criterio))
                         .ToList();
            }
        }
    }
}
