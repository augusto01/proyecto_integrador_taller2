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



            //VALIDAMOS QUE TODOS LOS DATOS ESTEN COMPLETOS 
            if (Tnombre.Text.Trim() == String.Empty || Tapellido.Text.Trim() == String.Empty || Tcontraseña.Text.Trim() == String.Empty
                || Tconfcontraseña.Text.Trim() == string.Empty || Tdomicilio.Text.Trim() == String.Empty || Tcorreo.Text.Trim() == String.Empty
                || Tdni.Text.Trim() == String.Empty || Tcategoria.Text.Trim() == String.Empty)
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

                if (Tconfcontraseña.Text.Trim() == String.Empty)
                {
                    errorContraseña.SetError(Tconfcontraseña, "Falta Completar este Campo!");
                }

                if (Tconfcontraseña.Text.Trim() == String.Empty)
                {
                    errorCategoria.SetError(Tcategoria, "Falta Completar este Campo!");
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

        //VALIDAMOS SI LOS DATOS SON CONGRUENTES 
        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorDni.SetError(Tdni, "Inserte un DNI valido!");
                e.Handled = true;
                return;

            }
            else
            {
                errorDni.Clear();
            }
        }
    }
}
