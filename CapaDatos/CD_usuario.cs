using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "select * from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                dni_usuario = Convert.ToInt64(dr["dni_usuario"].ToString()),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                username = dr["username"].ToString(),
                                telefono = Convert.ToInt64(dr["telefono"].ToString()),
                                password = dr["password"].ToString(),
                                email_usuario = dr["email_usuario"].ToString(),
                                oRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"].ToString()) }
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Usuario>();
                }
                finally
                {
                    if (oconexion.State == ConnectionState.Open) oconexion.Close();
                }
            }

            return lista;
        }

        public void agregarUsuario(usuario obj)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                db.usuario.Add(obj);
                db.SaveChanges();
            }
        }

        public List<usuario> obtenerUsuarios()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario.ToList();
            }
        }

        public List<usuario> buscarUsuarios(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario
                         .Where(p => p.dni_usuario.ToString().Contains(criterio) ||
                                     p.nombre.Contains(criterio) ||
                                     p.apellido.Contains(criterio) ||
                                     p.email_usuario.Contains(criterio) ||
                                     p.telefono.ToString().Contains(criterio))
                         .ToList();
            }
        }

        public List<usuario> ObtenerUsuariosActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario.Where(u => u.estado == 1).ToList();
            }
        }


        public void ActualizarUsuario(usuario usuario)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var usuarioExistente = db.usuario.Find(usuario.dni_usuario);
                if (usuarioExistente != null)
                {
                    usuarioExistente.nombre = usuario.nombre;
                    usuarioExistente.apellido = usuario.apellido;
                    usuarioExistente.username = usuario.username;
                    usuarioExistente.telefono = usuario.telefono;
                    usuarioExistente.email_usuario = usuario.email_usuario;
                    usuarioExistente.id_rol = usuario.id_rol;

                    // Solo actualiza la contraseña si el usuario.password NO está vacío
                    if (!string.IsNullOrEmpty(usuario.password))
                    {
                        usuarioExistente.password = usuario.password;
                    }
                 

                    db.SaveChanges();
                }
            }
        }

    }
}
