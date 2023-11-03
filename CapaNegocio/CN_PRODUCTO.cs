using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
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

       

        public void CN_Producto( int pid_talle, int pid_categoria, string pdescripcion, int pid_proveedor, float pprecio_unitario, DateTime pfecha_alta, int pstock)
        {
        
            this.id_talle = pid_talle;
            this.id_categoria = pid_categoria;
            this.descripcion = pdescripcion;
            this.id_proveedor = pid_proveedor;
            this.precio_unitario = pprecio_unitario;
            this.fecha_alta = pfecha_alta;
            this.stock = pstock;
        }
        public DataTable ConsultaDT()
        {
            CD_Producto mostrar_productos = new CD_Producto();
            return mostrar_productos.ConsultaProductosDG();
        }


        public void insertar_producto(string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            CD_Producto producto = new CD_Producto();
            producto.insertar_producto( descripcion,  precio_unitario,  stock,  id_talle,  id_categoria,  id_proveedor);
        }

        public void modificar_producto(int id_producto, string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            CD_Producto producto = new CD_Producto();
            producto.modificar_producto(id_producto, descripcion, precio_unitario, stock, id_talle, id_categoria, id_proveedor);
        }


    }

    public class CN_TALLE
    {
        public int id_talle { get; set; }

        public string descripcion_talle { get; set; }

        public void CN_Talle(string descripcion_talle)
        {
            this.descripcion_talle = descripcion_talle;
        }

        public void insertar_talle(string descripcion_talle)
        {
            CD_Producto talle = new CD_Producto();
            talle.cargar_talle(descripcion_talle);
        }
        public List<string> obtener_talles()
        {
            CD_Producto datos = new CD_Producto();
            return datos.obtener_talles();
        }

    }

    public class CN_CATEGORIA
    {

        public int id_categoria { get; set; }

        public string descripcion_categoria { get; set; }

        public void CN_Categoria(string descripcion_categoria)
        {
            this.descripcion_categoria = descripcion_categoria;
        }

        public void insertar_categoria(string descripcion_categoria)
        {
            CD_Producto talle = new CD_Producto();
            talle.cargar_categoria(descripcion_categoria);
        }

        public List<string> obtener_categorias()
        {
            CD_Producto datos = new CD_Producto();
            return datos.obtener_categorias();
        }

       

    }





}
