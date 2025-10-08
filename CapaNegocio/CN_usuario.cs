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
    }
}
