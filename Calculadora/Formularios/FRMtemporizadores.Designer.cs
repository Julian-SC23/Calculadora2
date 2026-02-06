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
            SuspendLayout();
            // 
            // LBLhora
            // 
            LBLhora.AutoSize = true;
            LBLhora.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLhora.Location = new Point(59, 21);
            LBLhora.Name = "LBLhora";
            LBLhora.Size = new Size(357, 83);
            LBLhora.TabIndex = 0;
            LBLhora.Text = "00:00:00 x.x";
            
            // 
            // TMRhora
            // 
            TMRhora.Enabled = true;
            TMRhora.Interval = 1000;
            TMRhora.Tick += TMRhora_Tick;
            // 
            // FRMtemporizadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 137);
            Controls.Add(LBLhora);
            Name = "FRMtemporizadores";
            Text = "Reloj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLhora;
        private System.Windows.Forms.Timer TMRhora;
    }
}