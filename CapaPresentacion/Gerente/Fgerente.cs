﻿using CapaPresentacion.Gerente.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Gerente
{
    public partial class Fgerente : Form
    {
        public Fgerente()
        {
            InitializeComponent();
            customizar_design();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int intlparam);
        private void customizar_design()
        {
            submenu_informe.Visible = false;
            submenu_clientes.Visible = false;  //cuando aparece el submenu por primera vez no es visible
            submenu_compras.Visible = false;
            submenu_usuarios.Visible = false;
            submenu_ventas.Visible = false;
            submenu_productos.Visible = false;
            submenu_proveedor.Visible = false;
            submenu_backup.Visible = false;
        }
        private Form formulario_activo = null;


        //abrir formulario
        private void abrirFormulario(object formulario_hijo)
        {
            if (this.pcontent.Controls.Count > 0)
                this.pcontent.Controls.RemoveAt(0);
            Form fh = formulario_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.pcontent.Controls.Add(fh);
            this.pcontent.Tag = fh;
            fh.Show();

        }
        private void mostrar_submenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultar_submenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }
        private void ocultar_submenu()
        {
            if (submenu_compras.Visible == true) submenu_compras.Visible = false;
            if (submenu_productos.Visible == true) submenu_productos.Visible = false;
            if (submenu_usuarios.Visible == true) submenu_usuarios.Visible = false;
            if (submenu_ventas.Visible == true) submenu_ventas.Visible = false;

            if (submenu_informe.Visible == true) submenu_informe.Visible = false;
            if (submenu_clientes.Visible == true) submenu_clientes.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button2.Visible = false;
            brestarurar.Visible = true;
        }

        private void Fgerente_Load(object sender, EventArgs e)
        {
            datos_usuario();
        }

        private void datos_usuario()
        {
            this.lnombre.Text = CapaEntidad.Cache.UserLoginCache.username;

        }

        private void brestarurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            brestarurar.Visible = false;
            button2.Visible=true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button2.Visible = false;
            brestarurar.Visible = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button2.Visible = false;
            brestarurar.Visible = true;
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void bminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brestarurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            brestarurar.Visible = false;
            button2.Visible = true;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void bcerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void busuarios_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_usuarios);
        }

        private void bproducto_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_productos);
        }

        private void bventas_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_ventas);
        }

        private void bClientes_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_clientes);
        }

        private void binforme_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_informe);
        }

        private void bcompras_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_compras);
        }

        private void bproveedor_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_proveedor);
        }

        private void bbackup_Click(object sender, EventArgs e)
        {
            mostrar_submenu(submenu_backup);
        }

        private void bagregar_usuarios_Click(object sender, EventArgs e)
        {
            ocultarhora();
            abrirFormulario(new Fagregar_usuario());
            ocultar_submenu();
        }

        private void ocultarhora()
        {
            lhora.Visible = false;
            lfecha.Visible = false;
        }

        private void mostrarhora()
        {
            lhora.Visible = true;
            lfecha.Visible = true;

        }
    }
}
