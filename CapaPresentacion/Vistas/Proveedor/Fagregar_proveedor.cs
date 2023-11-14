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
//using static Fable.Import.JS;

namespace CapaPresentacion.Vistas.Proveedor
{
    public partial class Fagregar_proveedor : Form
    {
        public Fagregar_proveedor()
        {
            InitializeComponent();
        }

        CN_PROVEEDOR proveedor = new CN_PROVEEDOR();

        
        bool banderaDNI = false;
        bool banderaEmail = false;

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
                eapellido.Clear();
            }
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

        private void Tcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ecel.SetError(Tcel, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }

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
            trazonsocial.Clear();
          

        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (tdni.Text.Trim() == String.Empty || tnombre.Text.Trim() == string.Empty || tapellido.Text.Trim() == string.Empty
              || Tcorreo.Text.Trim() == String.Empty||Tcel.Text.Trim() == String.Empty)
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
                if (Tcel.Text.Trim() == String.Empty)
                {
                    ecel.SetError(Tcel, "Campo Obligatorio!");
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
                                 + "\nEmail:" + Tcorreo.Text, "Agregar Proveedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        //string nombre_cliente, string apellido_cliente, int dni_cliente, string email_cliente, string domicilio_cliente, int celular_cliente
                        proveedor.registrar_proveedor(tnombre.Text, tapellido.Text, Int32.Parse(tdni.Text), Tcorreo.Text , tdomicilio.Text, trazonsocial.Text, Int32.Parse(Tcel.Text));


                        MessageBox.Show("El proveedor: " + tnombre.Text + " " + tapellido.Text + " se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        LimpiarErrores();

                    }

                }



            }
        }

        private void Fagregar_proveedor_Load(object sender, EventArgs e)
        {
            dgproveedores.DataSource = proveedor.ConsultaDT();
        }

        private void tbuscarobjeto_TextChanged(object sender, EventArgs e)
        {
            string valorBuscado = "" + tbuscarobjeto.Text;

            // Si estás usando un BindingSource
            int rowIndex = -1;

            foreach (DataGridViewRow fila in dgproveedores.Rows)
            {
                if (fila.Cells["DNI"].Value != null && fila.Cells["DNI"].Value.ToString() == valorBuscado)
                {
                    rowIndex = fila.Index;


                    break;
                }
            }

            if (rowIndex != -1)
            {
                DataGridViewRow row = dgproveedores.Rows[rowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                dgproveedores.CurrentCell = dgproveedores[0, rowIndex]; // Esto seleccionará la fila encontrada

            }
        }
    }
}
