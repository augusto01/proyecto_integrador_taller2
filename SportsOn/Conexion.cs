using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsOn
{
    //Creamos una nueva conexion con la base de datos
    public class Conexion
    {
        //variables privadas
        private string Base;
        private String Servidor;
        private String Usuario;
        private String Clave;

        //permitira autenticacion en sql server !
        private bool seguridad;

        //creamos un nuevo objeto con la conexion
        private static Conexion conex = null;
        private Conexion()
        {
            this.Base = "proyecto_taller2";
            this.Servidor = "DESKTOP-FG0LK48";
            this.Usuario = "sa";
            this.Clave = "1234";
            this.seguridad = true;
        }

        //creamos conexion 
        public SqlConnection crearConexion()
        {
            //variable tipo sql connection
            SqlConnection cadena = new SqlConnection();
            try
            {
                //creamos cadena de conexion
                cadena.ConnectionString = "Servidor = " + this.Servidor + "; Database: " + this.Base + ";";
                //validamos el tipo de seguridad 
                if (this.seguridad == true)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "user ID=" + this.Usuario + "Password" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }

        //generamos instancia
        public static Conexion crearInstancia()
        {
            if (conex == null)
            {
                conex = new Conexion();
            }
            return conex;
        }
    }
}
