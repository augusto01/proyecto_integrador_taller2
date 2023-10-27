using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "Server =DESKTOP-FG0LK48; integrated Security = True; Database =proyecto_taller2";


        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
            
    }
            
    
}
