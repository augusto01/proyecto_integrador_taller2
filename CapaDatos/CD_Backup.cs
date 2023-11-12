using System;
using System.Collections.Generic;
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

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conexion;
                        cmd.CommandText = $"use master";
                        cmd.CommandText = $"RESTORE DATABASE proyecto_taller2 FROM DISK = '{rutaArchivo}' WITH REPLACE";
                        cmd.CommandText = $"use proyecto_taller2";
                    cmd.ExecuteNonQuery();
                    }
                
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (puede ser un log, mensaje al usuario, etc.).
                Console.WriteLine($"Error al restaurar el respaldo: {ex.Message}");
                throw;
            }
        }
    }
}
