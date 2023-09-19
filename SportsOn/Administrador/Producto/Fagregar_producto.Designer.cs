namespace SportsOn.Administrador
{
    partial class Fagregar_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fagregar_producto));
            Tproveedor = new TextBox();
            Bagregar = new Button();
            Lindex = new Label();
            CBcategoria = new ComboBox();
            Tdescripcion = new TextBox();
            TBnombre = new TextBox();
            Enombre = new ErrorProvider(components);
            Edesc = new ErrorProvider(components);
            Ecantidad = new ErrorProvider(components);
            Eproveedor = new ErrorProvider(components);
            Ecategoria = new ErrorProvider(components);
            Tcantidad = new TextBox();
            Etalle = new ErrorProvider(components);
            CBtalle = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Enombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).BeginInit();
            SuspendLayout();
            // 
            // Tproveedor
            // 
            Tproveedor.Location = new Point(356, 185);
            Tproveedor.Name = "Tproveedor";
            Tproveedor.PlaceholderText = "Proveedor";
            Tproveedor.Size = new Size(265, 23);
            Tproveedor.TabIndex = 46;
            Tproveedor.TabStop = false;
            // 
            // Bagregar
            // 
            Bagregar.BackColor = Color.Transparent;
            Bagregar.Cursor = Cursors.Hand;
            Bagregar.FlatAppearance.BorderSize = 0;
            Bagregar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bagregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bagregar.FlatStyle = FlatStyle.Flat;
            Bagregar.ForeColor = SystemColors.ActiveCaptionText;
            Bagregar.Image = (Image)resources.GetObject("Bagregar.Image");
            Bagregar.ImageAlign = ContentAlignment.TopCenter;
            Bagregar.Location = new Point(662, 95);
            Bagregar.Name = "Bagregar";
            Bagregar.Size = new Size(76, 72);
            Bagregar.TabIndex = 44;
            Bagregar.UseVisualStyleBackColor = false;
            Bagregar.Click += Bagregar_Click;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(255, 18);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(283, 51);
            Lindex.TabIndex = 43;
            Lindex.Text = "Agregar Producto";
            // 
            // CBcategoria
            // 
            CBcategoria.FormattingEnabled = true;
            CBcategoria.Location = new Point(56, 185);
            CBcategoria.Name = "CBcategoria";
            CBcategoria.Size = new Size(265, 23);
            CBcategoria.TabIndex = 41;
            CBcategoria.Text = "Categoria";
            // 
            // Tdescripcion
            // 
            Tdescripcion.Location = new Point(356, 95);
            Tdescripcion.Name = "Tdescripcion";
            Tdescripcion.PlaceholderText = "Descripcion";
            Tdescripcion.Size = new Size(265, 23);
            Tdescripcion.TabIndex = 37;
            // 
            // TBnombre
            // 
            TBnombre.Location = new Point(56, 95);
            TBnombre.Name = "TBnombre";
            TBnombre.PlaceholderText = "Nombre";
            TBnombre.Size = new Size(265, 23);
            TBnombre.TabIndex = 36;
            TBnombre.TabStop = false;
            TBnombre.KeyPress += TBnombre_KeyPress;
            // 
            // Enombre
            // 
            Enombre.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Enombre.ContainerControl = this;
            Enombre.Icon = (Icon)resources.GetObject("Enombre.Icon");
            // 
            // Edesc
            // 
            Edesc.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edesc.ContainerControl = this;
            Edesc.Icon = (Icon)resources.GetObject("Edesc.Icon");
            // 
            // Ecantidad
            // 
            Ecantidad.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecantidad.ContainerControl = this;
            Ecantidad.Icon = (Icon)resources.GetObject("Ecantidad.Icon");
            // 
            // Eproveedor
            // 
            Eproveedor.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eproveedor.ContainerControl = this;
            Eproveedor.Icon = (Icon)resources.GetObject("Eproveedor.Icon");
            // 
            // Ecategoria
            // 
            Ecategoria.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Ecategoria.ContainerControl = this;
            Ecategoria.Icon = (Icon)resources.GetObject("Ecategoria.Icon");
            // 
            // Tcantidad
            // 
            Tcantidad.Location = new Point(56, 139);
            Tcantidad.Name = "Tcantidad";
            Tcantidad.PlaceholderText = "Cantidad";
            Tcantidad.Size = new Size(265, 23);
            Tcantidad.TabIndex = 47;
            Tcantidad.KeyPress += Tcantidad_KeyPress;
            // 
            // Etalle
            // 
            Etalle.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Etalle.ContainerControl = this;
            Etalle.Icon = (Icon)resources.GetObject("Etalle.Icon");
            // 
            // CBtalle
            // 
            CBtalle.FormattingEnabled = true;
            CBtalle.Location = new Point(356, 139);
            CBtalle.Name = "CBtalle";
            CBtalle.Size = new Size(265, 23);
            CBtalle.TabIndex = 48;
            CBtalle.Text = "Talle";
            // 
            // Fagregar_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(CBtalle);
            Controls.Add(Tcantidad);
            Controls.Add(Tproveedor);
            Controls.Add(Bagregar);
            Controls.Add(Lindex);
            Controls.Add(CBcategoria);
            Controls.Add(Tdescripcion);
            Controls.Add(TBnombre);
            Name = "Fagregar_producto";
            Text = "Fagregar_producto";
            Load += Fagregar_producto_Load;
            ((System.ComponentModel.ISupportInitialize)Enombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eproveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ecategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)Etalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Tproveedor;
        private Button Bagregar;
        private Label Lindex;
        private ComboBox CBcategoria;
        private TextBox Tdescripcion;
        private TextBox TBnombre;
        private ErrorProvider Enombre;
        private ErrorProvider Edesc;
        private ErrorProvider Ecantidad;
        private ErrorProvider Eproveedor;
        private ErrorProvider Ecategoria;
        private TextBox Tcantidad;
        private ErrorProvider Etalle;
        private ComboBox CBtalle;
    }
}