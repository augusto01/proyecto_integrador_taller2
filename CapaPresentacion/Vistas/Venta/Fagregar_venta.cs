using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fagregar_venta : Form
    {
        public Fagregar_venta()
        {
            InitializeComponent();
        }

        private void inicializar_cabecera()
        {
            CN_Usuario usuario = new CN_Usuario();
            tidvendedor.Text = usuario.id_usuario.ToString();
            tfecha.Text = DateTime.Today.ToString();
            tnombrevendedor.Text = usuario.nombre.ToString();
            
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

        

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {
            inicializar_cabecera();
        }
    }
}
