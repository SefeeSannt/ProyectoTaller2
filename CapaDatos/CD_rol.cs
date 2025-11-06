using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_rol
    {
        public List<Rol> Listar()
        {
            using (var db = new ProyectoTaller2Entities())
            {
                try
                {
                    return db.rol.Select(r => new Rol
                    {
                        id_rol = r.id_rol,
                        descripcion = r.descripcion
                    }).ToList();
                }
                catch (Exception)
                {
                    return new List<Rol>();
                }
            }
        }
    }
}

