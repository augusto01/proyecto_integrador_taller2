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
            pVentas = new Panel();
            button1 = new Button();
            button2 = new Button();
            pMenu = new Panel();
            Lcargo = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            Luser = new Label();
            Bcerrar = new Button();
            panel1 = new Panel();
            Bstock = new Button();
            BcerrarSesion = new Button();
            Bcaja = new Button();
            Bdatos_empleado = new Button();
            Bnota = new Button();
            Bventa = new Button();
            pCaja = new Panel();
            BcerrarCaja = new Button();
            Vcaja = new Button();
            Lsports = new Label();
            pVentas.SuspendLayout();
            pMenu.SuspendLayout();
            pCaja.SuspendLayout();
            SuspendLayout();
            // 
            // pVentas
            // 
            pVentas.BackColor = SystemColors.Highlight;
            pVentas.Controls.Add(button1);
            pVentas.Controls.Add(button2);
            pVentas.Location = new Point(0, 164);
            pVentas.Name = "pVentas";
            pVentas.Size = new Size(93, 92);
            pVentas.TabIndex = 36;
            pVentas.Visible = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 36);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 32;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Lime;
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(-3, 0);
            button2.Name = "button2";
            button2.Size = new Size(96, 39);
            button2.TabIndex = 31;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.MenuHighlight;
            pMenu.Controls.Add(Lcargo);
            pMenu.Controls.Add(panel3);
            pMenu.Controls.Add(panel2);
            pMenu.Controls.Add(Luser);
            pMenu.Controls.Add(Bcerrar);
            pMenu.Controls.Add(panel1);
            pMenu.Controls.Add(Bstock);
            pMenu.Controls.Add(BcerrarSesion);
            pMenu.Controls.Add(Bcaja);
            pMenu.Controls.Add(Bdatos_empleado);
            pMenu.Controls.Add(Bnota);
            pMenu.Controls.Add(Bventa);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(854, 164);
            pMenu.TabIndex = 33;
            // 
            // Lcargo
            // 
            Lcargo.AutoSize = true;
            Lcargo.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lcargo.ForeColor = SystemColors.HighlightText;
            Lcargo.Image = Properties.Resources.icono_user;
            Lcargo.ImageAlign = ContentAlignment.MiddleRight;
            Lcargo.Location = new Point(637, 26);
            Lcargo.Name = "Lcargo";
            Lcargo.Size = new Size(112, 24);
            Lcargo.TabIndex = 37;
            Lcargo.Text = "Empleado        ";
            // 
            // panel3
            // 
            panel3.Location = new Point(557, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(115, 142);
            panel3.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Location = new Point(567, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 133);
            panel2.TabIndex = 0;
            // 
            // Luser
            // 
            Luser.AutoSize = true;
            Luser.BackColor = SystemColors.MenuHighlight;
            Luser.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Luser.ForeColor = SystemColors.HighlightText;
            Luser.Location = new Point(12, 26);
            Luser.Name = "Luser";
            Luser.Size = new Size(166, 24);
            Luser.TabIndex = 35;
            Luser.Text = "Bienvenido empleado!";
            // 
            // Bcerrar
            // 
            Bcerrar.Cursor = Cursors.Hand;
            Bcerrar.FlatAppearance.BorderSize = 0;
            Bcerrar.FlatStyle = FlatStyle.Flat;
            Bcerrar.ForeColor = Color.CornflowerBlue;
            Bcerrar.Image = (Image)resources.GetObject("Bcerrar.Image");
            Bcerrar.Location = new Point(814, 12);
            Bcerrar.Name = "Bcerrar";
            Bcerrar.Size = new Size(29, 29);
            Bcerrar.TabIndex = 34;
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
            // Bstock
            // 
            Bstock.BackColor = Color.Transparent;
            Bstock.Cursor = Cursors.Hand;
            Bstock.FlatAppearance.BorderSize = 0;
            Bstock.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bstock.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bstock.FlatStyle = FlatStyle.Flat;
            Bstock.ForeColor = Color.Black;
            Bstock.Image = (Image)resources.GetObject("Bstock.Image");
            Bstock.ImageAlign = ContentAlignment.TopCenter;
            Bstock.Location = new Point(453, 65);
            Bstock.Name = "Bstock";
            Bstock.Size = new Size(88, 93);
            Bstock.TabIndex = 27;
            Bstock.Text = "Stock";
            Bstock.TextAlign = ContentAlignment.BottomCenter;
            Bstock.UseVisualStyleBackColor = false;
            // 
            // BcerrarSesion
            // 
            BcerrarSesion.BackColor = Color.Transparent;
            BcerrarSesion.Cursor = Cursors.Hand;
            BcerrarSesion.FlatAppearance.BorderSize = 0;
            BcerrarSesion.FlatAppearance.MouseDownBackColor = Color.Lime;
            BcerrarSesion.FlatAppearance.MouseOverBackColor = Color.Lime;
            BcerrarSesion.FlatStyle = FlatStyle.Flat;
            BcerrarSesion.ForeColor = Color.Black;
            BcerrarSesion.Image = (Image)resources.GetObject("BcerrarSesion.Image");
            BcerrarSesion.ImageAlign = ContentAlignment.TopCenter;
            BcerrarSesion.Location = new Point(753, 68);
            BcerrarSesion.Name = "BcerrarSesion";
            BcerrarSesion.Size = new Size(88, 93);
            BcerrarSesion.TabIndex = 22;
            BcerrarSesion.Text = "Cerrar Sesion";
            BcerrarSesion.TextAlign = ContentAlignment.BottomCenter;
            BcerrarSesion.UseVisualStyleBackColor = false;
            BcerrarSesion.Click += BcerrarSesion_Click;
            // 
            // Bcaja
            // 
            Bcaja.BackColor = Color.Transparent;
            Bcaja.Cursor = Cursors.Hand;
            Bcaja.FlatAppearance.BorderSize = 0;
            Bcaja.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bcaja.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bcaja.FlatStyle = FlatStyle.Flat;
            Bcaja.ForeColor = Color.Black;
            Bcaja.Image = (Image)resources.GetObject("Bcaja.Image");
            Bcaja.ImageAlign = ContentAlignment.TopCenter;
            Bcaja.Location = new Point(303, 65);
            Bcaja.Name = "Bcaja";
            Bcaja.Size = new Size(88, 93);
            Bcaja.TabIndex = 21;
            Bcaja.Text = "Caja";
            Bcaja.TextAlign = ContentAlignment.BottomCenter;
            Bcaja.UseVisualStyleBackColor = false;
            Bcaja.Click += Bcaja_Click;
            // 
            // Bdatos_empleado
            // 
            Bdatos_empleado.BackColor = Color.Transparent;
            Bdatos_empleado.Cursor = Cursors.Hand;
            Bdatos_empleado.FlatAppearance.BorderSize = 0;
            Bdatos_empleado.FlatAppearance.MouseDownBackColor = Color.Lime;
            Bdatos_empleado.FlatAppearance.MouseOverBackColor = Color.Lime;
            Bdatos_empleado.FlatStyle = FlatStyle.Flat;
            Bdatos_empleado.ForeColor = Color.Black;
            Bdatos_empleado.Image = (Image)resources.GetObject("Bdatos_empleado.Image");
            Bdatos_empleado.ImageAlign = ContentAlignment.TopCenter;
            Bdatos_empleado.Location = new Point(603, 68);
            Bdatos_empleado.Name = "Bdatos_empleado";
            Bdatos_empleado.Size = new Size(88, 93);
            Bdatos_empleado.TabIndex = 20;
            Bdatos_empleado.Text = "Perfil";
            Bdatos_empleado.TextAlign = ContentAlignment.BottomCenter;
            Bdatos_empleado.UseVisualStyleBackColor = false;
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
            Bnota.ForeColor = Color.Black;
            Bnota.Image = (Image)resources.GetObject("Bnota.Image");
            Bnota.ImageAlign = ContentAlignment.TopCenter;
            Bnota.Location = new Point(153, 68);
            Bnota.Name = "Bnota";
            Bnota.Size = new Size(88, 93);
            Bnota.TabIndex = 18;
            Bnota.Text = "Notas";
            Bnota.TextAlign = ContentAlignment.BottomCenter;
            Bnota.UseVisualStyleBackColor = false;
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
            Bventa.ForeColor = Color.Black;
            Bventa.Image = (Image)resources.GetObject("Bventa.Image");
            Bventa.ImageAlign = ContentAlignment.TopCenter;
            Bventa.Location = new Point(3, 68);
            Bventa.Name = "Bventa";
            Bventa.Size = new Size(88, 93);
            Bventa.TabIndex = 17;
            Bventa.Text = "Ventas";
            Bventa.TextAlign = ContentAlignment.BottomCenter;
            Bventa.UseVisualStyleBackColor = false;
            Bventa.Click += Bventa_Click;
            // 
            // pCaja
            // 
            pCaja.BackColor = SystemColors.Highlight;
            pCaja.Controls.Add(BcerrarCaja);
            pCaja.Controls.Add(Vcaja);
            pCaja.Location = new Point(298, 164);
            pCaja.Name = "pCaja";
            pCaja.Size = new Size(93, 92);
            pCaja.TabIndex = 37;
            pCaja.Visible = false;
            // 
            // BcerrarCaja
            // 
            BcerrarCaja.Cursor = Cursors.Hand;
            BcerrarCaja.FlatAppearance.BorderSize = 0;
            BcerrarCaja.FlatAppearance.MouseDownBackColor = Color.Lime;
            BcerrarCaja.FlatAppearance.MouseOverBackColor = Color.Lime;
            BcerrarCaja.FlatStyle = FlatStyle.Flat;
            BcerrarCaja.ForeColor = Color.Black;
            BcerrarCaja.Location = new Point(0, 36);
            BcerrarCaja.Name = "BcerrarCaja";
            BcerrarCaja.Size = new Size(96, 39);
            BcerrarCaja.TabIndex = 32;
            BcerrarCaja.Text = "Cerrar Caja";
            BcerrarCaja.UseVisualStyleBackColor = true;
            // 
            // Vcaja
            // 
            Vcaja.BackColor = SystemColors.Highlight;
            Vcaja.Cursor = Cursors.Hand;
            Vcaja.FlatAppearance.BorderSize = 0;
            Vcaja.FlatAppearance.MouseDownBackColor = Color.Lime;
            Vcaja.FlatAppearance.MouseOverBackColor = Color.Lime;
            Vcaja.FlatStyle = FlatStyle.Flat;
            Vcaja.ForeColor = Color.Black;
            Vcaja.Location = new Point(0, 0);
            Vcaja.Name = "Vcaja";
            Vcaja.Size = new Size(96, 39);
            Vcaja.TabIndex = 31;
            Vcaja.Text = "Ver Caja";
            Vcaja.UseVisualStyleBackColor = false;
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(261, 565);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 38;
            Lsports.Text = "SportsWorld";
            // 
            // empleado
            // 
            AccessibleName = "asd";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(854, 639);
            Controls.Add(Lsports);
            Controls.Add(pCaja);
            Controls.Add(pVentas);
            Controls.Add(pMenu);
            Name = "empleado";
            Text = "SportsWorld";
            Load += empleado_Load;
            pVentas.ResumeLayout(false);
            pMenu.ResumeLayout(false);
            pMenu.PerformLayout();
            pCaja.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pVentas;
        private Button button1;
        private Button button2;
        private Panel pMenu;
        private Panel panel3;
        private Panel panel2;
        private Label Luser;
        private Button Bcerrar;
        private Panel panel1;
        private Button Bstock;
        private Button BcerrarSesion;
        private Button Bcaja;
        private Button Bdatos_empleado;
        private Button Bnota;
        private Button Bventa;
        private Panel pCaja;
        private Button BcerrarCaja;
        private Button Vcaja;
        private Label Lcargo;
        private Label Lsports;
    }
}