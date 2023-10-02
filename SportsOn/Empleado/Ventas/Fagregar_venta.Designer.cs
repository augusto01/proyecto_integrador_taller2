namespace SportsOn.Empleado.Ventas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_venta));
            ldescuento = new Label();
            B_cancelar = new Button();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            CBcliente = new ComboBox();
            Eproducto = new ErrorProvider(components);
            GBagregar_venta = new GroupBox();
            TBstock_disponible = new TextBox();
            lstock_disponible = new Label();
            panel2 = new Panel();
            fechaactual = new Label();
            UDcantidad = new NumericUpDown();
            Lprecio_unitario = new Label();
            Bagregar_producto = new Button();
            CBproducto = new ComboBox();
            LSproducto = new Label();
            CBtipo_pago = new ComboBox();
            label1 = new Label();
            LCproducto = new Label();
            Etipopago = new ErrorProvider(components);
            lpreciototal = new Label();
            signopeso = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panelpreciototal = new Panel();
            Ecantidad = new ErrorProvider(components);
            label6 = new Label();
            DGagregar_venta = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Recargo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            Lindex = new Label();
            B_generar_compra = new Button();
            ((System.ComponentModel.ISupportInitialize)Eproducto).BeginInit();
            GBagregar_venta.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etipopago).BeginInit();
            panel1.SuspendLayout();
            panelpreciototal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).BeginInit();
            SuspendLayout();
            // 
            // ldescuento
            // 
            ldescuento.AutoSize = true;
            ldescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ldescuento.Location = new Point(809, 260);
            ldescuento.Name = "ldescuento";
            ldescuento.Size = new Size(83, 21);
            ldescuento.TabIndex = 60;
            ldescuento.Text = "Descuento";
            // 
            // B_cancelar
            // 
            B_cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_cancelar.Location = new Point(485, 417);
            B_cancelar.Name = "B_cancelar";
            B_cancelar.Size = new Size(150, 43);
            B_cancelar.TabIndex = 57;
            B_cancelar.Text = "Cancelar";
            B_cancelar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(41, 10);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 1;
            label5.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(21, 10);
            label7.Name = "label7";
            label7.Size = new Size(23, 25);
            label7.TabIndex = 0;
            label7.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 419);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 63;
            label2.Text = "Seleccione Cliente";
            // 
            // CBcliente
            // 
            CBcliente.FormattingEnabled = true;
            CBcliente.Location = new Point(160, 419);
            CBcliente.Name = "CBcliente";
            CBcliente.Size = new Size(211, 23);
            CBcliente.TabIndex = 62;
            // 
            // Eproducto
            // 
            Eproducto.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproducto.ContainerControl = this;
            Eproducto.Icon = (Icon)resources.GetObject("Eproducto.Icon");
            // 
            // GBagregar_venta
            // 
            GBagregar_venta.Controls.Add(TBstock_disponible);
            GBagregar_venta.Controls.Add(lstock_disponible);
            GBagregar_venta.Controls.Add(panel2);
            GBagregar_venta.Controls.Add(fechaactual);
            GBagregar_venta.Controls.Add(UDcantidad);
            GBagregar_venta.Controls.Add(Lprecio_unitario);
            GBagregar_venta.Controls.Add(Bagregar_producto);
            GBagregar_venta.Controls.Add(CBproducto);
            GBagregar_venta.Controls.Add(LSproducto);
            GBagregar_venta.Controls.Add(CBtipo_pago);
            GBagregar_venta.Controls.Add(label1);
            GBagregar_venta.Controls.Add(LCproducto);
            GBagregar_venta.Location = new Point(19, 45);
            GBagregar_venta.Name = "GBagregar_venta";
            GBagregar_venta.Size = new Size(928, 141);
            GBagregar_venta.TabIndex = 58;
            GBagregar_venta.TabStop = false;
            GBagregar_venta.Text = "Agregar Venta";
            // 
            // TBstock_disponible
            // 
            TBstock_disponible.BackColor = Color.FromArgb(192, 255, 255);
            TBstock_disponible.Location = new Point(359, 51);
            TBstock_disponible.Name = "TBstock_disponible";
            TBstock_disponible.Size = new Size(65, 23);
            TBstock_disponible.TabIndex = 55;
            // 
            // lstock_disponible
            // 
            lstock_disponible.AutoSize = true;
            lstock_disponible.Location = new Point(298, 54);
            lstock_disponible.Name = "lstock_disponible";
            lstock_disponible.Size = new Size(39, 15);
            lstock_disponible.TabIndex = 54;
            lstock_disponible.Text = "Stock:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(790, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 43);
            panel2.TabIndex = 53;
            // 
            // fechaactual
            // 
            fechaactual.AutoSize = true;
            fechaactual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fechaactual.ForeColor = Color.Lime;
            fechaactual.Location = new Point(778, 12);
            fechaactual.Name = "fechaactual";
            fechaactual.Size = new Size(142, 21);
            fechaactual.TabIndex = 50;
            fechaactual.Text = "Fecha de la venta";
            // 
            // UDcantidad
            // 
            UDcantidad.BackColor = Color.FromArgb(192, 255, 192);
            UDcantidad.Location = new Point(359, 93);
            UDcantidad.Name = "UDcantidad";
            UDcantidad.Size = new Size(65, 23);
            UDcantidad.TabIndex = 49;
            // 
            // Lprecio_unitario
            // 
            Lprecio_unitario.AutoSize = true;
            Lprecio_unitario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lprecio_unitario.Location = new Point(790, 48);
            Lprecio_unitario.Name = "Lprecio_unitario";
            Lprecio_unitario.Size = new Size(116, 21);
            Lprecio_unitario.TabIndex = 30;
            Lprecio_unitario.Text = "Precio Unitario:";
            // 
            // Bagregar_producto
            // 
            Bagregar_producto.Location = new Point(487, 51);
            Bagregar_producto.Name = "Bagregar_producto";
            Bagregar_producto.Size = new Size(85, 26);
            Bagregar_producto.TabIndex = 28;
            Bagregar_producto.Text = "Agregar";
            Bagregar_producto.UseVisualStyleBackColor = true;
            Bagregar_producto.Click += Bagregar_producto_Click;
            // 
            // CBproducto
            // 
            CBproducto.FormattingEnabled = true;
            CBproducto.Location = new Point(6, 51);
            CBproducto.Name = "CBproducto";
            CBproducto.Size = new Size(211, 23);
            CBproducto.TabIndex = 2;
            // 
            // LSproducto
            // 
            LSproducto.AutoSize = true;
            LSproducto.Location = new Point(6, 33);
            LSproducto.Name = "LSproducto";
            LSproducto.Size = new Size(115, 15);
            LSproducto.TabIndex = 0;
            LSproducto.Text = "Seleccione Producto";
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
            // LCproducto
            // 
            LCproducto.AutoSize = true;
            LCproducto.Location = new Point(298, 96);
            LCproducto.Name = "LCproducto";
            LCproducto.Size = new Size(58, 15);
            LCproducto.TabIndex = 1;
            LCproducto.Text = "Cantidad:";
            // 
            // Etipopago
            // 
            Etipopago.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etipopago.ContainerControl = this;
            Etipopago.Icon = (Icon)resources.GetObject("Etipopago.Icon");
            // 
            // lpreciototal
            // 
            lpreciototal.AutoSize = true;
            lpreciototal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lpreciototal.ForeColor = Color.Lime;
            lpreciototal.Location = new Point(41, 10);
            lpreciototal.Name = "lpreciototal";
            lpreciototal.Size = new Size(50, 25);
            lpreciototal.TabIndex = 1;
            lpreciototal.Text = "0.00";
            // 
            // signopeso
            // 
            signopeso.AutoSize = true;
            signopeso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            signopeso.ForeColor = Color.Lime;
            signopeso.Location = new Point(21, 10);
            signopeso.Name = "signopeso";
            signopeso.Size = new Size(23, 25);
            signopeso.TabIndex = 0;
            signopeso.Text = "$";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(809, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 43);
            panel1.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 128);
            label3.Location = new Point(40, 10);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 1;
            label3.Text = "0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 128, 128);
            label4.Location = new Point(21, 10);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 0;
            label4.Text = "$";
            // 
            // panelpreciototal
            // 
            panelpreciototal.BackColor = Color.Black;
            panelpreciototal.Controls.Add(lpreciototal);
            panelpreciototal.Controls.Add(signopeso);
            panelpreciototal.ForeColor = Color.Transparent;
            panelpreciototal.Location = new Point(809, 372);
            panelpreciototal.Name = "panelpreciototal";
            panelpreciototal.Size = new Size(118, 43);
            panelpreciototal.TabIndex = 53;
            // 
            // Ecantidad
            // 
            Ecantidad.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecantidad.ContainerControl = this;
            Ecantidad.Icon = (Icon)resources.GetObject("Ecantidad.Icon");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(809, 348);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 61;
            label6.Text = "Total a Pagar:";
            // 
            // DGagregar_venta
            // 
            DGagregar_venta.AllowUserToAddRows = false;
            DGagregar_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGagregar_venta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DGagregar_venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGagregar_venta.Columns.AddRange(new DataGridViewColumn[] { Producto, descripcion, Cantidad, Descuento, Recargo, precio, editar, eliminar });
            DGagregar_venta.Location = new Point(19, 189);
            DGagregar_venta.Name = "DGagregar_venta";
            DGagregar_venta.RowHeadersVisible = false;
            DGagregar_venta.RowTemplate.Height = 25;
            DGagregar_venta.Size = new Size(772, 226);
            DGagregar_venta.TabIndex = 56;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
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
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // editar
            // 
            editar.HeaderText = "Editar";
            editar.Name = "editar";
            editar.Resizable = DataGridViewTriState.True;
            editar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "eliminar";
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(393, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(235, 43);
            Lindex.TabIndex = 54;
            Lindex.Text = "Gestionar Ventas";
            // 
            // B_generar_compra
            // 
            B_generar_compra.BackColor = Color.FromArgb(192, 255, 192);
            B_generar_compra.Location = new Point(641, 417);
            B_generar_compra.Name = "B_generar_compra";
            B_generar_compra.Size = new Size(150, 43);
            B_generar_compra.TabIndex = 55;
            B_generar_compra.Text = "Generar Compra";
            B_generar_compra.UseVisualStyleBackColor = false;
            B_generar_compra.Click += B_generar_compra_Click;
            // 
            // Fagregar_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(ldescuento);
            Controls.Add(B_cancelar);
            Controls.Add(label2);
            Controls.Add(CBcliente);
            Controls.Add(GBagregar_venta);
            Controls.Add(panel1);
            Controls.Add(panelpreciototal);
            Controls.Add(label6);
            Controls.Add(DGagregar_venta);
            Controls.Add(Lindex);
            Controls.Add(B_generar_compra);
            Name = "Fagregar_venta";
            Text = "Fagregar_venta";
            Load += Fagregar_venta_Load;
            ((System.ComponentModel.ISupportInitialize)Eproducto).EndInit();
            GBagregar_venta.ResumeLayout(false);
            GBagregar_venta.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etipopago).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelpreciototal.ResumeLayout(false);
            panelpreciototal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ldescuento;
        private Button B_cancelar;
        private Label label5;
        private Label label7;
        private Label label2;
        private ComboBox CBcliente;
        private ErrorProvider Eproducto;
        private GroupBox GBagregar_venta;
        private TextBox TBstock_disponible;
        private Label lstock_disponible;
        private Panel panel2;
        private Label fechaactual;
        private NumericUpDown UDcantidad;
        private Label Lprecio_unitario;
        private Button Bagregar_producto;
        private ComboBox CBproducto;
        private Label LSproducto;
        private ComboBox CBtipo_pago;
        private Label label1;
        private Label LCproducto;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panelpreciototal;
        private Label lpreciototal;
        private Label signopeso;
        private Label label6;
        private DataGridView DGagregar_venta;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Recargo;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
        private Label Lindex;
        private Button B_generar_compra;
        private ErrorProvider Etipopago;
        private ErrorProvider Ecantidad;
    }
}