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

namespace SportsOn
{
    public partial class FagregarUsuario : Form
    {
        public FagregarUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FagregarUsuario_Load(object sender, EventArgs e)
        {
            inicializarUsuarios();

        }
        //INICIALIZAMOS LAS CATEGORIAS DE LOS USUARIOS 
        String[] categorias = { "Empleado", "Administrador", "Gerente" };
        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < categorias.Length; i++)
            {
                CBcategoria.Items.Add(categorias[i]);
            }

            CBcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //VALIDACION NOMBRE
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
            Enombre.Clear();
        }
        // VALIDACION APELLIDO
        private void TBapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                Eapellido.SetError(TBapellido, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                Eapellido.Clear();
            }
            Eapellido.Clear();
        }
        //VALIDACION DNI 
        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Edni.SetError(TBdni, "Solo acepta numeros!");
                e.Handled = true;
                Edni.Clear();
                return;

            }
            else
            {
                Edni.Clear();
            }
        }

        //VALIDACION CELULAR
        private void TBcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Ecelular.SetError(TBcelular, "Solo acepta numeros!");
                e.Handled = true;
                return;

            }
            else
            {
                Ecelular.Clear();
            }
        }

        //VALIDACION MAIL 
        private void TBemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(TBemail.Text, "@"))) && (!(Regex.IsMatch(TBemail.Text, "gmail")))) || ((!(Regex.IsMatch(TBemail.Text, "@"))) && (!(Regex.IsMatch(TBemail.Text, "hotmail")))))
            {
                Eemail.SetError(TBemail, "No tiene el formato esperado!\nEjemplo:user@gmail.com");

            }
            else
            {
                Eemail.Clear();

            }
        }

        private void TBcontra_TextChanged(object sender, EventArgs e)
        {
            {
                if (TBcontra.Enabled == true)
                {
                    if (TBcontra.Text.Length < 4)
                    {
                        Econtra.SetError(TBcontra, "La contraseña debe tener minimo 4 Digitos");
                        return;


                    }
                    else
                    {
                        Econtra.Clear();

                    }
                }
            }
        }

        //VALIDACION CONFIRMAR CONTRASEÑA
        /*private void TBconfcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TBconfcontra.Text == TBcontra.Text)
            {
                Econfcontra.Clear();
                e.Handled = true;
                
            }
            else
            {
                Econfcontra.SetError(TBconfcontra, "Las contraseñas no coinciden!");
                return;
            }
        }*/

        private void Bregistrar_Click(object sender, EventArgs e)
        {
            if (TBdni.Text.Trim() == String.Empty || TBnombre.Text.Trim() == string.Empty || TBapellido.Text.Trim() == string.Empty || TBcontra.Text.Trim() == String.Empty
                       || TBemail.Text.Trim() == String.Empty || CBcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (TBdni.Text.Trim() == String.Empty)
                {
                    Edni.SetError(TBdni, "Falta Completar este Campo!");
                }
                if (TBcontra.Text.Trim() == String.Empty)
                {
                    Edni.SetError(TBcontra, "Falta Completar este Campo!");
                }
                if (TBnombre.Text.Trim() == String.Empty)
                {
                    Enombre.SetError(TBnombre, "Falta Completar este Campo!");
                }
                if (TBapellido.Text.Trim() == String.Empty)
                {
                    Enombre.SetError(TBapellido, "Falta Completar este Campo!");
                }

                if (TBemail.Text.Trim() == String.Empty)
                {
                    Eemail.SetError(TBemail, "Falta Completar este Campo!");
                }
                if (CBcategoria.SelectedIndex == -1)
                {
                    Ecategoria.SetError(CBcategoria, "Falta Completar este Campo!");
                }
                else
                {
                    Ecategoria.Clear();
                }
            }
            else
            {
                Enombre.Clear();
                Eapellido.Clear();
                Edni.Clear();
                Eemail.Clear();
                Ecategoria.Clear();
                Edomicilio.Clear();
                Ecelular.Clear();
                Econtra.Clear();


                DialogResult resultado = MessageBox.Show("DNI:" + TBdni.Text + "\nApellido:" + TBapellido.Text + "   Nombre:" + TBnombre.Text
                       + "\nEmail:" + TBemail.Text, "Seguro que desea agregar este usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show("El Usuario:" + TBnombre.Text + " " + TBapellido.Text + "\nha sido Registrado Correctamente"
                        , "Insercción Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TBdni.Clear();
                    TBnombre.Clear();
                    TBapellido.Clear();
                    TBemail.Clear();
                    TBdomicilio.Clear();
                    TBcontra.Clear();
                    Econtra.Clear();

                    CBcategoria.Items.Clear();
                    inicializarUsuarios();

                }
            }

        }
       

        private void Bcancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea Salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}