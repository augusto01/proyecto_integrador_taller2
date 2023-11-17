using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_INFORME
    {





        // Instancia de la capa de datos
        private CD_Informes datos = new CD_Informes();

        // Método para obtener los datos de productos por categoría y prepararlos para la presentación
        public void GenerarGraficoVentas(DateTime dtdesde, DateTime dthasta)
        {
            // Llamada al método en la capa de datos
            CD_Venta informe = new CD_Venta();
            informe.getSalesOrder(dtdesde, dthasta);

            
        }
        public Dictionary<string, int> ObtenerProductosPorCategoria(DateTime fecha_desde, DateTime fecha_hasta)
        {
            // Llama al método de la capa de datos para obtener los productos por categoría
            DataTable productosPorCategoria = datos.ObtenerProductosPorCategoria(fecha_desde, fecha_hasta);

            // Convierte los datos obtenidos en un diccionario para facilitar su uso en la presentación
            Dictionary<string, int> datosParaGrafico = new Dictionary<string, int>();

            foreach (DataRow row in productosPorCategoria.Rows)
            {
                string categoria = row["Descripcion"].ToString();
                int cantidad = Convert.ToInt32(row["Cant"]);

                datosParaGrafico.Add(categoria, cantidad);
            }

            return datosParaGrafico;
        }

        public Dictionary<string, int> ObtenerVentasPorUsuario(DateTime fecha_desde, DateTime fecha_hasta)
        {
            // Llama al método de la capa de datos para obtener las ventas por usuario con los parámetros de fecha
            DataTable ventasporusuario = datos.ObtenerVentasPorUsuario(fecha_desde, fecha_hasta);

            // Convierte los datos obtenidos en un diccionario para facilitar su uso en la presentación
            Dictionary<string, int> datosParaGrafico = new Dictionary<string, int>();

            foreach (DataRow row in ventasporusuario.Rows)
            {
                string usuario = row["Usuario"].ToString();
                int cantidad = Convert.ToInt32(row["Cantidad de Ventas"]);

                datosParaGrafico.Add(usuario, cantidad);
            }

            return datosParaGrafico;
        }


        // Instancia de la capa de datos
        private CD_Informes datosdona = new CD_Informes();

        // Método para obtener datos de productos preferidos desde la capa de negocio
        public DataTable ObtenerProductosPreferidos(DateTime fecha_desde, DateTime fecha_hasta)
        {
            // Llama al método de la capa de datos para obtener los productos preferidos
            return datosdona.ObtenerProductosPreferidos(fecha_desde, fecha_hasta);
        }


        private CD_Informes datosDashboard = new CD_Informes();

        // Método para obtener datos del dashboard y pasarlos a la capa de presentación
        public void ObtenerDatosDashboard(out decimal totVentas, out int nProd, out int nCliente, out int nProv, out int nCantidadVentas, out int nEmpleado, DateTime fecha_desde,DateTime fecha_hasta)
        {
            datosDashboard.ObtenerDatosDashboard(out totVentas, out nProd, out nCliente, out nProv, out nCantidadVentas, out nEmpleado, fecha_desde, fecha_hasta);
        }

    }
}
