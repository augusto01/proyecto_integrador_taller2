using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Gerente.Informe
{
    public partial class Fagregar_informe_ger : Form
    {
        public Fagregar_informe_ger()
        {
            InitializeComponent();
            inicializarUsuarios();
        }
        String[] tipoinforme = { "Ventas Realizadas", "Compras Realizadas", "Productos añadidos", "Usuarios añadidos", "Clientes añadidos", "Productos eliminados", "Usuarios eliminados", "Clientes eliminados" };


        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < tipoinforme.Length; i++)
            {
                cbtipoinforme.Items.Add(tipoinforme[i]);
            }

            cbtipoinforme.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Fagregar_informe_ger_Load(object sender, EventArgs e)
        {

        }

        private void bdescargar_Click(object sender, EventArgs e)
        {
            if (cbtipoinforme.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de informe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
