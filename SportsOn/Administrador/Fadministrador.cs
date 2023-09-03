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
            if (!pCompras.Visible)
            {
                pCompras.Visible = true;
            }
            else
            {
                pCompras.Visible = false;
            }
        }

        private void Busuario_Click(object sender, EventArgs e)
        {
            if (!pUsuarios.Visible)
            {
                pUsuarios.Visible = true;
            }
            else
            {
                pUsuarios.Visible = false;
            }


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

        private void Lcargo_Click(object sender, EventArgs e)
        {

        }

        private void Luser_Click(object sender, EventArgs e)
        {

        }

        private void BagregarUsuario_Click(object sender, EventArgs e)
        {
            Form formulario = new FAgregarUsuario();
            formulario.Show();
        }

        private void Pstock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bstock_Click(object sender, EventArgs e)
        {
            if (!Pstock.Visible)
            {
                Pstock.Visible = true;
            }
            else
            {
                Pstock.Visible = false;
            }
        }

        private void Fadministrador_Load_1(object sender, EventArgs e)
        {
            pCompras.Visible = false;
            Pstock.Visible = false;
            pUsuarios.Visible = false;
        }

        private void Busuario_Leave(object sender, EventArgs e)
        {
            pUsuarios.Visible = false;
        }

        private void Bstock_Layout(object sender, LayoutEventArgs e)
        {
            Pstock.Visible = false;
        }   

        private void Bv_ventas_Leave(object sender, EventArgs e)
        {
            pCompras.Visible=false;
        }
    }
}
