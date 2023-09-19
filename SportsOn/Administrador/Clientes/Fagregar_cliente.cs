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

        private void Fagregar_cliente_Load(object sender, EventArgs e)
        {

        }

        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;


        // VALIDACION CAMPO A CAMPO 

        //NOMBRE

        private void TBnombre_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Tapellido_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Tdni_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void Tcelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    Ecelular.SetError(Tcelular, "Solo numeros!");
                    e.Handled = true;
                    return;

                }
        }
        


        //EMAIL
        private void Temail_KeyPress_1(object sender, KeyPressEventArgs e)
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


                        DialogResult respuesta = MessageBox.Show("Desea agregar otro cliente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.No)
                        {
                            Close();
                        }


                    }

                }

            }

        }

       
    }
}
