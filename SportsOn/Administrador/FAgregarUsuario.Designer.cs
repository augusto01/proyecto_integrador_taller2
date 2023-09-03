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
            Bcancelar = new Button();
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
            // Bcancelar
            // 
            Bcancelar.BackColor = Color.FromArgb(255, 192, 192);
            Bcancelar.Image = Properties.Resources.cancelar2;
            Bcancelar.ImageAlign = ContentAlignment.MiddleLeft;
            Bcancelar.Location = new Point(465, 459);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(128, 40);
            Bcancelar.TabIndex = 31;
            Bcancelar.Text = "Cancelar";
            Bcancelar.UseVisualStyleBackColor = false;
            Bcancelar.Click += Bcancelar_Click;
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.FromArgb(192, 255, 192);
            Bagregar.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar.Image = Properties.Resources.guardar2;
            Bagregar.ImageAlign = ContentAlignment.MiddleLeft;
            Bagregar.Location = new Point(328, 459);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(128, 40);
            Bagregar.TabIndex = 30;
            Bagregar.Text = "Agregar";
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(328, 35);
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
            Lsports.Location = new Point(323, 516);
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
            Tapellido.Location = new Point(328, 141);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 22;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(328, 89);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 21;
            TBnombre.TabStop = false;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // Enombre
            // 
            Enombre.ContainerControl = this;
            Enombre.Icon = (Icon)resources.GetObject("Enombre.Icon");
            // 
            // Eapellido
            // 
            Eapellido.ContainerControl = this;
            Eapellido.Icon = (Icon)resources.GetObject("Eapellido.Icon");
            // 
            // Edni
            // 
            Edni.ContainerControl = this;
            Edni.Icon = (Icon)resources.GetObject("Edni.Icon");
            // 
            // Econtra
            // 
            Econtra.ContainerControl = this;
            Econtra.Icon = (Icon)resources.GetObject("Econtra.Icon");
            // 
            // Edomi
            // 
            Edomi.ContainerControl = this;
            Edomi.Icon = (Icon)resources.GetObject("Edomi.Icon");
            // 
            // Ecel
            // 
            Ecel.ContainerControl = this;
            Ecel.Icon = (Icon)resources.GetObject("Ecel.Icon");
            // 
            // Eemail
            // 
            Eemail.ContainerControl = this;
            Eemail.Icon = (Icon)resources.GetObject("Eemail.Icon");
            // 
            // Ecategoria
            // 
            Ecategoria.ContainerControl = this;
            Ecategoria.Icon = (Icon)resources.GetObject("Ecategoria.Icon");
            // 
            // FAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(917, 637);
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
        private Button Bcancelar;
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
    }
}