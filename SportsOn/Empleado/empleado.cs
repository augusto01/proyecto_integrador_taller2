using SportsOn.Administrador.Caja;
using SportsOn.Administrador.Clientes;
using SportsOn.Administrador.Compras;
using SportsOn.Administrador.Informes;
using SportsOn.Administrador.Venta;
using SportsOn.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsOn.Empleado.Producto;
using SportsOn.Empleado.Ventas;
using Fagregar_venta = SportsOn.Empleado.Ventas.Fagregar_venta;

namespace SportsOn
{
    public partial class empleado : Form
    {

        public empleado()
        {
            InitializeComponent();
            customizar_design();
        }



        //Metodo para diseñar comportamiento del menu 
        private void customizar_design()
        {
            Psubmenu_ventas.Visible = false;
            Psubmenu_producto.Visible = false;  //cuando aparece el submenu por primera vez no es visible

            Psubmenu_caja.Visible = false;
            Psubmenu_cliente.Visible = false;
        }

        //ocultar submenu 
        private void ocultar_submenu()
        {
            if (Psubmenu_producto.Visible == true) Psubmenu_producto.Visible = false;

            if (Psubmenu_ventas.Visible == true) Psubmenu_ventas.Visible = false;

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



        private void Bventas_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_ventas);
        }
        private void Bagregar_venta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_venta());
            /*
             codigo
             
             */

            ocultar_submenu();
        }

        private void Bbuscar_venta_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FbuscarVenta());
            /*
            codigo

            */

            ocultar_submenu();
        }




        private void Bproducto_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_producto);
        }








        private void Bcerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }


        private void Bcaja_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_caja);
        }

        private void b_cerrar_caja_Click(object sender, EventArgs e)
        {
            /*
            codigo

            */

            ocultar_submenu();
        }

        private void Bver_caja_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new Fvercaja_emp());
            /*
           codigo

           */

            ocultar_submenu();
        }

        private void Bcliente_Click(object sender, EventArgs e)
        {
            mostrar_submenu(Psubmenu_cliente);
        }
        private void Bcerrar_sesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }


        private void Bagregar_cliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_cliente());
            /*CODIGO*/
            ocultar_submenu();
        }

        private void Bver_cliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Fbuscar_cliente());
            /*CODIGO*/
            ocultar_submenu();
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
        private void panel_menu_lateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fadministrador_Load(object sender, EventArgs e)
        {

        }

        private void Pcontent_Paint(object sender, PaintEventArgs e)
        {

        }



        private void empleado_Load(object sender, EventArgs e)
        {

        }

        private void Bbuscar_producto_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FbuscarProductoEmp());
        }

        private void Bagregar_venta_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_venta());
        }

        private void Bagregar_cliente_Click_1(object sender, EventArgs e)
        {
            abrirFormulario(new Fagregar_cliente());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}

