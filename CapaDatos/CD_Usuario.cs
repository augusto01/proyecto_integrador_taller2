using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CD_Usuario:Conexion
    {
     
        public DataTable ConsultaUsuariosDG()
        {
            var conexion = GetConnection();
            string consulta = "select us.id_usuario as 'ID',us.nombre_usuario as 'Nombre',us.apellido_usuario as 'Apellido',us.username as 'Username',us.dni_usuario as 'DNI',us.domicilio_usuario as 'Domicilio',us.email_usuario AS 'Email',us.celular_usuario,us.estado_usuario as 'Estado', tu.descripcion as'Tipo usuario' from Tipo_usuario tu\r\ninner join Usuario us on tu.id_tipo_usuario = us.id_tipo_usuario";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }

        public int insertar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Usuario(nombre_usuario, apellido_usuario, username, dni_usuario, email_usuario, domicilio_usuario, celular_usuario, pass, fecha_creacion, estado_usuario, id_tipo_usuario) " +
                            "VALUES('" + nombre_usuario + "', '" + apellido_usuario + "', '" + username + "', " + dni_usuario + ", '" + email_usuario + "', '" + domicilio_usuario + "', " + celular + ", '" + pass + "', getdate(), 1, " + id_tipousuario + ")";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, int id_tipousuario)
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

        public int eliminar_usuario(int dni)
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

