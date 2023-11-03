using CapaDatos;
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

        public CN_PRODUCTO(int idproducto, int id_talle, int id_categoria, string descripcion, int id_proveedor, float precio_unitario, DateTime fecha_alta, int stock)
        {
            this.id_proudcto = idproducto;
            this.id_talle=  id_talle;
            this.id_categoria = id_categoria;
            this.descripcion = descripcion;
            this.id_proveedor = id_proveedor;
            this.precio_unitario = precio_unitario;
            this.fecha_alta= fecha_alta;
            this.stock = stock;


        }

        public void insertar_producto(string descripcion, float precio_unitario, int stock, int id_talle, int id_categoria, int id_proveedor)
        {
            CD_Producto producto = new CD_Producto();
            producto.insertar_producto( descripcion,  precio_unitario,  stock,  id_talle,  id_categoria,  id_proveedor);
        }


    }
}
