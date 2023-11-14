using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaEntidad.Cache;

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fmis_ventas : Form
    {
        
        CN_VENTA venta = new CN_VENTA();    
        public Fmis_ventas()
        {
            InitializeComponent();
        }


        public  void mostrar_ventas()
        {


            dgventasusuario.DataSource = venta.consultarventas(CapaEntidad.Cache.UserLoginCache.id_usuario);


        }

        private void Fmis_ventas_Load(object sender, EventArgs e)
        {
            mostrar_ventas();
        }

       
    }
}
