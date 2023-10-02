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
        //variable global 
    

        //Definiomos una variable compuesta para mandar al formulario de busqueda 
      

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
