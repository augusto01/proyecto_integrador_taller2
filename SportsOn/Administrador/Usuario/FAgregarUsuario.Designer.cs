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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Tdni = new TextBox();
            Bagregar = new Button();
            Lindex = new Label();
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
            dg_usuarios = new DataGridView();
            id_usuario = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            Bcancelar = new Button();
            editarUsuario = new Button();
            groupBox2 = new GroupBox();
            bbuscar = new Button();
            TBdni = new TextBox();
            TBusername = new TextBox();
            Enrodoc = new ErrorProvider(components);
            Eusername = new ErrorProvider(components);
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
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Enrodoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eusername).BeginInit();
            SuspendLayout();
            // 
            // Tdni
            // 
            Tdni.Location = new Point(19, 76);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 29);
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
            Bagregar.Location = new Point(735, 53);
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
            Lindex.Location = new Point(364, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(304, 51);
            Lindex.TabIndex = 29;
            Lindex.Text = "Gestionar Usuarios";
            // 
            // Temail
            // 
            Temail.Location = new Point(319, 76);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 29);
            Temail.TabIndex = 27;
            Temail.KeyPress += Temail_KeyPress;
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(19, 174);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 29);
            CBcategoria.TabIndex = 26;
            CBcategoria.Text = "Tipo de Usuario";
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(319, 123);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 29);
            Tcelular.TabIndex = 25;
            Tcelular.KeyPress += Tcelular_KeyPress;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(19, 123);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 29);
            Tdomicilio.TabIndex = 24;
            // 
            // Lcontra
            // 
            Lcontra.Location = new Point(19, 228);
            Lcontra.Name = "Lcontra";
            Lcontra.PlaceholderText = "Contraseña";
            Lcontra.Size = new Size(265, 29);
            Lcontra.TabIndex = 23;
            Lcontra.UseSystemPasswordChar = true;
            Lcontra.TextChanged += Lcontra_TextChanged;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(319, 33);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 29);
            Tapellido.TabIndex = 22;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // TBnombre
            // 
            TBnombre.BackColor = Color.White;
            TBnombre.Location = new Point(19, 33);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 29);
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
            Tuser.Location = new Point(319, 174);
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Nombre Usuario";
            Tuser.Size = new Size(265, 29);
            Tuser.TabIndex = 34;
            Tuser.TabStop = false;
            // 
            // Tconfcontra
            // 
            Tconfcontra.Location = new Point(319, 228);
            Tconfcontra.Name = "Tconfcontra";
            Tconfcontra.PlaceholderText = "Confirmar contraseña";
            Tconfcontra.Size = new Size(265, 29);
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
            // dg_usuarios
            // 
            dg_usuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dg_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_usuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dg_usuarios.BackgroundColor = SystemColors.MenuHighlight;
            dg_usuarios.BorderStyle = BorderStyle.Fixed3D;
            dg_usuarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dg_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_usuarios.Columns.AddRange(new DataGridViewColumn[] { id_usuario, nombre, apellido, dni, usuario, editar, eliminar });
            dg_usuarios.Location = new Point(6, 66);
            dg_usuarios.Name = "dg_usuarios";
            dg_usuarios.RowTemplate.Height = 25;
            dg_usuarios.ScrollBars = ScrollBars.Vertical;
            dg_usuarios.Size = new Size(928, 280);
            dg_usuarios.TabIndex = 38;
            dg_usuarios.CellClick += dg_usuarios_CellClick;
            dg_usuarios.CellContentClick += dg_usuarios_CellContentClick;
            // 
            // id_usuario
            // 
            id_usuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id_usuario.HeaderText = "id_usuario";
            id_usuario.Name = "id_usuario";
            id_usuario.Width = 107;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.Name = "usuario";
            // 
            // editar
            // 
            editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editar.HeaderText = "Editar";
            editar.Image = Properties.Resources.lapiz;
            editar.Name = "editar";
            editar.Resizable = DataGridViewTriState.True;
            editar.SortMode = DataGridViewColumnSortMode.Automatic;
            editar.Width = 75;
            // 
            // eliminar
            // 
            eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            eliminar.HeaderText = "Eliminar";
            eliminar.Image = Properties.Resources.eliminar;
            eliminar.Name = "eliminar";
            eliminar.Width = 73;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Bcancelar);
            groupBox1.Controls.Add(editarUsuario);
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 266);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuarios";
            // 
            // Bcancelar
            // 
            Bcancelar.BackColor = Color.Transparent;
            Bcancelar.Cursor = Cursors.Hand;
            Bcancelar.FlatAppearance.BorderSize = 0;
            Bcancelar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bcancelar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bcancelar.FlatStyle = FlatStyle.Flat;
            Bcancelar.ForeColor = SystemColors.ActiveCaptionText;
            Bcancelar.Image = (Image)resources.GetObject("Bcancelar.Image");
            Bcancelar.ImageAlign = ContentAlignment.TopCenter;
            Bcancelar.Location = new Point(735, 131);
            Bcancelar.Name = "Bcancelar";
            Bcancelar.Size = new Size(81, 80);
            Bcancelar.TabIndex = 37;
            Bcancelar.UseVisualStyleBackColor = false;
            Bcancelar.Visible = false;
            Bcancelar.Click += Bcancelar_Click_1;
            // 
            // editarUsuario
            // 
            editarUsuario.BackColor = Color.Transparent;
            editarUsuario.Cursor = Cursors.Hand;
            editarUsuario.FlatAppearance.BorderSize = 0;
            editarUsuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            editarUsuario.FlatAppearance.MouseOverBackColor = Color.Transparent;
            editarUsuario.FlatStyle = FlatStyle.Flat;
            editarUsuario.ForeColor = SystemColors.ActiveCaptionText;
            editarUsuario.Image = (Image)resources.GetObject("editarUsuario.Image");
            editarUsuario.ImageAlign = ContentAlignment.TopCenter;
            editarUsuario.Location = new Point(735, 53);
            editarUsuario.Name = "editarUsuario";
            editarUsuario.Size = new Size(76, 72);
            editarUsuario.TabIndex = 36;
            editarUsuario.UseVisualStyleBackColor = false;
            editarUsuario.Visible = false;
            editarUsuario.Click += editarUsuario_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(TBdni);
            groupBox2.Controls.Add(TBusername);
            groupBox2.Controls.Add(dg_usuarios);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 352);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Usuarios";
            // 
            // bbuscar
            // 
            bbuscar.Location = new Point(533, 27);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(130, 29);
            bbuscar.TabIndex = 43;
            bbuscar.Text = "Buscar";
            bbuscar.UseVisualStyleBackColor = true;
            // 
            // TBdni
            // 
            TBdni.AcceptsReturn = true;
            TBdni.Location = new Point(276, 28);
            TBdni.Name = "TBdni";
            TBdni.PlaceholderText = "Buscar por DNI";
            TBdni.Size = new Size(218, 29);
            TBdni.TabIndex = 42;
            TBdni.KeyPress += TBdni_KeyPress;
            // 
            // TBusername
            // 
            TBusername.Location = new Point(6, 28);
            TBusername.Name = "TBusername";
            TBusername.PlaceholderText = "Buscar por nombre de usuario";
            TBusername.Size = new Size(218, 29);
            TBusername.TabIndex = 41;
            // 
            // Enrodoc
            // 
            Enrodoc.ContainerControl = this;
            // 
            // Eusername
            // 
            Eusername.ContainerControl = this;
            // 
            // FAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Controls.Add(groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Enrodoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eusername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tdni;
        private Button Bagregar;
        private Label Lindex;
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
        private DataGridView dg_usuarios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TBusername;
        private TextBox TBdni;
        private ErrorProvider Enrodoc;
        private ErrorProvider Eusername;
        private Button editarUsuario;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
        private Button bbuscar;
        private Button Bcancelar;
    }
}