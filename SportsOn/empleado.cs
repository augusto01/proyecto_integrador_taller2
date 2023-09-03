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
    public partial class empleado : Form
    {
        public empleado()
        {
            InitializeComponent();
        }

        private void Bcerrar_sesion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empleado_Load(object sender, EventArgs e)
        {

        }




        private void Bnota_Click(object sender, EventArgs e)
        {

        }



        private void Bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bcaja_Click(object sender, EventArgs e)
        {
            if (!pCaja.Visible)
            {
                pCaja.Visible = true;
            }
            else
            {
                pCaja.Visible = false;
            }
        }

        private void Bventa_Click(object sender, EventArgs e)
        {
            if (!pVentas.Visible)
            {
                pVentas.Visible = true;
            }
            else
            {
                pVentas.Visible = false;
            }
        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
