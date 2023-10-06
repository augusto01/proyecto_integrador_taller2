﻿namespace SportsOn.Gerente.Usuario
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
            lusuarios = new Label();
            Euser = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Ecorreo = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            TBbuscarporid = new TextBox();
            bbuscar = new Button();
            dg_usuarios = new DataGridView();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            TBdni = new TextBox();
            TBusername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Euser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).BeginInit();
            SuspendLayout();
            // 
            // lusuarios
            // 
            lusuarios.AutoSize = true;
            lusuarios.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lusuarios.ForeColor = Color.Lime;
            lusuarios.Location = new Point(440, 9);
            lusuarios.Name = "lusuarios";
            lusuarios.Size = new Size(153, 51);
            lusuarios.TabIndex = 45;
            lusuarios.Text = "Usuarios";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(TBbuscarporid);
            groupBox2.Controls.Add(bbuscar);
            groupBox2.Controls.Add(dg_usuarios);
            groupBox2.Controls.Add(TBdni);
            groupBox2.Controls.Add(TBusername);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(45, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(897, 352);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Usuarios";
            // 
            // TBbuscarporid
            // 
            TBbuscarporid.AcceptsReturn = true;
            TBbuscarporid.Location = new Point(497, 40);
            TBbuscarporid.Name = "TBbuscarporid";
            TBbuscarporid.PlaceholderText = "Buscar por ID";
            TBbuscarporid.Size = new Size(218, 29);
            TBbuscarporid.TabIndex = 45;
            // 
            // bbuscar
            // 
            bbuscar.Location = new Point(756, 39);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(130, 29);
            bbuscar.TabIndex = 43;
            bbuscar.Text = "Buscar";
            bbuscar.UseVisualStyleBackColor = true;
            // 
            // dg_usuarios
            // 
            dg_usuarios.AccessibleRole = AccessibleRole.None;
            dg_usuarios.AllowUserToAddRows = false;
            dg_usuarios.AllowUserToDeleteRows = false;
            dg_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_usuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_usuarios.Columns.AddRange(new DataGridViewColumn[] { editar, eliminar });
            dg_usuarios.Location = new Point(6, 87);
            dg_usuarios.Name = "dg_usuarios";
            dg_usuarios.ReadOnly = true;
            dg_usuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dg_usuarios.RowTemplate.Height = 25;
            dg_usuarios.Size = new Size(880, 225);
            dg_usuarios.TabIndex = 44;
            // 
            // editar
            // 
            editar.HeaderText = "Editar";
            editar.Image = Properties.Resources.lapiz2;
            editar.Name = "editar";
            editar.ReadOnly = true;
            editar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Image = Properties.Resources.eliminar2;
            eliminar.Name = "eliminar";
            eliminar.ReadOnly = true;
            eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TBdni
            // 
            TBdni.AcceptsReturn = true;
            TBdni.Location = new Point(257, 40);
            TBdni.Name = "TBdni";
            TBdni.PlaceholderText = "Buscar por DNI";
            TBdni.Size = new Size(218, 29);
            TBdni.TabIndex = 42;
            // 
            // TBusername
            // 
            TBusername.Location = new Point(6, 39);
            TBusername.Name = "TBusername";
            TBusername.PlaceholderText = "Buscar por nombre de usuario";
            TBusername.Size = new Size(218, 29);
            TBusername.TabIndex = 41;
            // 
            // Fbuscar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox2);
            Controls.Add(lusuarios);
            Name = "Fbuscar_usuario";
            Text = "Fbuscar_usuario";
            Load += Fbuscar_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)Euser).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lusuarios;
        private ErrorProvider Euser;
        private ErrorProvider errorProvider1;
        private ErrorProvider Edni;
        private ErrorProvider Ecorreo;
        private GroupBox groupBox2;
        private TextBox TBbuscarporid;
        private Button bbuscar;
        private DataGridView dg_usuarios;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
        private TextBox TBdni;
        private TextBox TBusername;
    }
}