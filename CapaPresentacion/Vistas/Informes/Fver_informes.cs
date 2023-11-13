using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaNegocio;

namespace CapaPresentacion.Vistas.Informes
{
    public partial class Fver_informes : Form
    {
        public Fver_informes()
        {
            InitializeComponent();
        }

        private void Fver_informes_Load(object sender, EventArgs e)
        {
            cargar_chart(chartproductosporcategoria);
            CargarDatosEnChartMasElegidos(chartmaselegidos);
            mostrar_labels();

        }

        private CN_INFORME negocioDashboard = new CN_INFORME();


        public void cargar_grafico()
        {
            // CN_INFORME informe = new CN_INFORME();

            // chartproductosporcategoria.Series[0].Points.DataBindXY(informe.producto_por_categoira,informe.producto_por_categoira)



        }

        public void cargar_chart(Chart chartproductosporcategoria)
        {
            CN_INFORME negocio = new CN_INFORME();
            // Llama al método de la capa de negocio para obtener los datos de productos por categoría
            Dictionary<string, int> datosParaGrafico = negocio.ObtenerProductosPorCategoria();

            // Utiliza los datos para actualizar el gráfico (chart) en la presentación
            // (La implementación específica depende de cómo quieras mostrar los datos en el gráfico)

            // Limpiar el gráfico antes de agregar nuevos datos
            chartproductosporcategoria.Series.Clear();
            chartproductosporcategoria.ChartAreas[0].AxisX.Interval = 1;

            // Crear una nueva serie para el gráfico
            Series series = new Series("Categorias");
            series.ChartType = SeriesChartType.Column;

            // Agregar datos al gráfico
            foreach (var dato in datosParaGrafico)
            {
                series.Points.AddXY(dato.Key, dato.Value);
            }

            // Agregar la serie al gráfico
            chartproductosporcategoria.Series.Add(series);



        }

        private void CargarDatosEnChartMasElegidos(Chart chart)
        {
                CN_INFORME negocio = new CN_INFORME();
            
                    // Llama al método de la capa de negocio para obtener los productos preferidos
            DataTable datosProductosPreferidos = negocio.ObtenerProductosPreferidos();

            // Utiliza los datos para actualizar el gráfico (chart) en la presentación
            // (La implementación específica depende de cómo quieras mostrar los datos en el gráfico)

            // Limpiar el gráfico antes de agregar nuevos datos
            chart.Series.Clear();

            // Crear una nueva serie para el gráfico
            Series series = new Series("Productos Preferidos");
            series.ChartType = SeriesChartType.Doughnut;

            // Agregar datos al gráfico
            foreach (DataRow row in datosProductosPreferidos.Rows)
            {
                string producto = row["Producto"].ToString();
                int vecesVendidas = Convert.ToInt32(row["Veces Vendidas"]);

                // Agregar el punto al gráfico
                DataPoint point = new DataPoint();
                point.SetValueXY(producto, vecesVendidas); // Establecer el nombre del producto como etiqueta y la cantidad como valor numérico
                point.Label = $"{producto}: {vecesVendidas} veces"; // Mostrar información adicional en el tooltip
                series.Points.Add(point);
            }

            // Agregar la serie al gráfico
            chart.Series.Add(series);
    
            
        }

        private void mostrar_labels()
        {
            
            negocioDashboard.ObtenerDatosDashboard(out decimal totVentas, out int nProd, out int nCliente, out int nProv, out int nCantidadVentas, out int nEmpleado);

            // Mostrar los valores en los labels (ajusta los nombres de los labels según tus necesidades)
            ltotal.Text = $"{totVentas.ToString("C")}";
            lnroproductos.Text = $"{nProd}";
            lnroclientes.Text = $" {nCliente}";
            lnroproveedores.Text = $" {nProv}";
            lnroventas.Text = $" {nCantidadVentas}";
            lnroempleados.Text = $"{nEmpleado}";
        }

    }
}
