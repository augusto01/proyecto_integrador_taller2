using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

    

namespace SportsOn
{

   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
     

        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void Biniciar_Click(object sender, EventArgs e)
        {
            //VALIDA SI LOS CAMPOS ESTAN VACIOS !
            if (Tusername.Text.Trim() == String.Empty || Tpass.Text.Trim() == String.Empty)
            {
                MessageBox.Show("El campo esta vacío!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (Tusername.Text == "admin" && Tpass.Text == "admin")
                {
                    Form formulario = new Fadministrador();
                    formulario.Show();

                }
                else
                {
                    if (Tusername.Text == "empleado" && Tpass.Text == "empleado")
                    {
                        Form formulario = new empleado();
                        formulario.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrectos!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }


        }

    }
}