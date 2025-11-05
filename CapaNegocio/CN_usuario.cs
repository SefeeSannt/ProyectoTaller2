using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CN_usuario
    {
        public CD_usuario oUsuario = new CD_usuario();

        public List<Usuario> Listar()
        {
            return oUsuario.Listar();
        }

        public void agregarUsuario(UsuarioModel obj)
        {
            var usuario = new usuario
            {
                dni_usuario = obj.dni_usuario,
                nombre = obj.nombre,
                apellido = obj.apellido,
                username = obj.username,
                telefono = obj.telefono,
                password = obj.password,
                email_usuario = obj.email_usuario,
                rol = new rol { id_rol = obj.oRol.id_rol }
            };
            oUsuario.agregarUsuario(usuario);
        }

        public List<UsuarioModel> ObtenerUsuarios()
        {
            var listaDatos = oUsuario.obtenerUsuarios();
            return listaDatos.Select(u => new UsuarioModel
            {
                dni_usuario = u.dni_usuario,
                nombre = u.nombre,
                apellido = u.apellido,
                username = u.username,
                telefono = u.telefono,
                password = u.password,
                email_usuario = u.email_usuario,
                oRol = new Rol { id_rol = u.id_rol }
            }).ToList();
        }

        public List<ProveedorModel> BuscarUsuarios(string criterio)
        {
            var listaDatos = oUsuario.buscarUsuarios(criterio);
            return listaDatos.Select(p => new ProveedorModel
            {
                dni_proveedor = p.dni_usuario,
                nombre = p.nombre,
                apellido = p.apellido,
                email_proveedor = p.email_usuario,
                telefono = p.telefono,
                estado = p.estado
            }).ToList();
        }
    }
}
