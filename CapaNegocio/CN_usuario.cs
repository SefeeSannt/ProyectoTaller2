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
                id_rol = obj.oRol != null ? obj.oRol.id_rol : 0,
                estado = obj.estado
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
                oRol = u.rol != null ? new Rol { id_rol = u.id_rol } : null,
                estado = u.estado,
                rol_nombre = u.rol != null ? u.rol.descripcion : string.Empty
            }).ToList();
        }

        public List<UsuarioModel> BuscarUsuarios(string criterio)
        {
            var listaDatos = oUsuario.buscarUsuarios(criterio);
            return listaDatos.Select(u => new UsuarioModel
            {
                dni_usuario = u.dni_usuario,
                nombre = u.nombre,
                apellido = u.apellido,
                username = u.username,
                telefono = u.telefono,
                email_usuario = u.email_usuario,
                estado = u.estado,
                oRol = u.rol != null ? new Rol { id_rol = u.id_rol } : null,
                rol_nombre = u.rol != null ? u.rol.descripcion : string.Empty
            }).ToList();
        }

        // Alta/Baja de usuario (actualiza int estado en BD)
        public void AltaUsuario(long dni)
        {
            oUsuario.AltaUsuario(dni);
        }

        public void BajaUsuario(long dni)
        {
            oUsuario.BajaUsuario(dni);
        }


        public void ActualizarUsuario(UsuarioModel usuario_Model)
        {
            var usuario = new usuario 
            {
                dni_usuario = usuario_Model.dni_usuario,
                nombre = usuario_Model.nombre,
                apellido = usuario_Model.apellido,
                username = usuario_Model.username,
                telefono = usuario_Model.telefono,
                password = usuario_Model.password,
                email_usuario = usuario_Model.email_usuario,
                id_rol = usuario_Model.oRol.id_rol,
                estado = usuario_Model.estado
            };
            oUsuario.ActualizarUsuario(usuario);
        }


        public List<UsuarioModel> ObtenerUsuariosActivos()
        {
            var listaDatos = oUsuario.ObtenerUsuariosActivos();

            return listaDatos.Select(u => new UsuarioModel
            {
                dni_usuario = u.dni_usuario,
                nombre = u.nombre,
                apellido = u.apellido,
                username = u.username,
                telefono = u.telefono,
                password = u.password,
                email_usuario = u.email_usuario,
                oRol = u.rol != null ? new Rol { id_rol = u.id_rol } : null,
                rol_nombre = u.rol != null ? u.rol.descripcion : string.Empty


            }).ToList();
        }





    }
}
