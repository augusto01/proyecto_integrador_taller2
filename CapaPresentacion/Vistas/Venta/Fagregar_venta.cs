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

        UserLoginCache usuario = new UserLoginCache();
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
        }

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {
            //inicializar_cabecera(usuario);
        }

       
    }
}
