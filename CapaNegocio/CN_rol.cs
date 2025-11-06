using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public  class CN_rol
    {
        private CD_rol oDatosRol = new CD_rol();

        public List<Rol> Listar()
        {
            return oDatosRol.Listar();
        }


    }
}
