namespace SportsOn.Gerente.Compra
{
    partial class Fagregar_compra_ger
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_compra_ger));
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Emontototal = new ErrorProvider(components);
            Etalle = new ErrorProvider(components);
            Edesc = new ErrorProvider(components);
            Ecantidad = new ErrorProvider(components);
            Eproducto = new ErrorProvider(components);
            monto = new DataGridViewTextBoxColumn();
            proveedor = new DataGridViewTextBoxColumn();
            talle = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            bbuscar = new Button();
            TBdni = new TextBox();
            TBusername = new TextBox();
            nombre_producto = new DataGridViewTextBoxColumn();
            dg_compras = new DataGridView();
            id_compra = new DataGridViewTextBoxColumn();
            Eproveedor = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            cbtalle = new ComboBox();
            Tmonto = new TextBox();
            Bagregar_compra = new Button();
            Tcantidad = new TextBox();
            CBproveedor = new ComboBox();
            Tdesc = new TextBox();
            Tproducto = new TextBox();
            groupBox1 = new GroupBox();
            Lindex = new Label();
            ((System.ComponentModel.ISupportInitialize)Emontototal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_compras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Emontototal
            // 
            Emontototal.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Emontototal.ContainerControl = this;
            Emontototal.Icon = (Icon)resources.GetObject("Emontototal.Icon");
            // 
            // Etalle
            // 
            Etalle.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etalle.ContainerControl = this;
            Etalle.Icon = (Icon)resources.GetObject("Etalle.Icon");
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
            // Eproducto
            // 
            Eproducto.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproducto.ContainerControl = this;
            Eproducto.Icon = (Icon)resources.GetObject("Eproducto.Icon");
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            // 
            // proveedor
            // 
            proveedor.HeaderText = "Proveedor";
            proveedor.Name = "proveedor";
            // 
            // talle
            // 
            talle.HeaderText = "Talle";
            talle.Name = "talle";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
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
            // nombre_producto
            // 
            nombre_producto.HeaderText = "PRODUCTO";
            nombre_producto.Name = "nombre_producto";
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
            // Eproveedor
            // 
            Eproveedor.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproveedor.ContainerControl = this;
            Eproveedor.Icon = (Icon)resources.GetObject("Eproveedor.Icon");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(TBdni);
            groupBox2.Controls.Add(TBusername);
            groupBox2.Controls.Add(dg_compras);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(15, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 352);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Compras";
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
            groupBox1.Location = new Point(15, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 266);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Compra";
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(326, 4);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(303, 51);
            Lindex.TabIndex = 42;
            Lindex.Text = "Gestionar Compras";
            // 
            // Fagregar_compra_ger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Name = "Fagregar_compra_ger";
            Text = "Fagregar_compra_ger";
            Load += Fagregar_compra_ger_Load;
            ((System.ComponentModel.ISupportInitialize)Emontototal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_compras).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ErrorProvider Emontototal;
        private GroupBox groupBox2;
        private Button bbuscar;
        private TextBox TBdni;
        private TextBox TBusername;
        private DataGridView dg_compras;
        private DataGridViewTextBoxColumn id_compra;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn talle;
        private DataGridViewTextBoxColumn proveedor;
        private DataGridViewTextBoxColumn monto;
        private GroupBox groupBox1;
        private ComboBox cbtalle;
        private TextBox Tmonto;
        private Button Bagregar_compra;
        private TextBox Tcantidad;
        private ComboBox CBproveedor;
        private TextBox Tdesc;
        private TextBox Tproducto;
        private Label Lindex;
        private ErrorProvider Etalle;
        private ErrorProvider Edesc;
        private ErrorProvider Ecantidad;
        private ErrorProvider Eproducto;
        private ErrorProvider Eproveedor;
    }
}