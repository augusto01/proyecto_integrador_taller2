using SportsOn.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace SportsOn
{
    public partial class FAgregarUsuario : Form
    {

        //conexion a la base de datos !

        SqlConnection conexion = new SqlConnection("Server=DESKTOP-FG0LK48; Database=proyecto_taller2; Integrated Security=True;");
        string server = "Data Source = DESKTOP-FG0LK4; Initial Catalog=super; Integrated Security=True";


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

        //DESACTIVAMOS EL BOTON DE EDITAR 


        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;
        bool banderaContraseña = false;
        bool banderaConfContra = false;

        //variable global posicion para el arrray de editar usuario 
        int posicion = 0;
        //filtro dni
        bool banderafiltrodni = false;

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
        private void Lcontra_TextChanged(object sender, EventArgs e)
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

        //CONFIRMAR CONTRASEÑA
        private void Tconfcontra_TextChanged(object sender, EventArgs e)
        {
            if (Tconfcontra.Text != Lcontra.Text)
            {
                Econfcontra.SetError(Tconfcontra, "Las contraseñas no coinciden!");
                banderaConfContra = false;
            }
            else
            {
                banderaConfContra = true;
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




        //FILTRO DNI

        private void TBdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Enrodoc.SetError(TBdni, "Solo números!");
                e.Handled = true;
                return;
                banderafiltrodni = false;


            }
            else
            {
                banderafiltrodni = true;
            }
        }


        private void Bagregar_Click(object sender, EventArgs e)
        {

            if (Tdni.Text.Trim() == String.Empty || TBnombre.Text.Trim() == string.Empty || Tapellido.Text.Trim() == string.Empty
               || Temail.Text.Trim() == String.Empty || CBcategoria.SelectedIndex == -1 || Lcontra.Text.Trim() == String.Empty || Tconfcontra.Text == String.Empty || Tuser.Text == String.Empty)
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

                if (Tuser.Text.Trim() == String.Empty)
                {
                    Euser.SetError(Tuser, "Campo Obligatorio!!");
                }

                if (Tapellido.Text.Trim() == String.Empty)
                {
                    Eapellido.SetError(Tapellido, "Campo Obligatorio!");
                }

                if (Temail.Text.Trim() == String.Empty)
                {
                    Eemail.SetError(Temail, "Campo Obligatorio!");
                }



                if (CBcategoria.SelectedIndex == -1)
                {
                    Ecategoria.SetError(CBcategoria, "Campo Obligatorio!");
                }


                if (Lcontra.Text.Trim() == String.Empty)
                {
                    Econtra.SetError(Lcontra, "Campo Obligatorio!");
                }

                if (Tconfcontra.Text.Trim() == String.Empty)
                {
                    Econfcontra.SetError(Tconfcontra, "Campo Obligatorio!");
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
                    Edni.Clear(); Econfcontra.Clear(); Enombre.Clear(); Eapellido.Clear(); Edomi.Clear(); Ecel.Clear(); Euser.Clear();
                    DialogResult resultado = MessageBox.Show("DNI:" + Tdni.Text + "\nNombre:" + TBnombre.Text + "   Apellido:" + Tapellido.Text
                                 + "\nEmail:" + Temail.Text, "Agregar Usuario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //si la respuesta es si cargamos el usuario 
                        CargaUsuario();
                        LimpiarCampos();
                        LimpiarErrores();

                    }

                }



            }

        }

        private void LimpiarCampos()
        {
            Tuser.Clear();
            Tdni.Clear();
            Tdomicilio.Clear();
            Tcelular.Clear();
            TBnombre.Clear();
            Tapellido.Clear();
            Temail.Clear();
            Lcontra.Clear();
            CBcategoria.Items.Clear();
            Tconfcontra.Clear();
        }

        private void LimpiarErrores()
        {
            Edni.Clear();
            Enombre.Clear();
            Eapellido.Clear();
            Eemail.Clear();
            Ecel.Clear();
            Econtra.Clear();
            Ecategoria.Clear();
            inicializarUsuarios();
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
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        //BUSQUEDA DE LOS USUARIOS EN EL DATAGRID



        public void CargaUsuario()
        {

            //conexion a la base de datos

            conexion.Open();
           
               SqlCommand agregar_usuario= new SqlCommand("INSERT INTO Usuario (id_tipo_usuario,nombre,apellido,correo,estado,fecha_creacion,dni,username,pass,cel) values("+CBcategoria.SelectedIndex+",'"+TBnombre.Text+"','"+Tapellido.Text+"','"+Temail.Text+"',1,getdate(),"+Tdni.Text+",'"+Tuser.Text+"','"+Lcontra.Text+"',"+Tcelular.Text+")", conexion);
            
 
            try
            {
                agregar_usuario.Parameters.Clear();

                agregar_usuario.ExecuteNonQuery();
                MessageBox.Show("El usuario " + TBnombre.Text + " " + Tapellido.Text + " se agreggo con exito!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                conexion.Close();
            }

        }

       




        //EDITAR REGISTROS      
        private void editarUsuario_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro que desea editar el usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string nombre, apellido, usuario, dni;

                nombre = TBnombre.Text;
                apellido = Tapellido.Text;
                usuario = Tuser.Text;
                dni = Tdni.Text;

                dg_usuarios[1, posicion].Value = TBnombre.Text;
                dg_usuarios[2, posicion].Value = Tapellido.Text;
                dg_usuarios[3, posicion].Value = Tdni.Text;
                dg_usuarios[4, posicion].Value = Tuser.Text;
                LimpiarCampos();
                TBnombre.Focus();

                Bagregar.Visible = true;
                editarUsuario.Visible = false;
            }
            else
            {
                LimpiarCampos();
                editarUsuario.Visible = false;
                Bagregar.Visible = true;


            }

        }

        private void dg_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dg_usuarios.CurrentRow.Index != -1 && dg_usuarios.Columns[e.ColumnIndex].Name == "editar")
            {


                Bagregar.Visible = false;
                editarUsuario.Visible = true;
                Bcancelar.Visible = true;
                posicion = dg_usuarios.CurrentRow.Index;
                TBnombre.Text = dg_usuarios[1, posicion].Value.ToString();
                Tapellido.Text = dg_usuarios[2, posicion].Value.ToString();
                Tdni.Text = dg_usuarios[3, posicion].Value.ToString();
                Tuser.Text = dg_usuarios[4, posicion].Value.ToString();

            }

        }


        //ELIMNAR REGISTROS 
        private void EliminarUsuario()
        {
            if (this.dg_usuarios.CurrentRow.Index != -1)
            {
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.dg_usuarios.Rows.RemoveAt(this.dg_usuarios.CurrentRow.Index);
                }

            }
        }

        private void dg_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_usuarios.Columns[e.ColumnIndex].Name == "eliminar")
            {
                EliminarUsuario();
            }


        }

        private void Bcancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cancelar la edicion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                posicion = dg_usuarios.CurrentRow.Index;
                TBnombre.Clear();
                Tapellido.Clear();
                Tdni.Clear();
                Tuser.Clear();
                editarUsuario.Visible = false;
                Bcancelar.Visible = false;
                Bagregar.Visible = true;
            }
        }









        // AGREGAR USUARIO A LA BASE DE DATOS 








        //buscar registro por dni
        /*private void BusquedaGrid(DataGridView d, int column)
        {
       
            for (int i = 0; i < d.Rows.Count; i++)
            {
                String dato = Convert.ToString(d.Rows[i].Cells[column].Value);
                if (dato !=TBdni.Text.Trim())
                {
                    d.CurrentRow.Visible = false;
                   
                    break;
                }

         
            }






        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            BusquedaGrid(dg_usuarios, 3);
        }*/
    }
}

