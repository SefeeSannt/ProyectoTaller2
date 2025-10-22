using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


    }
}
