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
    public class CD_Usuario
    {
        string cadenaconexion = "Server =DESKTOP-FG0LK48; integrated Security = True; Database =proyecto_taller2";

        public void conexion()
        {

            SqlConnection conexionsql = new SqlConnection();
            try
            {
                conexionsql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexionsql.Close();
                
            }
            MessageBox.Show("Conectado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void registrar_usuario(Usuario usuario)
        {
            SqlConnection conexionsql= new SqlConnection(cadenaconexion);
            conexionsql.Open();
            string Query = "INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('"+usuario.nombre+"','Giovino','mica1',1234,'user2@gmail.com','laprida1234',37771923,'1234',getdate(),1,2)";
            SqlCommand cmd = new SqlCommand(Query, conexionsql);
            cmd.ExecuteNonQuery();
            conexionsql.Close() ;

        }
       
    }
}

