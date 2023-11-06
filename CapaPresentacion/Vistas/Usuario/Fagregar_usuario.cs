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
using CapaNegocio;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Fable.Import.Browser;

namespace CapaPresentacion.Administrador.Usuario
{
    public partial class Fagregar_usuario : Form
    {
        CN_USUARIO usuario = new CN_USUARIO();
       
        public Fagregar_usuario()
        {
            InitializeComponent();
            inicializarUsuarios();
        }

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
        private void Fagregar_usuario_Load(object sender, EventArgs e)
        {
            dgusuarios.DataSource = usuario.ConsultaDT();

        }

        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;
        bool banderaContraseña = false;
        bool banderaConfContra = false;
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
        //validaciones campo a campo

        //nombre
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

        //apellido
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
                eapellido.Clear();
            }
        }

        //correo electronico
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
        //celular

        private void Tcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ecel.SetError(Tcel, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        //dni
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

        //contraseña
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
                    etipouser.SetError(cbtipo, "Campo Obligatorio!");
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
                        

                        usuario.insertar_usuario(tnombre.Text, tapellido.Text, Tuser.Text,Int32.Parse(tdni.Text) , Tcorreo.Text, tdomicilio.Text, Int32.Parse(Tcel.Text), Tpass.Text, cbtipo.SelectedIndex);
                        dgusuarios.DataSource = usuario.ConsultaDT();



                        //si la respuesta es si cargamos el usuario 
                        MessageBox.Show("El usuario: "+tnombre.Text+" "+tapellido.Text+" se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        LimpiarErrores();

                    }

                }



            }

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
            etipouser.Clear();
            inicializarUsuarios();
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }



        private void dgusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgusuarios.Columns[e.ColumnIndex].Name == "eliminar" && this.dgusuarios.CurrentRow.Index != -1)
            {
                EliminarUsuario();
            }
        }

        private void EliminarUsuario()
        {
            CN_USUARIO usuario = new CN_USUARIO();  
            if (this.dgusuarios.CurrentRow.Index != -1 )
            {
                int posicion = dgusuarios.CurrentRow.Index;
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {                  
                      
                    usuario.eliminar_usuario(Int32.Parse (dgusuarios[6, posicion].Value.ToString()) );
                    this.dgusuarios.Rows.RemoveAt(this.dgusuarios.CurrentRow.Index);
                }
                else
                {
                    tnombre.Clear();
                    tapellido.Clear();
                    Tuser.Clear();
                    tdni.Clear();
                    Tcorreo.Clear();
                    tdomicilio.Clear();
                    Tcel.Clear();

                    bcancelaredicion.Visible = false;
                    beditar.Visible = false;
                    bcancelar.Visible = true;
                    bnover.Visible = true;
                    bver.Visible = true;
                    Tpass.Visible = true;
                    Tconfcontra.Visible = true;
                    lcontra.Visible = true;
                    lconfcontra.Visible = true;
                }

            }
           

        }

        private void editar_accion()
        {
            bcancelaredicion.Visible = true;
            beditar.Visible = true;
            bcancelar.Visible = false;
            bnover.Visible = false; 
            bver.Visible = false;
            Tpass.Visible = false;
            Tconfcontra.Visible = false;
            lcontra.Visible = false;
            lconfcontra.Visible = false;  
 
        }
        private void dgusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            if (this.dgusuarios.CurrentRow.Index != -1 && dgusuarios.Columns[e.ColumnIndex].Index == 0)
            {
                int posicion;
                editar_accion();
                posicion = dgusuarios.CurrentRow.Index;
                tnombre.Text = dgusuarios[3, posicion].Value.ToString();
                tapellido.Text = dgusuarios[4, posicion].Value.ToString();
                Tuser.Text = dgusuarios[5, posicion].Value.ToString();
                tdni.Text = dgusuarios[6, posicion].Value.ToString();
                Tcorreo.Text = dgusuarios[8, posicion].Value.ToString(); 
                tdomicilio.Text = dgusuarios[7, posicion].Value.ToString();
                Tcel.Text = dgusuarios[9, posicion].Value.ToString();
                cbtipo.Text = dgusuarios[10, posicion].Value.ToString();
         

            }
            
        }

        private void bcancelaredicion_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar la edicion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                tnombre.Clear();
                tapellido.Clear();
                Tuser.Clear();
                tdni.Clear();
                Tcorreo.Clear();
                tdomicilio.Clear();
                Tcel.Clear();




                bcancelaredicion.Visible = false;
                beditar.Visible = false;
                bcancelar.Visible = true;
                bnover.Visible = true;
                bver.Visible = true;
                Tpass.Visible = true;
                Tconfcontra.Visible = true;
                lcontra.Visible = true;
                lconfcontra.Visible = true;
            }
        
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere editar el usuario?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if(cbtipo.SelectedIndex != -1)
                {
                    CN_USUARIO usuario = new CN_USUARIO();
                    usuario.modificar_usuario(tnombre.Text, tapellido.Text, Tuser.Text, Int32.Parse(tdni.Text), Tcorreo.Text, tdomicilio.Text, Int32.Parse(Tcel.Text), cbtipo.SelectedIndex);
                    MessageBox.Show("El usuario se edito correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgusuarios.DataSource = usuario.ConsultaDT();
                }
                else
                {
                    etipouser.SetError(cbtipo, "Campo Obligatorio!");
                }

               
            }
            tnombre.Clear();
            tapellido.Clear();
            Tuser.Clear();
            tdni.Clear();
            Tcorreo.Clear();
            tdomicilio.Clear();
            Tcel.Clear();




            bcancelaredicion.Visible = false;
            beditar.Visible = false;
            bcancelar.Visible = true;
            bnover.Visible = true;
            bver.Visible = true;
            Tpass.Visible = true;
            Tconfcontra.Visible = true;
            lcontra.Visible = true;
            lconfcontra.Visible = true;
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado =""+tbuscarobjeto.Text;

            // Si estás usando un BindingSource
            int rowIndex = -1;

            foreach (DataGridViewRow fila in dgusuarios.Rows)
            {
                if (fila.Cells["username"].Value != null && fila.Cells["username"].Value.ToString() == valorBuscado)
                {
                    rowIndex = fila.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dgusuarios.CurrentCell = dgusuarios[0, rowIndex]; // Esto seleccionará la fila encontrada
            }
            else
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
