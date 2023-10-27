using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion.Administrador;
using CapaPresentacion.Gerente;
using CapaPresentacion.Empleado;

using Microsoft.FSharp.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CapaPresentacion
{
    public partial class loguin : Form
    {

        public loguin()
        {

            InitializeComponent();


        }

        //poder desplazar el formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int intlparam);




        private void pminimizar_Click(object sender, EventArgs e)
        {

        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bver_Click(object sender, EventArgs e)
        {
            bnover.BringToFront();
            Tpass.UseSystemPasswordChar = false;
        }

        private void bnover_Click(object sender, EventArgs e)
        {
            bver.BringToFront();
            Tpass.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Bingresar_Click(object sender, EventArgs e)
        {

            // VALIDAR CAMPOS VACÍOS
            if (Tuser.Text.Trim() == String.Empty || Tpass.Text.Trim() == String.Empty)
            {

                msgerror("Debe completar todos los campos!");
                if (Tuser.Text.Trim() == String.Empty)
                {                   
                    msgerror("Ingrese un nombre de usuario!");
                }
                else
                {              
                    msgerror("Ingrese una contraseña!");
                }
            }
            else
            {
                lblerror.Visible = false;
                UserModelcs user = new UserModelcs();
                var validlogin = user.LoginUser(Tuser.Text, Tpass.Text);
                if (validlogin == true)
                {
                    int tipousuario = CapaEntidad.Cache.UserLoginCache.id_tipo_usuario;
                    switch (tipousuario)
                    {
                        case 0:
                            // Caso Vendedor
                            Empleado.Fvendedor form_empleado = new Empleado.Fvendedor();

                            form_empleado.FormClosed += logout; // Sobrecarga para cerrar sesion
                            form_empleado.Show(); // Mostramos el menu Aministrador
                            this.Hide(); // Ocultamos Login
                            break;
                        case 1:
                            // Caso Administrador
                            Administrador.Fadministradornuevo form_administrador = new Administrador.Fadministradornuevo();

                            form_administrador.FormClosed += logout; // Sobrecarga para cerrar sesion
                            form_administrador.Show(); // Mostramos el menu vendedor
                            this.Hide(); // Ocultamos Login
                            break;
                        case 2:
                            // Caso Gerente
                            Gerente.Fgerente form_gerente = new Gerente.Fgerente();

                            form_gerente.FormClosed += logout; // Sobrecarga para cerrar sesion
                            form_gerente.Show(); // Mostramos el menu SuperAdmin

                            this.Hide(); // Ocultamos Login
                            break;


                    }
                   
                }
                else
                {
                    msgerror("Usuario o contraseña incorrectos!");
                    Tpass.Clear();
                    Tuser.Focus();
                }
            }
            
           
        }



        private void msgerror(string msg)
        {
            lblerror.Visible = true;
            lblerror.Text = "       " + msg;
        }

        private void logout(object sender, FormClosedEventArgs e)
        {

            this.Tuser.Clear();
            this.Tpass.Clear();
            this.Show();
            Tuser.Focus();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loguin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
 } 
