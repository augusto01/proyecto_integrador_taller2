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



        private void Bbuscarproducto_Click(object sender, EventArgs e)
        {
            //VALIDA SI LOS CAMPOS ESTAN VACIOS !
            if (Tbuscar_producto.Text.Trim() == String.Empty)
            {
                MessageBox.Show("El campo esta vacio!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Bnota_Click(object sender, EventArgs e)
        {

        }
    }
}
