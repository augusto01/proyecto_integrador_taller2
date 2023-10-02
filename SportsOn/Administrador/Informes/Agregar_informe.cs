using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Administrador.Informes
{
    public partial class Agregar_informe : Form
    {

        //String para crear los tipos de informes.
        String[] tipoinforme = { "Ventas Realizadas", "Compras Realizadas", "Productos añadidos", "Usuarios añadidos", "Clientes añadidos", "Productos eliminados", "Usuarios eliminados", "Clientes eliminados" };
        public Agregar_informe()
        {
            InitializeComponent();
            inicializarUsuarios();
        }


        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < tipoinforme.Length; i++)
            {
                cbtipoinforme.Items.Add(tipoinforme[i]);
            }

            cbtipoinforme.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void bdescargar_Click(object sender, EventArgs e)
        {
            if (cbtipoinforme.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de informe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Agregar_informe_Load(object sender, EventArgs e)
        {

        }
    }
}
