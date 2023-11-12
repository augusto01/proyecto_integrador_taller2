using CapaPresentacion.Administrador.Clientes;
using CapaPresentacion.Administrador.Usuario;
using CapaPresentacion.Gerente.Producto;
using CapaPresentacion.Vistas.Backup;
using CapaPresentacion.Vistas.Compra;
using CapaPresentacion.Vistas.Informes;
using CapaPresentacion.Vistas.Proveedor;
using CapaPresentacion.Vistas.Venta;
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
    public partial class menu_gerente : Form
    {
        public menu_gerente()
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
            if (submenu_proveedor.Visible == true) submenu_proveedor.Visible = false;

        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
        private void datos_user()
        {
            lnombre.Text = CapaEntidad.Cache.UserLoginCache.nombre.Trim() + " " + CapaEntidad.Cache.UserLoginCache.apellido.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            brestarurar.Visible = true;
            button2.Visible = false ;
        }

        private void bminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brestarurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button2.Visible = true;
            brestarurar.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menu_gerente_Load(object sender, EventArgs e)
        {
            datos_user();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void bcerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
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


        //SUBMENUS

        //USUARIOS
            private void busuarios_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_usuarios);
          
            }

            private void bagregar_usuarios_Click(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_usuario());
                ocultar_submenu();
            }

        //PRODUCTO
            private void bproducto_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_productos);
            }

            private void bagregarproducto_Click(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_producto());
                ocultar_submenu();
            }
        //VENTAS

            private void bventas_Click(object sender, EventArgs e)
            {
                 mostrar_submenu(submenu_ventas);
            }
          
            private void bagregarventas_Click_1(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_venta());
                ocultar_submenu();
            }
        //CLIENTES

        private void bClientes_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_clientes);
            }
            private void bagregarclientes_Click(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_cliente());
                ocultar_submenu();
            }
        //INFORMES

            private void binforme_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_informe);
            }
        //COMPRAS

            private void bcompras_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_compras);
            }
            private void bagregarcompra_Click(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_compra());
                ocultar_submenu();
            }
        //PROVEEDOR
        private void bagregarproveedor_Click(object sender, EventArgs e)
            {
                ocultarhora();
                abrirFormulario(new Fagregar_proveedor());
                ocultar_submenu();
            }
            private void bproveedor_Click(object sender, EventArgs e)
            {
                mostrar_submenu(submenu_proveedor);
            }
        //BACKUP
            private void bbackup_Click(object sender, EventArgs e)
            {
                //codigo
            }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                ocultarhora();
                abrirFormulario(new Fagregar_backup());
                ocultar_submenu();
            }
        }

        private void bagregarcompra_Click_1(object sender, EventArgs e)
        {           
           ocultarhora();
           abrirFormulario(new Fagregar_compra());
           ocultar_submenu();
            
        }

        private void bverventas_Click(object sender, EventArgs e)
        {
            ocultarhora();
            abrirFormulario(new Fmis_ventas());
            ocultar_submenu();
        }

        private void bverinformes_Click(object sender, EventArgs e)
        {
            ocultarhora();
            abrirFormulario(new Fver_informes());
            ocultar_submenu();
        }
    }
}
