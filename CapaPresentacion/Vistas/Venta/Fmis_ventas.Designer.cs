namespace CapaPresentacion.Vistas.Venta
{
    partial class Fmis_ventas
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
            this.label10 = new System.Windows.Forms.Label();
            this.dgventasusuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgventasusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(349, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 37);
            this.label10.TabIndex = 84;
            this.label10.Text = "Mis Ventas";
            // 
            // dgventasusuario
            // 
            this.dgventasusuario.AllowUserToAddRows = false;
            this.dgventasusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgventasusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgventasusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgventasusuario.Location = new System.Drawing.Point(31, 70);
            this.dgventasusuario.Name = "dgventasusuario";
            this.dgventasusuario.Size = new System.Drawing.Size(804, 408);
            this.dgventasusuario.TabIndex = 85;
            // 
            // Fmis_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(898, 944);
            this.Controls.Add(this.dgventasusuario);
            this.Controls.Add(this.label10);
            this.Name = "Fmis_ventas";
            this.Text = "Fmis_ventas";
            this.Load += new System.EventHandler(this.Fmis_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgventasusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgventasusuario;
    }
}