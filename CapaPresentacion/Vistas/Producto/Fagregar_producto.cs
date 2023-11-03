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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Gerente.Producto
{
    public partial class Fagregar_producto : Form
    {

        CN_PRODUCTO producto = new CN_PRODUCTO();
        CN_CATEGORIA categoria = new CN_CATEGORIA();
        CN_TALLE talle = new CN_TALLE();
        CN_PROVEEDOR proveedor = new CN_PROVEEDOR();
        
        public Fagregar_producto()
        {
            InitializeComponent();
        }

        public void cargar_combo_box()
        {
            //categoria
            categoria.obtener_categorias();
            List<string> datos = categoria.obtener_categorias();
            cbcategoria.DataSource = datos;

            //talle
            talle.obtener_talles();
            List<string> datos_talle = talle.obtener_talles();
            cbtalle.DataSource = datos_talle;

            //proveedor
            proveedor.obtener_proveedores();
            List<string> datos_proveedor = proveedor.obtener_proveedores();
            cbproveedor.DataSource = datos_proveedor;

        }
        
        private void Fagregar_producto_Load(object sender, EventArgs e)
        {
            cargar_combo_box();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(tdesctalle.Text.Trim() == string.Empty)
            {
                edesctalle.SetError(tdesctalle, "Campo Obligatorio!!");
            }
            else
            {

               talle.insertar_talle(tdesctalle.Text);
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
                categoria.insertar_categoria(tcategoria.Text);
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




