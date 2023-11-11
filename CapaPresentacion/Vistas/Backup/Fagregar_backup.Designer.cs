namespace CapaPresentacion.Vistas.Backup
{
    partial class Fagregar_backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_backup));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.truta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tnombrearchivo = new System.Windows.Forms.TextBox();
            this.banadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eruta = new System.Windows.Forms.ErrorProvider(this.components);
            this.enombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eruta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enombre)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(414, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 37);
            this.label10.TabIndex = 131;
            this.label10.Text = "Backups";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 142;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(40, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 143;
            this.label1.Text = "Realizar Backup";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(40, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 38);
            this.label2.TabIndex = 144;
            this.label2.Text = "Restaurar base de datos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 146;
            this.label3.Text = "Ubicacion:";
            // 
            // truta
            // 
            this.truta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.truta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.truta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truta.ForeColor = System.Drawing.Color.White;
            this.truta.Location = new System.Drawing.Point(47, 293);
            this.truta.Name = "truta";
            this.truta.Size = new System.Drawing.Size(566, 24);
            this.truta.TabIndex = 145;
            this.truta.Text = "Seleccione un destino";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 148;
            this.label4.Text = "Nombre de archivo:";
            // 
            // tnombrearchivo
            // 
            this.tnombrearchivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tnombrearchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.tnombrearchivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnombrearchivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnombrearchivo.ForeColor = System.Drawing.Color.White;
            this.tnombrearchivo.Location = new System.Drawing.Point(47, 361);
            this.tnombrearchivo.Name = "tnombrearchivo";
            this.tnombrearchivo.Size = new System.Drawing.Size(566, 24);
            this.tnombrearchivo.TabIndex = 147;
            // 
            // banadir
            // 
            this.banadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.banadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.banadir.FlatAppearance.BorderSize = 0;
            this.banadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.banadir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banadir.ForeColor = System.Drawing.Color.White;
            this.banadir.Location = new System.Drawing.Point(646, 289);
            this.banadir.Name = "banadir";
            this.banadir.Size = new System.Drawing.Size(125, 31);
            this.banadir.TabIndex = 149;
            this.banadir.Text = "Examinar...";
            this.banadir.UseVisualStyleBackColor = false;
            this.banadir.Click += new System.EventHandler(this.banadir_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(646, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 31);
            this.button1.TabIndex = 150;
            this.button1.Text = "Backup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(646, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 31);
            this.button2.TabIndex = 153;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 152;
            this.label5.Text = "Ubicacion:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(47, 560);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(566, 24);
            this.textBox2.TabIndex = 151;
            this.textBox2.Text = "Seleccion el archivo .bak";
            // 
            // eruta
            // 
            this.eruta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.eruta.ContainerControl = this;
            this.eruta.Icon = ((System.Drawing.Icon)(resources.GetObject("eruta.Icon")));
            // 
            // enombre
            // 
            this.enombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.enombre.ContainerControl = this;
            this.enombre.Icon = ((System.Drawing.Icon)(resources.GetObject("enombre.Icon")));
            // 
            // Fagregar_backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(898, 944);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.banadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tnombrearchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.truta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fagregar_backup";
            this.Text = "Fagregar_backup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eruta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox truta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tnombrearchivo;
        private System.Windows.Forms.Button banadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ErrorProvider eruta;
        private System.Windows.Forms.ErrorProvider enombre;
    }
}