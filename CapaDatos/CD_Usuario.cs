using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Cache;

using System.Configuration;

namespace CapaDatos
{
    public class CD_Usuario
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_usuarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuarios", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public DataTable D_buscar_usuario(CapaEntidad.Cache.UserLoginCache obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuarios", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dni_usuario",obje.d);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
    }
}
}
