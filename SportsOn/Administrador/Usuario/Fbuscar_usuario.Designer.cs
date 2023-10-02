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
            lusuarios = new Label();
            Bconectar = new Button();
            dg_mostrarusuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Euser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dg_mostrarusuarios).BeginInit();
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
            // lusuarios
            // 
            lusuarios.AutoSize = true;
            lusuarios.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lusuarios.ForeColor = Color.Lime;
            lusuarios.Location = new Point(444, 9);
            lusuarios.Name = "lusuarios";
            lusuarios.Size = new Size(153, 51);
            lusuarios.TabIndex = 41;
            lusuarios.Text = "Usuarios";
            // 
            // Bconectar
            // 
            Bconectar.Location = new Point(125, 453);
            Bconectar.Name = "Bconectar";
            Bconectar.Size = new Size(96, 30);
            Bconectar.TabIndex = 43;
            Bconectar.Text = "conectar";
            Bconectar.UseVisualStyleBackColor = true;
            Bconectar.Click += Bconectar_Click;
            // 
            // dg_mostrarusuarios
            // 
            dg_mostrarusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_mostrarusuarios.Location = new Point(12, 63);
            dg_mostrarusuarios.Name = "dg_mostrarusuarios";
            dg_mostrarusuarios.RowTemplate.Height = 25;
            dg_mostrarusuarios.Size = new Size(946, 384);
            dg_mostrarusuarios.TabIndex = 44;
            // 
            // Fbuscar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(dg_mostrarusuarios);
            Controls.Add(Bconectar);
            Controls.Add(lusuarios);
            Name = "Fbuscar_usuario";
            Text = "Buscar Usuario";
            Load += Fbuscar_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)Euser).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dg_mostrarusuarios).EndInit();
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
        private Label lusuarios;
        private Button Bconectar;
        private DataGridView dg_mostrarusuarios;
    }
}