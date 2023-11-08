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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_venta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tfecha = new System.Windows.Forms.TextBox();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lfecha = new System.Windows.Forms.Label();
            this.tidfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvendedor = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tstock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tprecioproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bbuscarproducto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tcodproducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nucantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lprecio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Bgenerarventa = new System.Windows.Forms.Button();
            this.bcancelarventa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bagregarproducto = new System.Windows.Forms.Button();
            this.cbtipopago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tidvendedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgdetalle = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbproductos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucantidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la venta";
            // 
            // tfecha
            // 
            this.tfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tfecha.ForeColor = System.Drawing.Color.White;
            this.tfecha.Location = new System.Drawing.Point(804, 92);
            this.tfecha.Name = "tfecha";
            this.tfecha.ReadOnly = true;
            this.tfecha.Size = new System.Drawing.Size(98, 20);
            this.tfecha.TabIndex = 10;
            this.tfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lfecha
            // 
            this.lfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lfecha.AutoSize = true;
            this.lfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfecha.Location = new System.Drawing.Point(745, 92);
            this.lfecha.Name = "lfecha";
            this.lfecha.Size = new System.Drawing.Size(53, 18);
            this.lfecha.TabIndex = 5;
            this.lfecha.Text = "Fecha:";
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
            // lvendedor
            // 
            this.lvendedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvendedor.AutoSize = true;
            this.lvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvendedor.ForeColor = System.Drawing.Color.White;
            this.lvendedor.Location = new System.Drawing.Point(308, 82);
            this.lvendedor.Name = "lvendedor";
            this.lvendedor.Size = new System.Drawing.Size(97, 21);
            this.lvendedor.TabIndex = 6;
            this.lvendedor.Text = "vendendor";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cbproductos);
            this.groupBox2.Controls.Add(this.tstock);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tprecioproducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bbuscarproducto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tcodproducto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nucantidad);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Productos";
            // 
            // tstock
            // 
            this.tstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tstock.ForeColor = System.Drawing.Color.White;
            this.tstock.Location = new System.Drawing.Point(476, 39);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(67, 23);
            this.tstock.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(473, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Stock:";
            // 
            // tprecioproducto
            // 
            this.tprecioproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tprecioproducto.ForeColor = System.Drawing.Color.White;
            this.tprecioproducto.Location = new System.Drawing.Point(391, 39);
            this.tprecioproducto.Name = "tprecioproducto";
            this.tprecioproducto.Size = new System.Drawing.Size(67, 23);
            this.tprecioproducto.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Precio:";
            // 
            // bbuscarproducto
            // 
            this.bbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbuscarproducto.FlatAppearance.BorderSize = 0;
            this.bbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bbuscarproducto.Image = ((System.Drawing.Image)(resources.GetObject("bbuscarproducto.Image")));
            this.bbuscarproducto.Location = new System.Drawing.Point(159, 39);
            this.bbuscarproducto.Name = "bbuscarproducto";
            this.bbuscarproducto.Size = new System.Drawing.Size(27, 24);
            this.bbuscarproducto.TabIndex = 26;
            this.bbuscarproducto.UseVisualStyleBackColor = true;
            this.bbuscarproducto.Click += new System.EventHandler(this.bbuscarproducto_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(221, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "Producto:";
            // 
            // tcodproducto
            // 
            this.tcodproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tcodproducto.ForeColor = System.Drawing.Color.White;
            this.tcodproducto.Location = new System.Drawing.Point(18, 39);
            this.tcodproducto.Name = "tcodproducto";
            this.tcodproducto.Size = new System.Drawing.Size(137, 23);
            this.tcodproducto.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Cod Producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(609, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cantidad:";
            // 
            // nucantidad
            // 
            this.nucantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.nucantidad.ForeColor = System.Drawing.Color.White;
            this.nucantidad.Location = new System.Drawing.Point(612, 40);
            this.nucantidad.Name = "nucantidad";
            this.nucantidad.Size = new System.Drawing.Size(102, 23);
            this.nucantidad.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.dgdetalle);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(741, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lprecio);
            this.panel1.Location = new System.Drawing.Point(772, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 48);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(75, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "$";
            // 
            // lprecio
            // 
            this.lprecio.AutoSize = true;
            this.lprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprecio.ForeColor = System.Drawing.Color.Lime;
            this.lprecio.Location = new System.Drawing.Point(28, 12);
            this.lprecio.Name = "lprecio";
            this.lprecio.Size = new System.Drawing.Size(50, 24);
            this.lprecio.TabIndex = 14;
            this.lprecio.Text = "algo";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(333, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 37);
            this.label10.TabIndex = 83;
            this.label10.Text = "Agregar Venta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Bgenerarventa
            // 
            this.Bgenerarventa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bgenerarventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Bgenerarventa.FlatAppearance.BorderSize = 0;
            this.Bgenerarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bgenerarventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Bgenerarventa.ForeColor = System.Drawing.Color.White;
            this.Bgenerarventa.Image = ((System.Drawing.Image)(resources.GetObject("Bgenerarventa.Image")));
            this.Bgenerarventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bgenerarventa.Location = new System.Drawing.Point(773, 501);
            this.Bgenerarventa.Name = "Bgenerarventa";
            this.Bgenerarventa.Size = new System.Drawing.Size(130, 48);
            this.Bgenerarventa.TabIndex = 84;
            this.Bgenerarventa.Text = "Vender";
            this.Bgenerarventa.UseVisualStyleBackColor = false;
            // 
            // bcancelarventa
            // 
            this.bcancelarventa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcancelarventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.bcancelarventa.FlatAppearance.BorderSize = 0;
            this.bcancelarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelarventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.bcancelarventa.ForeColor = System.Drawing.Color.White;
            this.bcancelarventa.Image = ((System.Drawing.Image)(resources.GetObject("bcancelarventa.Image")));
            this.bcancelarventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bcancelarventa.Location = new System.Drawing.Point(773, 447);
            this.bcancelarventa.Name = "bcancelarventa";
            this.bcancelarventa.Size = new System.Drawing.Size(130, 48);
            this.bcancelarventa.TabIndex = 85;
            this.bcancelarventa.Text = "Cancelar";
            this.bcancelarventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bcancelarventa.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 82);
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
            this.label6.Location = new System.Drawing.Point(770, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "Total a Pagar:";
            // 
            // bagregarproducto
            // 
            this.bagregarproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bagregarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bagregarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bagregarproducto.FlatAppearance.BorderSize = 2;
            this.bagregarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagregarproducto.Image = ((System.Drawing.Image)(resources.GetObject("bagregarproducto.Image")));
            this.bagregarproducto.Location = new System.Drawing.Point(789, 193);
            this.bagregarproducto.Name = "bagregarproducto";
            this.bagregarproducto.Size = new System.Drawing.Size(97, 87);
            this.bagregarproducto.TabIndex = 89;
            this.bagregarproducto.Text = "Agregar";
            this.bagregarproducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bagregarproducto.UseVisualStyleBackColor = true;
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
            // dgdetalle
            // 
            this.dgdetalle.AllowUserToAddRows = false;
            this.dgdetalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.eliminar});
            this.dgdetalle.Location = new System.Drawing.Point(3, 26);
            this.dgdetalle.Name = "dgdetalle";
            this.dgdetalle.Size = new System.Drawing.Size(735, 206);
            this.dgdetalle.TabIndex = 0;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "Eliminar";
            // 
            // cbproductos
            // 
            this.cbproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbproductos.DisplayMember = "descripcion";
            this.cbproductos.ForeColor = System.Drawing.Color.White;
            this.cbproductos.FormattingEnabled = true;
            this.cbproductos.Location = new System.Drawing.Point(224, 40);
            this.cbproductos.Name = "cbproductos";
            this.cbproductos.Size = new System.Drawing.Size(150, 25);
            this.cbproductos.TabIndex = 31;
            this.cbproductos.SelectedIndexChanged += new System.EventHandler(this.cbproductos_SelectedIndexChanged);
            // 
            // Fagregar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(914, 983);
            this.Controls.Add(this.bagregarproducto);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fagregar_venta";
            this.Text = "Fagregar_venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucantidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lfecha;
        private System.Windows.Forms.TextBox tidfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lvendedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nucantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tcodproducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Bgenerarventa;
        private System.Windows.Forms.Button bcancelarventa;
        private System.Windows.Forms.TextBox tfecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bbuscarproducto;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tprecioproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bagregarproducto;
        private System.Windows.Forms.ComboBox cbtipopago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tidvendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgdetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.ComboBox cbproductos;
    }
}