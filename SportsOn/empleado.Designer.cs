namespace SportsOn
{
    partial class empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empleado));
            Lnombre = new Label();
            Bv_ventas = new Button();
            Bnota = new Button();
            Bventa = new Button();
            panelEmpleado = new Panel();
            Lrol = new Label();
            dg_empleado = new DataGridView();
            CodProducto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Tbuscar_producto = new TextBox();
            Bbuscarproducto = new Button();
            BcerrarSesion = new Button();
            button1 = new Button();
            Bdatos_empleado = new Button();
            Lsports = new Label();
            panelEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleado).BeginInit();
            SuspendLayout();
            // 
            // Lnombre
            // 
            Lnombre.AutoSize = true;
            Lnombre.Location = new Point(14, 18);
            Lnombre.Name = "Lnombre";
            Lnombre.Size = new Size(117, 15);
            Lnombre.TabIndex = 0;
            Lnombre.Text = "Bienvenido nombre !";
            // 
            // Bv_ventas
            // 
            Bv_ventas.BackColor = SystemColors.ButtonHighlight;
            Bv_ventas.Image = (Image)resources.GetObject("Bv_ventas.Image");
            Bv_ventas.ImageAlign = ContentAlignment.TopCenter;
            Bv_ventas.Location = new Point(311, 74);
            Bv_ventas.Name = "Bv_ventas";
            Bv_ventas.Size = new Size(88, 93);
            Bv_ventas.TabIndex = 4;
            Bv_ventas.Text = "Compras";
            Bv_ventas.TextAlign = ContentAlignment.BottomCenter;
            Bv_ventas.UseVisualStyleBackColor = false;
            // 
            // Bnota
            // 
            Bnota.BackColor = Color.White;
            Bnota.Image = (Image)resources.GetObject("Bnota.Image");
            Bnota.ImageAlign = ContentAlignment.TopCenter;
            Bnota.Location = new Point(217, 74);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(88, 93);
            Bnota.TabIndex = 3;
            Bnota.Text = "Notas";
            Bnota.TextAlign = ContentAlignment.BottomCenter;
            Bnota.UseVisualStyleBackColor = false;
            Bnota.Click += Bnota_Click;
            // 
            // Bventa
            // 
            Bventa.AccessibleName = "Registrar Venta";
            Bventa.BackColor = Color.White;
            Bventa.Image = (Image)resources.GetObject("Bventa.Image");
            Bventa.ImageAlign = ContentAlignment.TopCenter;
            Bventa.Location = new Point(123, 74);
            Bventa.Name = "Bventa";
            Bventa.Size = new Size(88, 93);
            Bventa.TabIndex = 2;
            Bventa.Text = "Ventas";
            Bventa.TextAlign = ContentAlignment.BottomCenter;
            Bventa.UseVisualStyleBackColor = false;
            // 
            // panelEmpleado
            // 
            panelEmpleado.Controls.Add(Lrol);
            panelEmpleado.Controls.Add(Lnombre);
            panelEmpleado.Location = new Point(15, 12);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(788, 56);
            panelEmpleado.TabIndex = 8;
            // 
            // Lrol
            // 
            Lrol.AutoSize = true;
            Lrol.Location = new Point(183, 18);
            Lrol.Name = "Lrol";
            Lrol.Size = new Size(83, 15);
            Lrol.TabIndex = 9;
            Lrol.Text = "Rol: Empleado";
            // 
            // dg_empleado
            // 
            dg_empleado.BackgroundColor = SystemColors.ButtonHighlight;
            dg_empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_empleado.Columns.AddRange(new DataGridViewColumn[] { CodProducto, Descripcion, Talle, cantidad, Precio });
            dg_empleado.GridColor = SystemColors.ActiveCaptionText;
            dg_empleado.Location = new Point(123, 215);
            dg_empleado.Name = "dg_empleado";
            dg_empleado.RowTemplate.Height = 25;
            dg_empleado.Size = new Size(558, 357);
            dg_empleado.TabIndex = 9;
            dg_empleado.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CodProducto
            // 
            CodProducto.HeaderText = "Cod_Producto";
            CodProducto.Name = "CodProducto";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.Name = "Talle";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 186);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 10;
            label1.Text = "Buscar un producto por codigo:";
            // 
            // Tbuscar_producto
            // 
            Tbuscar_producto.Location = new Point(318, 183);
            Tbuscar_producto.Name = "Tbuscar_producto";
            Tbuscar_producto.Size = new Size(304, 23);
            Tbuscar_producto.TabIndex = 11;
            // 
            // Bbuscarproducto
            // 
            Bbuscarproducto.Image = Properties.Resources.buscar3;
            Bbuscarproducto.Location = new Point(628, 178);
            Bbuscarproducto.Name = "Bbuscarproducto";
            Bbuscarproducto.Size = new Size(53, 31);
            Bbuscarproducto.TabIndex = 12;
            Bbuscarproducto.UseVisualStyleBackColor = true;
            Bbuscarproducto.Click += Bbuscarproducto_Click;
            // 
            // BcerrarSesion
            // 
            BcerrarSesion.BackColor = Color.White;
            BcerrarSesion.Image = (Image)resources.GetObject("BcerrarSesion.Image");
            BcerrarSesion.ImageAlign = ContentAlignment.TopCenter;
            BcerrarSesion.Location = new Point(593, 74);
            BcerrarSesion.Name = "BcerrarSesion";
            BcerrarSesion.Size = new Size(88, 93);
            BcerrarSesion.TabIndex = 6;
            BcerrarSesion.Text = "Cerrar Sesion";
            BcerrarSesion.TextAlign = ContentAlignment.BottomCenter;
            BcerrarSesion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(405, 74);
            button1.Name = "button1";
            button1.Size = new Size(88, 93);
            button1.TabIndex = 13;
            button1.Text = "Caja";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // Bdatos_empleado
            // 
            Bdatos_empleado.BackColor = Color.White;
            Bdatos_empleado.Image = (Image)resources.GetObject("Bdatos_empleado.Image");
            Bdatos_empleado.ImageAlign = ContentAlignment.TopCenter;
            Bdatos_empleado.Location = new Point(499, 74);
            Bdatos_empleado.Name = "Bdatos_empleado";
            Bdatos_empleado.Size = new Size(88, 93);
            Bdatos_empleado.TabIndex = 14;
            Bdatos_empleado.Text = "Perfil";
            Bdatos_empleado.TextAlign = ContentAlignment.BottomCenter;
            Bdatos_empleado.UseVisualStyleBackColor = false;
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(270, 575);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 15;
            Lsports.Text = "SportsWorld";
            // 
            // empleado
            // 
            AccessibleName = "asd";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(809, 639);
            Controls.Add(Lsports);
            Controls.Add(Bdatos_empleado);
            Controls.Add(button1);
            Controls.Add(BcerrarSesion);
            Controls.Add(Bbuscarproducto);
            Controls.Add(Bnota);
            Controls.Add(Bventa);
            Controls.Add(Tbuscar_producto);
            Controls.Add(label1);
            Controls.Add(Bv_ventas);
            Controls.Add(dg_empleado);
            Controls.Add(panelEmpleado);
            Name = "empleado";
            Text = "SportsWorld";
            Load += empleado_Load;
            panelEmpleado.ResumeLayout(false);
            panelEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lnombre;
        private Button Bv_ventas;
        private Button Bnota;
        private Button Bventa;
        private Panel panelEmpleado;
        private Label Lrol;
        private DataGridView dg_empleado;
        private Label label1;
        private TextBox Tbuscar_producto;
        private DataGridViewTextBoxColumn CodProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Precio;
        private Button Bbuscarproducto;
        private Button BcerrarSesion;
        private Button button1;
        private Button Bdatos_empleado;
        private Label Lsports;
    }
}