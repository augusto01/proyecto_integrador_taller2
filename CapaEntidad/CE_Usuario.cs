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
    public class CE_Usuario
    {

       public string username {get;set;}

       public string pass { get; set; }

       public  int id_usuario { get; set; }
       public  int id_tipo_usuario { get; set; }
       public  string domicilio { get; set; }
       public  string nombre { get; set; }
       public  string apellido { get; set; }
       public  string correo { get; set; }

       public  DateTime fecha_creacion { get; set; }
       public  int dni { get; set; }

       public  int cel { get; set; }

       public  int estado { get; set; }

        public  CE_Usuario(int id_tipo_usuario, string nombre, string apellido, string correo, int estado, DateTime fecha_creacion, int dni, string username, string pass, int cel, string domicilio)
        {
            this.id_tipo_usuario = id_tipo_usuario;
            this.nombre = nombre.Trim().ToString();
            this.apellido = apellido.Trim();
            this.correo = correo.Trim();
            this.estado = estado;
            this.fecha_creacion = fecha_creacion;
            this.dni = dni;
            this.username = username;
            this.pass = pass.Trim();
            this.cel = cel;
            this.domicilio = domicilio;
        }

    }


    
}
