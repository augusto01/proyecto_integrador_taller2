namespace SportsOn.Administrador.Caja
{
    partial class Fvercaja
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Lindex = new Label();
            groupBox1 = new GroupBox();
            panelpreciototal = new Panel();
            lpreciototal = new Label();
            signopeso = new Label();
            m_vendido = new Label();
            dg_usuarios = new DataGridView();
            nombre_cliente = new DataGridViewTextBoxColumn();
            c_productos = new DataGridViewTextBoxColumn();
            t_pago = new DataGridViewTextBoxColumn();
            f_venta = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            ver = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            panelpreciototal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).BeginInit();
            SuspendLayout();
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(398, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(99, 51);
            Lindex.TabIndex = 30;
            Lindex.Text = "CAJA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelpreciototal);
            groupBox1.Controls.Add(m_vendido);
            groupBox1.Controls.Add(dg_usuarios);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(929, 594);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas Realizadas";
            // 
            // panelpreciototal
            // 
            panelpreciototal.BackColor = Color.Black;
            panelpreciototal.Controls.Add(lpreciototal);
            panelpreciototal.Controls.Add(signopeso);
            panelpreciototal.ForeColor = Color.Transparent;
            panelpreciototal.Location = new Point(805, 341);
            panelpreciototal.Name = "panelpreciototal";
            panelpreciototal.Size = new Size(118, 43);
            panelpreciototal.TabIndex = 41;
            // 
            // lpreciototal
            // 
            lpreciototal.AutoSize = true;
            lpreciototal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lpreciototal.ForeColor = Color.Lime;
            lpreciototal.Location = new Point(41, 10);
            lpreciototal.Name = "lpreciototal";
            lpreciototal.Size = new Size(50, 25);
            lpreciototal.TabIndex = 1;
            lpreciototal.Text = "0.00";
            // 
            // signopeso
            // 
            signopeso.AutoSize = true;
            signopeso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            signopeso.ForeColor = Color.Lime;
            signopeso.Location = new Point(21, 10);
            signopeso.Name = "signopeso";
            signopeso.Size = new Size(23, 25);
            signopeso.TabIndex = 0;
            signopeso.Text = "$";
            // 
            // m_vendido
            // 
            m_vendido.AutoSize = true;
            m_vendido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            m_vendido.Location = new Point(643, 351);
            m_vendido.Name = "m_vendido";
            m_vendido.Size = new Size(156, 21);
            m_vendido.TabIndex = 40;
            m_vendido.Text = "Monto Total Vendido:";
            // 
            // dg_usuarios
            // 
            dg_usuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dg_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_usuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dg_usuarios.BackgroundColor = SystemColors.MenuHighlight;
            dg_usuarios.BorderStyle = BorderStyle.Fixed3D;
            dg_usuarios.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dg_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_usuarios.Columns.AddRange(new DataGridViewColumn[] { nombre_cliente, c_productos, t_pago, f_venta, monto, ver });
            dg_usuarios.Location = new Point(0, 55);
            dg_usuarios.Name = "dg_usuarios";
            dg_usuarios.RowTemplate.Height = 25;
            dg_usuarios.ScrollBars = ScrollBars.Vertical;
            dg_usuarios.Size = new Size(928, 280);
            dg_usuarios.TabIndex = 39;
            // 
            // nombre_cliente
            // 
            nombre_cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            nombre_cliente.HeaderText = "Cliente";
            nombre_cliente.Name = "nombre_cliente";
            nombre_cliente.Width = 69;
            // 
            // c_productos
            // 
            c_productos.HeaderText = "Cantidad de productos";
            c_productos.Name = "c_productos";
            // 
            // t_pago
            // 
            t_pago.HeaderText = "Tipo de pago";
            t_pago.Name = "t_pago";
            // 
            // f_venta
            // 
            f_venta.HeaderText = "Fecha de la venta";
            f_venta.Name = "f_venta";
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            // 
            // ver
            // 
            ver.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ver.HeaderText = "Ver Detalle";
            ver.Image = Properties.Resources.lapiz;
            ver.Name = "ver";
            ver.Resizable = DataGridViewTriState.True;
            ver.SortMode = DataGridViewColumnSortMode.Automatic;
            ver.Width = 87;
            // 
            // Fvercaja
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(970, 686);
            Controls.Add(groupBox1);
            Controls.Add(Lindex);
            Name = "Fvercaja";
            Text = "Fvercaja";
            Load += Fvercaja_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelpreciototal.ResumeLayout(false);
            panelpreciototal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lindex;
        private GroupBox groupBox1;
        private DataGridView dg_usuarios;
        private Label m_vendido;
        private Panel panelpreciototal;
        private Label lpreciototal;
        private Label signopeso;
        private DataGridViewTextBoxColumn nombre_cliente;
        private DataGridViewTextBoxColumn c_productos;
        private DataGridViewTextBoxColumn t_pago;
        private DataGridViewTextBoxColumn f_venta;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewImageColumn ver;
    }
}