using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    
    public class CN_VENTA
    {

        public int id_venta { get; set; }

        public int id_cabecera { get; set; }

        public int id_cantidad_prodycto { get; set; }

        public string nombre_producto { get; set; }

        public int id_producto { get; set; }

        public List<string> obtener_clientes()
        {
            CD_Venta datos = new CD_Venta();
            return datos.obtener_clientes();
        }
        public List<string> obtener_productos()
        {
            CD_Venta productos = new CD_Venta();
            return productos.obtener_productos();
        }
        public List<string> obtener_tipo_pago()
        {
            CD_Venta tipopagos = new CD_Venta();
            return tipopagos.obtener_tipo_pagos();
        }

        public int ObtenerSiguienteNumeroFactura()
        {
            CD_Venta datos = new CD_Venta();
            return datos.ObtenerUltimoNumeroFactura();
        }


        public void registrar_cabecera(int id_usuario, int id_cliente, int id_tipo_pago, DateTime fecha_Venta)
        {
            CD_Venta nueva_venta = new CD_Venta();
            nueva_venta.registrar_cabecera(id_usuario,id_cliente,id_tipo_pago, fecha_Venta);

        }

        public void sumar_stock(int stock, int cantidad, int id_producto)
        {
            CD_Venta nueva_venta = new CD_Venta();
            nueva_venta.sumar_stock(stock, cantidad, id_producto);

        }

        public void restar_stock(int stock, int cantidad, int id_producto)
        {
            CD_Venta nueva_venta = new CD_Venta();
            nueva_venta.restar_stock(stock, cantidad, id_producto);

        }
        public void resgistrar_detalle(int id_cabecera, int id_producto, string producto, decimal precio_unitario, int cantidad, decimal subtotal)
        {
            CD_Venta nueva_venta = new CD_Venta();
            nueva_venta.registrar_detalle(id_cabecera, id_producto, producto, precio_unitario, cantidad,subtotal);

        }



    }
    

    

}
