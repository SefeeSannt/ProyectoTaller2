using CapaDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_backup
    {
        public CD_backup cdBackup = new CD_backup();

        public void CrearBackup(string rutaCarpetaDestino)
        {
            //Validar que la carpeta exista (o manejar errores)
            if (string.IsNullOrEmpty(rutaCarpetaDestino) || !Directory.Exists(rutaCarpetaDestino))
            {
                throw new Exception("La ruta seleccionada no es válida.");
            }

            //Generar el nombre del archivo
            string dbName = "ProyectoTaller2"; // O obténlo dinámicamente
            string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + $"-BKUP_{dbName}.bak";
            string rutaCompleta = Path.Combine(rutaCarpetaDestino, fileName);

            //Llamar a la capa de datos para ejecutar
            cdBackup.RealizarBackup(rutaCompleta);
            
        }
    }
}
