namespace SportsOn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tusername = new TextBox();
            Tpass = new TextBox();
            Llogin = new Label();
            Biniciar = new Button();
            SuspendLayout();
            // 
            // Tusername
            // 
            Tusername.Location = new Point(218, 198);
            Tusername.Name = "Tusername";
            Tusername.PlaceholderText = "Nombre de Usuario";
            Tusername.Size = new Size(351, 23);
            Tusername.TabIndex = 0;
            // 
            // Tpass
            // 
            Tpass.Location = new Point(218, 241);
            Tpass.Name = "Tpass";
            Tpass.PlaceholderText = "Contraseña";
            Tpass.ShortcutsEnabled = false;
            Tpass.Size = new Size(351, 23);
            Tpass.TabIndex = 1;
            Tpass.UseSystemPasswordChar = true;
            // 
            // Llogin
            // 
            Llogin.AutoSize = true;
            Llogin.Font = new Font("Berlin Sans FB Demi", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Llogin.ForeColor = Color.Lime;
            Llogin.Location = new Point(271, 108);
            Llogin.Name = "Llogin";
            Llogin.Size = new Size(280, 55);
            Llogin.TabIndex = 2;
            Llogin.Text = "SportsWorld";
            // 
            // Biniciar
            // 
            Biniciar.FlatAppearance.BorderSize = 0;
            Biniciar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Biniciar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Biniciar.FlatStyle = FlatStyle.Flat;
            Biniciar.Image = Properties.Resources.iniciar_sesion1;
            Biniciar.Location = new Point(367, 270);
            Biniciar.Name = "Biniciar";
            Biniciar.Size = new Size(47, 64);
            Biniciar.TabIndex = 3;
            Biniciar.UseVisualStyleBackColor = true;
            Biniciar.Click += Biniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(Biniciar);
            Controls.Add(Llogin);
            Controls.Add(Tpass);
            Controls.Add(Tusername);
            Name = "Form1";
            Text = "Entrar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tusername;
        private TextBox Tpass;
        private Label Llogin;
        private Button Biniciar;
    }
}