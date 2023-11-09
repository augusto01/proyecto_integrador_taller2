using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Cache;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Fable.Import.Browser;

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fagregar_venta : Form
    {
        CN_VENTA cliente = new CN_VENTA();
        CN_PRODUCTO productoventa = new CN_PRODUCTO();


        public Fagregar_venta()
        {
            InitializeComponent();
            inicializar_cabecera();
        
            
        }

       

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tidvendedor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tnombrevendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void inicializar_cabecera()
        {
            // cargar productos 
            




            //tnombre.Text = usuario.nombre;
            tfecha.Text = DateTime.Today.Date.ToString("d");
            lvendedor.Text = CapaEntidad.Cache.UserLoginCache.nombre.Trim()+" "+ CapaEntidad.Cache.UserLoginCache.apellido.Trim();
            tidvendedor.Text = CapaEntidad.Cache.UserLoginCache.id_usuario.ToString();
            //cargar combobox clientes

            cliente.obtener_clientes();
            List<string> datos_clientes = cliente.obtener_clientes();
            cbcliente.DataSource = datos_clientes;
            cbcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente.obtener_clientes();

            //cargar combobox tipospagos

            cliente.obtener_clientes();
            List<string> tipospagos = cliente.obtener_tipo_pago();
            cbtipopago.DataSource = tipospagos;
            cbtipopago.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente.obtener_tipo_pago();

            //cargar combobox productos

           

           


        }

    

        private void cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void agregar_elemento()
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bbuscarproducto_Click(object sender, EventArgs e)
        {
            
            //
               
            
        }

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {
            dgproductos.DataSource = productoventa.ConsultaDT();
        }

        private void dgproductos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            if (dgproductos.Columns[e.ColumnIndex].Name == "agregar" && this.dgproductos.CurrentRow.Index != -1)
            {
                posicion = dgproductos.CurrentRow.Index;
                tprecio.Text = dgproductos[4, posicion].Value.ToString();
                tstock.Text = dgproductos[5, posicion].Value.ToString();
                tnombre.Text = dgproductos[2, posicion].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Fdatagridproductos formulariodg = new Fdatagridproductos();
           // formulariodg.Show();
        }

        private void bagregarproducto_Click(object sender, EventArgs e)
        {
            int n = dgdetalle.Rows.Add();
            //Anadimos registros al data grid


            dgdetalle.Rows[n].Cells[0].Value = tnombre.Text;
            dgdetalle.Rows[n].Cells[1].Value = tprecio.Text;
            dgdetalle.Rows[n].Cells[2].Value = nucantidad.Text;
            //dgproductos.Rows[n].Cells[4].Value = Tuser.Text;

            //scroll automatico del dg
            dgdetalle.FirstDisplayedScrollingRowIndex = dgdetalle.RowCount - 1;
        }
    }
}
