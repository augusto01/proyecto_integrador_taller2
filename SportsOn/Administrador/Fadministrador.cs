using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
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
            Form formulario = new FAgregarUsuario();
            formulario.Show();
        }



        private void Bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bcerrar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
