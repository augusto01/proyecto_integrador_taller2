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






    }
}
