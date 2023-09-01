using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn
{
    public partial class FagregarUsuario : Form
    {
        public FagregarUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbicono_Click(object sender, EventArgs e)
        {

        }
        //VALIDACION APELLIDO
        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                errorApellido.SetError(Tapellido, "Este Campo Solo Acepta Letras!");
                e.Handled = true;
                return;

            }
            else
            {
                errorApellido.Clear();
            }

        }
        //VALIDACION NOMBRE
        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                errorNombre.SetError(Tnombre, "Este Campo Solo Acepta Letras!");
                e.Handled = true;
                return;

            }
            else
            {
                errorNombre.Clear();
            }
        }

        //VALIDACION DNI
        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorDni.SetError(Tdni, "Solo acepta numeros!");
                e.Handled = true;
                return;

            }
            else
            {
                errorDni.Clear();
            }
        }

        //VALIDACION DE FECHA DE NACIMIENTO
        private void DTfechanac_ValueChanged(object sender, EventArgs e)
        {
            int edad = 0; //definimos esta variable para calcular la edad del usuario registrado !
            DateTime fechaActual = DateTime.Today;
            edad = fechaActual.Year - DTfechanac.Value.Year;
            if (fechaActual < DTfechanac.Value.AddYears(edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                error_fechanac.SetError(DTfechanac, "La edad Minima para registrar a un Usuario es 18 años!");

            }
            else
            {
                error_fechanac.Clear();

            }
        }


        //VALIDACION NRO TELEFONO
        private void Tnro_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorTel.SetError(Tdni, "Solo acepta numeros!");
                e.Handled = true;
                return;

            }
            else
            {
                errorTel.Clear();
            }
        }

        //VALIDACION EMAIL 
        private void Tcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "gmail")))) || ((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "hotmail")))))
            {
                errorCorreo.SetError(Tcorreo, "No tiene el formato esperado!\nEjemplo:user@gmail.com");

            }
            else
            {
                errorCorreo.Clear();

            }
        }

        //VALIDACION CONFIRMACION DE CONTRASEÑA
        private void Tconfcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tconfcontra.Text != Tcontraseña.Text)
            {
                errorConfcontra.SetError(Tconfcontra, "Las contraseñas no coinciden!");
            }
            else { errorConfcontra.Clear(); }

        }

        //VALIDAMOS QUE TODOS LOS DATOS ESTEN COMPLETOS 
        private void Bagregar_Click(object sender, EventArgs e)
        {
            errorNombre.Clear();
            errorApellido.Clear();
            errorContraseña.Clear();
            errorConfcontra.Clear();
            errorDomicilio.Clear();
            errorCorreo.Clear();
            errorCategoria.Clear();
            errorDni.Clear();




            if (Tnombre.Text.Trim() == String.Empty || Tapellido.Text.Trim() == String.Empty || Tcontraseña.Text.Trim() == String.Empty
                || Tconfcontra.Text.Trim() == string.Empty || Tdomicilio.Text.Trim() == String.Empty || Tcorreo.Text.Trim() == String.Empty
                || Tdni.Text.Trim() == String.Empty || Tconfcontra.Text.Trim() == String.Empty)
            {

                MessageBox.Show("Faltan Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Tnombre.Text.Trim() == String.Empty)
                {
                    errorNombre.SetError(Tnombre, "Falta Completar este campo!");
                }

                if (Tapellido.Text.Trim() == String.Empty)
                {
                    errorApellido.SetError(Tapellido, "Falta Completar este campo!");
                }

                if (Tdni.Text.Trim() == String.Empty)
                {
                    errorDni.SetError(Tdni, "Falta Completar este campo!");
                }

                if (Tdomicilio.Text.Trim() == String.Empty)
                {
                    errorDomicilio.SetError(Tdomicilio, "Falta Completar este campo!");
                }

                if (Tcorreo.Text.Trim() == String.Empty)
                {
                    errorCorreo.SetError(Tcorreo, "Falta Completar este campo!");
                }

                if (Tcontraseña.Text.Trim() == String.Empty)
                {
                    errorContraseña.SetError(Tcontraseña, "Falta Completar este Campo!");
                }

                if (Tconfcontra.Text.Trim() == String.Empty)
                {
                    errorContraseña.SetError(Tconfcontra, "Falta Completar este Campo!");
                }

                if (Tconfcontra.Text.Trim() == String.Empty)
                {
                    errorCategoria.SetError(Tconfcontra, "Falta Completar este Campo!");
                }


            }
            else
            {




                //SI LO ESTAN MOSTRAMOS EL USARIO A AGREGAR Y SE PIDE LA CONFIRMACION
                DialogResult respuesta = MessageBox.Show("Nombre:" + Tnombre.Text + "      Apellido:" + Tapellido.Text + "\nDNI:" + Tdni.Text, "Confirmar Insercción", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (respuesta == DialogResult.Yes)
                {

                    MessageBox.Show("El usuario ha sido agregado correctamente!", "Confirmar Insercción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }



        private void Bcancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Estas seguro que desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }


    }
}
