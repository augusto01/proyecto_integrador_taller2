using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn
{
    public partial class Fagregar_usuario : Form
    {

        //definimos array para los tipos de usuarios 

        String[] tipo_usuario = {"Empleado", "Administrador", "Gerente" };
        public Fagregar_usuario()
        {
            InitializeComponent();
        }

        private void Fagregar_usuario_Load(object sender, EventArgs e)
        {
            inicializarUsuarios();

        }
        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < tipo_usuario.Length; i++)
            {
                CBcategoria.Items.Add(tipo_usuario[i]);
            }

            CBcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Enombre.SetError(Tnombre, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                Enombre.Clear();
            }
        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Eapellido.SetError(Tapellido, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                Enombre.Clear();
            }
        }

        private void Tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Edni.SetError(Tdni, "Este Campo Solo Acepta Numeros!");
                e.Handled = true;
                return;



            }
        }

        private void Lcontra_TextChanged(object sender, EventArgs e)
        {
            if (Lcontra.Enabled == true)
            {
                if (Lcontra.Text.Length < 4)
                {
                    Econtra.SetError(Lcontra, "La contraseña debe tener minimo 4 Digitos");

                    ;
                }
                else
                {
                    Econtra.Clear();

                }
            }
        }

        private void Tcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Ecelular.SetError(Tcelular, "Solo numeros!");
                e.Handled = true;
                return;



            }
        }

        private void Temail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(Temail.Text, "@"))) && (!(Regex.IsMatch(Temail.Text, "gmail")))) || ((!(Regex.IsMatch(Temail.Text, "@"))) && (!(Regex.IsMatch(Temail.Text, "hotmail")))))
            {
                Eemail.SetError(Temail, "No tiene el formato esperado!\nEjemplo:user@gmail.com");

            }
            else
            {
                Eemail.Clear();

            }
        }
    }
}
