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
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Producto(id_talle, descripcion, precio_unitario, stock, fecha_alta, id_categoria, id_proveedor, estado)" +
                            "VALUES("+id_talle+",'" + descripcion + "', " + precio_unitario + ", " + stock + ", getdate(), " + id_categoria + ", " + id_proveedor + ",1)";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int modificar_producto(int id_producto, string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "update Producto set id_talle = "+id_talle+", descripcion = '"+descripcion+"', precio_unitario = "+precio_unitario+", stock = "+stock+", fecha_alta = getdate(), id_categoria = "+id_categoria+", id_proveedor = "+id_proveedor+", estado = 1 where id_producto = "+id_producto+"";
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
            string consulta = "select Producto.id_producto,Producto.descripcion as 'Producto',Talle.descripcion as 'Talle',precio_unitario as 'Precio',stock as 'Stock',Categoria.descripcion as 'Categoria',pro.nombre as 'Proveedor' from Producto\r\ninner join Proveedor pro on Producto.id_proveedor = pro.id_proveedor\r\ninner join Talle on Producto.id_talle = Talle.id_talle\r\ninner join Categoria on Producto.id_categoria = Categoria.id_categoria";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }








    }
}
