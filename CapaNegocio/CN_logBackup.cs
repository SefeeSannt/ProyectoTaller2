using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_logBackup
    {
        private ProyectoTaller2Entities db = new ProyectoTaller2Entities();
        public List<LogBackupModel> ObtenerTodos()
        {
            var listaDeDB = db.backup_logs.OrderByDescending(log => log.fecha).ToList();
            var listaModel = listaDeDB.Select(log => new LogBackupModel
            {
                Archivo = log.archivo,
                AdminEmail = log.admin_email,
                Fecha = log.fecha.Value
            }).ToList();

            return listaModel;
        }

        public void Agregar(string nombreArchivo, string emailUsuario)
        {
            backup_logs nuevoLog = new backup_logs();

            nuevoLog.archivo = nombreArchivo;
            nuevoLog.admin_email = emailUsuario;
            nuevoLog.fecha = DateTime.Now;

            db.backup_logs.Add(nuevoLog);
            db.SaveChanges();
        }
    }
}
