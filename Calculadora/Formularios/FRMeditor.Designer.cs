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
            editarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            SSeditor = new StatusStrip();
            TSstatus = new ToolStripStatusLabel();
            RTBeditor = new RichTextBox();
            OFPeditor = new OpenFileDialog();
            SFDeditor = new SaveFileDialog();
            FDeditor = new FontDialog();
            CDeditor = new ColorDialog();
            colorToolStripMenuItem = new ToolStripMenuItem();
            MSeditor.SuspendLayout();
            SSeditor.SuspendLayout();
            SuspendLayout();
            // 
            // MSeditor
            // 
            MSeditor.ImageScalingSize = new Size(24, 24);
            MSeditor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem });
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
            nuevoToolStripMenuItem.Size = new Size(228, 34);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(228, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(228, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(228, 34);
            guardarComoToolStripMenuItem.Text = "Guardar como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(228, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(225, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(225, 6);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(73, 29);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(270, 34);
            fuenteToolStripMenuItem.Text = "Fuente";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // SSeditor
            // 
            SSeditor.ImageScalingSize = new Size(24, 24);
            SSeditor.Items.AddRange(new ToolStripItem[] { TSstatus });
            SSeditor.Location = new Point(0, 418);
            SSeditor.Name = "SSeditor";
            SSeditor.Size = new Size(800, 32);
            SSeditor.TabIndex = 1;
            SSeditor.Text = "statusStrip1";
            // 
            // TSstatus
            // 
            TSstatus.Name = "TSstatus";
            TSstatus.Size = new Size(77, 25);
            TSstatus.Tag = "";
            TSstatus.Text = "Palabras";
            TSstatus.Click += TSstatus_Click;
            TSstatus.TextChanged += TSstatus_TextChanged;
            // 
            // RTBeditor
            // 
            RTBeditor.Location = new Point(0, 36);
            RTBeditor.Name = "RTBeditor";
            RTBeditor.Size = new Size(800, 380);
            RTBeditor.TabIndex = 2;
            RTBeditor.Text = "";
            RTBeditor.TextChanged += RTBeditor_TextChanged;
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
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(270, 34);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
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
            SSeditor.ResumeLayout(false);
            SSeditor.PerformLayout();
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
        private ToolStripStatusLabel TSstatus;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private FontDialog FDeditor;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog CDeditor;
    }
}