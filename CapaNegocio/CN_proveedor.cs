using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_proveedor
    {
        readonly CD_proveedor oProveedor = new CD_proveedor();
        public void AgregarProveedor(ProveedorModel proveedorModel)
        {
            var proveedorEntidad = new proveedor
            {
                dni_proveedor = proveedorModel.dni_proveedor,
                nombre = proveedorModel.nombre,
                apellido = proveedorModel.apellido,
                email_proveedor = proveedorModel.email_proveedor,
                telefono = proveedorModel.telefono,
                id_estado = proveedorModel.id_estado
            };
            oProveedor.AgregarProveedor(proveedorEntidad);
        }

        public List<ProveedorModel> ObtenerProveedores()
        {
            var listaDatos = oProveedor.obtenerProveedores();
            return listaDatos.Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_proveedor,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_proveedor,
                telefono = p.telefono,
                id_estado = p.id_estado
            }).ToList();
        }

        public List<ProveedorModel> ObtenerProveedoresActivos()
        {
            var listaDatos = oProveedor.obtenerProveedoresActivos();
            return listaDatos.Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_proveedor,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_proveedor,
                telefono = p.telefono,
                id_estado = p.id_estado
            }).ToList();
        }

        public List<ProveedorModel> BuscarProveedores(string criterio)
        {
            var listaDatos = oProveedor.buscarProveedores(criterio);
            return listaDatos.Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_proveedor,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_proveedor,
                telefono = p.telefono,
                id_estado = p.id_estado
            }).ToList();
        }

        public List<ProveedorModel> BuscarProveedoresActivos(string nombre, string dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {

                var query = db.proveedor
                    .Where(p => p.id_estado == 1);


                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    query = query.Where(p => p.nombre.Contains(nombre));
                }


                if (!string.IsNullOrWhiteSpace(dni))
                {
                    query = query.Where(p => p.dni_proveedor.ToString().Contains(dni));
                }


                var lista = query.Select(p => new ProveedorModel
                {
                    dni_proveedor = p.dni_proveedor,
                    nombre = p.nombre,
                    apellido = p.apellido,
                    email_proveedor = p.email_proveedor,
                    telefono = p.telefono,
                    id_estado = p.id_estado
                }).ToList();

                return lista;
            }
        }
        //Busca proveedores activos por cualquier criterio
        public List<ProveedorModel> BuscarProveedoresActivos2(string criterio)
        {
            var listaDatos = oProveedor.buscarProveedores(criterio);
            return listaDatos.Where(p => p.id_estado == 1).Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_proveedor,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_proveedor,
                telefono = p.telefono,
                id_estado = p.id_estado
            }).ToList();
        }

        public List<ProveedorModel> ListarProveedoresActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var lista = db.proveedor
                    .Where(p => p.id_estado == 1) // solo activos
                    .Select(p => new ProveedorModel
                    {
                        dni_proveedor = p.dni_proveedor,
                        nombre = p.nombre,
                        apellido = p.apellido,
                        email_proveedor = p.email_proveedor,
                        telefono = p.telefono,
                        id_estado = p.id_estado
                    }).ToList();

                return lista;
            }
        }

        public List<ProveedorModel> ObtenerProveedoresInactivos()
        {
            var listaDatos = oProveedor.obtenerProveedores();
            return listaDatos.Where(p => p.id_estado != 1).Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_proveedor,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_proveedor,
                telefono = p.telefono,
                id_estado = p.id_estado
            }).ToList();
        }

        public void ActualizarProveedor(ProveedorModel proveedorModel)
        {
            var proveedorEntidad = new proveedor
            {
                dni_proveedor = proveedorModel.dni_proveedor,
                nombre = proveedorModel.nombre,
                apellido = proveedorModel.apellido,
                email_proveedor = proveedorModel.email_proveedor,
                telefono = proveedorModel.telefono,
                id_estado = proveedorModel.id_estado
            };
            oProveedor.actualizarProveedor(proveedorEntidad);
        }
        public void altaProveedor(long dni_proveedor)
        {
            oProveedor.altaProveedor(dni_proveedor);
        }

        public void bajaProveedor(long dni_proveedor)
        {
            oProveedor.bajaProveedor(dni_proveedor);
        }

        public bool VerificarProveedorExistente(long dni_proveedor)
        {
            var listaDatos = oProveedor.obtenerProveedores();
            return listaDatos.Any(p => p.dni_proveedor == dni_proveedor);
        }

        public bool VerificarProveedorExistenteYActivo(long dni_proveedor)
        {
            var listaDatos = oProveedor.obtenerProveedoresActivos();
            return listaDatos.Any(p => p.dni_proveedor == dni_proveedor);
        }

        public bool emailExistente(string email, long dni)
        {
            var listaDatos = oProveedor.obtenerProveedores();
            return listaDatos.Any(p => p.email_proveedor == email && p.dni_proveedor != dni);
        }

    }

}

