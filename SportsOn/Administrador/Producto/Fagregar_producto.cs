using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        bool nombre = false;
        bool cantidad = false;
        bool precio = false;
        //definimos array para las categorias y los talles de los productos

        String[] TipoCategoria = { "Remeras", "Shorts", "Medias", "Zapatillas", "Shorts", "Medias", "Buzos", "Accesorios", "Musculosas" };

        String[] Talle = { "S", "M", "L", "X", "XL", "XXL" };


        //variable global posicion para el arrray de editar producto 
        int posicion = 0;

        private void inicializarProductos()
        {
            int i;

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

        //PRECIO
        private void Tprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Eprecio.SetError(Tprecio, "Solo numeros Positivos!");
                e.Handled = true;
                return;
                precio = false;

            }
            else
            {
                precio = true;
                Eprecio.Clear();

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
            if (Tproveedor.Text.Trim() == string.Empty || TBnombre.Text.Trim() == string.Empty || Tprecio.Text.Trim() == string.Empty || CBcategoria.SelectedIndex == -1 || Tcantidad.Text.Trim() == string.Empty)
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
                    Ecategoria.SetError(CBcategoria, "Campoo Obligatorio!");
                }

                if (Tprecio.Text.Trim() == String.Empty)
                {
                    Eprecio.SetError(Tprecio, "Campo Obligatorio!");
                }

                if (Tprecio.Text.Trim() == String.Empty)
                {
                    Eproveedor.SetError(Tproveedor, "Campo Obligatorio!");
                }




            }
            else
            {

                if (cantidad == false || nombre == false || precio == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {   //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !
                    Ecantidad.Clear(); Enombre.Clear(); Etalle.Clear(); Eproveedor.Clear(); Ecategoria.Clear(); Etalle.Clear(); Edesc.Clear();
                    DialogResult resultado = MessageBox.Show("Producto: " + TBnombre.Text + "\n" + "Cantidad: " + Tcantidad.Text + "\n", "Agregar Producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        CargaProducto();
                        MessageBox.Show("El producto:" + TBnombre.Text + " " + Tdescripcion.Text + "\nHa sido registrado correctamente!", "Registracion aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();

                        LimpiarErrores();





                    }

                }



            }

        }

        private void LimpiarCampos()
        {
            TBnombre.Clear();
            Tdescripcion.Clear();
            Tcantidad.Clear();
            Tproveedor.Clear();
            Tdescripcion.Clear();
            Tprecio.Clear();

        }

        private void LimpiarErrores()
        {
            Enombre.Clear();
            Edesc.Clear();
            Ecantidad.Clear();
            Ecategoria.Clear();
            Eproveedor.Clear();
            Etalle.Clear();
            Eprecio.Clear();


        }

        private void CargaProducto()
        {
            /*codigo para cargar el datagrid*/
            int n = dg_producto.Rows.Add();
            //Anadimos registros al data grid

            dg_producto.Rows[n].Cells[1].Value = TBnombre.Text;
            dg_producto.Rows[n].Cells[2].Value = Tdescripcion.Text;
            dg_producto.Rows[n].Cells[3].Value = Tcantidad.Text;
            dg_producto.Rows[n].Cells[4].Value = CBtalle.Text;
            dg_producto.Rows[n].Cells[5].Value = CBcategoria.Text;
            dg_producto.Rows[n].Cells[6].Value = Tprecio.Text;
            dg_producto.Rows[n].Cells[7].Value = Tproveedor.Text;

            //scroll automatico del dg
            dg_producto.FirstDisplayedScrollingRowIndex = dg_producto.RowCount - 1;
        }

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        //EDITAR PRODUCTO

        private void editarProducto_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro que desea editar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {


                dg_producto[1, posicion].Value = TBnombre.Text;
                dg_producto[2, posicion].Value = Tdescripcion.Text;
                dg_producto[3, posicion].Value = Tcantidad.Text;
                dg_producto[4, posicion].Value = CBtalle.Text;
                dg_producto[5, posicion].Value = CBcategoria.Text;
                dg_producto[6, posicion].Value = Tprecio.Text;
                dg_producto[7, posicion].Value = Tproveedor.Text;

                LimpiarCampos();
                TBnombre.Focus();

                Bagregar.Visible = true;
                editarProducto.Visible = false;
            }
            else
            {
                LimpiarCampos();
                editarProducto.Visible = false;
                Bagregar.Visible = true;


            }
        }

        private void EliminarProducto()
        {
            if (this.dg_producto.CurrentRow.Index != -1)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.dg_producto.Rows.RemoveAt(this.dg_producto.CurrentRow.Index);
                }

            }
        }

        private void dg_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dg_producto.CurrentRow.Index != -1 && dg_producto.Columns[e.ColumnIndex].Name == "dg_editar")
            {


                Bagregar.Visible = false;
                editarProducto.Visible = true;
                posicion = dg_producto.CurrentRow.Index;
                TBnombre.Text = dg_producto[1, posicion].Value.ToString();
                Tdescripcion.Text = dg_producto[2, posicion].Value.ToString();
                Tcantidad.Text = dg_producto[3, posicion].Value.ToString();
                CBtalle.Text = dg_producto[4, posicion].Value.ToString();
                CBcategoria.Text = dg_producto[5, posicion].Value.ToString();
                Tprecio.Text = dg_producto[6, posicion].Value.ToString();
                Tproveedor.Text = dg_producto[7, posicion].Value.ToString();

            }
        }

        private void dg_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_producto.Columns[e.ColumnIndex].Name == "dg_eliminar")
            {
                EliminarProducto();
            }
        }

        private void Lmoneda_Click(object sender, EventArgs e)
        {

        }

        private void Tcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
