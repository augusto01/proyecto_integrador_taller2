namespace CapaPresentacion
{
    partial class loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loguin));
            this.Tuser = new System.Windows.Forms.TextBox();
            this.Tpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bminimizar = new System.Windows.Forms.Button();
            this.pinferior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.crecuerdame = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.bver = new System.Windows.Forms.Button();
            this.bnover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bingresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pinferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tuser
            // 
            this.Tuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Tuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuser.ForeColor = System.Drawing.Color.White;
            this.Tuser.Location = new System.Drawing.Point(86, 209);
            this.Tuser.Name = "Tuser";
            this.Tuser.Size = new System.Drawing.Size(276, 20);
            this.Tuser.TabIndex = 1;
            // 
            // Tpass
            // 
            this.Tpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.Tpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tpass.ForeColor = System.Drawing.Color.White;
            this.Tpass.Location = new System.Drawing.Point(86, 331);
            this.Tpass.Name = "Tpass";
            this.Tpass.Size = new System.Drawing.Size(276, 20);
            this.Tpass.TabIndex = 2;
            this.Tpass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 44);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(379, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bminimizar
            // 
            this.bminimizar.FlatAppearance.BorderSize = 0;
            this.bminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bminimizar.Image = ((System.Drawing.Image)(resources.GetObject("bminimizar.Image")));
            this.bminimizar.Location = new System.Drawing.Point(336, 3);
            this.bminimizar.Name = "bminimizar";
            this.bminimizar.Size = new System.Drawing.Size(37, 29);
            this.bminimizar.TabIndex = 5;
            this.bminimizar.UseVisualStyleBackColor = true;
            this.bminimizar.Click += new System.EventHandler(this.bminimizar_Click);
            // 
            // pinferior
            // 
            this.pinferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pinferior.Controls.Add(this.label3);
            this.pinferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pinferior.Location = new System.Drawing.Point(0, 551);
            this.pinferior.Name = "pinferior";
            this.pinferior.Size = new System.Drawing.Size(423, 40);
            this.pinferior.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(124, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Almiron Pedro Augusto 2023";
            // 
            // crecuerdame
            // 
            this.crecuerdame.AutoSize = true;
            this.crecuerdame.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crecuerdame.ForeColor = System.Drawing.Color.Gray;
            this.crecuerdame.Location = new System.Drawing.Point(86, 357);
            this.crecuerdame.Name = "crecuerdame";
            this.crecuerdame.Size = new System.Drawing.Size(110, 21);
            this.crecuerdame.TabIndex = 3;
            this.crecuerdame.Text = "Recuerdame";
            this.crecuerdame.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(76, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "SportsWorlds";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.LightGray;
            this.lblerror.Image = ((System.Drawing.Image)(resources.GetObject("lblerror.Image")));
            this.lblerror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblerror.Location = new System.Drawing.Point(87, 396);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(69, 17);
            this.lblerror.TabIndex = 13;
            this.lblerror.Text = "labelerror";
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblerror.Visible = false;
            // 
            // bver
            // 
            this.bver.FlatAppearance.BorderSize = 0;
            this.bver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bver.Image = ((System.Drawing.Image)(resources.GetObject("bver.Image")));
            this.bver.Location = new System.Drawing.Point(368, 329);
            this.bver.Name = "bver";
            this.bver.Size = new System.Drawing.Size(26, 29);
            this.bver.TabIndex = 11;
            this.bver.UseVisualStyleBackColor = true;
            this.bver.Click += new System.EventHandler(this.bver_Click);
            // 
            // bnover
            // 
            this.bnover.FlatAppearance.BorderSize = 0;
            this.bnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnover.Image = ((System.Drawing.Image)(resources.GetObject("bnover.Image")));
            this.bnover.Location = new System.Drawing.Point(368, 329);
            this.bnover.Name = "bnover";
            this.bnover.Size = new System.Drawing.Size(26, 29);
            this.bnover.TabIndex = 12;
            this.bnover.UseVisualStyleBackColor = true;
            this.bnover.Click += new System.EventHandler(this.bnover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            // 
            // Bingresar
            // 
            this.Bingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.Bingresar.FlatAppearance.BorderSize = 0;
            this.Bingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bingresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bingresar.ForeColor = System.Drawing.Color.White;
            this.Bingresar.Location = new System.Drawing.Point(86, 429);
            this.Bingresar.Name = "Bingresar";
            this.Bingresar.Size = new System.Drawing.Size(276, 44);
            this.Bingresar.TabIndex = 4;
            this.Bingresar.Text = "Iniciar Sesion";
            this.Bingresar.UseVisualStyleBackColor = false;
            this.Bingresar.Click += new System.EventHandler(this.Bingresar_Click);
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(423, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.bver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bingresar);
            this.Controls.Add(this.crecuerdame);
            this.Controls.Add(this.pinferior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tpass);
            this.Controls.Add(this.Tuser);
            this.Controls.Add(this.bnover);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loguin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loguin";
            this.Load += new System.EventHandler(this.loguin_Load);
            this.panel1.ResumeLayout(false);
            this.pinferior.ResumeLayout(false);
            this.pinferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tuser;
        private System.Windows.Forms.TextBox Tpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pinferior;
        private System.Windows.Forms.Button bminimizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox crecuerdame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bver;
        private System.Windows.Forms.Button bnover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bingresar;
    }
}