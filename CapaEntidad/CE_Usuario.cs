using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CapaEntidad
{
    public class Usuario
    {

       public string username {get;set;}

       public string pass { get; set; }

       public static int id_usuario { get; set; }
       public static int id_tipo_usuario { get; set; }
       public static string domicilio { get; set; }
       public static string nombre { get; set; }
       public static string apellido { get; set; }
       public static string correo { get; set; }

       public static DateTime fecha_creacion { get; set; }
       public static int dni { get; set; }

       public static int cel { get; set; }

       public static SqlBoolean estado { get; set; }


    }


    
}
