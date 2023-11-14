namespace CapaPresentacion.Empleado
{
    partial class Fverproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fverproductos));
            this.label10 = new System.Windows.Forms.Label();
            this.dgproductosempleados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tbuscarobjeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgproductosempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(343, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 55);
            this.label10.TabIndex = 91;
            this.label10.Text = "Productos";
            // 
            // dgproductosempleados
            // 
            this.dgproductosempleados.AllowUserToAddRows = false;
            this.dgproductosempleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgproductosempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgproductosempleados.Location = new System.Drawing.Point(28, 108);
            this.dgproductosempleados.Name = "dgproductosempleados";
            this.dgproductosempleados.ReadOnly = true;
            this.dgproductosempleados.Size = new System.Drawing.Size(878, 529);
            this.dgproductosempleados.TabIndex = 92;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(290, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 150;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbuscarobjeto
            // 
            this.tbuscarobjeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbuscarobjeto.Location = new System.Drawing.Point(147, 85);
            this.tbuscarobjeto.Name = "tbuscarobjeto";
            this.tbuscarobjeto.Size = new System.Drawing.Size(137, 20);
            this.tbuscarobjeto.TabIndex = 149;
            this.tbuscarobjeto.TextChanged += new System.EventHandler(this.tbuscarobjeto_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 148;
            this.label13.Text = "Descripcion:";
            // 
            // Fverproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(930, 1022);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbuscarobjeto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgproductosempleados);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fverproductos";
            this.Load += new System.EventHandler(this.Fverproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgproductosempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgproductosempleados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbuscarobjeto;
        private System.Windows.Forms.Label label13;
    }
}