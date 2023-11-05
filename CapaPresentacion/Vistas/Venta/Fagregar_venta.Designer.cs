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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tfecha = new System.Windows.Forms.TextBox();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tnombrevendedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lfecha = new System.Windows.Forms.Label();
            this.tidvendedor = new System.Windows.Forms.TextBox();
            this.lidvendedor = new System.Windows.Forms.Label();
            this.tidfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.banadir = new System.Windows.Forms.Button();
            this.dgproductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lprecio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Bagregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tfecha);
            this.groupBox1.Controls.Add(this.cbcliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tnombrevendedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lfecha);
            this.groupBox1.Controls.Add(this.tidvendedor);
            this.groupBox1.Controls.Add(this.lidvendedor);
            this.groupBox1.Controls.Add(this.tidfactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la venta";
            // 
            // tfecha
            // 
            this.tfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tfecha.ForeColor = System.Drawing.Color.White;
            this.tfecha.Location = new System.Drawing.Point(300, 24);
            this.tfecha.Name = "tfecha";
            this.tfecha.ReadOnly = true;
            this.tfecha.Size = new System.Drawing.Size(98, 23);
            this.tfecha.TabIndex = 10;
            // 
            // cbcliente
            // 
            this.cbcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbcliente.ForeColor = System.Drawing.Color.White;
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(476, 21);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(166, 25);
            this.cbcliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente:";
            // 
            // tnombrevendedor
            // 
            this.tnombrevendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tnombrevendedor.ForeColor = System.Drawing.Color.White;
            this.tnombrevendedor.Location = new System.Drawing.Point(105, 50);
            this.tnombrevendedor.Name = "tnombrevendedor";
            this.tnombrevendedor.ReadOnly = true;
            this.tnombrevendedor.Size = new System.Drawing.Size(119, 23);
            this.tnombrevendedor.TabIndex = 7;
            this.tnombrevendedor.TextChanged += new System.EventHandler(this.tnombrevendedor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // lfecha
            // 
            this.lfecha.AutoSize = true;
            this.lfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfecha.Location = new System.Drawing.Point(250, 24);
            this.lfecha.Name = "lfecha";
            this.lfecha.Size = new System.Drawing.Size(53, 18);
            this.lfecha.TabIndex = 5;
            this.lfecha.Text = "Fecha:";
            // 
            // tidvendedor
            // 
            this.tidvendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tidvendedor.ForeColor = System.Drawing.Color.White;
            this.tidvendedor.Location = new System.Drawing.Point(105, 23);
            this.tidvendedor.Name = "tidvendedor";
            this.tidvendedor.ReadOnly = true;
            this.tidvendedor.Size = new System.Drawing.Size(119, 23);
            this.tidvendedor.TabIndex = 4;
            this.tidvendedor.TextChanged += new System.EventHandler(this.tidvendedor_TextChanged);
            // 
            // lidvendedor
            // 
            this.lidvendedor.AutoSize = true;
            this.lidvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lidvendedor.Location = new System.Drawing.Point(15, 23);
            this.lidvendedor.Name = "lidvendedor";
            this.lidvendedor.Size = new System.Drawing.Size(93, 18);
            this.lidvendedor.TabIndex = 3;
            this.lidvendedor.Text = "ID Vendedor:";
            // 
            // tidfactura
            // 
            this.tidfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tidfactura.ForeColor = System.Drawing.Color.White;
            this.tidfactura.Location = new System.Drawing.Point(755, 21);
            this.tidfactura.Name = "tidfactura";
            this.tidfactura.ReadOnly = true;
            this.tidfactura.Size = new System.Drawing.Size(119, 23);
            this.tidfactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.banadir);
            this.groupBox2.Controls.Add(this.dgproductos);
            this.groupBox2.Controls.Add(this.tid);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tnombre);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.cbproducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Productos";
            // 
            // banadir
            // 
            this.banadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.banadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.banadir.FlatAppearance.BorderSize = 0;
            this.banadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banadir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banadir.ForeColor = System.Drawing.Color.White;
            this.banadir.Location = new System.Drawing.Point(788, 35);
            this.banadir.Name = "banadir";
            this.banadir.Size = new System.Drawing.Size(96, 26);
            this.banadir.TabIndex = 86;
            this.banadir.Text = "Añadir";
            this.banadir.UseVisualStyleBackColor = false;
            // 
            // dgproductos
            // 
            this.dgproductos.AllowUserToAddRows = false;
            this.dgproductos.AllowUserToDeleteRows = false;
            this.dgproductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgproductos.Location = new System.Drawing.Point(18, 68);
            this.dgproductos.Name = "dgproductos";
            this.dgproductos.Size = new System.Drawing.Size(866, 118);
            this.dgproductos.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Añadir";
            this.Column1.Name = "Column1";
            // 
            // tid
            // 
            this.tid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tid.ForeColor = System.Drawing.Color.White;
            this.tid.Location = new System.Drawing.Point(406, 39);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(137, 23);
            this.tid.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(403, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "Buscar por ID:";
            // 
            // tnombre
            // 
            this.tnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tnombre.ForeColor = System.Drawing.Color.White;
            this.tnombre.Location = new System.Drawing.Point(218, 39);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(137, 23);
            this.tnombre.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(215, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Buscar por nombre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(572, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(575, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 23);
            this.numericUpDown1.TabIndex = 16;
            // 
            // cbproducto
            // 
            this.cbproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbproducto.ForeColor = System.Drawing.Color.White;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(18, 37);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(137, 25);
            this.cbproducto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Agregar Producto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lprecio);
            this.panel1.Location = new System.Drawing.Point(769, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 48);
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
            this.lprecio.Size = new System.Drawing.Size(55, 24);
            this.lprecio.TabIndex = 14;
            this.lprecio.Text = "0.00 ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(333, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 37);
            this.label10.TabIndex = 83;
            this.label10.Text = "Agregar Venta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Bagregar
            // 
            this.Bagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Bagregar.FlatAppearance.BorderSize = 0;
            this.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bagregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bagregar.ForeColor = System.Drawing.Color.White;
            this.Bagregar.Location = new System.Drawing.Point(767, 668);
            this.Bagregar.Name = "Bagregar";
            this.Bagregar.Size = new System.Drawing.Size(135, 48);
            this.Bagregar.TabIndex = 84;
            this.Bagregar.Text = "Generar Venta";
            this.Bagregar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(647, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 48);
            this.button1.TabIndex = 85;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(866, 158);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(769, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 48);
            this.panel2.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(75, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "0.00 ";
            // 
            // Fagregar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(914, 983);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bagregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fagregar_venta";
            this.Text = "Fagregar_venta";
            this.Load += new System.EventHandler(this.Fagregar_venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lfecha;
        private System.Windows.Forms.TextBox tidvendedor;
        private System.Windows.Forms.Label lidvendedor;
        private System.Windows.Forms.TextBox tidfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tnombrevendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lprecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgproductos;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Button Bagregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tfecha;
        private System.Windows.Forms.Button banadir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}