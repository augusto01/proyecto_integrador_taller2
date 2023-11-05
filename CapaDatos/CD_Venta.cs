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



        public List<string> obtener_productos()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT descripcion FROM Producto";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["descripcion"].ToString());
                        }
                    }
                }
            }
            return datos;
        }



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

        //obtener el ultimo nro de la factura + 1
        public int ObtenerUltimoNumeroFactura()
        {

            var connection = GetConnection();
            connection.Open();

            string sql = "SELECT MAX(id_detalle) FROM Venta_detalle";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                object result = command.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return 0; // Si no hay facturas en la base de datos o el valor es nulo, se establece a 0
                }

                return (int)result + 1; // Incrementa el número de factura en 1 para obtener el siguiente número
            }


        }

      

    }
}
