﻿using System;
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
    public class CD_Venta:Conexion
    {



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

        public void realizar_venta()
        {
            int codigo_venta;
            var conexion = GetConnection();
            conexion.Open();
            SqlCommand codigomaxventa = new SqlCommand("Select MAX (Id_cabecera) From Venta_cabecera");                      
            object resultado = codigomaxventa.ExecuteScalar();
            ObtenerUltimoNumeroFactura();
      
        }



    }
}
