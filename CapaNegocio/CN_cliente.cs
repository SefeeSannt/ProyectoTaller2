using System.Collections.Generic;
using System.Linq;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_cliente
    {
        readonly CD_cliente oCliente = new CD_cliente();

        public void AgregarCliente(ClienteModel clienteModel)
        {
            var clienteEntidad = new cliente
            {
                nombre = clienteModel.nombre,
                apellido = clienteModel.apellido,
                dni = clienteModel.dni,
                domicilio = clienteModel.domicilio,
                telefono = clienteModel.telefono,
                email = clienteModel.email,
                estado = clienteModel.estado
            };

            oCliente.AgregarCliente(clienteEntidad);
        }

        public List<ClienteModel> ObtenerClientes()
        {
            var listaDatos = oCliente.ObtenerClientes();
            return listaDatos.Select(c => new ClienteModel
            {
                nombre = c.nombre,
                apellido = c.apellido,
                dni = c.dni,
                domicilio = c.domicilio,
                telefono = c.telefono,
                email = c.email,
                estado = c.estado
            }).ToList();
        }

        public List<ClienteModel> ObtenerClientesActivos()
        {
            var listaDatos = oCliente.ObtenerClientesActivos();
            return listaDatos.Select(c => new ClienteModel
            {
                nombre = c.nombre,
                apellido = c.apellido,
                dni = c.dni,
                domicilio = c.domicilio,
                telefono = c.telefono,
                email = c.email,
                estado = c.estado
            }).ToList();
        }

        public List<ClienteModel> BuscarClientes(string criterio)
        {
            var listaDatos = oCliente.BuscarClientes(criterio);
            return listaDatos.Select(c => new ClienteModel
            {
                nombre = c.nombre,
                apellido = c.apellido,
                dni = c.dni,
                domicilio = c.domicilio,
                telefono = c.telefono,
                email = c.email,
                estado = c.estado
            }).ToList();
        }

        public List<ClienteModel> BuscarClientesActivos(string criterio)
        {
            var listaDatos = oCliente.BuscarClientesActivos(criterio);
            return listaDatos.Select(c => new ClienteModel
            {
                nombre = c.nombre,
                apellido = c.apellido,
                dni = c.dni,
                domicilio = c.domicilio,
                telefono = c.telefono,
                email = c.email,
                estado = c.estado
            }).ToList();
        }

        public void ActualizarCliente(ClienteModel clienteModel)
        {
            var clienteEntidad = new cliente
            {
                nombre = clienteModel.nombre,
                apellido = clienteModel.apellido,
                dni = clienteModel.dni,
                domicilio = clienteModel.domicilio,
                telefono = clienteModel.telefono,
                email = clienteModel.email,
                estado = clienteModel.estado
            };
            oCliente.ActualizarCliente(clienteEntidad);
        }

        public void BajaCliente(long dni)
        {
            oCliente.BajaCliente(dni);
        }

        public void AltaCliente(long dni)
        {
            oCliente.AltaCliente(dni);
        }

        public int TotalClientes()
        {
            return oCliente.TotalClientes();
        }

        public int TotalClientesActivos()
        {
            return oCliente.TotalClientesActivos();
        }

        public int TotalClientesInactivos()
        {
            return oCliente.TotalClientesInactivos();
        }
    }
}
