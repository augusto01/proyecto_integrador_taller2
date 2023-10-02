using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SportsOn.Administrador.Compras
{
    public partial class Fagregar_compra : Form
    {
        //array de proveedores
        String[] proveedores = { "Proveedor1", "Proveedor2", "Proveedor3" };
        public Fagregar_compra()
        {
            InitializeComponent();
            inicializarProveedores();

        }

        //inicializamos array

        private void inicializarProveedores()
        {
            int i;

            for (i = 0; i < proveedores.Length; i++)
            {
                CBproveedor.Items.Add(proveedores[i]);
            }

            CBproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //flags
        bool cantidad = false;
        bool banderamonto = false;


        //validaciones campo a campo


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
                Ecantidad.Clear();
            }
        }
        //MONTO

        private void Tmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Emontototal.SetError(Tmonto, "Solo números!");
                e.Handled = true;
                return;
                banderamonto = false;


            }
            else
            {
                banderamonto = true;
            }
        }




        private void Bagregar_compra_Click(object sender, EventArgs e)
        {
            if (Tproducto.Text.Trim() == String.Empty || Tdesc.Text.Trim() == string.Empty || Tmonto.Text.Trim() == string.Empty
               || CBproveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (Tproducto.Text.Trim() == String.Empty)
                {
                    Eproducto.SetError(Tproducto, "Campo Obligatorio!");
                }




                if (Tdesc.Text.Trim() == String.Empty)
                {
                    Edesc.SetError(Tdesc, "Campo Obligatorio!!");
                }

                if (Tcantidad.Text.Trim() == String.Empty)
                {
                    Ecantidad.SetError(Tcantidad, "Campo Obligatorio!!");
                }

                if (CBproveedor.Text.Trim() == String.Empty)
                {
                    Eproveedor.SetError(CBproveedor, "Campo Obligatorio!");
                }




            }
            else
            {

                if (banderamonto == false || cantidad == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {   //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !
                    Ecantidad.Clear(); Eproducto.Clear(); Eproveedor.Clear(); Edesc.Clear(); Etalle.Clear();
                    DialogResult resultado = MessageBox.Show("Producto:" + Tproducto.Text + "\nDescripcion:" + Tdesc.Text + "   Cantidad:" + Tcantidad.Text
                                 , "Agregar Producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //si la respuesta es si cargamos el usuario 
                        CargaCompra();

                        MessageBox.Show("La compra con el producto:" + Tproducto.Text + " " + Tdesc.Text + "\nHa sido registrada correctamente!", "Registracion aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCampos();
                        LimpiarErrores();




                    }

                }



            }
        }




        private void LimpiarCampos()
        {
            Tproducto.Clear();
            CBproveedor.Text = string.Empty;
            Tdesc.Clear();
            Tcantidad.Clear();
            Tmonto.Clear();
            cbtalle.Text = string.Empty;

        }

        private void LimpiarErrores()
        {
            Eproducto.Clear();
            Etalle.Clear();
            Emontototal.Clear();
            Edesc.Clear();
            Eproveedor.Clear();

        }

        private void Fagregar_compra_Load(object sender, EventArgs e)
        {

        }

        public void CargaCompra()
        {

            int n = dg_compras.Rows.Add();
            //Anadimos registros al data grid


            dg_compras.Rows[n].Cells[1].Value = Tproducto.Text;
            dg_compras.Rows[n].Cells[2].Value = Tdesc.Text;
            dg_compras.Rows[n].Cells[3].Value = cbtalle.Text;
            dg_compras.Rows[n].Cells[4].Value = CBproveedor.Text;
            dg_compras.Rows[n].Cells[5].Value = Tmonto.Text;

            //scroll automatico del dg
            dg_compras.FirstDisplayedScrollingRowIndex = dg_compras.RowCount - 1;
        }

        private void Fagregar_compra_Load_1(object sender, EventArgs e)
        {

        }
    }
}
