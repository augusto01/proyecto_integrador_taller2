using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn
{
    public partial class Conexion : Form
    {

        static string cadenaconexion = "server= DESKTOP-FG0LK48; database= proyecto_taller2";
        SqlConnection conexion = new SqlConnection(cadenaconexion);


        public Conexion()
        {
            InitializeComponent();
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("conexion a la BD: " + conexion.Database + "ha sido exitosa!");
        }
    }
}
