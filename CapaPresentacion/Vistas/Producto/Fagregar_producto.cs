using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Gerente.Producto
{
    public partial class Fagregar_producto : Form
    {

        CN_PRODUCTO productonuevo = new CN_PRODUCTO();
        CN_CATEGORIA categorianueva = new CN_CATEGORIA();
        CN_TALLE nuevotalle = new CN_TALLE();
        
        public Fagregar_producto()
        {
            InitializeComponent();
        }

        
        private void Fagregar_producto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(tdesctalle.Text.Trim() == string.Empty)
            {
                edesctalle.SetError(tdesctalle, "Campo Obligatorio!!");
            }
            else
            {

               nuevotalle.insertar_talle(tdesctalle.Text);
               MessageBox.Show("El talle : " +tdesctalle.Text+" se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tcategoria.Text.Trim() == string.Empty)
            {
                ecategoria.SetError(tcategoria, "Campo Obligatorio!!");
            }
            else
            {
                categorianueva.insertar_categoria(tcategoria.Text);
                MessageBox.Show("La categoria : " + tcategoria.Text + " se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere agregar el producto?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //productonuevo.insertar_producto( cbtalle., int pid_categoria, string pdescripcion, int pid_proveedor, float pprecio_unitario, DateTime pfecha_alta, int pstock)



            }
        }
    }
}




