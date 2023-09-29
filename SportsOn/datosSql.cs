using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsOn
{
    public class datosSql
    {
        public DataTable listarUsuarios()
        {
            //nos permite leer secuencia de filas de una tabla dentro de sql server
            SqlDataReader lista;
            DataTable tabla = new DataTable();


            //NOS CONECTAMOS A LA BASE DE DATOS 
            SqlConnection conex = new SqlConnection();
            try
            {
                string sql = "SELECT id_usuario, nombre,apellido, dni, username FROM Usuario";
                conex = Conexion.crearInstancia().crearConexion(); //devuelve el string de conexion a sql 
                SqlCommand comando = new SqlCommand(sql, conex); 
                conex.Open();
                lista = comando.ExecuteReader();
                tabla.Load(lista);
                return tabla;

            }
            catch(Exception e)
            {
                throw e;
            }

            finally
            {
                if(conex.State == ConnectionState.Open) conex.Close(); //SI LA CONEXION ESTA ABIERTA, LA CERRAMOS              
            }

        }

    }
}
