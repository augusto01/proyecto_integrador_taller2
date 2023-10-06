namespace SportsOn.Gerente.Producto
{
    partial class Fagregar_producto_ger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_producto_ger));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Eprecio = new ErrorProvider(components);
            Lmoneda = new Label();
            Tprecio = new TextBox();
            groupBox1 = new GroupBox();
            editarProducto = new Button();
            CBtalle = new ComboBox();
            Bagregar = new Button();
            Tcantidad = new TextBox();
            Tproveedor = new TextBox();
            CBcategoria = new ComboBox();
            Tdescripcion = new TextBox();
            TBnombre = new TextBox();
            dg_eliminar = new DataGridViewImageColumn();
            dg_editar = new DataGridViewImageColumn();
            dg_proveedor = new DataGridViewTextBoxColumn();
            dg_precio = new DataGridViewTextBoxColumn();
            dg_cateogoria = new DataGridViewTextBoxColumn();
            dg_talle = new DataGridViewTextBoxColumn();
            dg_cantidad = new DataGridViewTextBoxColumn();
            dg_descripcion = new DataGridViewTextBoxColumn();
            dg_nombre = new DataGridViewTextBoxColumn();
            dg_id_producto = new DataGridViewTextBoxColumn();
            bbuscar = new Button();
            dg_producto = new DataGridView();
            Lindex = new Label();
            Enombre = new ErrorProvider(components);
            Edesc = new ErrorProvider(components);
            Ecantidad = new ErrorProvider(components);
            Eproveedor = new ErrorProvider(components);
            Ecategoria = new ErrorProvider(components);
            Etalle = new ErrorProvider(components);
            Tnombre = new TextBox();
            TBidproducto = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Eprecio).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_producto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Eprecio
            // 
            Eprecio.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eprecio.ContainerControl = this;
            Eprecio.Icon = (Icon)resources.GetObject("Eprecio.Icon");
            // 
            // Lmoneda
            // 
            Lmoneda.AutoSize = true;
            Lmoneda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lmoneda.ForeColor = Color.Lime;
            Lmoneda.Location = new Point(759, 24);
            Lmoneda.Name = "Lmoneda";
            Lmoneda.Size = new Size(49, 21);
            Lmoneda.TabIndex = 51;
            Lmoneda.Text = "ARS$";
            // 
            // Tprecio
            // 
            Tprecio.Location = new Point(580, 22);
            Tprecio.Name = "Tprecio";
            Tprecio.PlaceholderText = "Precio";
            Tprecio.Size = new Size(135, 23);
            Tprecio.TabIndex = 50;
            Tprecio.KeyPress += Tprecio_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Lmoneda);
            groupBox1.Controls.Add(Tprecio);
            groupBox1.Controls.Add(editarProducto);
            groupBox1.Controls.Add(CBtalle);
            groupBox1.Controls.Add(Bagregar);
            groupBox1.Controls.Add(Tcantidad);
            groupBox1.Controls.Add(Tproveedor);
            groupBox1.Controls.Add(CBcategoria);
            groupBox1.Controls.Add(Tdescripcion);
            groupBox1.Controls.Add(TBnombre);
            groupBox1.Location = new Point(21, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(928, 145);
            groupBox1.TabIndex = 53;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // editarProducto
            // 
            editarProducto.BackColor = Color.Transparent;
            editarProducto.Cursor = Cursors.Hand;
            editarProducto.FlatAppearance.BorderSize = 0;
            editarProducto.FlatAppearance.MouseDownBackColor = Color.Transparent;
            editarProducto.FlatAppearance.MouseOverBackColor = Color.Transparent;
            editarProducto.FlatStyle = FlatStyle.Flat;
            editarProducto.ForeColor = SystemColors.ActiveCaptionText;
            editarProducto.Image = (Image)resources.GetObject("editarProducto.Image");
            editarProducto.ImageAlign = ContentAlignment.TopCenter;
            editarProducto.Location = new Point(732, 48);
            editarProducto.Name = "editarProducto";
            editarProducto.Size = new Size(76, 72);
            editarProducto.TabIndex = 49;
            editarProducto.UseVisualStyleBackColor = false;
            editarProducto.Visible = false;
            editarProducto.Click += editarProducto_Click_1;
            // 
            // CBtalle
            // 
            CBtalle.FormattingEnabled = true;
            CBtalle.Location = new Point(309, 66);
            CBtalle.Name = "CBtalle";
            CBtalle.Size = new Size(265, 23);
            CBtalle.TabIndex = 48;
            CBtalle.Text = "Talle";
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.Transparent;
            Bagregar.Cursor = Cursors.Hand;
            Bagregar.FlatAppearance.BorderSize = 0;
            Bagregar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bagregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bagregar.FlatStyle = FlatStyle.Flat;
            Bagregar.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar.Image = (Image)resources.GetObject("Bagregar.Image");
            Bagregar.ImageAlign = ContentAlignment.TopCenter;
            Bagregar.Location = new Point(732, 48);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 44;
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Tcantidad
            // 
            Tcantidad.Location = new Point(9, 66);
            Tcantidad.Name = "Tcantidad";
            Tcantidad.PlaceholderText = "Cantidad";
            Tcantidad.Size = new Size(265, 23);
            Tcantidad.TabIndex = 47;
            Tcantidad.KeyPress += Tcantidad_KeyPress;
            // 
            // Tproveedor
            // 
            Tproveedor.Location = new Point(309, 112);
            Tproveedor.Name = "Tproveedor";
            Tproveedor.PlaceholderText = "Proveedor";
            Tproveedor.Size = new Size(265, 23);
            Tproveedor.TabIndex = 46;
            Tproveedor.TabStop = false;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(9, 112);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 41;
            CBcategoria.Text = "Categoria";
            // 
            // Tdescripcion
            // 
            Tdescripcion.Location = new Point(309, 22);
            Tdescripcion.Name = "Tdescripcion";
            Tdescripcion.PlaceholderText = "Descripcion";
            Tdescripcion.Size = new Size(265, 23);
            Tdescripcion.TabIndex = 37;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(9, 22);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 36;
            TBnombre.TabStop = false;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // dg_eliminar
            // 
            dg_eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg_eliminar.HeaderText = "Eliminar";
            dg_eliminar.Image = Properties.Resources.eliminar;
            dg_eliminar.Name = "dg_eliminar";
            dg_eliminar.Width = 56;
            // 
            // dg_editar
            // 
            dg_editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg_editar.HeaderText = "Editar";
            dg_editar.Image = Properties.Resources.lapiz;
            dg_editar.Name = "dg_editar";
            dg_editar.Resizable = DataGridViewTriState.True;
            dg_editar.SortMode = DataGridViewColumnSortMode.Automatic;
            dg_editar.Width = 62;
            // 
            // dg_proveedor
            // 
            dg_proveedor.HeaderText = "Proveedor";
            dg_proveedor.Name = "dg_proveedor";
            // 
            // dg_precio
            // 
            dg_precio.HeaderText = "Precio";
            dg_precio.Name = "dg_precio";
            // 
            // dg_cateogoria
            // 
            dg_cateogoria.HeaderText = "Categoria";
            dg_cateogoria.Name = "dg_cateogoria";
            // 
            // dg_talle
            // 
            dg_talle.HeaderText = "Talle";
            dg_talle.Name = "dg_talle";
            // 
            // dg_cantidad
            // 
            dg_cantidad.HeaderText = "Cantidad";
            dg_cantidad.Name = "dg_cantidad";
            // 
            // dg_descripcion
            // 
            dg_descripcion.HeaderText = "Descripcion";
            dg_descripcion.Name = "dg_descripcion";
            // 
            // dg_nombre
            // 
            dg_nombre.HeaderText = "Nombre";
            dg_nombre.Name = "dg_nombre";
            // 
            // dg_id_producto
            // 
            dg_id_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dg_id_producto.HeaderText = "ID Producto";
            dg_id_producto.Name = "dg_id_producto";
            dg_id_producto.Width = 95;
            // 
            // bbuscar
            // 
            bbuscar.Location = new Point(497, 17);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(129, 23);
            bbuscar.TabIndex = 43;
            bbuscar.Text = "Buscar";
            bbuscar.UseVisualStyleBackColor = true;
            // 
            // dg_producto
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dg_producto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_producto.BackgroundColor = SystemColors.MenuHighlight;
            dg_producto.BorderStyle = BorderStyle.Fixed3D;
            dg_producto.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dg_producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_producto.Columns.AddRange(new DataGridViewColumn[] { dg_id_producto, dg_nombre, dg_descripcion, dg_cantidad, dg_talle, dg_cateogoria, dg_precio, dg_proveedor, dg_editar, dg_eliminar });
            dg_producto.Location = new Point(-40, 62);
            dg_producto.Name = "dg_producto";
            dg_producto.RowTemplate.Height = 25;
            dg_producto.ScrollBars = ScrollBars.Vertical;
            dg_producto.Size = new Size(968, 340);
            dg_producto.TabIndex = 38;
            dg_producto.CellClick += dg_producto_CellClick;
            dg_producto.CellContentClick += dg_producto_CellContentClick;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(370, 26);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(307, 51);
            Lindex.TabIndex = 51;
            Lindex.Text = "Gestionar Producto";
            // 
            // Enombre
            // 
            Enombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Enombre.ContainerControl = this;
            Enombre.Icon = (Icon)resources.GetObject("Enombre.Icon");
            // 
            // Edesc
            // 
            Edesc.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edesc.ContainerControl = this;
            Edesc.Icon = (Icon)resources.GetObject("Edesc.Icon");
            // 
            // Ecantidad
            // 
            Ecantidad.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecantidad.ContainerControl = this;
            Ecantidad.Icon = (Icon)resources.GetObject("Ecantidad.Icon");
            // 
            // Eproveedor
            // 
            Eproveedor.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproveedor.ContainerControl = this;
            Eproveedor.Icon = (Icon)resources.GetObject("Eproveedor.Icon");
            // 
            // Ecategoria
            // 
            Ecategoria.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecategoria.ContainerControl = this;
            Ecategoria.Icon = (Icon)resources.GetObject("Ecategoria.Icon");
            // 
            // Etalle
            // 
            Etalle.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etalle.ContainerControl = this;
            Etalle.Icon = (Icon)resources.GetObject("Etalle.Icon");
            // 
            // Tnombre
            // 
            Tnombre.AcceptsReturn = true;
            Tnombre.Location = new Point(257, 17);
            Tnombre.Name = "Tnombre";
            Tnombre.PlaceholderText = "Buscar por nombre";
            Tnombre.Size = new Size(218, 23);
            Tnombre.TabIndex = 42;
            // 
            // TBidproducto
            // 
            TBidproducto.Location = new Point(6, 17);
            TBidproducto.Name = "TBidproducto";
            TBidproducto.PlaceholderText = "Buscar por id Producto";
            TBidproducto.Size = new Size(218, 23);
            TBidproducto.TabIndex = 41;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(Tnombre);
            groupBox2.Controls.Add(TBidproducto);
            groupBox2.Controls.Add(dg_producto);
            groupBox2.Location = new Point(21, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(928, 402);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Usuarios";
            // 
            // Fagregar_producto_ger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Controls.Add(groupBox2);
            Name = "Fagregar_producto_ger";
            Text = "Fagregar_producto_ger";
            Load += Fagregar_producto_ger_Load;
            ((System.ComponentModel.ISupportInitialize)Eprecio).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_producto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider Eprecio;
        private GroupBox groupBox1;
        private Label Lmoneda;
        private TextBox Tprecio;
        private Button editarProducto;
        private ComboBox CBtalle;
        private Button Bagregar;
        private TextBox Tcantidad;
        private TextBox Tproveedor;
        private ComboBox CBcategoria;
        private TextBox Tdescripcion;
        private TextBox TBnombre;
        private Label Lindex;
        private GroupBox groupBox2;
        private Button bbuscar;
        private TextBox Tnombre;
        private TextBox TBidproducto;
        private DataGridView dg_producto;
        private DataGridViewTextBoxColumn dg_id_producto;
        private DataGridViewTextBoxColumn dg_nombre;
        private DataGridViewTextBoxColumn dg_descripcion;
        private DataGridViewTextBoxColumn dg_cantidad;
        private DataGridViewTextBoxColumn dg_talle;
        private DataGridViewTextBoxColumn dg_cateogoria;
        private DataGridViewTextBoxColumn dg_precio;
        private DataGridViewTextBoxColumn dg_proveedor;
        private DataGridViewImageColumn dg_editar;
        private DataGridViewImageColumn dg_eliminar;
        private ErrorProvider Enombre;
        private ErrorProvider Edesc;
        private ErrorProvider Ecantidad;
        private ErrorProvider Eproveedor;
        private ErrorProvider Ecategoria;
        private ErrorProvider Etalle;
    }
}