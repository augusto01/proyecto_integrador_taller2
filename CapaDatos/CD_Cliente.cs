using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente :Conexion
    {

        public DataTable ConsultaClientesDg()
        {
            var conexion = GetConnection();
            string consulta = "select * from Cliente";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }

        public int insertar_cliente(string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domicilio_cliente,int celular_cliente)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Cliente(nombre_cliente, apellido_cliente, dni_cliente, email_cliente, domicilio_cliente, celular_cliente,estado) " +
                            "VALUES('" + nombre_cliente + "', '" + apellido_cliente + "', " + dni_cliente + ", '" + email_cliente + "', '" + domicilio_cliente + "', " + celular_cliente + ", 1)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificar_cliente(string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domiclio_cliente, int celular)
        {
            var conexion = GetConnection();
            int flag = 0;

            conexion.Open();

            string query = "UPDATE Cliente SET nombre_cliente = @nombre_cliente, apellido_cliente = @apellido_cliente, dni_cliente = @dni_cliente, email_cliente = @email_cliente, domicilio_cliente =@domicilio_cliente , celular_cliente = @celular WHERE dni_cliente = @dni_cliente";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                // Utiliza parámetros para evitar la concatenación directa de valores en la consulta y prevenir inyección SQL
                cmd.Parameters.AddWithValue("@nombre_cliente", nombre_cliente);
                cmd.Parameters.AddWithValue("@apellido_cliente", apellido_cliente);
                cmd.Parameters.AddWithValue("@dni_cliente", dni_cliente);
                cmd.Parameters.AddWithValue("@email_cliente", email_cliente);
                cmd.Parameters.AddWithValue("@domicilio_cliente", domiclio_cliente);
                cmd.Parameters.AddWithValue("@celular", celular);
  

                flag = cmd.ExecuteNonQuery();
            }

            conexion.Close();
            return flag;


        }

        public int eliminar_cliente(int dni)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "update Cliente set estado = 0 WHERE dni_cliente = '" + dni + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }




    }
}
