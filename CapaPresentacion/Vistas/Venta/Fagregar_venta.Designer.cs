namespace CapaPresentacion.Vistas.Venta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tidvendedor = new System.Windows.Forms.TextBox();
            this.cbtipopago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tidfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tfecha = new System.Windows.Forms.TextBox();
            this.lfecha = new System.Windows.Forms.Label();
            this.lvendedor = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgdetalle = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lprecio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgproductos = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bcancelarventa = new System.Windows.Forms.Button();
            this.Bgenerarventa = new System.Windows.Forms.Button();
            this.tprecio = new System.Windows.Forms.TextBox();
            this.tstock = new System.Windows.Forms.TextBox();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.tcantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.bagregarproducto = new System.Windows.Forms.Button();
            this.tbuscarid = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ecantidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.pdfactura = new System.Drawing.Printing.PrintDocument();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ebuscarid = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebuscarid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tidvendedor);
            this.groupBox1.Controls.Add(this.cbtipopago);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbcliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tidfactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la venta";
            // 
            // tidvendedor
            // 
            this.tidvendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tidvendedor.ForeColor = System.Drawing.Color.White;
            this.tidvendedor.Location = new System.Drawing.Point(98, 24);
            this.tidvendedor.Name = "tidvendedor";
            this.tidvendedor.ReadOnly = true;
            this.tidvendedor.Size = new System.Drawing.Size(79, 23);
            this.tidvendedor.TabIndex = 91;
            // 
            // cbtipopago
            // 
            this.cbtipopago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbtipopago.ForeColor = System.Drawing.Color.White;
            this.cbtipopago.FormattingEnabled = true;
            this.cbtipopago.Location = new System.Drawing.Point(287, 23);
            this.cbtipopago.Name = "cbtipopago";
            this.cbtipopago.Size = new System.Drawing.Size(126, 25);
            this.cbtipopago.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 90;
            this.label8.Text = "ID Vendedor:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de pago:";
            // 
            // cbcliente
            // 
            this.cbcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbcliente.ForeColor = System.Drawing.Color.White;
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(483, 21);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(161, 25);
            this.cbcliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente:";
            // 
            // tidfactura
            // 
            this.tidfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tidfactura.ForeColor = System.Drawing.Color.White;
            this.tidfactura.Location = new System.Drawing.Point(755, 22);
            this.tidfactura.Name = "tidfactura";
            this.tidfactura.ReadOnly = true;
            this.tidfactura.Size = new System.Drawing.Size(119, 23);
            this.tidfactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Factura:";
            // 
            // tfecha
            // 
            this.tfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tfecha.ForeColor = System.Drawing.Color.White;
            this.tfecha.Location = new System.Drawing.Point(810, 97);
            this.tfecha.Name = "tfecha";
            this.tfecha.ReadOnly = true;
            this.tfecha.Size = new System.Drawing.Size(98, 20);
            this.tfecha.TabIndex = 10;
            this.tfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lfecha
            // 
            this.lfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lfecha.AutoSize = true;
            this.lfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfecha.Location = new System.Drawing.Point(751, 97);
            this.lfecha.Name = "lfecha";
            this.lfecha.Size = new System.Drawing.Size(53, 18);
            this.lfecha.TabIndex = 5;
            this.lfecha.Text = "Fecha:";
            // 
            // lvendedor
            // 
            this.lvendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvendedor.AutoSize = true;
            this.lvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvendedor.ForeColor = System.Drawing.Color.White;
            this.lvendedor.Location = new System.Drawing.Point(322, 87);
            this.lvendedor.Name = "lvendedor";
            this.lvendedor.Size = new System.Drawing.Size(97, 21);
            this.lvendedor.TabIndex = 6;
            this.lvendedor.Text = "vendendor";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgdetalle);
            this.groupBox3.Location = new System.Drawing.Point(21, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgdetalle
            // 
            this.dgdetalle.AllowUserToAddRows = false;
            this.dgdetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.dgdetalle.Location = new System.Drawing.Point(23, 26);
            this.dgdetalle.Name = "dgdetalle";
            this.dgdetalle.Size = new System.Drawing.Size(751, 206);
            this.dgdetalle.TabIndex = 0;
            this.dgdetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalle_CellContentClick_1);
            // 
            // idproducto
            // 
            this.idproducto.FillWeight = 95.63452F;
            this.idproducto.HeaderText = "ID producto";
            this.idproducto.Name = "idproducto";
            // 
            // producto
            // 
            this.producto.FillWeight = 95.63452F;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.FillWeight = 95.63452F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 95.63452F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.FillWeight = 95.63452F;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lprecio);
            this.panel1.Location = new System.Drawing.Point(811, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 48);
            this.panel1.TabIndex = 13;
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprecio.ForeColor = System.Drawing.Color.Lime;
            this.lprecio.Location = new System.Drawing.Point(3, 11);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(21, 24);
            this.lprecio.TabIndex = 14;
            this.lprecio.Text = "$";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(338, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 37);
            this.label10.TabIndex = 83;
            this.label10.Text = "Agregar Venta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 87;
            this.label2.Text = "Usted esta siendo atendido por:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(808, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "Total a Pagar:";
            // 
            // dgproductos
            // 
            this.dgproductos.AllowUserToAddRows = false;
            this.dgproductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agregar});
            this.dgproductos.Location = new System.Drawing.Point(21, 291);
            this.dgproductos.Name = "dgproductos";
            this.dgproductos.Size = new System.Drawing.Size(780, 100);
            this.dgproductos.TabIndex = 1;
            this.dgproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgproductos_CellClick_1);
            // 
            // agregar
            // 
            this.agregar.HeaderText = "Agregar";
            this.agregar.Image = ((System.Drawing.Image)(resources.GetObject("agregar.Image")));
            this.agregar.Name = "agregar";
            // 
            // bcancelarventa
            // 
            this.bcancelarventa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcancelarventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.bcancelarventa.FlatAppearance.BorderSize = 0;
            this.bcancelarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelarventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bcancelarventa.ForeColor = System.Drawing.Color.White;
            this.bcancelarventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelarventa.Location = new System.Drawing.Point(811, 535);
            this.bcancelarventa.Name = "bcancelarventa";
            this.bcancelarventa.Size = new System.Drawing.Size(105, 48);
            this.bcancelarventa.TabIndex = 85;
            this.bcancelarventa.Text = "Cancelar";
            this.bcancelarventa.UseVisualStyleBackColor = false;
            this.bcancelarventa.Click += new System.EventHandler(this.bcancelarventa_Click);
            // 
            // Bgenerarventa
            // 
            this.Bgenerarventa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bgenerarventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Bgenerarventa.FlatAppearance.BorderSize = 0;
            this.Bgenerarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bgenerarventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Bgenerarventa.ForeColor = System.Drawing.Color.White;
            this.Bgenerarventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bgenerarventa.Location = new System.Drawing.Point(811, 589);
            this.Bgenerarventa.Name = "Bgenerarventa";
            this.Bgenerarventa.Size = new System.Drawing.Size(105, 48);
            this.Bgenerarventa.TabIndex = 84;
            this.Bgenerarventa.Text = "Vender";
            this.Bgenerarventa.UseVisualStyleBackColor = false;
            this.Bgenerarventa.Click += new System.EventHandler(this.Bgenerarventa_Click);
            // 
            // tprecio
            // 
            this.tprecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tprecio.ForeColor = System.Drawing.Color.White;
            this.tprecio.Location = new System.Drawing.Point(352, 48);
            this.tprecio.Name = "tprecio";
            this.tprecio.ReadOnly = true;
            this.tprecio.Size = new System.Drawing.Size(79, 23);
            this.tprecio.TabIndex = 142;
            // 
            // tstock
            // 
            this.tstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tstock.ForeColor = System.Drawing.Color.White;
            this.tstock.Location = new System.Drawing.Point(462, 48);
            this.tstock.Name = "tstock";
            this.tstock.ReadOnly = true;
            this.tstock.Size = new System.Drawing.Size(79, 23);
            this.tstock.TabIndex = 143;
            // 
            // tnombre
            // 
            this.tnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tnombre.ForeColor = System.Drawing.Color.White;
            this.tnombre.Location = new System.Drawing.Point(213, 48);
            this.tnombre.Name = "tnombre";
            this.tnombre.ReadOnly = true;
            this.tnombre.Size = new System.Drawing.Size(107, 23);
            this.tnombre.TabIndex = 145;
            // 
            // tcantidad
            // 
            this.tcantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcantidad.ForeColor = System.Drawing.Color.White;
            this.tcantidad.Location = new System.Drawing.Point(580, 48);
            this.tcantidad.Name = "tcantidad";
            this.tcantidad.Size = new System.Drawing.Size(65, 23);
            this.tcantidad.TabIndex = 147;
            this.tcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcantidad_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tcantidad);
            this.groupBox2.Controls.Add(this.tnombre);
            this.groupBox2.Controls.Add(this.tstock);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tprecio);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.bagregarproducto);
            this.groupBox2.Controls.Add(this.tbuscarid);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(21, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 87);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del producto";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(171, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 148;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(576, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 19);
            this.label14.TabIndex = 147;
            this.label14.Text = "CANTIDAD";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(470, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 19);
            this.label15.TabIndex = 146;
            this.label15.Text = "STOCK";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(355, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 19);
            this.label16.TabIndex = 145;
            this.label16.Text = "PRECIO";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(222, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 19);
            this.label17.TabIndex = 142;
            this.label17.Text = "PRODUCTO";
            // 
            // bagregarproducto
            // 
            this.bagregarproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bagregarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bagregarproducto.FlatAppearance.BorderSize = 2;
            this.bagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagregarproducto.Image = ((System.Drawing.Image)(resources.GetObject("bagregarproducto.Image")));
            this.bagregarproducto.Location = new System.Drawing.Point(701, 9);
            this.bagregarproducto.Name = "bagregarproducto";
            this.bagregarproducto.Size = new System.Drawing.Size(73, 72);
            this.bagregarproducto.TabIndex = 89;
            this.bagregarproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bagregarproducto.UseVisualStyleBackColor = true;
            this.bagregarproducto.Click += new System.EventHandler(this.bagregarproducto_Click);
            // 
            // tbuscarid
            // 
            this.tbuscarid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tbuscarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbuscarid.ForeColor = System.Drawing.Color.White;
            this.tbuscarid.Location = new System.Drawing.Point(10, 48);
            this.tbuscarid.Name = "tbuscarid";
            this.tbuscarid.Size = new System.Drawing.Size(137, 23);
            this.tbuscarid.TabIndex = 139;
            this.tbuscarid.TextChanged += new System.EventHandler(this.tbuscarid_TextChanged);
            this.tbuscarid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbuscarid_KeyPress);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(19, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 19);
            this.label18.TabIndex = 138;
            this.label18.Text = "BUSCAR POR ID";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // ecantidad
            // 
            this.ecantidad.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ecantidad.ContainerControl = this;
            this.ecantidad.Icon = ((System.Drawing.Icon)(resources.GetObject("ecantidad.Icon")));
            // 
            // pdfactura
            // 
            this.pdfactura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdfactura_PrintPage);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.FillWeight = 121.8274F;
            this.dataGridViewImageColumn1.HeaderText = "Agregar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 697;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 737;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // ebuscarid
            // 
            this.ebuscarid.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ebuscarid.ContainerControl = this;
            this.ebuscarid.Icon = ((System.Drawing.Icon)(resources.GetObject("ebuscarid.Icon")));
            // 
            // Fagregar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(914, 788);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgproductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lfecha);
            this.Controls.Add(this.bcancelarventa);
            this.Controls.Add(this.Bgenerarventa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvendedor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fagregar_venta";
            this.Text = "Fagregar_venta";
            this.Load += new System.EventHandler(this.Fagregar_venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ebuscarid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lfecha;
        private System.Windows.Forms.TextBox tidfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lvendedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bgenerarventa;
        private System.Windows.Forms.Button bcancelarventa;
        private System.Windows.Forms.TextBox tfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bagregarproducto;
        private System.Windows.Forms.ComboBox cbtipopago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tidvendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgdetalle;
        private System.Windows.Forms.DataGridView dgproductos;
        private System.Windows.Forms.DataGridViewImageColumn agregar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox tprecio;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.TextBox tcantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbuscarid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider ecantidad;
        private System.Windows.Forms.Label lprecio;
        private System.Drawing.Printing.PrintDocument pdfactura;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ErrorProvider ebuscarid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}