using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Compra
{
    public partial class Fagregar_compra : Form
    {
        public Fagregar_compra()
        {
            InitializeComponent();
            inicializar_cabecera();
        }
        public void inicializar_cabecera()
        {

           tfecha.Text = DateTime.Today.Date.ToString("d");

        }





    }
}
