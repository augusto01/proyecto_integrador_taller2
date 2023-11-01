﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CapaEntidad;
using System.Threading.Tasks;
using CapaEntidad.Cache;

namespace CapaDatos
{
    public class Userdao:Conexion
    {
        private object commandType;

        public bool loguin (string user, string pass)
        {

            using (var connection = GetConnection())
            {
                connection.Open ();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuario where username=@username  and pass=@pass";
                    command.Parameters.AddWithValue ("@username", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType= CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader ();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.id_usuario = reader.GetInt32(0);
                            UserLoginCache.nombre = reader.GetString(1);                                      //obtenemos los valores del usuario actual
                            UserLoginCache.apellido = reader.GetString(2);
                            UserLoginCache.username = reader.GetString(3);
                            UserLoginCache.correo = reader.GetString(5);                         
                            UserLoginCache.domicilio = reader.GetString(6);
                            UserLoginCache.cel = reader.GetInt32(7);
                            UserLoginCache.pass = reader.GetString(8);
                            UserLoginCache.fecha_creacion = reader.GetDateTime(9);
                            UserLoginCache.id_tipo_usuario = reader.GetInt32(11);


                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }


        }



    }
}