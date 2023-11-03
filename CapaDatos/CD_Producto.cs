using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto:Conexion
    {

        



        public int insertar_producto(string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Producto(id_talle, descripcion, precio_unitario, stock, fecha_alta, id_categoria, id_proveedor)" +
                            "VALUES('" + descripcion + "', " + precio_unitario + ", " + stock + ", getdate(), " + id_categoria + ", " + id_proveedor + ")";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }



    }
}
