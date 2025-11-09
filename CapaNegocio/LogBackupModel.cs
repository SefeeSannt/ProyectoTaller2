using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class LogBackupModel
    {
        public string Archivo { get; set; }
        public string AdminEmail { get; set; }
        public DateTime Fecha { get; set; }
    }
}
