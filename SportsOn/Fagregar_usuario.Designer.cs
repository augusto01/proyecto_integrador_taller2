namespace SportsOn
{
    partial class Fagregar_usuario
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
            Tnombre = new TextBox();
            Tapellido = new TextBox();
            Lcontra = new TextBox();
            Tdomicilio = new TextBox();
            Tcelular = new TextBox();
            CBcategoria = new ComboBox();
            Temail = new TextBox();
            Lsports = new Label();
            Lindex = new Label();
            Bagregar = new Button();
            Bcancelar = new Button();
            Tdni = new TextBox();
            Enombre = new ErrorProvider(components);
            Eapellido = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Econtra = new ErrorProvider(components);
            Edomicilio = new ErrorProvider(components);
            Ecelular = new ErrorProvider(components);
            Eemail = new ErrorProvider(components);
            Ecategoria = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edomicilio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            SuspendLayout();
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(232, 63);
            Tnombre.Name = "Tnombre";
            Tnombre.PlaceholderText = "Nombre";
            Tnombre.Size = new Size(265, 23);
            Tnombre.TabIndex = 0;
            Tnombre.TabStop = false;
            Tnombre.KeyPress += Tnombre_KeyPress;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(232, 115);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 1;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // Lcontra
            // 
            Lcontra.Location = new Point(232, 207);
            Lcontra.Name = "Lcontra";
            Lcontra.PlaceholderText = "Contraseña";
            Lcontra.Size = new Size(265, 23);
            Lcontra.TabIndex = 2;
            Lcontra.UseSystemPasswordChar = true;
            Lcontra.TextChanged += Lcontra_TextChanged;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(232, 253);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 23);
            Tdomicilio.TabIndex = 3;
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(232, 304);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 23);
            Tcelular.TabIndex = 4;
            Tcelular.KeyPress += Tcelular_KeyPress;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(232, 389);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 5;
            // 
            // Temail
            // 
            Temail.Location = new Point(232, 346);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 23);
            Temail.TabIndex = 7;
            Temail.KeyPress += Temail_KeyPress;
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(220, 500);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 16;
            Lsports.Text = "SportsWorld";
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lindex.ForeColor = SystemColors.ActiveCaption;
            Lindex.Location = new Point(232, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(275, 37);
            Lindex.TabIndex = 17;
            Lindex.Text = "Agregar Usuario";
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.FromArgb(192, 255, 192);
            Bagregar.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar.Image = Properties.Resources.guardar2;
            Bagregar.ImageAlign = ContentAlignment.MiddleLeft;
            Bagregar.Location = new Point(232, 433);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(128, 40);
            Bagregar.TabIndex = 18;
            Bagregar.Text = "Agregar";
            Bagregar.UseVisualStyleBackColor = false;
            // 
            // Bcancelar
            // 
            Bcancelar.BackColor = Color.FromArgb(255, 192, 192);
            Bcancelar.Image = Properties.Resources.cancelar2;
            Bcancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Bcancelar.Location = new Point(366, 433);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(128, 40);
            Bcancelar.TabIndex = 19;
            Bcancelar.Text = "Cancelar";
            Bcancelar.UseVisualStyleBackColor = false;
            // 
            // Tdni
            // 
            Tdni.Location = new Point(232, 159);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 23);
            Tdni.TabIndex = 20;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Enombre
            // 
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
            // Econtra
            // 
            Econtra.ContainerControl = this;
            // 
            // Edomicilio
            // 
            Edomicilio.ContainerControl = this;
            // 
            // Ecelular
            // 
            Ecelular.ContainerControl = this;
            // 
            // Eemail
            // 
            Eemail.ContainerControl = this;
            // 
            // Ecategoria
            // 
            Ecategoria.ContainerControl = this;
            // 
            // Fagregar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(741, 579);
            Controls.Add(Tdni);
            Controls.Add(Bcancelar);
            Controls.Add(Bagregar);
            Controls.Add(Lindex);
            Controls.Add(Lsports);
            Controls.Add(Temail);
            Controls.Add(CBcategoria);
            Controls.Add(Tcelular);
            Controls.Add(Tdomicilio);
            Controls.Add(Lcontra);
            Controls.Add(Tapellido);
            Controls.Add(Tnombre);
            Name = "Fagregar_usuario";
            Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edomicilio).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tnombre;
        private TextBox Tapellido;
        private TextBox Lcontra;
        private TextBox Tdomicilio;
        private TextBox Tcelular;
        private ComboBox CBcategoria;
        private TextBox Temail;
        private Label Lsports;
        private Label Lindex;
        private Button Bagregar;
        private Button Bcancelar;
        private TextBox Tdni;
        private ErrorProvider Enombre;
        private ErrorProvider Eapellido;
        private ErrorProvider Edni;
        private ErrorProvider Econtra;
        private ErrorProvider Edomicilio;
        private ErrorProvider Ecelular;
        private ErrorProvider Eemail;
        private ErrorProvider Ecategoria;
    }
}