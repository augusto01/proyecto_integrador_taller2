using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Cache;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fagregar_venta : Form
    {
        CN_VENTA cliente = new CN_VENTA();
        CN_PRODUCTO productoventa = new CN_PRODUCTO();


        public Fagregar_venta()
        {
            InitializeComponent();
            inicializar_cabecera();
            cbproductos.DisplayMember = "descripcion"; 
            
        }

       

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tidvendedor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tnombrevendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void inicializar_cabecera()
        {

            //tnombre.Text = usuario.nombre;
            tfecha.Text = DateTime.Today.Date.ToString("d");
            lvendedor.Text = CapaEntidad.Cache.UserLoginCache.nombre.Trim()+" "+ CapaEntidad.Cache.UserLoginCache.apellido.Trim();
            tidvendedor.Text = CapaEntidad.Cache.UserLoginCache.id_usuario.ToString();
            //cargar combobox clientes

            cliente.obtener_clientes();
            List<string> datos_clientes = cliente.obtener_clientes();
            cbcliente.DataSource = datos_clientes;
            cbcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente.obtener_clientes();

            //cargar combobox tipospagos

            cliente.obtener_clientes();
            List<string> tipospagos = cliente.obtener_tipo_pago();
            cbtipopago.DataSource = tipospagos;
            cbtipopago.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente.obtener_tipo_pago();

            //cargar combobox productos

            productoventa.obtener_productos();
            List<string> productos = productoventa.obtener_productos();
            cbproductos.DataSource = productos;
            cbproductos.DropDownStyle = ComboBoxStyle.DropDownList;
            productoventa.obtener_productos();

            nucantidad.Value = 1;
            tidfactura.Text =  cliente.ObtenerSiguienteNumeroFactura().ToString();
            double precio;
            lprecio.Text = (0).ToString("C");
           


        }

    

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void agregar_elemento()
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            
            //
               
            
        }

        private void cbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbproductos.SelectedItem != null && cbproductos.SelectedItem is CN_PRODUCTO)
            {
                CN_PRODUCTO productoSeleccionado = (CN_PRODUCTO)cbproductos.SelectedItem;

                int id = productoSeleccionado.id_proudcto; // Suponiendo que la clase Producto tiene una propiedad Id.
                string nombre = productoSeleccionado.descripcion;
                double precio = productoSeleccionado.precio_unitario;
                int stock = productoSeleccionado.stock;

                // Hacer lo que necesites con los datos del producto seleccionado.
                tcodproducto.Text = ($"ID: {id}");
                //Console.WriteLine($"Nombre: {nombre}");
                tprecioproducto.Text=($"Precio: {precio:C}");
                tstock.Text = ($"Stock: {stock}");
            }
        }
    }
}
