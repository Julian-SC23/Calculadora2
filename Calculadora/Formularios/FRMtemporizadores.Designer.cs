namespace Calculadora.Formularios
{
    partial class FRMtemporizadores
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
            LBLhora = new Label();
            TMRhora = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            establecerAlarma1ToolStripMenuItem = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LBLhora
            // 
            LBLhora.AutoSize = true;
            LBLhora.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLhora.Location = new Point(148, 77);
            LBLhora.Name = "LBLhora";
            LBLhora.Size = new Size(357, 83);
            LBLhora.TabIndex = 0;
            LBLhora.Text = "00:00:00 x.x";
            LBLhora.Click += LBLhora_Click;
            // 
            // TMRhora
            // 
            TMRhora.Enabled = true;
            TMRhora.Interval = 1000;
            TMRhora.Tick += TMRhora_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { establecerAlarma1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(679, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "MNSalarma";
            // 
            // establecerAlarma1ToolStripMenuItem
            // 
            establecerAlarma1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem });
            establecerAlarma1ToolStripMenuItem.Name = "establecerAlarma1ToolStripMenuItem";
            establecerAlarma1ToolStripMenuItem.Size = new Size(112, 29);
            establecerAlarma1ToolStripMenuItem.Text = "Establecer ";
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(270, 34);
            alarma1ToolStripMenuItem.Text = "alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // FRMtemporizadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 233);
            Controls.Add(LBLhora);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FRMtemporizadores";
            Text = "Reloj";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLhora;
        private System.Windows.Forms.Timer TMRhora;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem establecerAlarma1ToolStripMenuItem;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
    }
}