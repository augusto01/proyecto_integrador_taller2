﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PRODUCTO
    {
       public int id_proudcto { get; set; }
        public int id_talle { get; set; }

        public int id_categoria { get; set; }

        public string descripcion { get; set; }

        public int id_proveedor { get; set; }

        public float precio_unitario { get; set; }

        public DateTime fecha_alta { get; set; }

        public int stock { get; set; }  

       

        public void CN_Usuario( int pid_talle, int pid_categoria, string pdescripcion, int pid_proveedor, float pprecio_unitario, DateTime pfecha_alta, int pstock)
        {
        
            this.id_talle = pid_talle;
            this.id_categoria = pid_categoria;
            this.descripcion = pdescripcion;
            this.id_proveedor = pid_proveedor;
            this.precio_unitario = pprecio_unitario;
            this.fecha_alta = pfecha_alta;
            this.stock = pstock;
        }

        public void insertar_producto(string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            CD_Producto producto = new CD_Producto();
            producto.insertar_producto( descripcion,  precio_unitario,  stock,  id_talle,  id_categoria,  id_proveedor);
        }


    }
}