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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_venta));
            Lindex = new Label();
            Bagregar_producto = new Button();
            CBtipo_pago = new ComboBox();
            label1 = new Label();
            CBproducto = new ComboBox();
            LCproducto = new Label();
            LSproducto = new Label();
            DGagregar_venta = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Recargo = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            B_generar_compra = new Button();
            B_cancelar = new Button();
            GBagregar_venta = new GroupBox();
            TBstock_disponible = new TextBox();
            lstock_disponible = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label7 = new Label();
            fechaactual = new Label();
            UDcantidad = new NumericUpDown();
            Lprecio_unitario = new Label();
            label2 = new Label();
            CBcliente = new ComboBox();
            Eproducto = new ErrorProvider(components);
            Etipopago = new ErrorProvider(components);
            Ecantidad = new ErrorProvider(components);
            signopeso = new Label();
            lpreciototal = new Label();
            panelpreciototal = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            ldescuento = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).BeginInit();
            GBagregar_venta.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etipopago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            panelpreciototal.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(404, -1);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(235, 43);
            Lindex.TabIndex = 30;
            Lindex.Text = "Gestionar Ventas";
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
            LCproducto.Location = new Point(298, 96);
            LCproducto.Name = "LCproducto";
            LCproducto.Size = new Size(58, 15);
            LCproducto.TabIndex = 1;
            LCproducto.Text = "Cantidad:";
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
            // DGagregar_venta
            // 
            DGagregar_venta.AllowUserToAddRows = false;
            DGagregar_venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGagregar_venta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DGagregar_venta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGagregar_venta.Columns.AddRange(new DataGridViewColumn[] { Producto, descripcion, Cantidad, Descuento, Recargo, precio, editar, eliminar });
            DGagregar_venta.Location = new Point(30, 179);
            DGagregar_venta.Name = "DGagregar_venta";
            DGagregar_venta.RowHeadersVisible = false;
            DGagregar_venta.RowTemplate.Height = 25;
            DGagregar_venta.Size = new Size(772, 226);
            DGagregar_venta.TabIndex = 32;
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
            // B_generar_compra
            // 
            B_generar_compra.BackColor = Color.FromArgb(192, 255, 192);
            B_generar_compra.Location = new Point(652, 407);
            B_generar_compra.Name = "B_generar_compra";
            B_generar_compra.Size = new Size(150, 43);
            B_generar_compra.TabIndex = 30;
            B_generar_compra.Text = "Generar Compra";
            B_generar_compra.UseVisualStyleBackColor = false;
            B_generar_compra.Click += B_generar_compra_Click;
            // 
            // B_cancelar
            // 
            B_cancelar.BackColor = Color.FromArgb(255, 192, 192);
            B_cancelar.Location = new Point(496, 407);
            B_cancelar.Name = "B_cancelar";
            B_cancelar.Size = new Size(150, 43);
            B_cancelar.TabIndex = 34;
            B_cancelar.Text = "Cancelar";
            B_cancelar.UseVisualStyleBackColor = false;
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
            GBagregar_venta.Location = new Point(30, 35);
            GBagregar_venta.Name = "GBagregar_venta";
            GBagregar_venta.Size = new Size(928, 141);
            GBagregar_venta.TabIndex = 36;
            GBagregar_venta.TabStop = false;
            GBagregar_venta.Text = "Agregar Venta";
            GBagregar_venta.Enter += GBagregar_venta_Enter;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 409);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 52;
            label2.Text = "Seleccione Cliente";
            // 
            // CBcliente
            // 
            CBcliente.FormattingEnabled = true;
            CBcliente.Location = new Point(171, 409);
            CBcliente.Name = "CBcliente";
            CBcliente.Size = new Size(211, 23);
            CBcliente.TabIndex = 51;
            // 
            // Eproducto
            // 
            Eproducto.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproducto.ContainerControl = this;
            Eproducto.Icon = (Icon)resources.GetObject("Eproducto.Icon");
            // 
            // Etipopago
            // 
            Etipopago.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etipopago.ContainerControl = this;
            Etipopago.Icon = (Icon)resources.GetObject("Etipopago.Icon");
            // 
            // Ecantidad
            // 
            Ecantidad.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecantidad.ContainerControl = this;
            Ecantidad.Icon = (Icon)resources.GetObject("Ecantidad.Icon");
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
            // panelpreciototal
            // 
            panelpreciototal.BackColor = Color.Black;
            panelpreciototal.Controls.Add(lpreciototal);
            panelpreciototal.Controls.Add(signopeso);
            panelpreciototal.ForeColor = Color.Transparent;
            panelpreciototal.Location = new Point(820, 362);
            panelpreciototal.Name = "panelpreciototal";
            panelpreciototal.Size = new Size(118, 43);
            panelpreciototal.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(820, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 43);
            panel1.TabIndex = 37;
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
            // ldescuento
            // 
            ldescuento.AutoSize = true;
            ldescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ldescuento.Location = new Point(820, 250);
            ldescuento.Name = "ldescuento";
            ldescuento.Size = new Size(83, 21);
            ldescuento.TabIndex = 38;
            ldescuento.Text = "Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(820, 338);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 39;
            label6.Text = "Total a Pagar:";
            // 
            // Fagregar_venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(970, 686);
            Controls.Add(label6);
            Controls.Add(ldescuento);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panelpreciototal);
            Controls.Add(CBcliente);
            Controls.Add(GBagregar_venta);
            Controls.Add(B_cancelar);
            Controls.Add(B_generar_compra);
            Controls.Add(DGagregar_venta);
            Controls.Add(Lindex);
            Name = "Fagregar_venta";
            Text = "Agregar Venta";
            Load += Fagregar_venta_Load;
            ((System.ComponentModel.ISupportInitialize)DGagregar_venta).EndInit();
            GBagregar_venta.ResumeLayout(false);
            GBagregar_venta.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UDcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etipopago).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            panelpreciototal.ResumeLayout(false);
            panelpreciototal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button Bagregar_producto;
        private Button B_generar_compra;
        private Button B_cancelar;
        private GroupBox GBagregar_venta;
        private Label Lprecio_unitario;
        private NumericUpDown UDcantidad;
        private ErrorProvider Eproducto;
        private ErrorProvider Etipopago;
        private ErrorProvider Ecantidad;
        private Label fechaactual;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Recargo;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
        private Label label2;
        private ComboBox CBcliente;
        private Label signopeso;
        private Panel panelpreciototal;
        private Label lpreciototal;
        private Label label6;
        private Label ldescuento;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Label lstock_disponible;
        private TextBox TBstock_disponible;
    }
}