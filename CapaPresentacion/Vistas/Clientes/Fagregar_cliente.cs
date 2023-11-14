using CapaNegocio;
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

namespace CapaPresentacion.Administrador.Clientes
{
    public partial class Fagregar_cliente : Form
    {
        public Fagregar_cliente()
        {
            InitializeComponent();
            
        }

        CN_CLIENTE cliente = new CN_CLIENTE();

        //BANDERAS PARA SABER EL ESTADOS DE LOS TEXT BOX 
        bool banderaDNI = false;
        bool banderaEmail = false;


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
        //correo

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

        private void tdomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        //metodos esteticos
        private void LimpiarCampos()
        {

            tdni.Clear();
            tdomicilio.Clear();
            Tcel.Clear();
            tnombre.Clear();
            tapellido.Clear();
            Tcorreo.Clear();

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

        }

        //boton agregar
        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (tdni.Text.Trim() == String.Empty || tnombre.Text.Trim() == string.Empty || tapellido.Text.Trim() == string.Empty
              || Tcorreo.Text.Trim() == String.Empty)
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

                if (tapellido.Text.Trim() == String.Empty)
                {
                    eapellido.SetError(tapellido, "Campo Obligatorio!");
                }

                if (Tcorreo.Text.Trim() == String.Empty)
                {
                    ecorreo.SetError(Tcorreo, "Campo Obligatorio!");
                }

            }
            else
            {

                if (banderaDNI == false || banderaEmail == false)
                {

                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    //SI LOS CAMPOS ESTAN COMPLETOS HACEMOS LA INSERCION DEL USUARIO NUEVO !
                    LimpiarErrores();
                    DialogResult resultado = MessageBox.Show("DNI:" + tdni.Text + "\nNombre:" + tnombre.Text + "   Apellido:" + tapellido.Text
                                 + "\nEmail:" + Tcorreo.Text, "Agregar Cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //si la respuesta es si cargamos el usuario 
                        CN_CLIENTE cliente = new CN_CLIENTE();
                        cliente.registrar_cliente(tnombre.Text, tapellido.Text, Int32.Parse(tdni.Text), Tcorreo.Text, tdomicilio.Text, Int32.Parse(Tcel.Text));
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

        private void Fagregar_cliente_Load(object sender, EventArgs e)
        {
            dgclientes.DataSource = cliente.ConsultaDT();
        }
        private void editar_accion()
        {
            bcancelaredicion.Visible = true;
            beditar.Visible = true;
            bcancelar.Visible = false;


        }
        private void dgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgclientes.Columns[e.ColumnIndex].Name == "editar" && this.dgclientes.CurrentRow.Index != -1)
            {
                int posicion;
                editar_accion();
                posicion = dgclientes.CurrentRow.Index;
                tnombre.Text = dgclientes[3, posicion].Value.ToString();
                tapellido.Text = dgclientes[4, posicion].Value.ToString();
                tdni.Text = dgclientes[5, posicion].Value.ToString();
                Tcorreo.Text = dgclientes[6, posicion].Value.ToString();
                tdomicilio.Text = dgclientes[7, posicion].Value.ToString();
                Tcel.Text = dgclientes[8, posicion].Value.ToString();

            }
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere editar el usuario?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {


                CN_CLIENTE cliente = new CN_CLIENTE();
                cliente.modificar_cliente(tnombre.Text, tapellido.Text, Int32.Parse(tdni.Text), Tcorreo.Text, tdomicilio.Text, Int32.Parse(Tcel.Text));
                MessageBox.Show("El cliente se edito correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgclientes.DataSource = cliente.ConsultaDT();

            }
            tnombre.Clear();
            tapellido.Clear();
            tdni.Clear();
            Tcorreo.Clear();
            tdomicilio.Clear();
            Tcel.Clear();
            bcancelaredicion.Visible = false;
            beditar.Visible = false;
            bcancelar.Visible = true;

        }

        private void bcancelaredicion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar la edicion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                tnombre.Clear();
                tapellido.Clear();
                tdni.Clear();
                Tcorreo.Clear();
                tdomicilio.Clear();
                Tcel.Clear();
                bcancelaredicion.Visible = false;
                beditar.Visible = false;
                bcancelar.Visible = true;

            }
        }
        private void EliminarCliente()
        {
            CN_USUARIO usuario = new CN_USUARIO();
            if (this.dgclientes.CurrentRow.Index != -1)
            {
                int posicion = dgclientes.CurrentRow.Index;
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    cliente.eliminar_cliente(Int32.Parse(dgclientes[5, posicion].Value.ToString()));
                    this.dgclientes.Rows.RemoveAt(this.dgclientes.CurrentRow.Index);
                    MessageBox.Show("El cliente se elimino correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgclientes.DataSource = cliente.ConsultaDT();

                }
                else
                {
                    tnombre.Clear();
                    tapellido.Clear();
          
                    tdni.Clear();
                    Tcorreo.Clear();
                    tdomicilio.Clear();
                    Tcel.Clear();

                    bcancelaredicion.Visible = false;
                    beditar.Visible = false;
                    bcancelar.Visible = true;
                
                }

            }


        }
        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgclientes.Columns[e.ColumnIndex].Name == "eliminar" && this.dgclientes.CurrentRow.Index != -1)
            {
                EliminarCliente();
            }
        }
    }
}