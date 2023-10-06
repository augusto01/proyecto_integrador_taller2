using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportsOn.Gerente.Usuario
{
    public partial class Fbuscar_usuario : Form
    {


        SqlConnection conexion = new SqlConnection("Server=DESKTOP-FG0LK48; Database=proyecto_taller2; Integrated Security=True;");
        public Fbuscar_usuario()
        {
            InitializeComponent();
        }

        private void Fbuscar_usuario_Load(object sender, EventArgs e)
        {
            string consulta_mostrarusuario = "Select id_usuario,nombre, apellido, dni, fecha_creacion, username, correo, estado from Usuario";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_mostrarusuario, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dg_usuarios.DataSource = dt;

        }
    }
}
