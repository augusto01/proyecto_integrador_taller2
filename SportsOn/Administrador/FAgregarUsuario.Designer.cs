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
            Bcerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Econtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edomi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            SuspendLayout();
            // 
            // Tdni
            // 
            Tdni.Location = new Point(328, 185);
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
            Bagregar.Location = new Point(419, 441);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 30;
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(328, 27);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(275, 37);
            Lindex.TabIndex = 29;
            Lindex.Text = "Agregar Usuario";
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.Lime;
            Lsports.Location = new Point(313, 516);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 28;
            Lsports.Text = "SportsWorld";
            // 
            // Temail
            // 
            Temail.Location = new Point(328, 372);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 23);
            Temail.TabIndex = 27;
            Temail.KeyPress += Temail_KeyPress;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(328, 415);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 26;
            CBcategoria.Text = "Tipo de Usuario";
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(328, 326);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 23);
            Tcelular.TabIndex = 25;
            Tcelular.KeyPress += Tcelular_KeyPress;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(328, 279);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 23);
            Tdomicilio.TabIndex = 24;
            // 
            // Lcontra
            // 
            Lcontra.Location = new Point(328, 233);
            Lcontra.Name = "Lcontra";
            Lcontra.PlaceholderText = "Contraseña";
            Lcontra.Size = new Size(265, 23);
            Lcontra.TabIndex = 23;
            Lcontra.UseSystemPasswordChar = true;
            Lcontra.TextChanged += Lcontra_TextChanged;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(328, 134);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 22;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(328, 85);
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
            // Bcerrar
            // 
            Bcerrar.Cursor = Cursors.Hand;
            Bcerrar.FlatAppearance.BorderSize = 0;
            Bcerrar.FlatStyle = FlatStyle.Flat;
            Bcerrar.ForeColor = Color.CornflowerBlue;
            Bcerrar.Image = (Image)resources.GetObject("Bcerrar.Image");
            Bcerrar.Location = new Point(744, 19);
            Bcerrar.Name = "Bcerrar";
            Bcerrar.Size = new Size(45, 45);
            Bcerrar.TabIndex = 33;
            Bcerrar.UseVisualStyleBackColor = true;
            Bcerrar.Click += Bcerrar_Click;
            // 
            // FAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(917, 637);
            Controls.Add(Bcerrar);
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
        private Button Bcerrar;
    }
}