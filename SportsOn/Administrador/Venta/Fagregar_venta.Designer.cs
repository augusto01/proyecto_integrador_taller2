namespace SportsOn.Administrador
{
    partial class Fagregar_venta
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
            Lindex = new Label();
            Bagregar_producto = new Button();
            lprecio = new Label();
            CBtipo_pago = new ComboBox();
            label1 = new Label();
            CBproducto = new ComboBox();
            LCproducto = new Label();
            LSproducto = new Label();
            DGagregar_venta = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Recargo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ltotal_precio = new Label();
            B_generar_compra = new Button();
            B_cancelar = new Button();
            GBagregar_venta = new GroupBox();
            UDcantidad = new NumericUpDown();
            Lprecio_unitario = new Label();
            GBprecio_total = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).BeginInit();
            GBagregar_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).BeginInit();
            GBprecio_total.SuspendLayout();
            SuspendLayout();
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(259, 1);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(276, 51);
            Lindex.TabIndex = 30;
            Lindex.Text = "Gestionar Ventas";
            // 
            // Bagregar_producto
            // 
            Bagregar_producto.Location = new Point(264, 93);
            Bagregar_producto.Name = "Bagregar_producto";
            Bagregar_producto.Size = new Size(64, 23);
            Bagregar_producto.TabIndex = 28;
            Bagregar_producto.Text = "Agregar";
            Bagregar_producto.UseVisualStyleBackColor = true;
            // 
            // lprecio
            // 
            lprecio.AutoSize = true;
            lprecio.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lprecio.ForeColor = Color.Lime;
            lprecio.Location = new Point(550, 39);
            lprecio.Name = "lprecio";
            lprecio.Size = new Size(147, 51);
            lprecio.TabIndex = 27;
            lprecio.Text = "PRECIO$";
            // 
            // CBtipo_pago
            // 
            CBtipo_pago.FormattingEnabled = true;
            CBtipo_pago.Location = new Point(6, 93);
            CBtipo_pago.Name = "CBtipo_pago";
            CBtipo_pago.Size = new Size(211, 23);
            CBtipo_pago.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 75);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Tipo de pago";
            // 
            // CBproducto
            // 
            CBproducto.FormattingEnabled = true;
            CBproducto.Location = new Point(6, 51);
            CBproducto.Name = "CBproducto";
            CBproducto.Size = new Size(211, 23);
            CBproducto.TabIndex = 2;
            // 
            // LCproducto
            // 
            LCproducto.AutoSize = true;
            LCproducto.Location = new Point(264, 33);
            LCproducto.Name = "LCproducto";
            LCproducto.Size = new Size(55, 15);
            LCproducto.TabIndex = 1;
            LCproducto.Text = "Cantidad";
            // 
            // LSproducto
            // 
            LSproducto.AutoSize = true;
            LSproducto.Location = new Point(3, 33);
            LSproducto.Name = "LSproducto";
            LSproducto.Size = new Size(115, 15);
            LSproducto.TabIndex = 0;
            LSproducto.Text = "Seleccione Producto";
            LSproducto.Click += label1_Click;
            // 
            // DGagregar_venta
            // 
            DGagregar_venta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DGagregar_venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGagregar_venta.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Descuento, Recargo, Precio });
            DGagregar_venta.Location = new Point(33, 179);
            DGagregar_venta.Name = "DGagregar_venta";
            DGagregar_venta.RowTemplate.Height = 25;
            DGagregar_venta.Size = new Size(543, 226);
            DGagregar_venta.TabIndex = 32;
            DGagregar_venta.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            // 
            // Recargo
            // 
            Recargo.HeaderText = "Recargo";
            Recargo.Name = "Recargo";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // ltotal_precio
            // 
            ltotal_precio.AutoSize = true;
            ltotal_precio.Font = new Font("Kanit SemiBold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ltotal_precio.ForeColor = Color.Lime;
            ltotal_precio.Location = new Point(433, 10);
            ltotal_precio.Name = "ltotal_precio";
            ltotal_precio.Size = new Size(104, 46);
            ltotal_precio.TabIndex = 1;
            ltotal_precio.Text = "precio";
            // 
            // B_generar_compra
            // 
            B_generar_compra.BackColor = Color.FromArgb(192, 255, 192);
            B_generar_compra.Location = new Point(583, 182);
            B_generar_compra.Name = "B_generar_compra";
            B_generar_compra.Size = new Size(150, 43);
            B_generar_compra.TabIndex = 30;
            B_generar_compra.Text = "Generar Compra";
            B_generar_compra.UseVisualStyleBackColor = false;
            // 
            // B_cancelar
            // 
            B_cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_cancelar.Location = new Point(583, 231);
            B_cancelar.Name = "B_cancelar";
            B_cancelar.Size = new Size(150, 43);
            B_cancelar.TabIndex = 34;
            B_cancelar.Text = "Cancelar";
            B_cancelar.UseVisualStyleBackColor = false;
            // 
            // GBagregar_venta
            // 
            GBagregar_venta.Controls.Add(UDcantidad);
            GBagregar_venta.Controls.Add(Lprecio_unitario);
            GBagregar_venta.Controls.Add(Bagregar_producto);
            GBagregar_venta.Controls.Add(lprecio);
            GBagregar_venta.Controls.Add(CBproducto);
            GBagregar_venta.Controls.Add(LSproducto);
            GBagregar_venta.Controls.Add(CBtipo_pago);
            GBagregar_venta.Controls.Add(label1);
            GBagregar_venta.Controls.Add(LCproducto);
            GBagregar_venta.Location = new Point(30, 45);
            GBagregar_venta.Name = "GBagregar_venta";
            GBagregar_venta.Size = new Size(703, 131);
            GBagregar_venta.TabIndex = 36;
            GBagregar_venta.TabStop = false;
            GBagregar_venta.Text = "Agregar Venta";
            GBagregar_venta.Enter += GBagregar_venta_Enter;
            // 
            // UDcantidad
            // 
            UDcantidad.BackColor = Color.FromArgb(192, 255, 192);
            UDcantidad.Location = new Point(264, 52);
            UDcantidad.Name = "UDcantidad";
            UDcantidad.Size = new Size(65, 23);
            UDcantidad.TabIndex = 49;
            // 
            // Lprecio_unitario
            // 
            Lprecio_unitario.AutoSize = true;
            Lprecio_unitario.Location = new Point(565, 33);
            Lprecio_unitario.Name = "Lprecio_unitario";
            Lprecio_unitario.Size = new Size(114, 15);
            Lprecio_unitario.TabIndex = 30;
            Lprecio_unitario.Text = "Precio del producto:";
            // 
            // GBprecio_total
            // 
            GBprecio_total.Controls.Add(ltotal_precio);
            GBprecio_total.Location = new Point(33, 411);
            GBprecio_total.Name = "GBprecio_total";
            GBprecio_total.Size = new Size(543, 68);
            GBprecio_total.TabIndex = 37;
            GBprecio_total.TabStop = false;
            GBprecio_total.Text = "Total a pagar";
            // 
            // Fagregar_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(770, 686);
            Controls.Add(GBprecio_total);
            Controls.Add(GBagregar_venta);
            Controls.Add(B_cancelar);
            Controls.Add(B_generar_compra);
            Controls.Add(DGagregar_venta);
            Controls.Add(Lindex);
            Name = "Fagregar_venta";
            Text = "Agregar Venta";
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).EndInit();
            GBagregar_venta.ResumeLayout(false);
            GBagregar_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).EndInit();
            GBprecio_total.ResumeLayout(false);
            GBprecio_total.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lindex;
        private DataGridView DGagregar_venta;
        private Label LSproducto;
        private Label LCproducto;
        private ComboBox CBtipo_pago;
        private Label label1;
        private ComboBox CBproducto;
        private TextBox TBcantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Recargo;
        private DataGridViewTextBoxColumn Precio;
        private Label lprecio;
        private Button Bagregar_producto;
        private Label ltotal_precio;
        private Button B_generar_compra;
        private Button B_cancelar;
        private GroupBox GBagregar_venta;
        private Label Lprecio_unitario;
        private GroupBox GBprecio_total;
        private NumericUpDown UDcantidad;
    }
}