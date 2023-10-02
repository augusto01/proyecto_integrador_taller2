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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Enombre = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Eapellido = new ErrorProvider(components);
            Eemail = new ErrorProvider(components);
            Ecelular = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            bbuscar = new Button();
            TBdni = new TextBox();
            TBusername = new TextBox();
            dg_cliente = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            celular = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            groupBox1 = new GroupBox();
            Bcancelar = new Button();
            editarCliente = new Button();
            Bagregar = new Button();
            Tdni = new TextBox();
            Temail = new TextBox();
            Tcelular = new TextBox();
            Tdomicilio = new TextBox();
            Tapellido = new TextBox();
            TBnombre = new TextBox();
            Lindex = new Label();
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_cliente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // groupBox2
            // 
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(TBdni);
            groupBox2.Controls.Add(TBusername);
            groupBox2.Controls.Add(dg_cliente);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 322);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(940, 352);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Cliente";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // bbuscar
            // 
            bbuscar.Location = new Point(533, 27);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(130, 29);
            bbuscar.TabIndex = 43;
            bbuscar.Text = "Buscar";
            bbuscar.UseVisualStyleBackColor = true;
            bbuscar.Click += bbuscar_Click;
            // 
            // TBdni
            // 
            TBdni.AcceptsReturn = true;
            TBdni.Location = new Point(276, 28);
            TBdni.Name = "TBdni";
            TBdni.PlaceholderText = "Buscar por DNI";
            TBdni.Size = new Size(218, 29);
            TBdni.TabIndex = 42;
            TBdni.TextChanged += TBdni_TextChanged;
            // 
            // TBusername
            // 
            TBusername.Location = new Point(6, 28);
            TBusername.Name = "TBusername";
            TBusername.PlaceholderText = "Buscar por nombre de usuario";
            TBusername.Size = new Size(218, 29);
            TBusername.TabIndex = 41;
            TBusername.TextChanged += TBusername_TextChanged;
            // 
            // dg_cliente
            // 
            dg_cliente.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dg_cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dg_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_cliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dg_cliente.BackgroundColor = SystemColors.MenuHighlight;
            dg_cliente.BorderStyle = BorderStyle.Fixed3D;
            dg_cliente.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dg_cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_cliente.Columns.AddRange(new DataGridViewColumn[] { id_cliente, nombre, apellido, dni, celular, domicilio, editar, eliminar });
            dg_cliente.Location = new Point(6, 66);
            dg_cliente.Name = "dg_cliente";
            dg_cliente.RowTemplate.Height = 25;
            dg_cliente.ScrollBars = ScrollBars.Vertical;
            dg_cliente.Size = new Size(928, 280);
            dg_cliente.TabIndex = 38;
            dg_cliente.CellClick += dg_cliente_CellClick;
            dg_cliente.CellContentClick += dg_cliente_CellContentClick;
            // 
            // id_cliente
            // 
            id_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id_cliente.HeaderText = "ID Cliente";
            id_cliente.Name = "id_cliente";
            id_cliente.Width = 102;
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
            // celular
            // 
            celular.HeaderText = "Celular";
            celular.Name = "celular";
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Domicilio";
            domicilio.Name = "domicilio";
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
            groupBox1.Controls.Add(editarCliente);
            groupBox1.Controls.Add(Bagregar);
            groupBox1.Controls.Add(Tdni);
            groupBox1.Controls.Add(Temail);
            groupBox1.Controls.Add(Tcelular);
            groupBox1.Controls.Add(Tdomicilio);
            groupBox1.Controls.Add(Tapellido);
            groupBox1.Controls.Add(TBnombre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(934, 266);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Cliente";
            groupBox1.Enter += groupBox1_Enter;
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
            Bcancelar.Click += Bcancelar_Click;
            // 
            // editarCliente
            // 
            editarCliente.BackColor = Color.Transparent;
            editarCliente.Cursor = Cursors.Hand;
            editarCliente.FlatAppearance.BorderSize = 0;
            editarCliente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            editarCliente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            editarCliente.FlatStyle = FlatStyle.Flat;
            editarCliente.ForeColor = SystemColors.ActiveCaptionText;
            editarCliente.Image = (Image)resources.GetObject("editarCliente.Image");
            editarCliente.ImageAlign = ContentAlignment.TopCenter;
            editarCliente.Location = new Point(735, 53);
            editarCliente.Name = "editarCliente";
            editarCliente.Size = new Size(76, 72);
            editarCliente.TabIndex = 36;
            editarCliente.UseVisualStyleBackColor = false;
            editarCliente.Visible = false;
            editarCliente.Click += editarUsuario_Click;
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
            // Tdni
            // 
            Tdni.Location = new Point(19, 131);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "DNI";
            Tdni.Size = new Size(265, 29);
            Tdni.TabIndex = 32;
            Tdni.TextChanged += Tdni_TextChanged;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Temail
            // 
            Temail.Location = new Point(329, 131);
            Temail.Name = "Temail";
            Temail.PlaceholderText = "Email";
            Temail.Size = new Size(265, 29);
            Temail.TabIndex = 27;
            Temail.TextChanged += Temail_TextChanged;
            Temail.KeyPress += Temail_KeyPress;
            // 
            // Tcelular
            // 
            Tcelular.Location = new Point(329, 208);
            Tcelular.Name = "Tcelular";
            Tcelular.PlaceholderText = "Celular";
            Tcelular.Size = new Size(265, 29);
            Tcelular.TabIndex = 25;
            Tcelular.TextChanged += Tcelular_TextChanged;
            Tcelular.KeyPress += Tcelular_KeyPress;
            // 
            // Tdomicilio
            // 
            Tdomicilio.Location = new Point(19, 208);
            Tdomicilio.Name = "Tdomicilio";
            Tdomicilio.PlaceholderText = "Domicilio";
            Tdomicilio.Size = new Size(265, 29);
            Tdomicilio.TabIndex = 24;
            Tdomicilio.TextChanged += Tdomicilio_TextChanged;
            // 
            // Tapellido
            // 
            Tapellido.Location = new Point(329, 53);
            Tapellido.Name = "Tapellido";
            Tapellido.PlaceholderText = "Apellido";
            Tapellido.Size = new Size(265, 29);
            Tapellido.TabIndex = 22;
            Tapellido.TextChanged += Tapellido_TextChanged;
            Tapellido.KeyPress += Tapellido_KeyPress;
            // 
            // TBnombre
            // 
            TBnombre.BackColor = Color.White;
            TBnombre.Location = new Point(19, 53);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 29);
            TBnombre.TabIndex = 21;
            TBnombre.TabStop = false;
            TBnombre.TextChanged += TBnombre_TextChanged;
            TBnombre.KeyPress += TBnombre_KeyPress_1;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.BackColor = SystemColors.Highlight;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(341, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(293, 51);
            Lindex.TabIndex = 48;
            Lindex.Text = "Gestionar Clientes";
            Lindex.Click += Lindex_Click;
            // 
            // Fagregar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(970, 686);
            Controls.Add(Lindex);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Fagregar_cliente";
            Text = "Fagregar_cliente";
            Load += Fagregar_cliente_Load;
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eapellido).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eemail).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecelular).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_cliente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider Enombre;
        private ErrorProvider Edni;
        private ErrorProvider Eapellido;
        private ErrorProvider Eemail;
        private ErrorProvider Ecelular;
        private GroupBox groupBox2;
        private Button bbuscar;
        private TextBox TBdni;
        private TextBox TBusername;
        private DataGridView dg_cliente;
        private GroupBox groupBox1;
        private Button Bcancelar;
        private Button editarCliente;
        private Button Bagregar;
        private TextBox Tdni;
        private TextBox Temail;
        private TextBox Tcelular;
        private TextBox Tdomicilio;
        private TextBox Tapellido;
        private TextBox TBnombre;
        private Label Lindex;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn celular;
        private DataGridViewTextBoxColumn domicilio;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
    }
}