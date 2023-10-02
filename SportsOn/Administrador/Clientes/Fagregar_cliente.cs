using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Administrador.Clientes
{
    public partial class Fagregar_cliente : Form
    {
        public Fagregar_cliente()
        {
            InitializeComponent();
        }



        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;


        int posicion;

        // VALIDACION CAMPO A CAMPO 

        //NOMBRE
        private void TBnombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Enombre.SetError(TBnombre, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                Enombre.Clear();
            }
        }



        //APELLIDO
        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Enombre.SetError(Tapellido, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                Eapellido.Clear();
            }
        }


        //DNI
        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Edni.SetError(Tdni, "Solo números!");
                e.Handled = true;
                return;
                banderaDNI = false;


            }
            else
            {
                banderaDNI = true;
            }
        }



        //CELULAR
        private void Tcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Ecelular.SetError(Tcelular, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }



        //EMAIL
        private void Temail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(Temail.Text, "@"))) && (!(Regex.IsMatch(Temail.Text, "gmail")))) || ((!(Regex.IsMatch(Temail.Text, "@"))) && (!(Regex.IsMatch(Temail.Text, "hotmail")))))
            {
                Eemail.SetError(Temail, "No tiene el formato esperado!\nEjemplo:user@gmail.com");
                banderaEmail = false;
            }
            else
            {
                Eemail.Clear();
                banderaEmail = true;

            }
        }


        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (Tdni.Text.Trim() == String.Empty || TBnombre.Text.Trim() == string.Empty || Tapellido.Text.Trim() == string.Empty
               || Temail.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (Tdni.Text.Trim() == String.Empty)
                {
                    Edni.SetError(Tdni, "Campo Obligatorio!");
                }




                if (TBnombre.Text.Trim() == String.Empty)
                {
                    Enombre.SetError(TBnombre, "Campo Obligatorio!!");
                }



                if (Tapellido.Text.Trim() == String.Empty)
                {
                    Eapellido.SetError(Tapellido, "Campo Obligatorio!");
                }

                if (Temail.Text.Trim() == String.Empty)
                {
                    Eemail.SetError(Temail, "Campo Obligatorio!");
                }


            }
            else
            {

                if (banderaDNI == false || banderaEmail == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {   //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL CLIENTE NUEVO !
                    Edni.Clear(); Enombre.Clear(); Eapellido.Clear(); Ecelular.Clear();
                    DialogResult resultado = MessageBox.Show("DNI:" + Tdni.Text + "\nNombre:" + TBnombre.Text + "   Apellido:" + Tapellido.Text
                                 + "\nEmail:" + Temail.Text, "Agregar Cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        CargaCliente();
                        MessageBox.Show("El cliente:" + TBnombre.Text + " " + Tapellido.Text + "\nHa sido registrado correctamente!", "Registracion aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Tdni.Clear();
                        Tdomicilio.Clear();
                        Tcelular.Clear();
                        TBnombre.Clear();
                        Tapellido.Clear();
                        Temail.Clear();


                        //errores
                        Edni.Clear();
                        Enombre.Clear();
                        Eapellido.Clear();
                        Eemail.Clear();
                        Ecelular.Clear();





                    }

                }

            }
        }

        //carga cliente al data grid
        public void CargaCliente()
        {

            int n = dg_cliente.Rows.Add();
            //Anadimos registros al data grid


            dg_cliente.Rows[n].Cells[1].Value = TBnombre.Text;
            dg_cliente.Rows[n].Cells[2].Value = Tapellido.Text;
            dg_cliente.Rows[n].Cells[3].Value = Tdni.Text;
            dg_cliente.Rows[n].Cells[4].Value = Tcelular.Text;
            dg_cliente.Rows[n].Cells[5].Value = Tdomicilio.Text;

            //scroll automatico del dg
            dg_cliente.FirstDisplayedScrollingRowIndex = dg_cliente.RowCount - 1;




        }

        //EDITAR CLIENTE
        private void dg_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dg_cliente.CurrentRow.Index != -1 && dg_cliente.Columns[e.ColumnIndex].Name == "editar")
            {


                Bagregar.Visible = false;
                editarCliente.Visible = true;
                Bcancelar.Visible = true;
                posicion = dg_cliente.CurrentRow.Index;
                TBnombre.Text = dg_cliente[1, posicion].Value.ToString();
                Tapellido.Text = dg_cliente[2, posicion].Value.ToString();
                Tdni.Text = dg_cliente[3, posicion].Value.ToString();
                Tcelular.Text = dg_cliente[4, posicion].Value.ToString();
                Tdomicilio.Text = dg_cliente[5, posicion].Value.ToString();

            }
        }



        private void editarUsuario_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro que desea editar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {


                dg_cliente[1, posicion].Value = TBnombre.Text;
                dg_cliente[2, posicion].Value = Tapellido.Text;
                dg_cliente[3, posicion].Value = Tdni.Text;
                dg_cliente[4, posicion].Value = Tcelular.Text;
                dg_cliente[5, posicion].Value = Tdomicilio.Text;
                LimpiarCampos();
                TBnombre.Focus();

                Bagregar.Visible = true;
                editarCliente.Visible = false;
                Bcancelar.Visible = false;
            }
            else
            {
                LimpiarCampos();
                editarCliente.Visible = false;
                Bagregar.Visible = true;


            }
        }


        //ELIMINAR CLIENTES

        private void EliminarCliente()
        {
            if (this.dg_cliente.CurrentRow.Index != -1)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.dg_cliente.Rows.RemoveAt(this.dg_cliente.CurrentRow.Index);
                }

            }
        }

        private void dg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_cliente.Columns[e.ColumnIndex].Name == "eliminar")
            {
                EliminarCliente();
            }
        }




        private void LimpiarCampos()
        {

            Tdni.Clear();
            Tdomicilio.Clear();
            Tcelular.Clear();
            TBnombre.Clear();
            Tapellido.Clear();
            Temail.Clear();

        }

        
    }
}
