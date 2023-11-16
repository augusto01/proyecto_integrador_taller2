using CapaNegocio;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fable.Import.Browser;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Gerente.Producto
{
    public partial class Fagregar_producto : Form
    {

        CN_PRODUCTO producto = new CN_PRODUCTO();
        CN_CATEGORIA categoria = new CN_CATEGORIA();
        CN_TALLE talle = new CN_TALLE();
        CN_PROVEEDOR proveedor = new CN_PROVEEDOR();
        
        public Fagregar_producto()
        {
            InitializeComponent();
                 inicializartipobusqueda();
        }

        String[] tipobusqueda = { "id_producto", "Producto" };
        private void inicializartipobusqueda()
        {
            int i;

            for (i = 0; i < tipobusqueda.Length; i++)
            {
                cbbuscarpor.Items.Add(tipobusqueda[i]);
            }

            cbbuscarpor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void tstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                estock.SetError(tstock, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }
        public void cargar_combo_box()
        {
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtalle.DropDownStyle = ComboBoxStyle.DropDownList;

            //categoria
            categoria.obtener_categorias();
            List<string> datos = categoria.obtener_categorias();
            cbcategoria.DataSource = datos;

            //talle
            talle.obtener_talles();
            List<string> datos_talle = talle.obtener_talles();
            cbtalle.DataSource = datos_talle;

            //proveedor
            proveedor.obtener_proveedores();
            List<string> datos_proveedor = proveedor.obtener_proveedores();
            cbproveedor.DataSource = datos_proveedor;

        }
        
        private void Fagregar_producto_Load(object sender, EventArgs e)

        {
           
            dgproductos.DataSource = producto.ConsultaDT();
            cargar_combo_box();
            cbcategoria.SelectedItem = null;
            cbtalle.SelectedItem = null;
            cbproveedor.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(tdesctalle.Text.Trim() == string.Empty)
            {
                edesctalle.SetError(tdesctalle, "Campo Obligatorio!!");
            }
            else
            {

               talle.insertar_talle(tdesctalle.Text);
               MessageBox.Show("El talle : " +tdesctalle.Text+" se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cargar_combo_box();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tcategoria.Text.Trim() == string.Empty)
            {
                ecategoria.SetError(tcategoria, "Campo Obligatorio!!");
            }
            else
            {
                categoria.insertar_categoria(tcategoria.Text);
                MessageBox.Show("La categoria : " + tcategoria.Text + " se agrego correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar_combo_box();
            }
        }

        private void Bagregar_Click(object sender, EventArgs e)
        {
            if (tdesc.Text == String.Empty || tprecio.Text == String.Empty || tstock.Text == String.Empty)
            {
                MessageBox.Show("Falta Completar Campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                if (tprecio.Text.Trim() == String.Empty)
                {
                    eprecio.SetError(tprecio, "Campo Obligatorio!");
                }

                if (tdesc.Text.Trim() == String.Empty)
                {
                    edesc.SetError(tdesc, "Campo Obligatorio!!");
                }

                if (tstock.Text.Trim() == String.Empty)
                {
                    edesc.SetError(tstock, "Campo Obligatorio!!");
                }


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Seguro quiere agregar el producto?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    producto.insertar_producto(tdesc.Text, float.Parse(tprecio.Text) , Int32.Parse(tstock.Text),cbtalle.SelectedIndex, cbcategoria.SelectedIndex, cbproveedor.SelectedIndex);
                    dgproductos.DataSource = producto.ConsultaDT();
                    MessageBox.Show("El producto se agrego correctamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   


                }
            }
          
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar el regsitro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                tdesc.Clear();
                tprecio.Clear();
                tstock.Clear();
                cbcategoria.SelectedItem = null;
                cbtalle.SelectedItem = null;
                cbproveedor.SelectedItem = null;

            }
        }

        private void cancelaredicion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere cancelar la edicion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                tdesc.Clear();
                tprecio.Clear();
                tstock.Clear();
                cbcategoria.SelectedItem = null;
                cbtalle.SelectedItem = null;
                cbproveedor.SelectedItem = null;
                cancelaredicion.Visible = false;
                beditar.Visible = false;
                bcancelar.Visible = true;

            }
        }


        private void editar_accion()
        {
            cancelaredicion.Visible = true;
            beditar.Visible = true;
            bcancelar.Visible = false;
          

        }
        private void dgproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductos.Columns[e.ColumnIndex].Name == "eliminar" && this.dgproductos.CurrentRow.Index != -1)
            {
                EliminarProducto();
            }
        }

        private void EliminarProducto()
        {
            CN_PRODUCTO producto = new CN_PRODUCTO();
            if (this.dgproductos.CurrentRow.Index != -1)
            {
                int posicion = dgproductos.CurrentRow.Index;
                DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    producto.eliminar_producto(Int32.Parse (dgproductos[2, posicion].Value.ToString()) );
                    this.dgproductos.Rows.RemoveAt(this.dgproductos.CurrentRow.Index);
                }
                else
                {
                    tdesc.Clear();
                    tprecio.Clear();
                    tstock.Clear();
                    cbcategoria.SelectedItem = null;
                    cbtalle.SelectedItem = null; 
                    cbproveedor.SelectedItem = null;
                     cancelaredicion.Visible = false;
                    beditar.Visible = false;
                    bcancelar.Visible = true;
                 
                }

            }
        }

        private void dgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgproductos.CurrentRow.Index != -1 && dgproductos.Columns[e.ColumnIndex].Index == 0)
            {
                int posicion;
                editar_accion();
                posicion = dgproductos.CurrentRow.Index;
                
                tdesc.Text = dgproductos[3, posicion].Value.ToString();
                cbtalle.Text = dgproductos[4, posicion].Value.ToString();
                tprecio.Text = dgproductos[5, posicion].Value.ToString();
                tstock.Text = dgproductos[6, posicion].Value.ToString();
                cbcategoria.Text = dgproductos[7, posicion].Value.ToString();
                cbproveedor.Text = dgproductos[8, posicion].Value.ToString();

            }
        }

        private void beditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro quiere editar el usuario?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int posicion;
                posicion = dgproductos.CurrentRow.Index;



                CN_PRODUCTO producto = new CN_PRODUCTO();
                    producto.modificar_producto(Int32.Parse((dgproductos[2, posicion].Value.ToString()) ), tdesc.Text, float.Parse(tprecio.Text) , Int32.Parse(tstock.Text) , cbtalle.SelectedIndex, cbcategoria.SelectedIndex, cbproveedor.SelectedIndex);
                    dgproductos.DataSource = producto.ConsultaDT();
                MessageBox.Show("El producto se edito correctamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tdesc.Clear();
                tprecio.Clear();
                tstock.Clear();
                cbcategoria.SelectedItem = null;
                cbtalle.SelectedItem = null;
                cbproveedor.SelectedItem = null;
                cancelaredicion.Visible = false;
                beditar.Visible = false;
                bcancelar.Visible = true;

                beditar.Visible = false;
         


            }
         
            
        }

        private void tprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                eprecio.SetError(tprecio, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            string valorBuscado = "" + tbuscarobjeto.Text;

            // Si estás usando un BindingSource
            int rowIndex = -1;

            foreach (DataGridViewRow fila in dgproductos.Rows)
            {
                if (fila.Cells["Producto"].Value != null && fila.Cells["Producto"].Value.ToString() == valorBuscado)
                {
                    rowIndex = fila.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                DataGridViewRow row = dgproductos.Rows[rowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                dgproductos.CurrentCell = dgproductos[0, rowIndex]; // Esto seleccionará la fila encontrada
            }
        }

        

        private void tbuscarobjeto_TextChanged_1(object sender, EventArgs e)
        {
            int rowIndex = -1;
            string columnaSeleccionada = cbbuscarpor.SelectedItem.ToString();
            foreach (DataGridViewRow fila in dgproductos.Rows)
            {
                if (fila.Cells[columnaSeleccionada].Value != null && fila.Cells[columnaSeleccionada].Value.ToString() == tbuscarobjeto.Text)
                {
                    rowIndex = fila.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                DataGridViewRow row = dgproductos.Rows[rowIndex];

                // Seleccionar toda la fila
                row.Selected = true;
                dgproductos.CurrentCell = dgproductos[0, rowIndex]; // Esto seleccionará la fila encontrada
            }
        }
    }
}




