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
using System.Data.SqlClient;
namespace SportsOn.Administrador
{
    public partial class Fbuscar_usuario : Form
    {



        SqlConnection conexion = new SqlConnection("Server=DESKTOP-FG0LK48; Database=proyecto_taller2; Integrated Security=True;");
        public Fbuscar_usuario()
        {
            InitializeComponent();
        }
        //flags
        bool flagDni = true;
        bool flagCorreo = true;
        bool flagUser = true;
        //variable global 
        private void Fbuscar_usuario_Load(object sender, EventArgs e)
        {
            string consulta_mostrarusuario = "Select id_usuario,nombre, apellido, dni, fecha_creacion, username, correo, estado from Usuario";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_mostrarusuario, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dg_mostrarusuarios.DataSource = dt;



        }

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

        private void Bconectar_Click(object sender, EventArgs e)
        {
            abrirConexion();
        }

        private void abrirConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion exitosa!");


            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexion!");
            }
        }


    }
}
