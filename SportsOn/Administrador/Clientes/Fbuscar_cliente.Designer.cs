namespace SportsOn.Administrador.Clientes
{
    partial class Fbuscar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fbuscar_cliente));
            dataGridView1 = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            domicilio = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            Bbuscar = new Button();
            Tid = new TextBox();
            Tdni = new TextBox();
            Lindex = new Label();
            Eid = new ErrorProvider(components);
            Edni = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Edni).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_cliente, nombre, apellido, dni, domicilio, Accion });
            dataGridView1.Location = new Point(35, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 261);
            dataGridView1.TabIndex = 43;
            // 
            // id_cliente
            // 
            id_cliente.HeaderText = "ID Cliente";
            id_cliente.Name = "id_cliente";
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            // 
            // domicilio
            // 
            domicilio.HeaderText = "Domicilio";
            domicilio.Name = "domicilio";
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            // 
            // Bbuscar
            // 
            Bbuscar.FlatAppearance.BorderSize = 0;
            Bbuscar.FlatStyle = FlatStyle.Flat;
            Bbuscar.Image = (Image)resources.GetObject("Bbuscar.Image");
            Bbuscar.Location = new Point(566, 99);
            Bbuscar.Name = "Bbuscar";
            Bbuscar.Size = new Size(112, 81);
            Bbuscar.TabIndex = 42;
            Bbuscar.UseVisualStyleBackColor = true;
            Bbuscar.Click += Bbuscar_Click;
            // 
            // Tid
            // 
            Tid.Location = new Point(35, 112);
            Tid.Name = "Tid";
            Tid.PlaceholderText = "Buscar por ID cliente";
            Tid.Size = new Size(218, 23);
            Tid.TabIndex = 41;
            Tid.KeyPress += Tid_KeyPress;
            // 
            // Tdni
            // 
            Tdni.AcceptsReturn = true;
            Tdni.Location = new Point(35, 141);
            Tdni.Name = "Tdni";
            Tdni.PlaceholderText = "Buscar por DNI";
            Tdni.Size = new Size(218, 23);
            Tdni.TabIndex = 39;
            Tdni.KeyPress += Tdni_KeyPress;
            // 
            // Lindex
            // 
            Lindex.AutoSize = true;
            Lindex.BackColor = SystemColors.Highlight;
            Lindex.Font = new Font("Kanit SemiBold", 23.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Lindex.ForeColor = Color.Lime;
            Lindex.Location = new Point(282, 9);
            Lindex.Name = "Lindex";
            Lindex.Size = new Size(236, 51);
            Lindex.TabIndex = 38;
            Lindex.Text = "Buscar Cliente";
            // 
            // Eid
            // 
            Eid.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Eid.ContainerControl = this;
            Eid.Icon = (Icon)resources.GetObject("Eid.Icon");
            // 
            // Edni
            // 
            Edni.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Edni.ContainerControl = this;
            Edni.Icon = (Icon)resources.GetObject("Edni.Icon");
            // 
            // Fbuscar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(770, 686);
            Controls.Add(dataGridView1);
            Controls.Add(Bbuscar);
            Controls.Add(Tid);
            Controls.Add(Tdni);
            Controls.Add(Lindex);
            Name = "Fbuscar_cliente";
            Text = "Fbuscar_cliente";
            Load += Fbuscar_cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Edni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Bbuscar;
        private TextBox Tid;
        private TextBox Tdni;
        private Label Lindex;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn domicilio;
        private DataGridViewTextBoxColumn Accion;
        private ErrorProvider Eid;
        private ErrorProvider Edni;
    }
}