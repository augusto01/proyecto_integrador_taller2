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
        public DataTable ObtenerProductosPorCategoria(DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("productos_por_categoria", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añade los parámetros al comando
                cmd.Parameters.Add("@fecha_desde", SqlDbType.Date).Value = fecha_desde;
                cmd.Parameters.Add("@fecha_hasta", SqlDbType.Date).Value = fecha_hasta;

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
        }

        public DataTable ObtenerVentasPorUsuario(DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ventas_por_usuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añade los parámetros al comando
                cmd.Parameters.Add("@fecha_desde", SqlDbType.Date).Value = fecha_desde;
                cmd.Parameters.Add("@fecha_hasta", SqlDbType.Date).Value = fecha_hasta;

                try
                {
                    conexion.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ventasPorUsuario = new DataTable();
                    adapter.Fill(ventasPorUsuario);

                    return ventasPorUsuario;
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
        public DataTable ObtenerProductosPreferidos(DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (var conexion = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("productos_preferidos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añade los parámetros al comando
                cmd.Parameters.Add("@fecha_desde", SqlDbType.Date).Value = fecha_desde;
                cmd.Parameters.Add("@fecha_hasta", SqlDbType.Date).Value = fecha_hasta;

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
        }


        public void ObtenerDatosDashboard(out decimal totVentas, out int nProd, out int nCliente, out int nProv, out int nCantidadVentas, out int nEmpleado, DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();

                using (SqlCommand cmd = new SqlCommand("DashboardDatos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añade los parámetros al comando
                    cmd.Parameters.Add("@fecha_desde", SqlDbType.Date).Value = fecha_desde;
                    cmd.Parameters.Add("@fecha_hasta", SqlDbType.Date).Value = fecha_hasta;
                    // Parámetros de salida
                    cmd.Parameters.Add("@totVentas", SqlDbType.Decimal).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nprod", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ncliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nprov", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ncantidadventas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@nempleado", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    // Obtener los valores de los parámetros de salida
                    totVentas = cmd.Parameters["@totVentas"].Value != DBNull.Value ? Convert.ToDecimal(cmd.Parameters["@totVentas"].Value) : 0.0m;
                    nProd = (int)cmd.Parameters["@nprod"].Value;
                    nCliente = (int)cmd.Parameters["@ncliente"].Value;
                    nProv = (int)cmd.Parameters["@nprov"].Value;
                    nCantidadVentas = (int)cmd.Parameters["@ncantidadventas"].Value;
                    nEmpleado = (int)cmd.Parameters["@nempleado"].Value;
                }
            }
        }







    }
}
