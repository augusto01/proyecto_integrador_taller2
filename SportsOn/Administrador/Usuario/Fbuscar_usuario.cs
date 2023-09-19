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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SportsOn.Administrador
{
    public partial class Fbuscar_usuario : Form
    {
        public Fbuscar_usuario()
        {
            InitializeComponent();
        }
        //flags
        bool flagDni = true;
        bool flagCorreo = true;
        bool flagUser = true;



        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Edni.SetError(Tdni, "Solo números!");
                e.Handled = true;
                return;
                flagDni = false;


            }
            else
            {
                flagDni = true;
            }
        }
        private void Tcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "gmail")))) || ((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "hotmail")))))
            {
                Ecorreo.SetError(Tcorreo, "No tiene el formato esperado!\nEjemplo:user@gmail.com");
                flagCorreo = false;
            }
            else
            {
                Ecorreo.Clear();
                flagCorreo = true;

            }
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            if (Tcorreo.Text == String.Empty && Tuser.Text == String.Empty && Tdni.Text == String.Empty)
            {
                MessageBox.Show("Ingrese al menos un campo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Tdni.Text.Trim() == String.Empty)
                {
                    Edni.SetError(Tdni, "Ingrese DNI!");
                }


                if (Tuser.Text.Trim() == String.Empty)
                {
                    Euser.SetError(Tuser, "Ingrese nombre de usuario!");
                }

                if (Tcorreo.Text.Trim() == String.Empty)
                {
                    Ecorreo.SetError(Tcorreo, "Ingrese correo!");
                }
            }
            else
            {
                if (flagCorreo == false || flagDni == false || flagUser == false)
                {
                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ok!", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Fbuscar_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
