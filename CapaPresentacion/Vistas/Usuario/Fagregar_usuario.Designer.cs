﻿namespace CapaPresentacion.Administrador.Usuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_usuario));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.Bagregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tapellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tdni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tcel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tcorreo = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lconfcontra = new System.Windows.Forms.Label();
            this.Tconfcontra = new System.Windows.Forms.TextBox();
            this.lcontra = new System.Windows.Forms.Label();
            this.Tpass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.enombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.eapellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.edni = new System.Windows.Forms.ErrorProvider(this.components);
            this.ecorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ecel = new System.Windows.Forms.ErrorProvider(this.components);
            this.euser = new System.Windows.Forms.ErrorProvider(this.components);
            this.etipouser = new System.Windows.Forms.ErrorProvider(this.components);
            this.econtra = new System.Windows.Forms.ErrorProvider(this.components);
            this.econfcontra = new System.Windows.Forms.ErrorProvider(this.components);
            this.tdomicilio = new System.Windows.Forms.TextBox();
            this.ldomicilio = new System.Windows.Forms.Label();
            this.bcancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgusuarios = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bver = new System.Windows.Forms.Button();
            this.bnover = new System.Windows.Forms.Button();
            this.beditar = new System.Windows.Forms.Button();
            this.bcancelaredicion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbuscarpor = new System.Windows.Forms.ComboBox();
            this.tbuscarobjeto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.enombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eapellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.euser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etipouser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.econtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.econfcontra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre (*)";
            // 
            // tnombre
            // 
            this.tnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnombre.ForeColor = System.Drawing.Color.White;
            this.tnombre.Location = new System.Drawing.Point(33, 203);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(214, 24);
            this.tnombre.TabIndex = 15;
            this.tnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tnombre_KeyPress);
            // 
            // Bagregar
            // 
            this.Bagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Bagregar.FlatAppearance.BorderSize = 0;
            this.Bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bagregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bagregar.ForeColor = System.Drawing.Color.White;
            this.Bagregar.Location = new System.Drawing.Point(616, 462);
            this.Bagregar.Name = "Bagregar";
            this.Bagregar.Size = new System.Drawing.Size(141, 48);
            this.Bagregar.TabIndex = 25;
            this.Bagregar.Text = "Agregar";
            this.Bagregar.UseVisualStyleBackColor = false;
            this.Bagregar.Click += new System.EventHandler(this.Bagregar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellido(*)";
            // 
            // tapellido
            // 
            this.tapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tapellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tapellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tapellido.ForeColor = System.Drawing.Color.White;
            this.tapellido.Location = new System.Drawing.Point(336, 203);
            this.tapellido.Name = "tapellido";
            this.tapellido.Size = new System.Drawing.Size(202, 24);
            this.tapellido.TabIndex = 16;
            this.tapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tapellido_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "DNI (*)";
            // 
            // tdni
            // 
            this.tdni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tdni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tdni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdni.ForeColor = System.Drawing.Color.White;
            this.tdni.Location = new System.Drawing.Point(336, 345);
            this.tdni.Name = "tdni";
            this.tdni.Size = new System.Drawing.Size(202, 24);
            this.tdni.TabIndex = 20;
            this.tdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tdni_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nro celular ";
            // 
            // Tcel
            // 
            this.Tcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Tcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tcel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcel.ForeColor = System.Drawing.Color.White;
            this.Tcel.Location = new System.Drawing.Point(335, 267);
            this.Tcel.Name = "Tcel";
            this.Tcel.Size = new System.Drawing.Size(202, 24);
            this.Tcel.TabIndex = 18;
            this.Tcel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tcel_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Correo Electronico (*)";
            // 
            // Tcorreo
            // 
            this.Tcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tcorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Tcorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tcorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcorreo.ForeColor = System.Drawing.Color.White;
            this.Tcorreo.Location = new System.Drawing.Point(33, 267);
            this.Tcorreo.Name = "Tcorreo";
            this.Tcorreo.Size = new System.Drawing.Size(214, 24);
            this.Tcorreo.TabIndex = 17;
            this.Tcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tcorreo_KeyPress);
            // 
            // cbtipo
            // 
            this.cbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipo.ForeColor = System.Drawing.Color.White;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.ItemHeight = 24;
            this.cbtipo.Location = new System.Drawing.Point(33, 345);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(214, 32);
            this.cbtipo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tipo Usuario (*)";
            // 
            // Tuser
            // 
            this.Tuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Tuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tuser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuser.ForeColor = System.Drawing.Color.White;
            this.Tuser.Location = new System.Drawing.Point(336, 410);
            this.Tuser.Name = "Tuser";
            this.Tuser.Size = new System.Drawing.Size(202, 24);
            this.Tuser.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre de Usuario (*)";
            // 
            // lconfcontra
            // 
            this.lconfcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lconfcontra.AutoSize = true;
            this.lconfcontra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconfcontra.Location = new System.Drawing.Point(331, 450);
            this.lconfcontra.Name = "lconfcontra";
            this.lconfcontra.Size = new System.Drawing.Size(202, 19);
            this.lconfcontra.TabIndex = 35;
            this.lconfcontra.Text = "Confirmar Contraseña (*)";
            // 
            // Tconfcontra
            // 
            this.Tconfcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tconfcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Tconfcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tconfcontra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tconfcontra.ForeColor = System.Drawing.Color.White;
            this.Tconfcontra.Location = new System.Drawing.Point(335, 476);
            this.Tconfcontra.Name = "Tconfcontra";
            this.Tconfcontra.Size = new System.Drawing.Size(202, 24);
            this.Tconfcontra.TabIndex = 24;
            this.Tconfcontra.UseSystemPasswordChar = true;
            this.Tconfcontra.TextChanged += new System.EventHandler(this.Tconfcontra_TextChanged);
            // 
            // lcontra
            // 
            this.lcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcontra.AutoSize = true;
            this.lcontra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcontra.Location = new System.Drawing.Point(29, 450);
            this.lcontra.Name = "lcontra";
            this.lcontra.Size = new System.Drawing.Size(121, 19);
            this.lcontra.TabIndex = 33;
            this.lcontra.Text = "Contraseña (*)";
            // 
            // Tpass
            // 
            this.Tpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.Tpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tpass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpass.ForeColor = System.Drawing.Color.White;
            this.Tpass.Location = new System.Drawing.Point(31, 474);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(216, 24);
            this.Tpass.TabIndex = 23;
            this.Tpass.UseSystemPasswordChar = true;
            this.Tpass.TextChanged += new System.EventHandler(this.Tpass_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(303, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 56);
            this.label10.TabIndex = 36;
            this.label10.Text = "Agregar Usuario";
            // 
            // enombre
            // 
            this.enombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.enombre.ContainerControl = this;
            this.enombre.Icon = ((System.Drawing.Icon)(resources.GetObject("enombre.Icon")));
            // 
            // eapellido
            // 
            this.eapellido.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eapellido.ContainerControl = this;
            this.eapellido.Icon = ((System.Drawing.Icon)(resources.GetObject("eapellido.Icon")));
            // 
            // edni
            // 
            this.edni.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.edni.ContainerControl = this;
            this.edni.Icon = ((System.Drawing.Icon)(resources.GetObject("edni.Icon")));
            // 
            // ecorreo
            // 
            this.ecorreo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ecorreo.ContainerControl = this;
            this.ecorreo.Icon = ((System.Drawing.Icon)(resources.GetObject("ecorreo.Icon")));
            // 
            // ecel
            // 
            this.ecel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ecel.ContainerControl = this;
            this.ecel.Icon = ((System.Drawing.Icon)(resources.GetObject("ecel.Icon")));
            // 
            // euser
            // 
            this.euser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.euser.ContainerControl = this;
            this.euser.Icon = ((System.Drawing.Icon)(resources.GetObject("euser.Icon")));
            // 
            // etipouser
            // 
            this.etipouser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.etipouser.ContainerControl = this;
            this.etipouser.Icon = ((System.Drawing.Icon)(resources.GetObject("etipouser.Icon")));
            // 
            // econtra
            // 
            this.econtra.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.econtra.ContainerControl = this;
            this.econtra.Icon = ((System.Drawing.Icon)(resources.GetObject("econtra.Icon")));
            // 
            // econfcontra
            // 
            this.econfcontra.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.econfcontra.ContainerControl = this;
            this.econfcontra.Icon = ((System.Drawing.Icon)(resources.GetObject("econfcontra.Icon")));
            // 
            // tdomicilio
            // 
            this.tdomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tdomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tdomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdomicilio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdomicilio.ForeColor = System.Drawing.Color.White;
            this.tdomicilio.Location = new System.Drawing.Point(33, 410);
            this.tdomicilio.Name = "tdomicilio";
            this.tdomicilio.Size = new System.Drawing.Size(214, 24);
            this.tdomicilio.TabIndex = 21;
            // 
            // ldomicilio
            // 
            this.ldomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ldomicilio.AutoSize = true;
            this.ldomicilio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldomicilio.Location = new System.Drawing.Point(29, 386);
            this.ldomicilio.Name = "ldomicilio";
            this.ldomicilio.Size = new System.Drawing.Size(82, 19);
            this.ldomicilio.TabIndex = 40;
            this.ldomicilio.Text = "Domicilio";
            // 
            // bcancelar
            // 
            this.bcancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.bcancelar.FlatAppearance.BorderSize = 0;
            this.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelar.ForeColor = System.Drawing.Color.White;
            this.bcancelar.Location = new System.Drawing.Point(763, 462);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(141, 48);
            this.bcancelar.TabIndex = 26;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = false;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Campo Obligatorio (*)";
            // 
            // dgusuarios
            // 
            this.dgusuarios.AllowUserToAddRows = false;
            this.dgusuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.eliminar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgusuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgusuarios.Location = new System.Drawing.Point(4, 587);
            this.dgusuarios.Name = "dgusuarios";
            this.dgusuarios.ReadOnly = true;
            this.dgusuarios.Size = new System.Drawing.Size(930, 273);
            this.dgusuarios.TabIndex = 50;
            this.dgusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuarios_CellClick);
            this.dgusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuarios_CellContentClick);
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = global::CapaPresentacion.Properties.Resources.lapiz2;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Width = 40;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = global::CapaPresentacion.Properties.Resources.borrarr2;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 40;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Editar";
            this.dataGridViewImageColumn3.Image = global::CapaPresentacion.Properties.Resources.lapiz2;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Eliminar";
            this.dataGridViewImageColumn4.Image = global::CapaPresentacion.Properties.Resources.borrarr2;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // bver
            // 
            this.bver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bver.FlatAppearance.BorderSize = 0;
            this.bver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bver.Image = ((System.Drawing.Image)(resources.GetObject("bver.Image")));
            this.bver.Location = new System.Drawing.Point(574, 475);
            this.bver.Name = "bver";
            this.bver.Size = new System.Drawing.Size(26, 29);
            this.bver.TabIndex = 37;
            this.bver.UseVisualStyleBackColor = true;
            this.bver.Click += new System.EventHandler(this.bver_Click);
            // 
            // bnover
            // 
            this.bnover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnover.FlatAppearance.BorderSize = 0;
            this.bnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnover.Image = ((System.Drawing.Image)(resources.GetObject("bnover.Image")));
            this.bnover.Location = new System.Drawing.Point(574, 475);
            this.bnover.Name = "bnover";
            this.bnover.Size = new System.Drawing.Size(26, 29);
            this.bnover.TabIndex = 38;
            this.bnover.UseVisualStyleBackColor = true;
            this.bnover.Click += new System.EventHandler(this.bnover_Click);
            // 
            // beditar
            // 
            this.beditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.beditar.FlatAppearance.BorderSize = 0;
            this.beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beditar.ForeColor = System.Drawing.Color.White;
            this.beditar.Location = new System.Drawing.Point(616, 462);
            this.beditar.Name = "beditar";
            this.beditar.Size = new System.Drawing.Size(141, 48);
            this.beditar.TabIndex = 51;
            this.beditar.Text = "Editar";
            this.beditar.UseVisualStyleBackColor = false;
            this.beditar.Visible = false;
            this.beditar.Click += new System.EventHandler(this.beditar_Click);
            // 
            // bcancelaredicion
            // 
            this.bcancelaredicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcancelaredicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.bcancelaredicion.FlatAppearance.BorderSize = 0;
            this.bcancelaredicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancelaredicion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcancelaredicion.ForeColor = System.Drawing.Color.White;
            this.bcancelaredicion.Location = new System.Drawing.Point(763, 463);
            this.bcancelaredicion.Name = "bcancelaredicion";
            this.bcancelaredicion.Size = new System.Drawing.Size(141, 48);
            this.bcancelaredicion.TabIndex = 52;
            this.bcancelaredicion.Text = "Cancelar";
            this.bcancelaredicion.UseVisualStyleBackColor = false;
            this.bcancelaredicion.Visible = false;
            this.bcancelaredicion.Click += new System.EventHandler(this.bcancelaredicion_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(545, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 147;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 145;
            this.label13.Text = "Buscar por:";
            // 
            // cbbuscarpor
            // 
            this.cbbuscarpor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbuscarpor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.cbbuscarpor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbuscarpor.ForeColor = System.Drawing.Color.White;
            this.cbbuscarpor.FormattingEnabled = true;
            this.cbbuscarpor.ItemHeight = 20;
            this.cbbuscarpor.Location = new System.Drawing.Point(112, 553);
            this.cbbuscarpor.Name = "cbbuscarpor";
            this.cbbuscarpor.Size = new System.Drawing.Size(214, 28);
            this.cbbuscarpor.TabIndex = 148;
            // 
            // tbuscarobjeto
            // 
            this.tbuscarobjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbuscarobjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tbuscarobjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbuscarobjeto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuscarobjeto.ForeColor = System.Drawing.Color.White;
            this.tbuscarobjeto.Location = new System.Drawing.Point(337, 557);
            this.tbuscarobjeto.Name = "tbuscarobjeto";
            this.tbuscarobjeto.Size = new System.Drawing.Size(202, 24);
            this.tbuscarobjeto.TabIndex = 149;
            this.tbuscarobjeto.TextChanged += new System.EventHandler(this.tbuscarobjeto_TextChanged_1);
            // 
            // Fagregar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(946, 788);
            this.Controls.Add(this.tbuscarobjeto);
            this.Controls.Add(this.cbbuscarpor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bcancelaredicion);
            this.Controls.Add(this.beditar);
            this.Controls.Add(this.dgusuarios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.ldomicilio);
            this.Controls.Add(this.tdomicilio);
            this.Controls.Add(this.bver);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lconfcontra);
            this.Controls.Add(this.Tconfcontra);
            this.Controls.Add(this.lcontra);
            this.Controls.Add(this.Tpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tuser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tcel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tcorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tdni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tapellido);
            this.Controls.Add(this.Bagregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnombre);
            this.Controls.Add(this.bnover);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fagregar_usuario";
            this.ShowIcon = false;
            this.Text = "Fagregar_usuario";
            this.Load += new System.EventHandler(this.Fagregar_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eapellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.euser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etipouser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.econtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.econfcontra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.Button Bagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tapellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tdni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tcorreo;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lconfcontra;
        private System.Windows.Forms.TextBox Tconfcontra;
        private System.Windows.Forms.Label lcontra;
        private System.Windows.Forms.TextBox Tpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bver;
        private System.Windows.Forms.Button bnover;
        private System.Windows.Forms.ErrorProvider enombre;
        private System.Windows.Forms.ErrorProvider eapellido;
        private System.Windows.Forms.ErrorProvider edni;
        private System.Windows.Forms.ErrorProvider ecorreo;
        private System.Windows.Forms.ErrorProvider ecel;
        private System.Windows.Forms.ErrorProvider euser;
        private System.Windows.Forms.ErrorProvider etipouser;
        private System.Windows.Forms.ErrorProvider econtra;
        private System.Windows.Forms.ErrorProvider econfcontra;
        private System.Windows.Forms.Label ldomicilio;
        private System.Windows.Forms.TextBox tdomicilio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgusuarios;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button beditar;
        private System.Windows.Forms.Button bcancelaredicion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbuscarobjeto;
        private System.Windows.Forms.ComboBox cbbuscarpor;
    }
}