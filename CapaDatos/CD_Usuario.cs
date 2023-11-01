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
        string cadenaconexion = "Server =DESKTOP-DQQ7GPL\\SQLEXPRESS; integrated Security = True; Database =proyecto_taller2";

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

        public void registrar_usuario(CE_Usuario usuario)
        {
            SqlConnection conexionsql= new SqlConnection(cadenaconexion);
            conexionsql.Open();
            string Query = "INSERT INTO Usuario (nombre_usuario,apellido_usuario,username,dni_usuario,email_usuario,domicilio_usuario,celular_usuario,pass,fecha_creacion,estado_usuario,id_tipo_usuario) VALUES ('"+usuario.nombre+"','"+usuario.apellido+"','"+usuario.username+"',"+usuario.dni+",'"+usuario.correo+"','"+usuario.domicilio+"',"+usuario.cel+",'"+usuario.pass+"','"+usuario.fecha_creacion+"',1,"+usuario.id_tipo_usuario+")";
            SqlCommand cmd = new SqlCommand(Query, conexionsql);
            cmd.ExecuteNonQuery();
            conexionsql.Close() ;

        }
       
    }
}

