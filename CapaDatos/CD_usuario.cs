using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    //consulta sql
                    string query = "select id_usuario, documento, nombre, apellido, correo, clave, estado from usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;


                    oconexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                documento = dr["documento"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                correo = dr["correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                               
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
                finally
                {
                    if (oconexion.State == ConnectionState.Open) oconexion.Close();
                }


                return lista;
        }

    }
}
}
