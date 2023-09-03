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
            Lsports = new Label();
            Bventa = new Button();
            Bnota = new Button();
            Bv_ventas = new Button();
            Bdatos_empleado = new Button();
            Bcaja = new Button();
            BcerrarSesion = new Button();
            Binforme = new Button();
            Bstock = new Button();
            Busuario = new Button();
            pMenu = new Panel();
            Bcerrar = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pMenu.SuspendLayout();
            SuspendLayout();
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
            Bventa.BackColor = Color.Transparent;
            Bventa.Cursor = Cursors.Hand;
            Bventa.FlatAppearance.BorderSize = 0;
            Bventa.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bventa.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bventa.FlatStyle = FlatStyle.Flat;
            Bventa.Image = (Image)resources.GetObject("Bventa.Image");
            Bventa.ImageAlign = ContentAlignment.TopCenter;
            Bventa.Location = new Point(3, 68);
            Bventa.Name = "Bventa";
            Bventa.Size = new Size(88, 93);
            Bventa.TabIndex = 17;
            Bventa.Text = "Ventas";
            Bventa.TextAlign = ContentAlignment.BottomCenter;
            Bventa.UseVisualStyleBackColor = false;
            // 
            // Bnota
            // 
            Bnota.BackColor = Color.Transparent;
            Bnota.CausesValidation = false;
            Bnota.Cursor = Cursors.Hand;
            Bnota.FlatAppearance.BorderSize = 0;
            Bnota.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bnota.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bnota.FlatStyle = FlatStyle.Flat;
            Bnota.Image = (Image)resources.GetObject("Bnota.Image");
            Bnota.ImageAlign = ContentAlignment.TopCenter;
            Bnota.Location = new Point(97, 68);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(88, 93);
            Bnota.TabIndex = 18;
            Bnota.Text = "Notas";
            Bnota.TextAlign = ContentAlignment.BottomCenter;
            Bnota.UseVisualStyleBackColor = false;
            // 
            // Bv_ventas
            // 
            Bv_ventas.BackColor = Color.Transparent;
            Bv_ventas.Cursor = Cursors.Hand;
            Bv_ventas.FlatAppearance.BorderSize = 0;
            Bv_ventas.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bv_ventas.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bv_ventas.FlatStyle = FlatStyle.Flat;
            Bv_ventas.Image = (Image)resources.GetObject("Bv_ventas.Image");
            Bv_ventas.ImageAlign = ContentAlignment.TopCenter;
            Bv_ventas.Location = new Point(191, 68);
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
            Bdatos_empleado.BackColor = Color.Transparent;
            Bdatos_empleado.Cursor = Cursors.Hand;
            Bdatos_empleado.FlatAppearance.BorderSize = 0;
            Bdatos_empleado.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bdatos_empleado.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bdatos_empleado.FlatStyle = FlatStyle.Flat;
            Bdatos_empleado.Image = (Image)resources.GetObject("Bdatos_empleado.Image");
            Bdatos_empleado.ImageAlign = ContentAlignment.TopCenter;
            Bdatos_empleado.Location = new Point(661, 68);
            Bdatos_empleado.Name = "Bdatos_empleado";
            Bdatos_empleado.Size = new Size(88, 93);
            Bdatos_empleado.TabIndex = 20;
            Bdatos_empleado.Text = "Perfil";
            Bdatos_empleado.TextAlign = ContentAlignment.BottomCenter;
            Bdatos_empleado.UseVisualStyleBackColor = false;
            // 
            // Bcaja
            // 
            Bcaja.BackColor = Color.Transparent;
            Bcaja.Cursor = Cursors.Hand;
            Bcaja.FlatAppearance.BorderSize = 0;
            Bcaja.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bcaja.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bcaja.FlatStyle = FlatStyle.Flat;
            Bcaja.Image = (Image)resources.GetObject("Bcaja.Image");
            Bcaja.ImageAlign = ContentAlignment.TopCenter;
            Bcaja.Location = new Point(285, 68);
            Bcaja.Name = "Bcaja";
            Bcaja.Size = new Size(88, 93);
            Bcaja.TabIndex = 21;
            Bcaja.Text = "Caja";
            Bcaja.TextAlign = ContentAlignment.BottomCenter;
            Bcaja.UseVisualStyleBackColor = false;
            // 
            // BcerrarSesion
            // 
            BcerrarSesion.BackColor = Color.Transparent;
            BcerrarSesion.Cursor = Cursors.Hand;
            BcerrarSesion.FlatAppearance.BorderSize = 0;
            BcerrarSesion.FlatAppearance.MouseDownBackColor = Color.Lime;
            BcerrarSesion.FlatAppearance.MouseOverBackColor = Color.Lime;
            BcerrarSesion.FlatStyle = FlatStyle.Flat;
            BcerrarSesion.Image = (Image)resources.GetObject("BcerrarSesion.Image");
            BcerrarSesion.ImageAlign = ContentAlignment.TopCenter;
            BcerrarSesion.Location = new Point(755, 68);
            BcerrarSesion.Name = "BcerrarSesion";
            BcerrarSesion.Size = new Size(88, 93);
            BcerrarSesion.TabIndex = 22;
            BcerrarSesion.Text = "Cerrar Sesion";
            BcerrarSesion.TextAlign = ContentAlignment.BottomCenter;
            BcerrarSesion.UseVisualStyleBackColor = false;
            BcerrarSesion.Click += BcerrarSesion_Click;
            // 
            // Binforme
            // 
            Binforme.BackColor = Color.Transparent;
            Binforme.Cursor = Cursors.Hand;
            Binforme.FlatAppearance.BorderSize = 0;
            Binforme.FlatAppearance.MouseDownBackColor = Color.Lime;
            Binforme.FlatAppearance.MouseOverBackColor = Color.Lime;
            Binforme.FlatStyle = FlatStyle.Flat;
            Binforme.Image = (Image)resources.GetObject("Binforme.Image");
            Binforme.ImageAlign = ContentAlignment.TopCenter;
            Binforme.Location = new Point(379, 68);
            Binforme.Name = "Binforme";
            Binforme.Size = new Size(88, 93);
            Binforme.TabIndex = 26;
            Binforme.Text = "Informes";
            Binforme.TextAlign = ContentAlignment.BottomCenter;
            Binforme.UseVisualStyleBackColor = false;
            // 
            // Bstock
            // 
            Bstock.BackColor = Color.Transparent;
            Bstock.Cursor = Cursors.Hand;
            Bstock.FlatAppearance.BorderSize = 0;
            Bstock.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bstock.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bstock.FlatStyle = FlatStyle.Flat;
            Bstock.Image = (Image)resources.GetObject("Bstock.Image");
            Bstock.ImageAlign = ContentAlignment.TopCenter;
            Bstock.Location = new Point(473, 68);
            Bstock.Name = "Bstock";
            Bstock.Size = new Size(88, 93);
            Bstock.TabIndex = 27;
            Bstock.Text = "Stock";
            Bstock.TextAlign = ContentAlignment.BottomCenter;
            Bstock.UseVisualStyleBackColor = false;
            // 
            // Busuario
            // 
            Busuario.BackColor = Color.Transparent;
            Busuario.Cursor = Cursors.Hand;
            Busuario.FlatAppearance.BorderSize = 0;
            Busuario.FlatAppearance.MouseDownBackColor = Color.Lime;
            Busuario.FlatAppearance.MouseOverBackColor = Color.Lime;
            Busuario.FlatStyle = FlatStyle.Flat;
            Busuario.Image = (Image)resources.GetObject("Busuario.Image");
            Busuario.ImageAlign = ContentAlignment.TopCenter;
            Busuario.Location = new Point(567, 68);
            Busuario.Name = "Busuario";
            Busuario.Size = new Size(88, 93);
            Busuario.TabIndex = 28;
            Busuario.Text = "Usuarios";
            Busuario.TextAlign = ContentAlignment.BottomCenter;
            Busuario.UseVisualStyleBackColor = false;
            Busuario.Click += Busuario_Click;
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.MenuHighlight;
            pMenu.Controls.Add(Bcerrar);
            pMenu.Controls.Add(panel1);
            pMenu.Controls.Add(Busuario);
            pMenu.Controls.Add(Bstock);
            pMenu.Controls.Add(Binforme);
            pMenu.Controls.Add(BcerrarSesion);
            pMenu.Controls.Add(Bcaja);
            pMenu.Controls.Add(Bdatos_empleado);
            pMenu.Controls.Add(Bv_ventas);
            pMenu.Controls.Add(Bnota);
            pMenu.Controls.Add(Bventa);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(860, 164);
            pMenu.TabIndex = 29;
            pMenu.Paint += pMenu_Paint;
            // 
            // Bcerrar
            // 
            Bcerrar.Cursor = Cursors.Hand;
            Bcerrar.FlatAppearance.BorderSize = 0;
            Bcerrar.FlatStyle = FlatStyle.Flat;
            Bcerrar.ForeColor = Color.CornflowerBlue;
            Bcerrar.Image = Properties.Resources.cerrar;
            Bcerrar.Location = new Point(812, 3);
            Bcerrar.Name = "Bcerrar";
            Bcerrar.Size = new Size(45, 45);
            Bcerrar.TabIndex = 31;
            Bcerrar.UseVisualStyleBackColor = true;
            Bcerrar.Click += Bcerrar_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(828, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(32, 453);
            panel1.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.ForeColor = SystemColors.ControlText;
            flowLayoutPanel1.Location = new Point(0, 164);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(860, 514);
            flowLayoutPanel1.TabIndex = 30;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Fadministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 678);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pMenu);
            Controls.Add(Lsports);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fadministrador";
            Text = "SportsWorld";
            pMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lsports;
        private Button Bventa;
        private Button Bnota;
        private Button Bv_ventas;
        private Button Bdatos_empleado;
        private Button Bcaja;
        private Button BcerrarSesion;
        private Button Binforme;
        private Button Bstock;
        private Button Busuario;
        private Panel pMenu;
        private Panel panel1;
        private Button Bcerrar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}