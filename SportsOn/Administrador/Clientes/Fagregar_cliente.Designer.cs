namespace SportsOn.Administrador.Clientes
{
    partial class Fagregar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_cliente));
            Tdni = new TextBox();
            Bagregar = new Button();
            Lindex = new Label();
            Temail = new TextBox();
            Tcelular = new TextBox();
            Tdomicilio = new TextBox();
            Tapellido = new TextBox();
            TBnombre = new TextBox();
            Enombre = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Eapellido = new ErrorProvider(components);
            Eemail = new ErrorProvider(components);
            Ecelular = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).BeginInit();
            SuspendLayout();
            // 
            // Tdni
            // 
            Tdni.Location = new Point(41, 143);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 23);
            Tdni.TabIndex = 45;
            Tdni.KeyPress += Tdni_KeyPress_1;
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
            Bagregar.Location = new Point(668, 117);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 44;
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(240, 23);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(254, 51);
            Lindex.TabIndex = 43;
            Lindex.Text = "Agregar Cliente";
            // 
            // Temail
            // 
            Temail.Location = new Point(341, 143);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 23);
            Temail.TabIndex = 42;
            Temail.KeyPress += Temail_KeyPress_1;
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(341, 190);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 23);
            Tcelular.TabIndex = 40;
            Tcelular.KeyPress += Tcelular_KeyPress_1;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(41, 190);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 23);
            Tdomicilio.TabIndex = 39;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(341, 100);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 23);
            Tapellido.TabIndex = 37;
            Tapellido.KeyPress += Tapellido_KeyPress_1;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(41, 100);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 36;
            TBnombre.TabStop = false;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // Enombre
            // 
            Enombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Enombre.ContainerControl = this;
            Enombre.Icon = (Icon)resources.GetObject("Enombre.Icon");
            // 
            // Edni
            // 
            Edni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edni.ContainerControl = this;
            Edni.Icon = (Icon)resources.GetObject("Edni.Icon");
            // 
            // Eapellido
            // 
            Eapellido.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eapellido.ContainerControl = this;
            Eapellido.Icon = (Icon)resources.GetObject("Eapellido.Icon");
            // 
            // Eemail
            // 
            Eemail.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eemail.ContainerControl = this;
            Eemail.Icon = (Icon)resources.GetObject("Eemail.Icon");
            // 
            // Ecelular
            // 
            Ecelular.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecelular.ContainerControl = this;
            Ecelular.Icon = (Icon)resources.GetObject("Ecelular.Icon");
            // 
            // Fagregar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(770, 686);
            Controls.Add(Tdni);
            Controls.Add(Bagregar);
            Controls.Add(Lindex);
            Controls.Add(Temail);
            Controls.Add(Tcelular);
            Controls.Add(Tdomicilio);
            Controls.Add(Tapellido);
            Controls.Add(TBnombre);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Fagregar_cliente";
            Text = "Fagregar_cliente";
            Load += Fagregar_cliente_Load;
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tdni;
        private Button Bagregar;
        private Label Lindex;
        private TextBox Temail;
        private TextBox Tcelular;
        private TextBox Tdomicilio;
        private TextBox Tapellido;
        private TextBox TBnombre;
        private ErrorProvider Enombre;
        private ErrorProvider Edni;
        private ErrorProvider Eapellido;
        private ErrorProvider Eemail;
        private ErrorProvider Ecelular;
    }
}