﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor:Conexion
    {





     

        public int insertar_proveedor(string nombre,string apellido,string razon_social, string direccion, string correo,int nro_telefono, int dni)
        {
            var conexion = GetConnection();
            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO Proveedor (nombre, apellido, razonsocial,direccion,correo,nro_telefono,dni) values ('"+nombre+"','"+apellido+"','"+razon_social+"','"+direccion+"','"+correo+"',"+nro_telefono+","+dni+")";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

    }
 

}