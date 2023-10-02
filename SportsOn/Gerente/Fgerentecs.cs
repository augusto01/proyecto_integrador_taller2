using SportsOn.Gerente.Caja;
using SportsOn.Gerente.Cliente;
using SportsOn.Gerente.Compra;
using SportsOn.Gerente.Informe;
using SportsOn.Gerente.Producto;
using SportsOn.Gerente.Usuario;
using SportsOn.Gerente.Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsOn.Gerente
{
    public partial class Fgerentecs : Form
    {
        public Fgerentecs()
        {
            InitializeComponent();
            customizar_design();
        }

        private void Fgerentecs_Load(object sender, EventArgs e)
        {

        }
        //Metodo para diseñar comportamiento del menu 
        private void customizar_design()
        {
            Psubmenu_ventas.Visible = false;
            Psubmenu_producto.Visible = false;  //cuando aparece el submenu por primera vez no es visible
            Psubmenu_compras.Visible = false;
            Psubmenu_usuario.Visible = false;
            Psubmenu_informe.Visible = false;
            Psubmenu_caja.Visible = false;
            Psubmenu_cliente.Visible = false;
        }

        //ocultar submenu 
        private void ocultar_submenu()
        {
            if (Psubmenu_compras.Visible == true) Psubmenu_compras.Visible = false;
            if (Psubmenu_producto.Visible == true) Psubmenu_producto.Visible = false;
            if (Psubmenu_usuario.Visible == true) Psubmenu_usuario.Visible = false;
            if (Psubmenu_ventas.Visible == true) Psubmenu_ventas.Visible = false;
            if (Psubmenu_informe.Visible == true) Psubmenu_informe.Visible = false;
            if (Psubmenu_caja.Visible == true) Psubmenu_caja.Visible = false;
            if (Psubmenu_cliente.Visible == true) Psubmenu_cliente.Visible = false;

        }

        //Mostrar submenu 
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

        //controlador de formularios 

        private Form formulario_activo = null;
        private void abrirFormulario(object formulario_hijo)
        {
            if (this.Pcontent.Controls.Count > 0)
                this.Pcontent.Controls.RemoveAt(0);
            Form fh = formulario_hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.Pcontent.Controls.Add(fh);
            this.Pcontent.Tag = fh;
            fh.Show();

        }

        private void Bventas_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_ventas);
        }

        private void Bcompras_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_compras);
        }

        private void Bproducto_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_producto);
        }

        private void Busuario_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_usuario);
        }

        private void Binforme_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_informe);
        }

        private void Bcaja_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_caja);
        }

        private void Bcliente_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_cliente);
        }

        private void Bagregar_usuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_usuario_ger());

            ocultar_submenu();
        }

        private void Bagregar_producto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_producto_ger());
        }

        private void Bagregar_venta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_venta_ger());
        }

        private void Bagregar_cliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_cliente_ger());
        }

        private void Bagregar_informe_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_informe_ger());
        }

        private void Bagregar_compra_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_compra_ger());
        }

        private void Bver_caja_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Caja_gerente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Bbuscar_usuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fbuscar_usuario());
        }
    }
}
