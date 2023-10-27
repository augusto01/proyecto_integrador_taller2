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

namespace CapaPresentacion.Gerente.Usuarios
{
    public partial class Fagregar_usuario : Form
    {
        public Fagregar_usuario()
        {
            InitializeComponent();
            inicializarUsuarios();
        }
        bool banderaDNI = false;
        bool banderaEmail = false;
        bool banderaContraseña = false;
        bool banderaConfContra = false;


        String[] TipoUsuario = { "Empleado", "Administrador", "Gerente" };
        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < TipoUsuario.Length; i++)
            {
                cbtipo.Items.Add(TipoUsuario[i]);
            }

            cbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                enombre.SetError(tnombre, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                enombre.Clear();
            }
        }

        private void tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                eapellido.SetError(tapellido, "Solo letras!");
                e.Handled = true;
                return;

            }
            else
            {
                enombre.Clear();
            }
        }

        private void tnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "gmail")))) || ((!(Regex.IsMatch(Tcorreo.Text, "@"))) && (!(Regex.IsMatch(Tcorreo.Text, "hotmail")))))
            {
                ecorreo.SetError(Tcorreo, "No tiene el formato esperado!\nEjemplo:user@gmail.com");
                banderaEmail = false;
            }
            else
            {
                ecorreo.Clear();
                banderaEmail = true;

            }
        }

        private void Tcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ecel.SetError(Tcel, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void tdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                edni.SetError(tdni, "Solo números!");
                e.Handled = true;
                return;
                banderaDNI = false;


            }
            else
            {
                banderaDNI = true;
            }
        }

        private void Tpass_TextChanged(object sender, EventArgs e)
        {
            if (Tpass.Text.Length < 4)
            {
                econtra.SetError(Tpass, "La contraseña debe tener minimo 4 digitos");
                banderaContraseña = false;
            }
            else
            {
                banderaContraseña = true;
                econtra.Clear();

            }
        }

        private void Tconfcontra_TextChanged(object sender, EventArgs e)
        {
            if (Tconfcontra.Text != Tpass.Text)
            {
                econfcontra.SetError(Tconfcontra, "Las contraseñas no coinciden!");
                banderaConfContra = false;
            }
            else
            {
                banderaConfContra = true;
            }
        }

        private void bver_Click(object sender, EventArgs e)
        {
            bnover.BringToFront();
            Tconfcontra.UseSystemPasswordChar = false;
        }

        private void bnover_Click(object sender, EventArgs e)
        {
            bver.BringToFront();
            Tconfcontra.UseSystemPasswordChar = true;
        }

        private void LimpiarCampos()
        {
            Tuser.Clear();
            tdni.Clear();
            tdomicilio.Clear();
            Tcel.Clear();
            tnombre.Clear();
            tapellido.Clear();
            Tcorreo.Clear();
            Tpass.Clear();
            cbtipo.Items.Clear();
            Tconfcontra.Clear();
        }

        private void LimpiarErrores()
        {
            edni.Clear();
            enombre.Clear();
            eapellido.Clear();
            ecorreo.Clear();
            ecel.Clear();
            econtra.Clear();
            etipo.Clear();
            inicializarUsuarios();
        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (tdni.Text.Trim() == String.Empty || tnombre.Text.Trim() == string.Empty || tapellido.Text.Trim() == string.Empty
                || Tcorreo.Text.Trim() == String.Empty || cbtipo.SelectedIndex == -1 || Tpass.Text.Trim() == String.Empty || Tconfcontra.Text == String.Empty || Tuser.Text == String.Empty)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (tdni.Text.Trim() == String.Empty)
                {
                    edni.SetError(tdni, "Campo Obligatorio!");
                }

                if (tnombre.Text.Trim() == String.Empty)
                {
                    enombre.SetError(tnombre, "Campo Obligatorio!!");
                }

                if (Tuser.Text.Trim() == String.Empty)
                {
                    euser.SetError(Tuser, "Campo Obligatorio!!");
                }

                if (tapellido.Text.Trim() == String.Empty)
                {
                    eapellido.SetError(tapellido, "Campo Obligatorio!");
                }

                if (Tcorreo.Text.Trim() == String.Empty)
                {
                    ecorreo.SetError(Tcorreo, "Campo Obligatorio!");
                }

                if (cbtipo.SelectedIndex == -1)
                {
                    etipo.SetError(cbtipo, "Campo Obligatorio!");
                }

                if (Tpass.Text.Trim() == String.Empty)
                {
                    econtra.SetError(Tpass, "Campo Obligatorio!");
                }

                if (Tconfcontra.Text.Trim() == String.Empty)
                {
                    econfcontra.SetError(Tconfcontra, "Campo Obligatorio!");
                }

            }
            else
            {

                if (banderaDNI == false || banderaEmail == false || banderaContraseña == false || banderaConfContra == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !
                    LimpiarErrores();
                    DialogResult resultado = MessageBox.Show("DNI:" + tdni.Text + "\nNombre:" + tnombre.Text + "   Apellido:" + tapellido.Text
                                 + "\nEmail:" + Tcorreo.Text, "Agregar Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //si la respuesta es si cargamos el usuario 
                        MessageBox.Show("Exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        LimpiarErrores();

                    }

                }




            }

        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
