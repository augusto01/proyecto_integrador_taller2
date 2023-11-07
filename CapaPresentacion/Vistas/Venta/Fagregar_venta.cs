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

            nucantidad.Value = 1;
            tidfactura.Text =  cliente.ObtenerSiguienteNumeroFactura().ToString();
            double precio;
            lprecio.Text = (0).ToString("C");
           


        }

        private void Fagregar_venta_Load(object sender, EventArgs e)
        {
            dgproductos.DataSource = productoventa.ConsultaDT();
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

        private void dgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgproductos.Columns[e.ColumnIndex].Name == "agregarproducto" && this.dgproductos.CurrentRow.Index != -1)
            {/*
                // Obtiene la fila seleccionada en el dataGridView1
                DataGridViewRow registroseleccionado = dgproductos.Rows[e.RowIndex];

                // Clona la fila para copiarla al dataGridView2
                DataGridViewRow newRow = (DataGridViewRow)registroseleccionado.Clone();
                foreach (DataGridViewCell cell in registroseleccionado.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }

                // Agrega la fila clonada al dataGridView2*/
                // Obtiene la fila seleccionada en el dataGridView1
                DataGridViewRow selectedRow = dgproductos.Rows[e.RowIndex];

                // Clona la fila para copiarla al dataGridView2
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

                // Añade la fila clonada al dataGridView2
                dgdetalle.Rows.Add(newRow);

                // Copia el contenido de las celdas
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = selectedRow.Cells[i].Value;
                }
                dgdetalle.Rows.Add(newRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgproductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgproductos.SelectedRows[0];

                // Asegúrate de que dataGridView2 tenga las mismas columnas que dataGridView1
                if (dgdetalle.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn column in dgproductos.Columns)
                    {
                        dgdetalle.Columns.Add(column.Name, column.HeaderText);
                    }
                }

                // Obtiene el índice de la columna "Cantidad" en dataGridView1
                int stockdisponible = dgproductos.Columns["stock"].Index;

                // Obtiene el valor de la celda "Cantidad" en la fila seleccionada
                int cantidadValue;
                if (int.TryParse(selectedRow.Cells[stockdisponible].Value.ToString(), out cantidadValue))
                {
                    int cantidad = (int)nucantidad.Value;  // Establece aquí el valor límite que desees

                    // Realiza la validación
                    if (cantidad > stockdisponible)
                    {
                        // Muestra un mensaje de advertencia
                        MessageBox.Show("La cantidad a vender supera el stock disponible!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // No copia la fila si no cumple con la validación
                    }

                    // Clona la fila y la agrega a dataGridView2 si pasa la validación
                    object[] rowData = new object[selectedRow.Cells.Count];
                    for (int i = 0; i < selectedRow.Cells.Count; i++)
                    {
                        rowData[i] = selectedRow.Cells[i].Value;
                    }
                    dgdetalle.Rows.Add(rowData);

                }
            }
        }
    }
}
