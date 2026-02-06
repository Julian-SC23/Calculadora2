namespace Calculadora
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            ordenamientosToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivoToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(147, 34);
            archivoToolStripMenuItem1.Text = "Salir";
            archivoToolStripMenuItem1.Click += archivoToolStripMenuItem1_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, ordenamientosToolStripMenuItem, registroToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(126, 29);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(270, 34);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // ordenamientosToolStripMenuItem
            // 
            ordenamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            ordenamientosToolStripMenuItem.Size = new Size(270, 34);
            ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(174, 34);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(270, 34);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem ordenamientosToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
    }
}