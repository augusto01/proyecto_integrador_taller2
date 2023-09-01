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
            Tnombre = new TextBox();
            label1 = new Label();
            Lnombre = new Label();
            Lapellido = new Label();
            Tapellido = new TextBox();
            Tdni = new TextBox();
            Ldni = new Label();
            label2 = new Label();
            Tdomicilio = new TextBox();
            Ltelefono = new Label();
            Tnro_telefono = new TextBox();
            CBhombre = new CheckBox();
            CBmujer = new CheckBox();
            Lcorreo = new Label();
            Lcontraseña = new Label();
            label3 = new Label();
            Tcorreo = new TextBox();
            Tcontraseña = new TextBox();
            Tconfcontraseña = new TextBox();
            Lsports = new Label();
            pbicono = new PictureBox();
            Lcategoria = new Label();
            Tcategoria = new TextBox();
            Bagregar = new Button();
            Bcancelar = new Button();
            errorNombre = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorApellido = new ErrorProvider(components);
            errorDni = new ErrorProvider(components);
            errorDomicilio = new ErrorProvider(components);
            errorTelefono = new ErrorProvider(components);
            errorCorreo = new ErrorProvider(components);
            errorContraseña = new ErrorProvider(components);
            errorConfcontra = new ErrorProvider(components);
            errorCategoria = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbicono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorApellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorDni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorDomicilio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorConfcontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCategoria).BeginInit();
            SuspendLayout();
            // 
            // Tnombre
            // 
            Tnombre.Location = new Point(170, 53);
            Tnombre.Name = "Tnombre";
            Tnombre.Size = new Size(247, 23);
            Tnombre.TabIndex = 0;
            Tnombre.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 5;
            label1.Text = "Agregar Usuario";
            // 
            // Lnombre
            // 
            Lnombre.AutoSize = true;
            Lnombre.Location = new Point(90, 53);
            Lnombre.Name = "Lnombre";
            Lnombre.Size = new Size(67, 15);
            Lnombre.TabIndex = 6;
            Lnombre.Text = "Nombre (*)";
            Lnombre.Click += label2_Click;
            // 
            // Lapellido
            // 
            Lapellido.AutoSize = true;
            Lapellido.Location = new Point(90, 94);
            Lapellido.Name = "Lapellido";
            Lapellido.Size = new Size(67, 15);
            Lapellido.TabIndex = 7;
            Lapellido.Text = "Apellido (*)";
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(170, 94);
            Tapellido.Name = "Tapellido";
            Tapellido.Size = new Size(247, 23);
            Tapellido.TabIndex = 8;
            Tapellido.TextAlign = HorizontalAlignment.Center;
            // 
            // Tdni
            // 
            Tdni.Location = new Point(170, 145);
            Tdni.Name = "Tdni";
            Tdni.Size = new Size(247, 23);
            Tdni.TabIndex = 9;
            Tdni.TextAlign = HorizontalAlignment.Center;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Ldni
            // 
            Ldni.AutoSize = true;
            Ldni.Location = new Point(109, 148);
            Ldni.Name = "Ldni";
            Ldni.Size = new Size(43, 15);
            Ldni.TabIndex = 10;
            Ldni.Text = "DNI (*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 197);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Domicilio (*)";
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(170, 194);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.Size = new Size(247, 23);
            Tdomicilio.TabIndex = 12;
            Tdomicilio.TextAlign = HorizontalAlignment.Center;
            // 
            // Ltelefono
            // 
            Ltelefono.AutoSize = true;
            Ltelefono.Location = new Point(78, 243);
            Ltelefono.Name = "Ltelefono";
            Ltelefono.Size = new Size(74, 15);
            Ltelefono.TabIndex = 13;
            Ltelefono.Text = "Nro telefono";
            // 
            // Tnro_telefono
            // 
            Tnro_telefono.Location = new Point(170, 240);
            Tnro_telefono.Name = "Tnro_telefono";
            Tnro_telefono.Size = new Size(247, 23);
            Tnro_telefono.TabIndex = 14;
            Tnro_telefono.TextAlign = HorizontalAlignment.Center;
            // 
            // CBhombre
            // 
            CBhombre.AutoSize = true;
            CBhombre.Location = new Point(452, 196);
            CBhombre.Name = "CBhombre";
            CBhombre.Size = new Size(70, 19);
            CBhombre.TabIndex = 15;
            CBhombre.Text = "Hombre";
            CBhombre.UseVisualStyleBackColor = true;
            // 
            // CBmujer
            // 
            CBmujer.AutoSize = true;
            CBmujer.Location = new Point(528, 197);
            CBmujer.Name = "CBmujer";
            CBmujer.Size = new Size(57, 19);
            CBmujer.TabIndex = 16;
            CBmujer.Text = "Mujer";
            CBmujer.UseVisualStyleBackColor = true;
            // 
            // Lcorreo
            // 
            Lcorreo.AutoSize = true;
            Lcorreo.Location = new Point(34, 285);
            Lcorreo.Name = "Lcorreo";
            Lcorreo.Size = new Size(118, 15);
            Lcorreo.TabIndex = 18;
            Lcorreo.Text = "Correo electronico(*)";
            // 
            // Lcontraseña
            // 
            Lcontraseña.AutoSize = true;
            Lcontraseña.Location = new Point(73, 332);
            Lcontraseña.Name = "Lcontraseña";
            Lcontraseña.Size = new Size(79, 21);
            Lcontraseña.TabIndex = 19;
            Lcontraseña.Text = "Contraseña(*)";
            Lcontraseña.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 380);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 20;
            label3.Text = "Confirmar contraseña(*)";
            label3.UseCompatibleTextRendering = true;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(170, 285);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.Size = new Size(247, 23);
            Tcorreo.TabIndex = 21;
            Tcorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // Tcontraseña
            // 
            Tcontraseña.Location = new Point(170, 332);
            Tcontraseña.Name = "Tcontraseña";
            Tcontraseña.Size = new Size(247, 23);
            Tcontraseña.TabIndex = 22;
            Tcontraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // Tconfcontraseña
            // 
            Tconfcontraseña.Location = new Point(170, 377);
            Tconfcontraseña.Name = "Tconfcontraseña";
            Tconfcontraseña.Size = new Size(247, 23);
            Tconfcontraseña.TabIndex = 23;
            Tconfcontraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // Lsports
            // 
            Lsports.AutoSize = true;
            Lsports.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Lsports.ForeColor = Color.CornflowerBlue;
            Lsports.Location = new Point(170, 509);
            Lsports.Name = "Lsports";
            Lsports.Size = new Size(280, 55);
            Lsports.TabIndex = 24;
            Lsports.Text = "SportsWorld";
            // 
            // pbicono
            // 
            pbicono.Image = Properties.Resources.mujer_icono;
            pbicono.Location = new Point(452, 53);
            pbicono.Margin = new Padding(0);
            pbicono.Name = "pbicono";
            pbicono.Size = new Size(137, 137);
            pbicono.TabIndex = 25;
            pbicono.TabStop = false;
            pbicono.Click += pbicono_Click;
            // 
            // Lcategoria
            // 
            Lcategoria.AutoSize = true;
            Lcategoria.Location = new Point(82, 418);
            Lcategoria.Name = "Lcategoria";
            Lcategoria.Size = new Size(70, 21);
            Lcategoria.TabIndex = 26;
            Lcategoria.Text = "Categoria(*)";
            Lcategoria.UseCompatibleTextRendering = true;
            // 
            // Tcategoria
            // 
            Tcategoria.Location = new Point(170, 418);
            Tcategoria.Name = "Tcategoria";
            Tcategoria.Size = new Size(247, 23);
            Tcategoria.TabIndex = 27;
            Tcategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // Bagregar
            // 
            Bagregar.Location = new Point(170, 447);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(125, 37);
            Bagregar.TabIndex = 28;
            Bagregar.Text = "Aceptar";
            Bagregar.UseVisualStyleBackColor = true;
            Bagregar.Click += Bagregar_Click;
            // 
            // Bcancelar
            // 
            Bcancelar.Location = new Point(301, 447);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(116, 37);
            Bcancelar.TabIndex = 29;
            Bcancelar.Text = "Cancelar";
            Bcancelar.UseVisualStyleBackColor = true;
            // 
            // errorNombre
            // 
            errorNombre.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorApellido
            // 
            errorApellido.ContainerControl = this;
            // 
            // errorDni
            // 
            errorDni.ContainerControl = this;
            // 
            // errorDomicilio
            // 
            errorDomicilio.ContainerControl = this;
            // 
            // errorTelefono
            // 
            errorTelefono.ContainerControl = this;
            // 
            // errorCorreo
            // 
            errorCorreo.ContainerControl = this;
            // 
            // errorContraseña
            // 
            errorContraseña.ContainerControl = this;
            // 
            // errorConfcontra
            // 
            errorConfcontra.ContainerControl = this;
            // 
            // errorCategoria
            // 
            errorCategoria.ContainerControl = this;
            // 
            // FagregarUsuario
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 573);
            Controls.Add(Bcancelar);
            Controls.Add(Bagregar);
            Controls.Add(Tcategoria);
            Controls.Add(Lcategoria);
            Controls.Add(pbicono);
            Controls.Add(Lsports);
            Controls.Add(Tconfcontraseña);
            Controls.Add(Tcontraseña);
            Controls.Add(Tcorreo);
            Controls.Add(label3);
            Controls.Add(Lcontraseña);
            Controls.Add(Lcorreo);
            Controls.Add(CBmujer);
            Controls.Add(CBhombre);
            Controls.Add(Tnro_telefono);
            Controls.Add(Ltelefono);
            Controls.Add(Tdomicilio);
            Controls.Add(label2);
            Controls.Add(Ldni);
            Controls.Add(Tdni);
            Controls.Add(Tapellido);
            Controls.Add(Lapellido);
            Controls.Add(Lnombre);
            Controls.Add(label1);
            Controls.Add(Tnombre);
            Name = "FagregarUsuario";
            Text = "Agregar Usuario";
            ((System.ComponentModel.ISupportInitialize)pbicono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorApellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorDni).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorDomicilio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorConfcontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tnombre;
        private Label label1;
        private Label Lnombre;
        private Label Lapellido;
        private TextBox Tapellido;
        private TextBox Tdni;
        private Label Ldni;
        private Label label2;
        private TextBox Tdomicilio;
        private Label Ltelefono;
        private TextBox Tnro_telefono;
        private CheckBox CBhombre;
        private CheckBox CBmujer;
        private Label Lcorreo;
        private Label Lcontraseña;
        private Label label3;
        private TextBox Tcorreo;
        private TextBox Tcontraseña;
        private TextBox Tconfcontraseña;
        private Label Lsports;
        private PictureBox pbicono;
        private Label Lcategoria;
        private TextBox Tcategoria;
        private Button Bagregar;
        private Button Bcancelar;
        private ErrorProvider errorNombre;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorApellido;
        private ErrorProvider errorDni;
        private ErrorProvider errorDomicilio;
        private ErrorProvider errorTelefono;
        private ErrorProvider errorCorreo;
        private ErrorProvider errorContraseña;
        private ErrorProvider errorConfcontra;
        private ErrorProvider errorCategoria;
    }
}