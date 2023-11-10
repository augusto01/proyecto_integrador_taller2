using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CapaDatos
{
    public  class Conexion
    {

        
        private readonly string connectionString;

        public Conexion()
        {
            connectionString = "Server=DESKTOP-DQQ7GPL\\SQLEXPRESS; integrated Security = True; Database =proyecto_taller2";


        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        } 
    }
   
    
}
