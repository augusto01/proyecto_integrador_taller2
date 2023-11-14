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

namespace CapaPresentacion.Empleado
{
    public partial class Fverproductos : Form
    {

        CN_PRODUCTO productos = new CN_PRODUCTO();
        public Fverproductos()
        {
            InitializeComponent();
        }



        private void mostrar_productos()
        {

            dgproductosempleados.DataSource = productos.ConsultaDT();

        }

        private void Fverproductos_Load(object sender, EventArgs e)
        {
            mostrar_productos();
        }

        private void tbuscarobjeto_TextChanged(object sender, EventArgs e)
        {
            string valorBuscado = "" + tbuscarobjeto.Text;

            // Si estás usando un BindingSource
            int rowIndex = -1;

            foreach (DataGridViewRow fila in dgproductosempleados.Rows)
            {
                if (fila.Cells["Producto"].Value != null && fila.Cells["Producto"].Value.ToString() == valorBuscado)
                {
                    rowIndex = fila.Index;


                    break;
                }
            }

            if (rowIndex != -1)
            {
                DataGridViewRow row = dgproductosempleados.Rows[rowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                dgproductosempleados.CurrentCell = dgproductosempleados[0, rowIndex]; // Esto seleccionará la fila encontrada
            }
        }
    }
}
