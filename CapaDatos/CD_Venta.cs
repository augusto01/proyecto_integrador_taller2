using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Venta:Conexion
    {








        public List<string> obtener_clientes()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT nombre_cliente FROM Cliente";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["nombre_cliente"].ToString());
                        }
                    }
                }
            }
            return datos;
        }

        private void generar_venta()
        {




        }





        
    }
}
