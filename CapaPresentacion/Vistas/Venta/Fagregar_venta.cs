using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Cache;
using CapaNegocio;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.html;

namespace CapaPresentacion.Vistas.Venta
{
    public partial class Fagregar_venta : Form
    {
      
        CN_VENTA cliente = new CN_VENTA();
        CN_PRODUCTO productoventa = new CN_PRODUCTO();

        decimal preciototal = 0;

        public Fagregar_venta()
        {
            InitializeComponent();
            inicializar_cabecera();


        }

       

    //declaramos el total 
    decimal total = 0;

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
            tidfactura.Text = cliente.ObtenerSiguienteNumeroFactura().ToString();
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

            tcantidad.Text = "1";
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
                tbuscarid.Text = dgproductos[1,posicion].Value.ToString();
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

            if (tcantidad.Text.Trim() == String.Empty || tprecio.Text.Trim() == String.Empty || tnombre.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Seleccione un producto!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }           
            else
            {
                if (Int32.Parse(tcantidad.Text) == 0 )
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(Int32.Parse(tstock.Text) < Int32.Parse(tcantidad.Text))
                    {
                        MessageBox.Show("No hay stock disponible!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int n = dgdetalle.Rows.Add();

                        // Anadimos registros al data grid
                        cliente.restar_stock(Int32.Parse(tstock.Text) ,Int32.Parse(tcantidad.Text),Int32.Parse (tbuscarid.Text));
                        dgdetalle.Rows[n].Cells[0].Value = tbuscarid.Text;
                        dgdetalle.Rows[n].Cells[1].Value = tnombre.Text;
                        dgdetalle.Rows[n].Cells[2].Value = tprecio.Text;
                        dgdetalle.Rows[n].Cells[3].Value = tcantidad.Text;

                        // Calcular el subtotal para la nueva fila
                        decimal precio = decimal.Parse(tprecio.Text);
                        int cantidad = Int32.Parse(tcantidad.Text);
                        decimal subtotal = precio * cantidad;

                        dgdetalle.Rows[n].Cells[4].Value = subtotal;

                        // Recorremos el datagrid para calcular el total
                        decimal total = 0;
                        foreach (DataGridViewRow fila in dgdetalle.Rows)
                        {
                            if (!fila.IsNewRow && fila.Cells["Subtotal"].Value != null)
                            {
                                // Convertir el valor de la celda a decimal y acumularlo.
                                total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                            }
                        }

                        lprecio.Text = " " + total.ToString("C0", new System.Globalization.CultureInfo("es-MX")); // Mostrar el total con formato de moneda.

                        // Limpiar campos y ajustar el valor predeterminado de la cantidad.
                        tcantidad.Text = "1";
                        tnombre.Clear();
                        tprecio.Clear();
                        tstock.Clear();
                        tbuscarid.Clear();
                        //consultamos de nuevo para actualizar el stock
                        dgproductos.DataSource = productoventa.ConsultaDT();
                    }
                    

                }
                
            }
           
        }

        private void tcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ecantidad.SetError(tcantidad, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }
        private void dgdetalle_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgdetalle.Columns["eliminar"].Index && e.RowIndex >= 0)
            {
              //  int n = dgdetalle.CurrentRow.Index;
               // cliente.sumar_stock(Convert.ToInt32(tstock.Text), Convert.ToInt32(dgdetalle.Rows[n].Cells[3].Value), Convert.ToInt32(dgdetalle.Rows[n].Cells[0].Value));
                dgdetalle.Rows.RemoveAt(e.RowIndex);
            }

            foreach (DataGridViewRow fila in dgdetalle.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["Subtotal"].Value != null)
                {
                    // Convertir el valor de la celda a decimal y acumularlo.
                    total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                }
            }
        }

        private void Bgenerarventa_Click(object sender, EventArgs e)
        {
         
            int cantidad_registros = 0;
            if (dgdetalle.RowCount == 0)
            {

                MessageBox.Show("Ingrese al menos un producto!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                cantidad_registros= dgdetalle.RowCount;
                cliente.registrar_cabecera(Int32.Parse(tidvendedor.Text) , cbcliente.SelectedIndex,cbtipopago.SelectedIndex, DateTime.Parse(tfecha.Text));
                int idcabecera = cliente.ObtenerSiguienteNumeroFactura();
                
                for (int i = 0; i < dgdetalle.Rows.Count; i++)
                {
                    DataGridViewRow fila = dgdetalle.Rows[i];

                    // Obtener los valores de las celdas
                    int id_producto = Convert.ToInt32(fila.Cells["idproducto"].Value);
                    string producto = Convert.ToString(fila.Cells["Producto"].Value);
                    decimal precioUnitario = Convert.ToDecimal(fila.Cells["precio"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    decimal subtotal = Convert.ToDecimal(fila.Cells["subtotal"].Value);
                    preciototal += Convert.ToDecimal(fila.Cells["subtotal"].Value);

                    cliente.resgistrar_detalle(cliente.ObtenerSiguienteNumeroFactura() - 1, id_producto, producto, precioUnitario, cantidad, subtotal, preciototal);
                    
                }

                MessageBox.Show("Venta generada con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*================= IMPRESION DEL TICKET  ====================*/

                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = ("factura_"+ (cliente.ObtenerSiguienteNumeroFactura()-1).ToString()+".pdf");

                

                string paginahtml =Properties.Resources.plamtilla.ToString();
                paginahtml = paginahtml.Replace("@idcabecera",(cliente.ObtenerSiguienteNumeroFactura() - 1).ToString());
                paginahtml = paginahtml.Replace("@tipo_de_pago",cbtipopago.Text);
                paginahtml = paginahtml.Replace("@CLIENTE", cbcliente.Text);
                paginahtml = paginahtml.Replace("@FECHA", tfecha.Text);

                string filas = string.Empty;


                foreach (DataGridViewRow row in dgdetalle.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                   
                    filas += "</tr>";
                  
                }
                paginahtml = paginahtml.Replace("@FILAS", filas);
                paginahtml = paginahtml.Replace("@TOTAL", preciototal.ToString());

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdf,stream);

                        pdf.Open();
                        pdf.Add(new Phrase(""));

                        using (StringReader sr = new StringReader(paginahtml))
                        {

                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);



                        }



                            pdf.Close();
                        stream.Close();
                    }
                       



                }


            }
        }

        private void pdfactura_PrintPage(object sender, PrintPageEventArgs e)
        {
          

        }

        private void bcancelarventa_Click(object sender, EventArgs e)
        {
           

            DialogResult resultado = MessageBox.Show("Seguro que quiere cancelar la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Venta cancelada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgdetalle.Rows.Clear();
                this.Close();

            }
            //si la venta es cancelada reponemos el stock 

        }

        private void tbuscarid_TextChanged(object sender, EventArgs e)
        {
            string valorBuscado = "" + tbuscarid.Text;

            // Si estás usando un BindingSource
            int rowIndex = -1;

            foreach (DataGridViewRow fila in dgproductos.Rows)
            {
                if (fila.Cells["id_producto"].Value != null && fila.Cells["id_producto"].Value.ToString() == valorBuscado)
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

        private void tbuscarid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                ebuscarid.SetError(tbuscarid, "Solo numeros!");
                e.Handled = true;
                return;

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
