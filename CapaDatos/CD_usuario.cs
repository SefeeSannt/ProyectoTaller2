using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Entity;
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
                                telefono = dr["telefono"] != DBNull.Value ? Convert.ToInt64(dr["telefono"].ToString()) : 0,
                                password = dr["password"].ToString(),
                                email_usuario = dr["email_usuario"].ToString(),
                                estado = dr["estado"] != DBNull.Value ? Convert.ToInt32(dr["estado"]) : 0,
                                oRol = new Rol() { id_rol = dr["id_rol"] != DBNull.Value ? Convert.ToInt32(dr["id_rol"]) : 0 }
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
                    if (oconexion.State == System.Data.ConnectionState.Open) oconexion.Close();
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
                return db.usuario.Include("rol").ToList();
            }
        }

        public List<usuario> buscarUsuarios(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario
                         .Include("rol")
                         .Where(p => p.dni_usuario.ToString().Contains(criterio) ||
                                     p.nombre.Contains(criterio) ||
                                     p.apellido.Contains(criterio) ||
                                     p.email_usuario.Contains(criterio) ||
                                     p.telefono.ToString().Contains(criterio))
                         .ToList();
            }
        }

        // Nuevos métodos para actualizar el int 'estado' en tabla usuario
        public void AltaUsuario(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var usu = db.usuario.Find(dni);
                if (usu != null)
                {
                    usu.estado = 1;
                    db.SaveChanges();
                }
            }
        }

        public void BajaUsuario(long dni)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                var usu = db.usuario.Find(dni);
                if (usu != null)
                {
                    usu.estado = 0;
                    db.SaveChanges();
                }
            }
        }


        public void ActualizarUsuario (usuario Usuario)
        {
            using(var db = new ProyectoTaller2Entities())
            {
                var usu = db.usuario.Find(Usuario.dni_usuario);
                if (usu != null)
                {
                    usu.nombre = Usuario.nombre;
                    usu.apellido = Usuario.apellido;
                    usu.username = Usuario.username;
                    usu.telefono = Usuario.telefono;
                    if (!string.IsNullOrEmpty(Usuario.password))
                    {
                        usu.password = Usuario.password;
                    }
                    // Si está vacío, simplemente no hacemos nada, y la contraseña 
                    // original en 'usu' se mantiene intacta.

                    usu.email_usuario = Usuario.email_usuario;
                    usu.id_rol = Usuario.id_rol;
                    usu.estado = Usuario.estado; 

                    db.SaveChanges();
                }
            }
        }


        

        public List <usuario> ObtenerUsuariosActivos()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario
                         .Include("rol")
                         .Where(u => u.estado == 1)
                         .ToList();
            }
        }

        public List<usuario> BuscarUsuarioActivo(string criterio)
        {
            using (var db = new ProyectoTaller2Entities())
            {
                return db.usuario
                         .Include("rol")
                         .Where(u => u.estado == 1 &&
                                     (u.dni_usuario.ToString().Contains(criterio) ||
                                      u.nombre.Contains(criterio) ||
                                      u.apellido.Contains(criterio) ||
                                      u.email_usuario.Contains(criterio) ||
                                      u.telefono.ToString().Contains(criterio)))
                         .ToList();
            }





        }
}

}
