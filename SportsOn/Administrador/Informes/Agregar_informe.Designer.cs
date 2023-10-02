namespace SportsOn.Administrador.Informes
{
    partial class Agregar_informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_informe));
            linforme = new Label();
            gbinforme = new GroupBox();
            label2 = new Label();
            bdescargar = new Button();
            pictureBox1 = new PictureBox();
            lusuario = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ltipo = new Label();
            cbtipoinforme = new ComboBox();
            Etipo = new ErrorProvider(components);
            gbinforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etipo).BeginInit();
            SuspendLayout();
            // 
            // linforme
            // 
            linforme.AutoSize = true;
            linforme.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linforme.ForeColor = Color.Lime;
            linforme.Location = new Point(393, 9);
            linforme.Name = "linforme";
            linforme.Size = new Size(151, 51);
            linforme.TabIndex = 30;
            linforme.Text = "Informes";
            // 
            // gbinforme
            // 
            gbinforme.Controls.Add(label2);
            gbinforme.Controls.Add(bdescargar);
            gbinforme.Controls.Add(pictureBox1);
            gbinforme.Controls.Add(lusuario);
            gbinforme.Controls.Add(comboBox2);
            gbinforme.Controls.Add(label1);
            gbinforme.Controls.Add(dateTimePicker1);
            gbinforme.Controls.Add(ltipo);
            gbinforme.Controls.Add(cbtipoinforme);
            gbinforme.Location = new Point(82, 63);
            gbinforme.Name = "gbinforme";
            gbinforme.Size = new Size(838, 511);
            gbinforme.TabIndex = 31;
            gbinforme.TabStop = false;
            gbinforme.Text = "Generar informe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(520, 119);
            label2.Name = "label2";
            label2.Size = new Size(151, 51);
            label2.TabIndex = 31;
            label2.Text = "Informes";
            // 
            // bdescargar
            // 
            bdescargar.BackColor = Color.FromArgb(192, 255, 192);
            bdescargar.ForeColor = SystemColors.ControlText;
            bdescargar.Location = new Point(141, 251);
            bdescargar.Name = "bdescargar";
            bdescargar.Size = new Size(157, 47);
            bdescargar.TabIndex = 8;
            bdescargar.Text = "Generar Informe";
            bdescargar.UseVisualStyleBackColor = false;
            bdescargar.Click += bdescargar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(419, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 261);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lusuario
            // 
            lusuario.AutoSize = true;
            lusuario.Location = new Point(19, 119);
            lusuario.Name = "lusuario";
            lusuario.Size = new Size(47, 15);
            lusuario.TabIndex = 6;
            lusuario.Text = "Usuario";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(125, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 23);
            comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 195);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 4;
            label1.Text = "Fecha en cuestion ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(192, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // ltipo
            // 
            ltipo.AutoSize = true;
            ltipo.Location = new Point(19, 37);
            ltipo.Name = "ltipo";
            ltipo.Size = new Size(91, 15);
            ltipo.TabIndex = 1;
            ltipo.Text = "Tipo de informe";
            // 
            // cbtipoinforme
            // 
            cbtipoinforme.FormattingEnabled = true;
            cbtipoinforme.Location = new Point(125, 37);
            cbtipoinforme.Name = "cbtipoinforme";
            cbtipoinforme.Size = new Size(192, 23);
            cbtipoinforme.TabIndex = 0;
            // 
            // Etipo
            // 
            Etipo.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etipo.ContainerControl = this;
            Etipo.Icon = (Icon)resources.GetObject("Etipo.Icon");
            // 
            // Agregar_informe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(gbinforme);
            Controls.Add(linforme);
            Name = "Agregar_informe";
            Text = "Agregar_informe";
            gbinforme.ResumeLayout(false);
            gbinforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label linforme;
        private GroupBox gbinforme;
        private Button bdescargar;
        private PictureBox pictureBox1;
        private Label lusuario;
        private ComboBox comboBox2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label ltipo;
        private ComboBox cbtipoinforme;
        private Label label2;
        private ErrorProvider Etipo;
    }
}