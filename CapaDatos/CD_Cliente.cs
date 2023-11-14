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

        public int insertar_cliente(string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domicilio_cliente, int celular_cliente)
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

        public int modificar_cliente(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, int id_tipousuario)
        {
            var conexion = GetConnection();
            int flag = 0;

            conexion.Open();

            string query = "UPDATE Usuario SET nombre_usuario = @nombre_usuario, apellido_usuario = @apellido_usuario, username = @username, email_usuario = @email_usuario, domicilio_usuario = @domicilio_usuario, celular_usuario = @celular, id_tipo_usuario = @id_tipousuario WHERE dni_usuario = @dni_usuario";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                // Utiliza parámetros para evitar la concatenación directa de valores en la consulta y prevenir inyección SQL
                cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("@apellido_usuario", apellido_usuario);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@dni_usuario", dni_usuario);
                cmd.Parameters.AddWithValue("@email_usuario", email_usuario);
                cmd.Parameters.AddWithValue("@domicilio_usuario", domicilio_usuario);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@id_tipousuario", id_tipousuario);

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
            string query = "update Usuario set estado_usuario = 0 WHERE dni_usuario = '" + dni + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }




    }
}
