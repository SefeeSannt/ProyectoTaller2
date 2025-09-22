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

        public List<cliente> ObtenerClientesActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Where(c => c.estado == "1").ToList();
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

        public List<cliente> BuscarClientesActivos(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente
                         .Where(c => c.estado == "1" &&
                                     (c.nombre.Contains(criterio) ||
                                      c.apellido.Contains(criterio) ||
                                      c.dni.ToString().Contains(criterio) ||
                                      c.domicilio.Contains(criterio) ||
                                      c.email.Contains(criterio)))
                         .ToList();
            }
        }

        public bool ClienteExiste(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Any(c => c.dni == dni);
            }
        }

        public bool EmailExiste(string email)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Any(c => c.email == email);
            }
        }

        public void ActualizarCliente(cliente cliente)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var clienteExistente = db.cliente.Find(cliente.dni);
                if (clienteExistente != null)
                {
                    clienteExistente.nombre = cliente.nombre;
                    clienteExistente.apellido = cliente.apellido;
                    clienteExistente.domicilio = cliente.domicilio;
                    clienteExistente.telefono = cliente.telefono;
                    clienteExistente.email = cliente.email;
                    clienteExistente.estado = cliente.estado;
                    db.SaveChanges();
                }
            }
        }

        public void BajaCliente(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var cliente = db.cliente.Find(dni);
                if (cliente != null)
                {
                   cliente.estado = "0";
                    db.SaveChanges();
                }
            }
        }

        public void AltaCliente(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var cliente = db.cliente.Find(dni);
                if (cliente != null)
                {
                    cliente.estado = "1";
                    db.SaveChanges();
                }
            }
        }

        public int TotalClientes()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Count();
            }
        }

        public int TotalClientesActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Count(c => c.estado == "1");
            }
        }

        public int TotalClientesInactivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.cliente.Count(c => c.estado == "0");
            }
        }
    }
}
