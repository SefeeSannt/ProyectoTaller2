using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_proveedor
    {
        public void AgregarProveedor(proveedor proveedor)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                db.proveedor.Add(proveedor);
                db.SaveChanges();
            }
        }

        public List<proveedor> obtenerProveedores()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor.ToList();
            }
        }

        public List<proveedor> obtenerProveedoresActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor.Where(p => p.estado == 1).ToList();
            }
        }

        public List<proveedor> buscarProveedores(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor
                         .Where(p => p.dni_proveedor.ToString().Contains(criterio) ||
                                     p.nombre.Contains(criterio) ||
                                     p.apellido.Contains(criterio) ||
                                     p.email_proveedor.Contains(criterio) ||
                                     p.telefono.ToString().Contains(criterio))
                         .ToList();
            }
        }

        public List<proveedor> buscarProveedoresActivos(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor
                         .Where(p => p.estado == 1 &&
                                     (p.dni_proveedor.ToString().Contains(criterio) ||
                                     p.nombre.Contains(criterio) ||
                                     p.apellido.Contains(criterio) ||
                                     p.email_proveedor.Contains(criterio) ||
                                     p.telefono.ToString().Contains(criterio)))
                         .ToList();
            }
        }

        public void actualizarProveedor(proveedor proveedor)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var proveedorExistente = db.proveedor.Find(proveedor.dni_proveedor);
                if (proveedorExistente != null)
                {
                    proveedorExistente.nombre = proveedor.nombre;
                    proveedorExistente.apellido = proveedor.apellido;
                    proveedorExistente.email_proveedor = proveedor.email_proveedor;
                    proveedorExistente.telefono = proveedor.telefono;
                    proveedorExistente.estado = proveedor.estado;
                    db.SaveChanges();
                }
            }
        }

        public void altaProveedor(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var proveedor = db.proveedor.Find(dni);
                if (proveedor != null)
                {
                    proveedor.estado = 1;
                    db.SaveChanges();
                }
            }
        }

        public void bajaProveedor(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var proveedor = db.proveedor.Find(dni);
                if (proveedor != null)
                {
                    proveedor.estado = 0;
                    db.SaveChanges();
                }
            }
        }

        public bool ProveedorExiste(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor.Any(p => p.dni_proveedor == dni);
            }
        }

        public bool emailExiste(string email)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.proveedor.Any(p => p.email_proveedor == email);
            }
        }

    }
}
