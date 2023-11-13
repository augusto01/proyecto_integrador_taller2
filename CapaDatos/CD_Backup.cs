using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Backup: Conexion
    {

     

        public void realizar_backup(string rutaArchivo, string nombrearchivo)
        {
            var conexion = GetConnection();

           
                    conexion.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conexion;
                cmd.CommandText = $"BACKUP DATABASE proyecto_taller2 TO DISK = '{rutaArchivo}\\{nombrearchivo}' WITH INIT, STATS = 10";
                cmd.ExecuteNonQuery();
            }


        }

        public void restaurar_backup(string rutaArchivo)
        {
            try
            {
                var conexion = GetConnection();
                conexion.Open();

                // Desconectar usuarios activos
                using (SqlCommand cmdDisconnectUsers = new SqlCommand("ALTER DATABASE proyecto_taller2 SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", conexion))
                {
                    cmdDisconnectUsers.ExecuteNonQuery();
                }

                // Restaurar la base de datos
                using (SqlCommand cmdRestore = new SqlCommand($"USE master; RESTORE DATABASE proyecto_taller2 FROM DISK = '{rutaArchivo}' WITH REPLACE; USE proyecto_taller2;", conexion))
                {
                    cmdRestore.ExecuteNonQuery();
                }

                // Restaurar la conexión múltiple
                using (SqlCommand cmdReconnectUsers = new SqlCommand("ALTER DATABASE proyecto_taller2 SET MULTI_USER;", conexion))
                {
                    cmdReconnectUsers.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al restaurar el respaldo: {ex.Message}");
                throw;
            }
                    
            
            
        }
    }
}
