using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Empleado.Ventas
{
    public partial class Fagregar_venta : Form
    {
        public Fagregar_venta()
        {
            InitializeComponent();
        }

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {

        }

        private void B_generar_compra_Click(object sender, EventArgs e)
        {
            //2da parte 

            if (lpreciototal.Text == "0.00")
            {
                MessageBox.Show("Debe agregar al menos un producto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bagregar_producto_Click(object sender, EventArgs e)
        {
            if (CBproducto.SelectedIndex == -1 || CBtipo_pago.SelectedIndex == -1 || UDcantidad.Value == 0)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (UDcantidad.Value == 0)
                {
                    Ecantidad.SetError(UDcantidad, "Campo Obligatorio!");
                }

                if (CBtipo_pago.SelectedIndex == -1)
                {
                    Etipopago.SetError(CBtipo_pago, "Campo Obligatorio!");
                }



                if (CBtipo_pago.SelectedIndex == -1)
                {
                    Eproducto.SetError(CBproducto, "Campo Obligatorio!!");
                }
            }
            else
            {
                //COMPROBAR QUE LA CANTIDAD SEA MENOR O IGUAL AL STOCK DISPONIBLE, HACER LA INSERCION AL DATAGRID

            }
        }
    }
}
