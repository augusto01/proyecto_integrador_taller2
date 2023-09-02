using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn
{
    public partial class Fadministrador : Form
    {
        public Fadministrador()
        {
            InitializeComponent();
        }

        private void Bv_ventas_Click(object sender, EventArgs e)
        {

        }

        private void Busuario_Click(object sender, EventArgs e)
        {
            Form formulario = new Fagregar_usuario();
            formulario.Show();
        }
    }
}
