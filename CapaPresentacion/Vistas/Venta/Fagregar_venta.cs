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

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fagregar_venta : Form
    {
        CN_VENTA cliente = new CN_VENTA();

        public Fagregar_venta()
        {
            InitializeComponent();
            inicializar_cabecera();
            
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
            tfecha.Text = DateTime.Today.ToString();
            tnombrevendedor.Text = CapaEntidad.Cache.UserLoginCache.nombre;
            tidvendedor.Text = CapaEntidad.Cache.UserLoginCache.id_usuario.ToString();
            //cargar combobox clientes

            cliente.obtener_clientes();
            List<string> datos_clientes = cliente.obtener_clientes();
            cbcliente.DataSource = datos_clientes;
            cbcliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {
            //inicializar_cabecera(usuario);
        }

       
    }
}
