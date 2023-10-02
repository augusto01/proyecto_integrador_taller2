using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Administrador.Clientes
{
    public partial class Fbuscar_cliente : Form
    {
        public Fbuscar_cliente()
        {
            InitializeComponent();
        }


        //flags
        bool flagDni = false;
        bool flagID = false;


        private void Fbuscar_cliente_Load(object sender, EventArgs e)
        {

        }

   


        //DNI CLIENTE
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

        //ID CLIENTE
        private void Tid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                Edni.SetError(Tid, "Solo números!");
                e.Handled = true;
                return;
                flagID = false;


            }
            else
            {
                flagID = true;
            }
        }



        private void Bbuscar_Click(object sender, EventArgs e)
        {
            if (Tid.Text == String.Empty && Tdni.Text == String.Empty)
            {
                MessageBox.Show("Ingrese al menos un campo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Tdni.Text.Trim() == String.Empty)
                {
                    Edni.SetError(Tdni, "Ingrese DNI!");
                }

                if (Tid.Text.Trim() == String.Empty)
                {
                    Edni.SetError(Tid, "Ingrese ID del cliente!");
                }

            }
            else
            {
                if (flagID == false || flagDni == false)
                {
                    MessageBox.Show("Valores invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Eid.Clear(); Edni.Clear();  
                    MessageBox.Show("ok!", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
