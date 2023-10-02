namespace SportsOn.Empleado.Producto
{
    partial class FbuscarProductoEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FbuscarProductoEmp));
            dataGridView1 = new DataGridView();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            Bbuscar = new Button();
            Tuser = new TextBox();
            Tdni = new TextBox();
            Lindex = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_usuario, nombre, Descripcion, stock, proveedor, Accion });
            dataGridView1.Location = new Point(79, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 261);
            dataGridView1.TabIndex = 48;
            // 
            // id_usuario
            // 
            id_usuario.HeaderText = "id_producto";
            id_usuario.Name = "id_usuario";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            // 
            // Bbuscar
            // 
            Bbuscar.FlatAppearance.BorderSize = 0;
            Bbuscar.FlatStyle = FlatStyle.Flat;
            Bbuscar.Image = (Image)resources.GetObject("Bbuscar.Image");
            Bbuscar.Location = new Point(610, 68);
            Bbuscar.Name = "Bbuscar";
            Bbuscar.Size = new Size(112, 81);
            Bbuscar.TabIndex = 47;
            Bbuscar.UseVisualStyleBackColor = true;
            // 
            // Tuser
            // 
            Tuser.Location = new Point(79, 97);
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Nombre del producto";
            Tuser.Size = new Size(218, 23);
            Tuser.TabIndex = 46;
            // 
            // Tdni
            // 
            Tdni.AcceptsReturn = true;
            Tdni.Location = new Point(79, 126);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "ID del producto";
            Tdni.Size = new Size(218, 23);
            Tdni.TabIndex = 45;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.BackColor = SystemColors.Highlight;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(326, 6);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(265, 51);
            Lindex.TabIndex = 44;
            Lindex.Text = "Buscar Producto";
            // 
            // FbuscarProductoEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Bbuscar);
            Controls.Add(Tuser);
            Controls.Add(Tdni);
            Controls.Add(Lindex);
            Name = "FbuscarProductoEmp";
            Text = "FbuscarProductoEmp";
            Load += FbuscarProductoEmp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn Accion;
        private Button Bbuscar;
        private TextBox Tuser;
        private TextBox Tdni;
        private Label Lindex;
    }
}