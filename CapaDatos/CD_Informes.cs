using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Informes :Conexion
    {
        public DataTable ObtenerProductosPorCategoria()
        {
            var conexion = GetConnection();
            SqlCommand cmd = new SqlCommand("productos_por_categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable productosPorCategoria = new DataTable();
                adapter.Fill(productosPorCategoria);

                return productosPorCategoria;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable ObtenerProductosPreferidos()
        {
            var conexion = GetConnection();
            SqlCommand cmd = new SqlCommand("productos_preferidos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable productosPreferidos = new DataTable();
                adapter.Fill(productosPreferidos);

                return productosPreferidos;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ObtenerDatosDashboard(out float totVentas, out int nProd, out int nCateg, out int nCliente, out int nProv, out int nCantidadVentas, out int nEmpleado)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("DashboardDatos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de salida
                    cmd.Parameters.Add("@totVentas", SqlDbType.Float).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nprod", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ncateg", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ncliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nprov", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ncantidadventas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nempleado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    // Obtener los valores de los parámetros de salida
                    totVentas = (float)cmd.Parameters["@totVentas"].Value;
                    nProd = (int)cmd.Parameters["@nprod"].Value;
                    nCateg = (int)cmd.Parameters["@ncateg"].Value;
                    nCliente = (int)cmd.Parameters["@ncliente"].Value;
                    nProv = (int)cmd.Parameters["@nprov"].Value;
                    nCantidadVentas = (int)cmd.Parameters["@ncantidadventas"].Value;
                    nEmpleado = (int)cmd.Parameters["@nempleado"].Value;
                }
            }
        }






    }
}
