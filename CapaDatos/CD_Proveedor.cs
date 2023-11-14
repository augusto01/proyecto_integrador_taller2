using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaDatos
{
    public class CD_Proveedor:Conexion
    {



        public DataTable ConsultarProveedoresDG()
        {
            var conexion = GetConnection();
            string consulta = "Select * from Proveedor";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }



        public int insertar_proveedor(string nombre,string apellido,string razon_social, string direccion, string correo,int nro_telefono, int dni)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Proveedor (nombre, apellido, razonsocial,direccion,correo,nro_telefono,dni, estado) values ('"+nombre+"','"+apellido+"','"+razon_social+"','"+direccion+"','"+correo+"',"+nro_telefono+","+dni+",1)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificar_proveedor( string nombre, string apellido, int dni,string email, string domicilio,string razonsocial, int celular)
        {
            var conexion = GetConnection();
            int flag = 0;

            conexion.Open();

            string query = "UPDATE Proveedor SET nombre = @nombre_usuario, apellido = @apellido_usuario, razonsocial = @razonsocial, direccion = @domicilio_usuario, correo = @email_usuario, nro_telefono = @celular, dni = @dni_usuario WHERE dni = @dni_usuario";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                // Utiliza parámetros para evitar la concatenación directa de valores en la consulta y prevenir inyección SQL
                cmd.Parameters.AddWithValue("@nombre_usuario", nombre);
                cmd.Parameters.AddWithValue("@apellido_usuario", apellido);
                cmd.Parameters.AddWithValue("@dni_usuario", dni);
                cmd.Parameters.AddWithValue("@email_usuario", email);
                cmd.Parameters.AddWithValue("@domicilio_usuario", domicilio);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@razonsocial", razonsocial);

                flag = cmd.ExecuteNonQuery();
            }

            conexion.Close();
            return flag;


        }

        public List<string> obtener_proveedores()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT nombre FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["nombre"].ToString());
                        }
                    }
                }
            }
            return datos;
        }

    }
 

}
