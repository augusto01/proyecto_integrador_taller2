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
                MessageBox.Show("El campo esta vacio!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //ADMINISTRADOR
                if (Tusername.Text == "admin" && Tpass.Text == "admin")
                {
                    Form formulario = new Fadministrador();
                    formulario.Show();
                }
                else
                {
                    //EMPLEADO
                    if (Tusername.Text == "empleado" && Tpass.Text == "empleado")
                    {
                        Form formulario = new empleado();
                        formulario.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
         
        }
    }
}