namespace SportsOn.Empleado.Ventas
{
    partial class FbuscarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FbuscarVenta));
            dataGridView1 = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            tb_fecha = new TextBox();
            Bbuscar = new Button();
            Tid_venta = new TextBox();
            Tb_vendedor = new TextBox();
            Lindex = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_cliente, nombre, apellido, dni, domicilio, Accion });
            dataGridView1.Location = new Point(79, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 261);
            dataGridView1.TabIndex = 54;
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "ID Cliente";
            id_cliente.Name = "id_cliente";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Domicilio";
            domicilio.Name = "domicilio";
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            // 
            // tb_fecha
            // 
            tb_fecha.AcceptsReturn = true;
            tb_fecha.Location = new Point(79, 143);
            tb_fecha.Name = "tb_fecha";
            tb_fecha.PlaceholderText = "Buscar por fecha ";
            tb_fecha.Size = new Size(218, 23);
            tb_fecha.TabIndex = 55;
            // 
            // Bbuscar
            // 
            Bbuscar.FlatAppearance.BorderSize = 0;
            Bbuscar.FlatStyle = FlatStyle.Flat;
            Bbuscar.Image = (Image)resources.GetObject("Bbuscar.Image");
            Bbuscar.Location = new Point(610, 96);
            Bbuscar.Name = "Bbuscar";
            Bbuscar.Size = new Size(112, 81);
            Bbuscar.TabIndex = 53;
            Bbuscar.UseVisualStyleBackColor = true;
            // 
            // Tid_venta
            // 
            Tid_venta.Location = new Point(79, 63);
            Tid_venta.Name = "Tid_venta";
            Tid_venta.PlaceholderText = "ID venta";
            Tid_venta.Size = new Size(218, 23);
            Tid_venta.TabIndex = 52;
            // 
            // Tb_vendedor
            // 
            Tb_vendedor.AcceptsReturn = true;
            Tb_vendedor.Location = new Point(79, 103);
            Tb_vendedor.Name = "Tb_vendedor";
            Tb_vendedor.PlaceholderText = "Buscar por vendedor";
            Tb_vendedor.Size = new Size(218, 23);
            Tb_vendedor.TabIndex = 51;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.BackColor = SystemColors.Highlight;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(326, 6);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(219, 51);
            Lindex.TabIndex = 50;
            Lindex.Text = "Buscar Venta";
            // 
            // FbuscarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tb_fecha);
            Controls.Add(Bbuscar);
            Controls.Add(Tid_venta);
            Controls.Add(Tb_vendedor);
            Controls.Add(Lindex);
            Name = "FbuscarVenta";
            Text = "FbuscarVenta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn domicilio;
        private DataGridViewTextBoxColumn Accion;
        private TextBox tb_fecha;
        private Button Bbuscar;
        private TextBox Tid_venta;
        private TextBox Tb_vendedor;
        private Label Lindex;
    }
}