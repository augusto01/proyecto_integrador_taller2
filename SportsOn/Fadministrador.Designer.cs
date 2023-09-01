namespace SportsOn
{
    partial class Fadministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fadministrador));
            panelEmpleado = new Panel();
            Lrol = new Label();
            Lnombre = new Label();
            dg_empleado = new DataGridView();
            CodProducto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Lsports = new Label();
            Bventa = new Button();
            Bnota = new Button();
            Bv_ventas = new Button();
            Bdatos_empleado = new Button();
            button1 = new Button();
            BcerrarSesion = new Button();
            Bbuscarproducto = new Button();
            Tbuscar_producto = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleado).BeginInit();
            SuspendLayout();
            // 
            // panelEmpleado
            // 
            panelEmpleado.Controls.Add(Lrol);
            panelEmpleado.Controls.Add(Lnombre);
            panelEmpleado.Location = new Point(12, 12);
            panelEmpleado.Name = "panelEmpleado";
            panelEmpleado.Size = new Size(835, 56);
            panelEmpleado.TabIndex = 9;
            // 
            // Lrol
            // 
            Lrol.AutoSize = true;
            Lrol.Location = new Point(183, 18);
            Lrol.Name = "Lrol";
            Lrol.Size = new Size(106, 15);
            Lrol.TabIndex = 9;
            Lrol.Text = "Rol: Administrador";
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
            // dg_empleado
            // 
            dg_empleado.BackgroundColor = SystemColors.ButtonHighlight;
            dg_empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_empleado.Columns.AddRange(new DataGridViewColumn[] { CodProducto, Descripcion, Talle, cantidad, Precio });
            dg_empleado.GridColor = SystemColors.ActiveCaptionText;
            dg_empleado.Location = new Point(161, 211);
            dg_empleado.Name = "dg_empleado";
            dg_empleado.RowTemplate.Height = 25;
            dg_empleado.Size = new Size(543, 357);
            dg_empleado.TabIndex = 10;
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
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(289, 594);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 16;
            Lsports.Text = "SportsWorld";
            // 
            // Bventa
            // 
            Bventa.AccessibleName = "Registrar Venta";
            Bventa.BackColor = Color.White;
            Bventa.Image = (Image)resources.GetObject("Bventa.Image");
            Bventa.ImageAlign = ContentAlignment.TopCenter;
            Bventa.Location = new Point(12, 74);
            Bventa.Name = "Bventa";
            Bventa.Size = new Size(88, 93);
            Bventa.TabIndex = 17;
            Bventa.Text = "Ventas";
            Bventa.TextAlign = ContentAlignment.BottomCenter;
            Bventa.UseVisualStyleBackColor = false;
            // 
            // Bnota
            // 
            Bnota.BackColor = Color.White;
            Bnota.Image = (Image)resources.GetObject("Bnota.Image");
            Bnota.ImageAlign = ContentAlignment.TopCenter;
            Bnota.Location = new Point(101, 74);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(88, 93);
            Bnota.TabIndex = 18;
            Bnota.Text = "Notas";
            Bnota.TextAlign = ContentAlignment.BottomCenter;
            Bnota.UseVisualStyleBackColor = false;
            // 
            // Bv_ventas
            // 
            Bv_ventas.BackColor = SystemColors.ButtonHighlight;
            Bv_ventas.Image = (Image)resources.GetObject("Bv_ventas.Image");
            Bv_ventas.ImageAlign = ContentAlignment.TopCenter;
            Bv_ventas.Location = new Point(195, 74);
            Bv_ventas.Name = "Bv_ventas";
            Bv_ventas.Size = new Size(88, 93);
            Bv_ventas.TabIndex = 19;
            Bv_ventas.Text = "Compras";
            Bv_ventas.TextAlign = ContentAlignment.BottomCenter;
            Bv_ventas.UseVisualStyleBackColor = false;
            Bv_ventas.Click += Bv_ventas_Click;
            // 
            // Bdatos_empleado
            // 
            Bdatos_empleado.BackColor = Color.White;
            Bdatos_empleado.Image = (Image)resources.GetObject("Bdatos_empleado.Image");
            Bdatos_empleado.ImageAlign = ContentAlignment.TopCenter;
            Bdatos_empleado.Location = new Point(665, 74);
            Bdatos_empleado.Name = "Bdatos_empleado";
            Bdatos_empleado.Size = new Size(88, 93);
            Bdatos_empleado.TabIndex = 20;
            Bdatos_empleado.Text = "Perfil";
            Bdatos_empleado.TextAlign = ContentAlignment.BottomCenter;
            Bdatos_empleado.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(289, 74);
            button1.Name = "button1";
            button1.Size = new Size(88, 93);
            button1.TabIndex = 21;
            button1.Text = "Caja";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // BcerrarSesion
            // 
            BcerrarSesion.BackColor = Color.White;
            BcerrarSesion.Image = (Image)resources.GetObject("BcerrarSesion.Image");
            BcerrarSesion.ImageAlign = ContentAlignment.TopCenter;
            BcerrarSesion.Location = new Point(759, 74);
            BcerrarSesion.Name = "BcerrarSesion";
            BcerrarSesion.Size = new Size(88, 93);
            BcerrarSesion.TabIndex = 22;
            BcerrarSesion.Text = "Cerrar Sesion";
            BcerrarSesion.TextAlign = ContentAlignment.BottomCenter;
            BcerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Bbuscarproducto
            // 
            Bbuscarproducto.Image = Properties.Resources.buscar3;
            Bbuscarproducto.Location = new Point(652, 176);
            Bbuscarproducto.Name = "Bbuscarproducto";
            Bbuscarproducto.Size = new Size(53, 31);
            Bbuscarproducto.TabIndex = 25;
            Bbuscarproducto.UseVisualStyleBackColor = true;
            // 
            // Tbuscar_producto
            // 
            Tbuscar_producto.Location = new Point(342, 179);
            Tbuscar_producto.Name = "Tbuscar_producto";
            Tbuscar_producto.Size = new Size(304, 23);
            Tbuscar_producto.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 179);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 23;
            label1.Text = "Buscar un producto por codigo:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(383, 74);
            button2.Name = "button2";
            button2.Size = new Size(88, 93);
            button2.TabIndex = 26;
            button2.Text = "Informes";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(477, 74);
            button3.Name = "button3";
            button3.Size = new Size(88, 93);
            button3.TabIndex = 27;
            button3.Text = "Stock";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(571, 74);
            button4.Name = "button4";
            button4.Size = new Size(88, 93);
            button4.TabIndex = 28;
            button4.Text = "Usuarios";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // Fadministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 678);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Bbuscarproducto);
            Controls.Add(Tbuscar_producto);
            Controls.Add(label1);
            Controls.Add(BcerrarSesion);
            Controls.Add(button1);
            Controls.Add(Bdatos_empleado);
            Controls.Add(Bv_ventas);
            Controls.Add(Bnota);
            Controls.Add(Bventa);
            Controls.Add(Lsports);
            Controls.Add(dg_empleado);
            Controls.Add(panelEmpleado);
            Name = "Fadministrador";
            Text = "SportsWorld";
            panelEmpleado.ResumeLayout(false);
            panelEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_empleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEmpleado;
        private Label Lrol;
        private Label Lnombre;
        private DataGridView dg_empleado;
        private DataGridViewTextBoxColumn CodProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Talle;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Precio;
        private Label Lsports;
        private Button Bventa;
        private Button Bnota;
        private Button Bv_ventas;
        private Button Bdatos_empleado;
        private Button button1;
        private Button BcerrarSesion;
        private Button Bbuscarproducto;
        private TextBox Tbuscar_producto;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}