namespace SportsOn.Administrador.Compras
{
    partial class Fagregar_compra
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_compra));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Lindex = new Label();
            groupBox1 = new GroupBox();
            cbtalle = new ComboBox();
            Tmonto = new TextBox();
            Bagregar_compra = new Button();
            Tcantidad = new TextBox();
            CBproveedor = new ComboBox();
            Tdesc = new TextBox();
            Tproducto = new TextBox();
            groupBox2 = new GroupBox();
            bbuscar = new Button();
            TBdni = new TextBox();
            TBusername = new TextBox();
            dg_compras = new DataGridView();
            id_compra = new DataGridViewTextBoxColumn();
            nombre_producto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            talle = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            Eproducto = new ErrorProvider(components);
            Ecantidad = new ErrorProvider(components);
            Edesc = new ErrorProvider(components);
            Etalle = new ErrorProvider(components);
            Emontototal = new ErrorProvider(components);
            Eproveedor = new ErrorProvider(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            monto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_compras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Emontototal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).BeginInit();
            SuspendLayout();
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(323, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(303, 51);
            Lindex.TabIndex = 31;
            Lindex.Text = "Gestionar Compras";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbtalle);
            groupBox1.Controls.Add(Tmonto);
            groupBox1.Controls.Add(Bagregar_compra);
            groupBox1.Controls.Add(Tcantidad);
            groupBox1.Controls.Add(CBproveedor);
            groupBox1.Controls.Add(Tdesc);
            groupBox1.Controls.Add(Tproducto);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 266);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Compra";
            // 
            // cbtalle
            // 
            cbtalle.FormattingEnabled = true;
            cbtalle.Location = new Point(377, 76);
            cbtalle.Name = "cbtalle";
            cbtalle.Size = new Size(265, 29);
            cbtalle.TabIndex = 35;
            cbtalle.Text = "Talle";
            // 
            // Tmonto
            // 
            Tmonto.Location = new Point(377, 133);
            Tmonto.Name = "Tmonto";
            Tmonto.PlaceholderText = "Monto total de la compra ";
            Tmonto.Size = new Size(265, 29);
            Tmonto.TabIndex = 34;
            Tmonto.TabStop = false;
            Tmonto.KeyPress += Tmonto_KeyPress;
            // 
            // Bagregar_compra
            // 
            Bagregar_compra.BackColor = Color.Transparent;
            Bagregar_compra.Cursor = Cursors.Hand;
            Bagregar_compra.FlatAppearance.BorderSize = 0;
            Bagregar_compra.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bagregar_compra.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bagregar_compra.FlatStyle = FlatStyle.Flat;
            Bagregar_compra.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar_compra.Image = (Image)resources.GetObject("Bagregar_compra.Image");
            Bagregar_compra.ImageAlign = ContentAlignment.TopCenter;
            Bagregar_compra.Location = new Point(760, 53);
            Bagregar_compra.Name = "Bagregar_compra";
            Bagregar_compra.Size = new Size(76, 72);
            Bagregar_compra.TabIndex = 30;
            Bagregar_compra.UseVisualStyleBackColor = false;
            Bagregar_compra.Click += Bagregar_compra_Click;
            // 
            // Tcantidad
            // 
            Tcantidad.Location = new Point(19, 76);
            Tcantidad.Name = "Tcantidad";
            Tcantidad.PlaceholderText = "Cantidad";
            Tcantidad.Size = new Size(265, 29);
            Tcantidad.TabIndex = 32;
            Tcantidad.KeyPress += Tcantidad_KeyPress;
            // 
            // CBproveedor
            // 
            CBproveedor.FormattingEnabled = true;
            CBproveedor.Location = new Point(19, 133);
            CBproveedor.Name = "CBproveedor";
            CBproveedor.Size = new Size(265, 29);
            CBproveedor.TabIndex = 26;
            CBproveedor.Text = "Proveedor";
            // 
            // Tdesc
            // 
            Tdesc.Location = new Point(377, 33);
            Tdesc.Name = "Tdesc";
            Tdesc.PlaceholderText = "Descripcion";
            Tdesc.Size = new Size(265, 29);
            Tdesc.TabIndex = 22;
            // 
            // Tproducto
            // 
            Tproducto.BackColor = Color.White;
            Tproducto.Location = new Point(19, 33);
            Tproducto.Name = "Tproducto";
            Tproducto.PlaceholderText = "Producto";
            Tproducto.Size = new Size(265, 29);
            Tproducto.TabIndex = 21;
            Tproducto.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(TBdni);
            groupBox2.Controls.Add(TBusername);
            groupBox2.Controls.Add(dg_compras);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 352);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Compras";
            // 
            // bbuscar
            // 
            bbuscar.Location = new Point(533, 27);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(130, 29);
            bbuscar.TabIndex = 43;
            bbuscar.Text = "Buscar";
            bbuscar.UseVisualStyleBackColor = true;
            // 
            // TBdni
            // 
            TBdni.AcceptsReturn = true;
            TBdni.Location = new Point(276, 28);
            TBdni.Name = "TBdni";
            TBdni.PlaceholderText = "Buscar por DNI";
            TBdni.Size = new Size(218, 29);
            TBdni.TabIndex = 42;
            // 
            // TBusername
            // 
            TBusername.Location = new Point(6, 28);
            TBusername.Name = "TBusername";
            TBusername.PlaceholderText = "Buscar por nombre de usuario";
            TBusername.Size = new Size(218, 29);
            TBusername.TabIndex = 41;
            // 
            // dg_compras
            // 
            dg_compras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dg_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_compras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dg_compras.BackgroundColor = SystemColors.MenuHighlight;
            dg_compras.BorderStyle = BorderStyle.Fixed3D;
            dg_compras.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dg_compras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_compras.Columns.AddRange(new DataGridViewColumn[] { id_compra, nombre_producto, descripcion, talle, proveedor, monto });
            dg_compras.Location = new Point(6, 66);
            dg_compras.Name = "dg_compras";
            dg_compras.RowTemplate.Height = 25;
            dg_compras.ScrollBars = ScrollBars.Vertical;
            dg_compras.Size = new Size(928, 263);
            dg_compras.TabIndex = 38;
            // 
            // id_compra
            // 
            id_compra.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id_compra.HeaderText = "ID COMPRA";
            id_compra.Name = "id_compra";
            id_compra.Width = 119;
            // 
            // nombre_producto
            // 
            nombre_producto.HeaderText = "PRODUCTO";
            nombre_producto.Name = "nombre_producto";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // talle
            // 
            talle.HeaderText = "Talle";
            talle.Name = "talle";
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            // 
            // Eproducto
            // 
            Eproducto.ContainerControl = this;
            // 
            // Ecantidad
            // 
            Ecantidad.ContainerControl = this;
            // 
            // Edesc
            // 
            Edesc.ContainerControl = this;
            // 
            // Etalle
            // 
            Etalle.ContainerControl = this;
            // 
            // Emontototal
            // 
            Emontototal.ContainerControl = this;
            // 
            // Eproveedor
            // 
            Eproveedor.ContainerControl = this;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            // 
            // Fagregar_compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Name = "Fagregar_compra";
            Text = "Fagregar_compra";
            Load += Fagregar_compra_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_compras).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Emontototal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lindex;
        private GroupBox groupBox1;
        private TextBox Tmonto;
        private Button Bagregar_compra;
        private TextBox Tcantidad;
        private ComboBox CBproveedor;
        private TextBox Tdesc;
        private TextBox Tproducto;
        private GroupBox groupBox2;
        private Button bbuscar;
        private TextBox TBdni;
        private TextBox TBusername;
        private DataGridView dg_compras;
        private ComboBox cbtalle;
        private ErrorProvider Eproducto;
        private ErrorProvider Ecantidad;
        private ErrorProvider Edesc;
        private ErrorProvider Etalle;
        private ErrorProvider Emontototal;
        private ErrorProvider Eproveedor;
        private DataGridViewTextBoxColumn id_compra;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn talle;
        private DataGridViewTextBoxColumn proveedor;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn monto;
    }
}