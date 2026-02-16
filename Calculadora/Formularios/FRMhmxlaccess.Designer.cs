namespace Calculadora.Formularios
{
    partial class FRMhmxlaccess
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
            DGpersona = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            BTguardar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGpersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // DGpersona
            // 
            DGpersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGpersona.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Telefono });
            DGpersona.Dock = DockStyle.Fill;
            DGpersona.Location = new Point(0, 0);
            DGpersona.Name = "DGpersona";
            DGpersona.RowHeadersWidth = 62;
            DGpersona.Size = new Size(1015, 347);
            DGpersona.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 550;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 250;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(DGpersona);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BTguardar);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1015, 460);
            splitContainer1.SplitterDistance = 347;
            splitContainer1.TabIndex = 1;
            // 
            // BTguardar
            // 
            BTguardar.Location = new Point(452, 40);
            BTguardar.Name = "BTguardar";
            BTguardar.Size = new Size(112, 34);
            BTguardar.TabIndex = 0;
            BTguardar.Text = "Guardar";
            BTguardar.UseVisualStyleBackColor = true;
            BTguardar.Click += button1_Click;
            // 
            // FRMhmxlaccess
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 460);
            Controls.Add(splitContainer1);
            Name = "FRMhmxlaccess";
            Text = "FRMhmxlaccess";
            ((System.ComponentModel.ISupportInitialize)DGpersona).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGpersona;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private SplitContainer splitContainer1;
        private Button BTguardar;
    }
}