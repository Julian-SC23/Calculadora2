namespace Calculadora.Formularios
{
    partial class frmRegistro
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            BTregistrar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            DTGmostrar = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGmostrar).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(48, 30);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(48, 60);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(387, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(48, 112);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(48, 142);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(387, 31);
            txtApellido.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(48, 202);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(177, 25);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha de Nacimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(48, 247);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(284, 31);
            dtpFecha.TabIndex = 5;
            // 
            // BTregistrar
            // 
            BTregistrar.Location = new Point(466, 309);
            BTregistrar.Name = "BTregistrar";
            BTregistrar.Size = new Size(112, 34);
            BTregistrar.TabIndex = 6;
            BTregistrar.Text = "Registrar";
            BTregistrar.UseVisualStyleBackColor = true;
            BTregistrar.Click += BTregistrar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1037, 402);
            tabControl1.TabIndex = 7;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(BTregistrar);
            tabPage1.Controls.Add(lblNombre);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(lblFecha);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(lblApellido);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1029, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DTGmostrar);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1029, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DTGmostrar
            // 
            DTGmostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGmostrar.Location = new Point(18, 6);
            DTGmostrar.Name = "DTGmostrar";
            DTGmostrar.RowHeadersWidth = 62;
            DTGmostrar.Size = new Size(1005, 358);
            DTGmostrar.TabIndex = 0;
            DTGmostrar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 440);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            Load += frmRegistro_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTGmostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button BTregistrar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView DTGmostrar;
    }
}