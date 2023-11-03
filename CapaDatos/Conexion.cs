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
            connectionString = "Server =DESKTOP-FG0LK48; integrated Security = True; Database =proyecto_taller2";


        }


        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


        public DataTable ConsultaUsuariosDG()
        {
            var conexion = GetConnection();
            string consulta = "select us.id_usuario as 'ID',us.nombre_usuario as 'Nombre',us.apellido_usuario as 'Apellido',us.username as 'Username',us.dni_usuario as 'DNI',us.domicilio_usuario as 'Domicilio',us.email_usuario AS 'Email',us.celular_usuario,us.estado_usuario as 'Estado', tu.descripcion as'Tipo usuario' from Tipo_usuario tu\r\ninner join Usuario us on tu.id_tipo_usuario = us.id_tipo_usuario";
            SqlCommand cmd = new SqlCommand(consulta,conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
            

        }

        public int insertar_usuario(string nombre_usuario,string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Usuario(nombre_usuario, apellido_usuario, username, dni_usuario, email_usuario, domicilio_usuario, celular_usuario, pass, fecha_creacion, estado_usuario, id_tipo_usuario) " +
                            "VALUES('"+nombre_usuario+"', '"+apellido_usuario+"', '"+username+"', "+dni_usuario+", '"+email_usuario+"', '"+domicilio_usuario+"', "+celular+", '"+pass+"', getdate(), 1, "+id_tipousuario+")";
            SqlCommand cmd = new SqlCommand(query,conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int modificar_usuario(string nombre_usuario, string apellido_usuario, string username, int dni_usuario, string email_usuario, string domicilio_usuario, int celular, string pass, int id_tipousuario)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "update Usuario set nombre_usuario = '"+nombre_usuario+"' , apellido_usuario= '"+apellido_usuario+"',username='"+username+"',dni_usuario = "+dni_usuario+",email_usuario ='"+email_usuario+"', domicilio_usuario= '"+domicilio_usuario+"', celular_usuario = "+celular+", pass = '"+pass+"',id_tipo_usuario = "+id_tipousuario+" WHERE dni_usuario = "+dni_usuario+"";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public int eliminar_usuario(string dni)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "update Usuario set estado_usuario = 0 WHERE dni_usuario = '"+dni+"'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

    }
   
    
}
