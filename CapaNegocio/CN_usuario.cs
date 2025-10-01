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
        private CD_usuario objcd_usuario = new CD_usuario();//instancia a nuestra clase usuario de la capa datos

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

    }
}
