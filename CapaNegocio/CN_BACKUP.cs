using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_BACKUP
    {


       

        public void RealizarBackup(string rutaArchivo, string nombrearchivo)
        {
            CD_Backup datosbackup = new CD_Backup();
            datosbackup.realizar_backup(rutaArchivo,nombrearchivo);
        }
        public void RestaurarBackup(string rutaArchivo)
        {
            CD_Backup resturar = new CD_Backup();
            resturar.restaurar_backup(rutaArchivo);
        }




    }
}
