using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Venta : Conexion
    {



        public DataTable Consulta_ventasDG(int id_usuario)
        {
            var conexion = GetConnection();
            string consulta = "select distinct vc.id_cabecera as 'ID-FACTURA', cli.nombre_cliente as 'Cliente', tp.desc_tipo_pago as 'Tipo Pago', vc.fecha_venta as 'Fecha de Venta', sum (pro.precio_unitario * Venta_detalle.cantidad_producto) as 'Precio Total'from Venta_detalle\r\ninner join Producto pro on pro.id_producto = Venta_detalle.id_producto\r\ninner join Venta_cabecera vc on Venta_detalle.id_cabecera = vc.id_cabecera\r\ninner join Cliente cli on vc.id_cliente = cli.id_cliente\r\ninner join Usuario us on vc.id_usuario = us.id_usuario\r\ninner join Tipo_pago tp on tp.id_tipo_pago = vc.id_tipo_pago where us.id_usuario = " + id_usuario + "\r\ngroup by vc.id_cabecera, cli.nombre_cliente, tp.desc_tipo_pago, vc.fecha_venta";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;


        }



        public List<string> obtener_productos()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT descripcion FROM Producto";
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

        public List<string> obtener_tipo_pagos()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT desc_tipo_pago FROM Tipo_pago";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["desc_tipo_pago"].ToString());
                        }
                    }
                }
            }
            return datos;
        }


        public List<string> obtener_clientes()
        {
            List<string> datos = new List<string>();
            var conexion = GetConnection();
            {
                conexion.Open();
                string query = "SELECT nombre_cliente FROM Cliente";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datos.Add(reader["nombre_cliente"].ToString());
                        }
                    }
                }
            }
            return datos;
        }

        //obtener el ultimo nro de la factura + 1
        public int ObtenerUltimoNumeroFactura()
        {

            var connection = GetConnection();
            connection.Open();

            string sql = "SELECT MAX(id_cabecera) FROM Venta_cabecera";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                object result = command.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return 0; // Si no hay facturas en la base de datos o el valor es nulo, se establece a 0
                }

                return (int)result + 1; // Incrementa el número de factura en 1 para obtener el siguiente número
            }


        }

        public bool restar_stock(int stock, int cantidad, int id_producto)
        {
            bool respuesta = true;
            var conexion = GetConnection();

            try
            {

                StringBuilder query = new StringBuilder();
                query.AppendLine("update Producto set stock = stock - @cantidad where id_producto =@id_producto ");
                SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cmd.CommandType = CommandType.Text;
                conexion.Open();

                respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                respuesta = false;
            }

            return respuesta;

        }

        public bool sumar_stock(int stock, int cantidad, int id_producto)
        {
            bool respuesta = true;
            var conexion = GetConnection();

            try
            {

                StringBuilder query = new StringBuilder();
                query.AppendLine("update Producto set stock = stock + @cantidad where id_producto =@id_producto ");
                SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cmd.CommandType = CommandType.Text;
                conexion.Open();

                respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception ex)
            {
                respuesta = false;
            }

            return respuesta;

        }

        public int registrar_cabecera(int id_usuario, int id_cliente, int id_tipo_pago, DateTime fecha_Venta)
        {

            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "insert into Venta_cabecera (id_usuario,id_cliente,id_tipo_pago,fecha_Venta) Values(" + id_usuario + "," + id_cliente + "," + id_tipo_pago + ",getdate())";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int registrar_detalle(int id_cabecera, int id_producto, string producto, decimal precio_unitario, int cantidad, decimal subtotal, decimal total)
        {

            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "insert into Venta_detalle(id_cabecera,cantidad_producto,id_producto,subtotal,total) Values(" + id_cabecera + "," + cantidad + "," + id_producto + ", " + subtotal + "," + total + ")";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }


     

        public DataTable ObtenerProductosDeVenta(int idVenta)
        {
            var conexion = GetConnection();
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT \r\n                            vc.id_cabecera,\r\n                            vc.fecha_venta,\r\n                            cli.nombre_cliente AS nombre_cliente,\r\n                            pro.descripcion AS nombre_producto,\r\n                            vd.cantidad_producto,\r\n                            pro.precio_unitario\r\n                        FROM \r\n                            Venta_cabecera vc\r\n                            INNER JOIN Cliente cli ON cli.id_cliente = vc.id_cliente\r\n                            INNER JOIN Venta_detalle vd ON vd.id_cabecera = vc.id_cabecera\r\n                            INNER JOIN Producto pro ON pro.id_producto = vd.id_producto\r\n                        WHERE \r\n                            vc.id_cabecera = 1005", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdVenta", idVenta);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            
        }

        public DataTable getSalesOrder(DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = @"select distinct vc.id_cabecera as 'ID-FACTURA', 
                    cli.nombre_cliente as 'Cliente', 
                    tp.desc_tipo_pago as 'Tipo Pago', 
                    vc.fecha_venta as 'Fecha de Venta', 
                    sum(pro.precio_unitario * Venta_detalle.cantidad_producto) as 'Precio Total'
                    from Venta_detalle
                    inner join Producto pro on pro.id_producto = Venta_detalle.id_producto
                    inner join Venta_cabecera vc on Venta_detalle.id_cabecera = vc.id_cabecera
                    inner join Cliente cli on vc.id_cliente = cli.id_cliente 
                    inner join Usuario us on vc.id_usuario = us.id_usuario
                    inner join Tipo_pago tp on tp.id_tipo_pago = vc.id_tipo_pago 
                    where vc.fecha_venta between @fecha_desde and @fecha_hasta
                    group by vc.id_cabecera, cli.nombre_cliente, tp.desc_tipo_pago, vc.fecha_venta;";

                    // Corrección: Cambia los nombres de los parámetros y su tipo
                    command.Parameters.Add("@fecha_desde", SqlDbType.Date).Value = fecha_desde;
                    command.Parameters.Add("@fecha_hasta", SqlDbType.Date).Value = fecha_hasta;

                    command.CommandType = CommandType.Text;

                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }


    }

}
