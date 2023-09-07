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
            Lindex = new Label();
            Tdni = new TextBox();
            Tuser = new TextBox();
            Tcorreo = new TextBox();
            Bbuscar = new Button();
            Euser = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            Ecorreo = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Euser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).BeginInit();
            SuspendLayout();
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(326, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(257, 37);
            Lindex.TabIndex = 30;
            Lindex.Text = "Buscar Usuario";
            Lindex.Click += Lindex_Click;
            // 
            // Tdni
            // 
            Tdni.AcceptsReturn = true;
            Tdni.Location = new Point(326, 98);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "Buscar por DNI";
            Tdni.Size = new Size(218, 23);
            Tdni.TabIndex = 33;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Tuser
            // 
            Tuser.Location = new Point(326, 69);
            Tuser.Name = "Tuser";
            Tuser.PlaceholderText = "Buscar por nombre de usuario";
            Tuser.Size = new Size(218, 23);
            Tuser.TabIndex = 34;
            // 
            // Tcorreo
            // 
            Tcorreo.Location = new Point(326, 127);
            Tcorreo.Name = "Tcorreo";
            Tcorreo.PlaceholderText = "Buscar por correo";
            Tcorreo.Size = new Size(218, 23);
            Tcorreo.TabIndex = 35;
            Tcorreo.KeyPress += Tcorreo_KeyPress;
            // 
            // Bbuscar
            // 
            Bbuscar.FlatAppearance.BorderSize = 0;
            Bbuscar.FlatStyle = FlatStyle.Flat;
            Bbuscar.Image = (Image)resources.GetObject("Bbuscar.Image");
            Bbuscar.Location = new Point(403, 156);
            Bbuscar.Name = "Bbuscar";
            Bbuscar.Size = new Size(75, 60);
            Bbuscar.TabIndex = 36;
            Bbuscar.UseVisualStyleBackColor = true;
            Bbuscar.Click += Bbuscar_Click;
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
            // Fbuscar_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(873, 468);
            Controls.Add(Bbuscar);
            Controls.Add(Tcorreo);
            Controls.Add(Tuser);
            Controls.Add(Tdni);
            Controls.Add(Lindex);
            Name = "Fbuscar_usuario";
            Text = "Fbuscar_usuario";
            Load += Fbuscar_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)Euser).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecorreo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lindex;
        private TextBox Tdni;
        private TextBox Tuser;
        private TextBox Tcorreo;
        private Button Bbuscar;
        private ErrorProvider Euser;
        private ErrorProvider errorProvider1;
        private ErrorProvider Edni;
        private ErrorProvider Ecorreo;
    }
}