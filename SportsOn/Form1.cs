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
        }
    }
}