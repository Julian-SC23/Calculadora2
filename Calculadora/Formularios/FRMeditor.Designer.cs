namespace Calculadora.Formularios
{
    partial class FRMeditor
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
            MSeditor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            SSeditor = new StatusStrip();
            RTBeditor = new RichTextBox();
            OFPeditor = new OpenFileDialog();
            SFDeditor = new SaveFileDialog();
            MSeditor.SuspendLayout();
            SuspendLayout();
            // 
            // MSeditor
            // 
            MSeditor.ImageScalingSize = new Size(24, 24);
            MSeditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            MSeditor.Location = new Point(0, 0);
            MSeditor.Name = "MSeditor";
            MSeditor.Size = new Size(800, 33);
            MSeditor.TabIndex = 0;
            MSeditor.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem, toolStripSeparator1, toolStripSeparator2 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(270, 34);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(270, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(270, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(270, 34);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(267, 6);
            // 
            // SSeditor
            // 
            SSeditor.ImageScalingSize = new Size(24, 24);
            SSeditor.Location = new Point(0, 428);
            SSeditor.Name = "SSeditor";
            SSeditor.Size = new Size(800, 22);
            SSeditor.TabIndex = 1;
            SSeditor.Text = "statusStrip1";
            // 
            // RTBeditor
            // 
            RTBeditor.Location = new Point(0, 36);
            RTBeditor.Name = "RTBeditor";
            RTBeditor.Size = new Size(800, 380);
            RTBeditor.TabIndex = 2;
            RTBeditor.Text = "";
            // 
            // OFPeditor
            // 
            OFPeditor.FileName = "openFileDialog1";
            OFPeditor.Filter = "\"Archivos de texto\" | *.txt";
            // 
            // SFDeditor
            // 
            SFDeditor.Filter = "\"Archivos de texto\" | *.txt";
            // 
            // FRMeditor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RTBeditor);
            Controls.Add(SSeditor);
            Controls.Add(MSeditor);
            MainMenuStrip = MSeditor;
            Name = "FRMeditor";
            Text = "FRMeditor";
            MSeditor.ResumeLayout(false);
            MSeditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MSeditor;
        private StatusStrip SSeditor;
        private RichTextBox RTBeditor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private OpenFileDialog OFPeditor;
        private SaveFileDialog SFDeditor;
    }
}