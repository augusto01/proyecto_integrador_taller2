using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CapaDatos
{
    public class CD_Producto:Conexion
    {
        public int insertar_producto(string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            int flag = 0;
            var conexion = GetConnection();
            try
            {
                conexion.Open();

                // Usar parámetros en lugar de concatenar directamente los valores
                string query = "INSERT INTO Producto (descripcion, precio_unitario, stock, fecha_alta, id_categoria, id_proveedor, id_talle, estado) " +
                               "VALUES (@descripcion, @precio_unitario, @stock, GETDATE(), @id_categoria, @id_proveedor, @id_talle, 1)";

                SqlCommand cmd = new SqlCommand(query, conexion);

                // Agregar parámetros
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                cmd.Parameters.AddWithValue("@id_talle", id_talle);

                flag = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la ejecución de la consulta
                Console.WriteLine("Error al insertar producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return flag;
        }
        public int modificar_producto(int id_producto, string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();

            string query = "UPDATE Producto SET id_talle = @id_talle, descripcion = @descripcion, precio_unitario = @precio_unitario, stock = @stock, fecha_alta = GETDATE(), id_categoria = @id_categoria, id_proveedor = @id_proveedor, estado = 1 WHERE id_producto = @id_producto";

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                // Utiliza parámetros para evitar la concatenación directa de valores en la consulta y prevenir inyección SQL
                cmd.Parameters.AddWithValue("@id_talle", id_talle);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                cmd.Parameters.AddWithValue("@id_producto", id_producto);

                flag = cmd.ExecuteNonQuery();
            }

            conexion.Close();
            return flag;
        }

        public int eliminar_producto(int id_producto)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "update Producto set estado = 0 where id_producto = " + id_producto + " ";  
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int cargar_talle(string descripcion_talle)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "Insert into Talle (descripcion)values ('"+descripcion_talle+"')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int cargar_categoria(string descripcion_talle)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Categoria(descripcion) values ('"+descripcion_talle+"')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public List<string> obtener_categorias()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT descripcion FROM Categoria";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["descripcion"].ToString());
                        }
                    }
                }
            }
            return datos;
        }
        public List<string> obtener_productos_activos()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT descripcion FROM Producto where estado = 1";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["descripcion"].ToString());
                        }
                    }
                }
            }
            return datos;
        }
        public List<string> obtener_talles()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT descripcion FROM Talle";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["descripcion"].ToString());
                        }
                    }
                }
            }
            return datos;
        }

        public DataTable ConsultaProductosDG()
        {
            var conexion = GetConnection();
            string consulta = "select Producto.id_producto,Producto.descripcion as 'Producto',\r\n\t\tTalle.descripcion as 'Talle',precio_unitario as 'Precio',\r\n\t\tstock as 'Stock',\r\n\t\tCategoria.descripcion as 'Categoria',\r\n\t\tpro.nombre as 'Proveedor' from Producto\r\n\t\tinner join Proveedor pro on Producto.id_proveedor = pro.id_proveedor \r\n\t\tinner join Talle on Producto.id_talle = Talle.id_talle\r\n\t\tinner join Categoria on Producto.id_categoria = Categoria.id_categoria";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }

        public DataTable ConsultaPreciosDG()
        {
            var conexion = GetConnection();
            string consulta = "select precio_unitario From Producto";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }







    }
}
