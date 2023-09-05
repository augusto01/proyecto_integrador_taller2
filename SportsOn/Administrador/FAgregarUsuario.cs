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
    public partial class FAgregarUsuario : Form
    {

        //String creado para Seleccionar el tipo de usuario que se esta registrando.
        String[] TipoUsuario = { "Empleado", "Administrador", "Gerente" };
        public FAgregarUsuario()
        {
            InitializeComponent();
        }

        private void FAgregarUsuario_Load(object sender, EventArgs e)
        {
            inicializarUsuarios();
        }

        private void inicializarUsuarios()
        {
            int i;

            for (i = 0; i < TipoUsuario.Length; i++)
            {
                CBcategoria.Items.Add(TipoUsuario[i]);
            }

            CBcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;
        bool banderaContraseña = false;

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

        //CONTRASENA
        private void Lcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Lcontra.Text.Length < 4)
            {
                Econtra.SetError(Lcontra, "La contraseña debe tener minimo 4 digitos");
                banderaContraseña = false;
            }
            else
            {
                banderaContraseña = true;
                Econtra.Clear();

            }
        }

        //CELULAR
        private void Tcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Ecel.SetError(Tcelular, "Solo numeros!");
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
               || Temail.Text.Trim() == String.Empty || CBcategoria.SelectedIndex == -1 || Lcontra.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (Tdni.Text.Trim() == String.Empty)
                {
                    Edni.SetError(Tdni, "Campo Obligatorio!");
                }
                else
                {
                    Edni.Clear();
                }



                if (TBnombre.Text.Trim() == String.Empty)
                {
                    Enombre.SetError(TBnombre, "Campo Obligatorio!!");
                }
                else
                {
                    Enombre.Clear();
                }

                if (Tapellido.Text.Trim() == String.Empty)
                {
                    Eapellido.SetError(Tapellido, "Campo Obligatorio!");
                }
                else
                {
                    Eapellido.Clear();
                }

                if (Temail.Text.Trim() == String.Empty)
                {
                    Eemail.SetError(Temail, "Campo Obligatorio!");
                }
                else
                {
                    Edni.Clear();
                }


                if (CBcategoria.SelectedIndex == -1)
                {
                    Ecategoria.SetError(CBcategoria, "Campo Obligatorio!");
                }
                else
                {
                    Ecategoria.Clear();
                }

                if (Lcontra.Text.Trim() == String.Empty)
                {
                    Econtra.SetError(Lcontra, "Campo Obligatorio!");
                }
                else
                {
                    Econtra.Clear();
                }
            }
            else
            {

                if (banderaDNI == false || banderaEmail == false || banderaContraseña == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {   //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !

                    DialogResult resultado = MessageBox.Show("DNI:" + Tdni.Text + "\nNombre:" + TBnombre.Text + "   Apellido:" + Tapellido.Text
                                 + "\nEmail:" + Temail.Text, "Agregar Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("El Usuario:" + TBnombre.Text + " " + Tapellido.Text + "\nHa sido registrado correctamente!", "Registracion aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Tdni.Clear();
                        Tdomicilio.Clear();
                        Tcelular.Clear();
                        TBnombre.Clear();
                        Tapellido.Clear();
                        Temail.Clear();
                        Lcontra.Clear();
                        CBcategoria.Items.Clear();

                        //errores
                        Edni.Clear();
                        Enombre.Clear();
                        Eapellido.Clear();
                        Eemail.Clear();
                        Ecel.Clear();
                        Econtra.Clear();
                        Ecategoria.Clear();
                        inicializarUsuarios();

                        DialogResult respuesta = MessageBox.Show("Desea agregar otro usuario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (respuesta == DialogResult.No)
                        {
                            Close();
                        }


                    }

                }



            }

        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

       
    }


}

