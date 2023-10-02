namespace SportsOn.Administrador
{
    partial class Fbuscar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fbuscar_usuario));
            Euser = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Ecorreo = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            Tconfcontra = new TextBox();
            Tuser = new TextBox();
            Bagregar = new Button();
            Tdni = new TextBox();
            Temail = new TextBox();
            CBcategoria = new ComboBox();
            Tcelular = new TextBox();
            Tdomicilio = new TextBox();
            Lcontra = new TextBox();
            Tapellido = new TextBox();
            TBnombre = new TextBox();
            Lindex = new Label();
            ((System.ComponentModel.ISupportInitialize)Euser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Euser
            // 
            Euser.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Euser.ContainerControl = this;
            Euser.Icon = (Icon)resources.GetObject("Euser.Icon");
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Edni
            // 
            Edni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edni.ContainerControl = this;
            Edni.Icon = (Icon)resources.GetObject("Edni.Icon");
            // 
            // Ecorreo
            // 
            Ecorreo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecorreo.ContainerControl = this;
            Ecorreo.Icon = (Icon)resources.GetObject("Ecorreo.Icon");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Tconfcontra);
            groupBox1.Controls.Add(Tuser);
            groupBox1.Controls.Add(Bagregar);
            groupBox1.Controls.Add(Tdni);
            groupBox1.Controls.Add(Temail);
            groupBox1.Controls.Add(CBcategoria);
            groupBox1.Controls.Add(Tcelular);
            groupBox1.Controls.Add(Tdomicilio);
            groupBox1.Controls.Add(Lcontra);
            groupBox1.Controls.Add(Tapellido);
            groupBox1.Controls.Add(TBnombre);
            groupBox1.Location = new Point(17, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 266);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuarios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Tconfcontra
            // 
            Tconfcontra.Location = new Point(319, 228);
            Tconfcontra.Name = "Tconfcontra";
            Tconfcontra.PlaceholderText = "Confirmar contraseña";
            Tconfcontra.Size = new Size(265, 23);
            Tconfcontra.TabIndex = 35;
            Tconfcontra.UseSystemPasswordChar = true;
            // 
            // Tuser
            // 
            Tuser.Location = new Point(319, 174);
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Nombre Usuario";
            Tuser.Size = new Size(265, 23);
            Tuser.TabIndex = 34;
            Tuser.TabStop = false;
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
            Bagregar.Location = new Point(629, 97);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 30;
            Bagregar.UseVisualStyleBackColor = false;
             
            // 
            // Tdni
            // 
            Tdni.Location = new Point(19, 76);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 23);
            Tdni.TabIndex = 32;
            // 
            // Temail
            // 
            Temail.Location = new Point(319, 76);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 23);
            Temail.TabIndex = 27;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(19, 174);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 26;
            CBcategoria.Text = "Tipo de Usuario";
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(319, 123);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 23);
            Tcelular.TabIndex = 25;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(19, 123);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 23);
            Tdomicilio.TabIndex = 24;
            // 
            // Lcontra
            // 
            Lcontra.Location = new Point(19, 228);
            Lcontra.Name = "Lcontra";
            Lcontra.PlaceholderText = "Contraseña";
            Lcontra.Size = new Size(265, 23);
            Lcontra.TabIndex = 23;
            Lcontra.UseSystemPasswordChar = true;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(319, 33);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 22;
            // 
            // TBnombre
            // 
            TBnombre.BackColor = Color.White;
            TBnombre.Location = new Point(19, 33);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 21;
            TBnombre.TabStop = false;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(247, 11);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(280, 51);
            Lindex.TabIndex = 41;
            Lindex.Text = "Agregar Usuarios";
            // 
            // Fbuscar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(770, 686);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Name = "Fbuscar_usuario";
            Text = "Fbuscar_usuario";
            ((System.ComponentModel.ISupportInitialize)Euser).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider Euser;
        private ErrorProvider errorProvider1;
        private ErrorProvider Edni;
        private ErrorProvider Ecorreo;
        private GroupBox groupBox1;
        private TextBox Tconfcontra;
        private TextBox Tuser;
        private Button Bagregar;
        private TextBox Tdni;
        private TextBox Temail;
        private ComboBox CBcategoria;
        private TextBox Tcelular;
        private TextBox Tdomicilio;
        private TextBox Lcontra;
        private TextBox Tapellido;
        private TextBox TBnombre;
        private Label Lindex;
    }
}