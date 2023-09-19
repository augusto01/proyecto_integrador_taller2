namespace SportsOn
{
    partial class FAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAgregarUsuario));
            Tdni = new TextBox();
            Bagregar = new Button();
            Lindex = new Label();
            Lsports = new Label();
            Temail = new TextBox();
            CBcategoria = new ComboBox();
            Tcelular = new TextBox();
            Tdomicilio = new TextBox();
            Lcontra = new TextBox();
            Tapellido = new TextBox();
            TBnombre = new TextBox();
            Enombre = new ErrorProvider(components);
            Eapellido = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Econtra = new ErrorProvider(components);
            Edomi = new ErrorProvider(components);
            Ecel = new ErrorProvider(components);
            Eemail = new ErrorProvider(components);
            Ecategoria = new ErrorProvider(components);
            Tuser = new TextBox();
            Tconfcontra = new TextBox();
            Econfcontra = new ErrorProvider(components);
            Euser = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edomi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econfcontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Euser).BeginInit();
            SuspendLayout();
            // 
            // Tdni
            // 
            Tdni.Location = new Point(49, 129);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 23);
            Tdni.TabIndex = 32;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.Transparent;
            Bagregar.Cursor = Cursors.Hand;
            Bagregar.FlatAppearance.BorderSize = 0;
            Bagregar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bagregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bagregar.FlatStyle = FlatStyle.Flat;
            Bagregar.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar.Image = (Image)resources.GetObject("Bagregar.Image");
            Bagregar.ImageAlign = ContentAlignment.TopCenter;
            Bagregar.Location = new Point(665, 150);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 30;
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(248, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(265, 51);
            Lindex.TabIndex = 29;
            Lindex.Text = "Agregar Usuario";
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.Lime;
            Lsports.Location = new Point(248, 622);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 28;
            Lsports.Text = "SportsWorld";
            // 
            // Temail
            // 
            Temail.Location = new Point(349, 129);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 23);
            Temail.TabIndex = 27;
            Temail.KeyPress += Temail_KeyPress;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(49, 227);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 26;
            CBcategoria.Text = "Tipo de Usuario";
            CBcategoria.SelectedIndexChanged += CBcategoria_SelectedIndexChanged;
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(349, 176);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 23);
            Tcelular.TabIndex = 25;
            Tcelular.KeyPress += Tcelular_KeyPress;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(49, 176);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 23);
            Tdomicilio.TabIndex = 24;
            // 
            // Lcontra
            // 
            Lcontra.Location = new Point(49, 281);
            Lcontra.Name = "Lcontra";
            Lcontra.PlaceholderText = "Contraseña";
            Lcontra.Size = new Size(265, 23);
            Lcontra.TabIndex = 23;
            Lcontra.UseSystemPasswordChar = true;
            Lcontra.TextChanged += Lcontra_TextChanged;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(349, 86);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 22;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(49, 86);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 21;
            TBnombre.TabStop = false;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // Enombre
            // 
            Enombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Enombre.ContainerControl = this;
            Enombre.Icon = (Icon)resources.GetObject("Enombre.Icon");
            // 
            // Eapellido
            // 
            Eapellido.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eapellido.ContainerControl = this;
            Eapellido.Icon = (Icon)resources.GetObject("Eapellido.Icon");
            // 
            // Edni
            // 
            Edni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edni.ContainerControl = this;
            Edni.Icon = (Icon)resources.GetObject("Edni.Icon");
            // 
            // Econtra
            // 
            Econtra.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Econtra.ContainerControl = this;
            Econtra.Icon = (Icon)resources.GetObject("Econtra.Icon");
            // 
            // Edomi
            // 
            Edomi.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edomi.ContainerControl = this;
            Edomi.Icon = (Icon)resources.GetObject("Edomi.Icon");
            // 
            // Ecel
            // 
            Ecel.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecel.ContainerControl = this;
            Ecel.Icon = (Icon)resources.GetObject("Ecel.Icon");
            // 
            // Eemail
            // 
            Eemail.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eemail.ContainerControl = this;
            Eemail.Icon = (Icon)resources.GetObject("Eemail.Icon");
            // 
            // Ecategoria
            // 
            Ecategoria.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecategoria.ContainerControl = this;
            Ecategoria.Icon = (Icon)resources.GetObject("Ecategoria.Icon");
            // 
            // Tuser
            // 
            Tuser.Location = new Point(349, 227);
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Nombre Usuario";
            Tuser.Size = new Size(265, 23);
            Tuser.TabIndex = 34;
            Tuser.TabStop = false;
            // 
            // Tconfcontra
            // 
            Tconfcontra.Location = new Point(349, 281);
            Tconfcontra.Name = "Tconfcontra";
            Tconfcontra.PlaceholderText = "Confirmar contraseña";
            Tconfcontra.Size = new Size(265, 23);
            Tconfcontra.TabIndex = 35;
            Tconfcontra.UseSystemPasswordChar = true;
            Tconfcontra.TextChanged += Tconfcontra_TextChanged;
            // 
            // Econfcontra
            // 
            Econfcontra.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Econfcontra.ContainerControl = this;
            Econfcontra.Icon = (Icon)resources.GetObject("Econfcontra.Icon");
            // 
            // Euser
            // 
            Euser.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Euser.ContainerControl = this;
            Euser.Icon = (Icon)resources.GetObject("Euser.Icon");
            // 
            // FAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(770, 686);
            Controls.Add(Tconfcontra);
            Controls.Add(Tuser);
            Controls.Add(Tdni);
            Controls.Add(Bagregar);
            Controls.Add(Lindex);
            Controls.Add(Lsports);
            Controls.Add(Temail);
            Controls.Add(CBcategoria);
            Controls.Add(Tcelular);
            Controls.Add(Tdomicilio);
            Controls.Add(Lcontra);
            Controls.Add(Tapellido);
            Controls.Add(TBnombre);
            Name = "FAgregarUsuario";
            Text = "Agregar Usuario";
            Load += FAgregarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edomi).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)Econfcontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Euser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tdni;
        private Button Bagregar;
        private Label Lindex;
        private Label Lsports;
        private TextBox Temail;
        private ComboBox CBcategoria;
        private TextBox Tcelular;
        private TextBox Tdomicilio;
        private TextBox Lcontra;
        private TextBox Tapellido;
        private TextBox TBnombre;
        private ErrorProvider Enombre;
        private ErrorProvider Eapellido;
        private ErrorProvider Edni;
        private ErrorProvider Econtra;
        private ErrorProvider Edomi;
        private ErrorProvider Ecel;
        private ErrorProvider Eemail;
        private ErrorProvider Ecategoria;
        private TextBox Tconfcontra;
        private TextBox Tuser;
        private ErrorProvider Econfcontra;
        private ErrorProvider Euser;
    }
}