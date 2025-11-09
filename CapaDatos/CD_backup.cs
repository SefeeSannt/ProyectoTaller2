using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaDatos
{
    public class CD_backup
    {
        // Necesitarás tu cadena de conexión
        private string connectionString = CapaDatos.conexion.cadena;

        public void RealizarBackup(string rutaCompleta)
        {
            // Obtener el nombre de la BD desde la connection string
            var builder = new SqlConnectionStringBuilder(connectionString);
            string dbName = builder.InitialCatalog;

            string query = $"BACKUP DATABASE [{dbName}] TO DISK = N'{rutaCompleta}' WITH NOFORMAT, NOINIT, SKIP, STATS = 10";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
