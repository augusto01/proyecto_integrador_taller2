using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SportsOn.Administrador
{
    public partial class Fagregar_producto : Form
    {
        public Fagregar_producto()
        {
            InitializeComponent();
            inicializarProductos();
            inicializarTalles();
        }

        //flags
        bool cantidad = false;
        bool nombre = false;
        


        //definimos array para las categorias y los talles de los productos

        String[] TipoCategoria = { "Remeras", "Shorts", "Medias", "Zapatillas", "Shorts", "Medias", "Buzos", "Accesorios", "Musculosas" };

        String[] Talle = { "S", "M", "L", "X", "XL", "XXL" };


        private void inicializarProductos()
        {
            int i ;

            for (i = 0; i < TipoCategoria.Length; i++)
            {
                CBcategoria.Items.Add(TipoCategoria[i]);
            }

            CBcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void inicializarTalles()
        {
            int i;

            for (i = 0; i < Talle.Length; i++)
            {
                CBtalle.Items.Add(Talle[i]);
            }

            CBtalle.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void Fagregar_producto_Load(object sender, EventArgs e)
        {

        }

        //VALIDACIONES CAMPO A CAMPO


        //NOMBRE 
        private void TBnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Enombre.SetError(TBnombre, "Solo letras!");
                e.Handled = true;
                return;
                nombre = false;
            }
            else
            {
                Enombre.Clear();
                nombre = true;
            }
        }


        //CANTIDAD
        private void Tcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Ecantidad.SetError(Tcantidad, "Solo numeros Positivos!");
                e.Handled = true;
                return;
                cantidad = false;

            }
            else
            {
                cantidad = true;
                Enombre.Clear();
            }
        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (TBnombre.Text.Trim() == string.Empty || CBcategoria.SelectedIndex == -1 || Tcantidad.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (TBnombre.Text.Trim() == String.Empty)
                {
                    Enombre.SetError(TBnombre, "Campo Obligatorio!!");
                }

                if (Tcantidad.Text.Trim() == String.Empty)
                {
                    Ecategoria.SetError(Tcantidad, "Campo Obligatorio!");
                }

                if (CBcategoria.SelectedIndex == -1)
                {
                    Ecategoria.SetError(CBcategoria, "Campo Obligatorio!");
                }




            }
            else
            {

                if (cantidad == false || nombre == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {   //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !
                    Ecantidad.Clear(); Enombre.Clear(); Etalle.Clear(); Eproveedor.Clear(); Ecategoria.Clear(); Etalle.Clear(); Edesc.Clear();
                    DialogResult resultado = MessageBox.Show("Producto: " + TBnombre.Text + "\n"+"Cantidad: " + Tcantidad.Text+"\n", "Agregar Producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("El producto:" + TBnombre.Text + " " + Tdescripcion.Text + "\nHa sido registrado correctamente!", "Registracion aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TBnombre.Clear();
                        Tcantidad.Clear();
                        Tdescripcion.Clear();
                        TBnombre.Clear();
                        Tproveedor.Clear();

                        //errores
                        Ecantidad.Clear();
                        Edesc.Clear();
                        Enombre.Clear();
                        Ecategoria.Clear();


                        DialogResult respuesta = MessageBox.Show("Desea agregar otro producto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.No)
                        {
                            Close();
                        }


                    }

                }



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
    }

}
