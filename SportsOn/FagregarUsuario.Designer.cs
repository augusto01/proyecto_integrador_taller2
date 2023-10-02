namespace SportsOn
{
    partial class FagregarUsuario
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
            TBnombre = new TextBox();
            TBapellido = new TextBox();
            TBdni = new TextBox();
            TBdomicilio = new TextBox();
            TBemail = new TextBox();
            TBcontra = new TextBox();
            CBcategoria = new ComboBox();
            Lcategoria = new Label();
            Bregistrar = new Button();
            Bcancelar = new Button();
            Lsports = new Label();
            label1 = new Label();
            TBcelular = new TextBox();
            Enombre = new ErrorProvider(components);
            Eapellido = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Edomicilio = new ErrorProvider(components);
            Eemail = new ErrorProvider(components);
            Econtra = new ErrorProvider(components);
            Econfcontra = new ErrorProvider(components);
            Ecelular = new ErrorProvider(components);
            Ecategoria = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edomicilio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econfcontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            SuspendLayout();
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(156, 117);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(279, 23);
            TBnombre.TabIndex = 0;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // TBapellido
            // 
            TBapellido.Location = new Point(156, 164);
            TBapellido.Name = "TBapellido";
            TBapellido.PlaceholderText = "Apellido";
            TBapellido.Size = new Size(279, 23);
            TBapellido.TabIndex = 1;
            TBapellido.KeyPress += TBapellido_KeyPress;
            // 
            // TBdni
            // 
            TBdni.Location = new Point(156, 214);
            TBdni.Name = "TBdni";
            TBdni.PlaceholderText = "DNI";
            TBdni.Size = new Size(279, 23);
            TBdni.TabIndex = 2;
            TBdni.KeyPress += TBdni_KeyPress;
            // 
            // TBdomicilio
            // 
            TBdomicilio.Location = new Point(156, 257);
            TBdomicilio.Name = "TBdomicilio";
            TBdomicilio.PlaceholderText = "Domicilio";
            TBdomicilio.Size = new Size(279, 23);
            TBdomicilio.TabIndex = 3;
            // 
            // TBemail
            // 
            TBemail.Location = new Point(156, 303);
            TBemail.Name = "TBemail";
            TBemail.PlaceholderText = "Email";
            TBemail.Size = new Size(279, 23);
            TBemail.TabIndex = 4;
            TBemail.KeyPress += TBemail_KeyPress;
            // 
            // TBcontra
            // 
            TBcontra.Location = new Point(156, 360);
            TBcontra.Name = "TBcontra";
            TBcontra.PlaceholderText = "Contraseña";
            TBcontra.Size = new Size(279, 23);
            TBcontra.TabIndex = 5;
            TBcontra.UseSystemPasswordChar = true;
            TBcontra.TextChanged += TBcontra_TextChanged;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(267, 460);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(166, 23);
            CBcategoria.TabIndex = 8;
            CBcategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Lcategoria
            // 
            Lcategoria.AutoSize = true;
            Lcategoria.Location = new Point(156, 463);
            Lcategoria.Name = "Lcategoria";
            Lcategoria.Size = new Size(58, 15);
            Lcategoria.TabIndex = 9;
            Lcategoria.Text = "Categoria";
            // 
            // Bregistrar
            // 
            Bregistrar.BackColor = Color.FromArgb(192, 255, 192);
            Bregistrar.Image = Properties.Resources.guardar1;
            Bregistrar.ImageAlign = ContentAlignment.MiddleLeft;
            Bregistrar.Location = new Point(156, 500);
            Bregistrar.Name = "Bregistrar";
            Bregistrar.Size = new Size(126, 41);
            Bregistrar.TabIndex = 10;
            Bregistrar.Text = "Registrar";
            Bregistrar.UseVisualStyleBackColor = false;
            Bregistrar.Click += Bregistrar_Click;
            // 
            // Bcancelar
            // 
            Bcancelar.BackColor = Color.FromArgb(255, 192, 192);
            Bcancelar.Image = Properties.Resources.cancelar1;
            Bcancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Bcancelar.Location = new Point(307, 500);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(126, 41);
            Bcancelar.TabIndex = 11;
            Bcancelar.Text = "Cancelar";
            Bcancelar.UseVisualStyleBackColor = false;
            Bcancelar.Click += Bcancelar_Click_1;
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(154, 580);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 17;
            Lsports.Text = "SportsWorld";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(144, 42);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 18;
            label1.Text = "Agregar Usuario";
            // 
            // TBcelular
            // 
            TBcelular.Location = new Point(154, 416);
            TBcelular.Name = "TBcelular";
            TBcelular.PlaceholderText = "Nro telefono";
            TBcelular.Size = new Size(279, 23);
            TBcelular.TabIndex = 19;
            TBcelular.KeyPress += TBcelular_KeyPress;
            // 
            // Enombre
            // 
            Enombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Enombre.ContainerControl = this;
            // 
            // Eapellido
            // 
            Eapellido.ContainerControl = this;
            // 
            // Edni
            // 
            Edni.ContainerControl = this;
            // 
            // Edomicilio
            // 
            Edomicilio.ContainerControl = this;
            // 
            // Eemail
            // 
            Eemail.ContainerControl = this;
            // 
            // Econtra
            // 
            Econtra.ContainerControl = this;
            // 
            // Econfcontra
            // 
            Econfcontra.ContainerControl = this;
            // 
            // Ecelular
            // 
            Ecelular.ContainerControl = this;
            // 
            // Ecategoria
            // 
            Ecategoria.ContainerControl = this;
            // 
            // FagregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(591, 644);
            Controls.Add(TBcelular);
            Controls.Add(label1);
            Controls.Add(Lsports);
            Controls.Add(Bcancelar);
            Controls.Add(Bregistrar);
            Controls.Add(Lcategoria);
            Controls.Add(CBcategoria);
            Controls.Add(TBcontra);
            Controls.Add(TBemail);
            Controls.Add(TBdomicilio);
            Controls.Add(TBdni);
            Controls.Add(TBapellido);
            Controls.Add(TBnombre);
            Name = "FagregarUsuario";
            Text = "Agregar Usuario";
            Load += FagregarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edomicilio).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Econfcontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBnombre;
        private TextBox TBapellido;
        private TextBox TBdni;
        private TextBox TBdomicilio;
        private TextBox TBemail;
        private TextBox TBcontra;
        private ComboBox CBcategoria;
        private Label Lcategoria;
        private Button Bregistrar;
        private Button Bcancelar;
        private Label Lsports;
        private Label label1;
        private TextBox TBcelular;
        private ErrorProvider Enombre;
        private ErrorProvider Eapellido;
        private ErrorProvider Edni;
        private ErrorProvider Edomicilio;
        private ErrorProvider Eemail;
        private ErrorProvider Econtra;
        private ErrorProvider Econfcontra;
        private ErrorProvider Ecelular;
        private ErrorProvider Ecategoria;
    }
}