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
        public Dictionary<string, int> ObtenerProductosPorCategoria()
        {
            // Llama al método de la capa de datos para obtener los productos por categoría
            DataTable productosPorCategoria = datos.ObtenerProductosPorCategoria();

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

        // Instancia de la capa de datos
        private CD_Informes datosdona = new CD_Informes();

        // Método para obtener datos de productos preferidos desde la capa de negocio
        public DataTable ObtenerProductosPreferidos()
        {
            // Llama al método de la capa de datos para obtener los productos preferidos
            return datosdona.ObtenerProductosPreferidos();
        }
    }
}
