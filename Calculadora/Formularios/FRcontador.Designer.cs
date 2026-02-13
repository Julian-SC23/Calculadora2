namespace Calculadora.Formularios
{
    partial class FRcontador
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
            LBcuenta = new Label();
            BTinicio = new Button();
            BTdetener = new Button();
            trackBar1 = new TrackBar();
            TMRcontador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // LBcuenta
            // 
            LBcuenta.AutoSize = true;
            LBcuenta.Font = new Font("Arial", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBcuenta.Location = new Point(286, 43);
            LBcuenta.Name = "LBcuenta";
            LBcuenta.Size = new Size(59, 65);
            LBcuenta.TabIndex = 0;
            LBcuenta.Text = "0";
            LBcuenta.Click += LBcuenta_Click;
            // 
            // BTinicio
            // 
            BTinicio.Location = new Point(173, 298);
            BTinicio.Name = "BTinicio";
            BTinicio.Size = new Size(112, 34);
            BTinicio.TabIndex = 1;
            BTinicio.Text = "Inicio";
            BTinicio.UseVisualStyleBackColor = true;
            BTinicio.Click += BTinicio_Click;
            // 
            // BTdetener
            // 
            BTdetener.Location = new Point(378, 298);
            BTdetener.Name = "BTdetener";
            BTdetener.Size = new Size(112, 34);
            BTdetener.TabIndex = 2;
            BTdetener.Text = "Detener";
            BTdetener.UseVisualStyleBackColor = true;
            BTdetener.Click += BTdetener_Click;
            // 
            // trackBar1
            // 
            trackBar1.Enabled = false;
            trackBar1.Location = new Point(54, 156);
            trackBar1.Maximum = 5;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(523, 69);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 1;
            // 
            // TMRcontador
            // 
            TMRcontador.Interval = 1;
            TMRcontador.Tick += TMRcontador_Tick;
            // 
            // FRcontador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 373);
            Controls.Add(trackBar1);
            Controls.Add(BTdetener);
            Controls.Add(BTinicio);
            Controls.Add(LBcuenta);
            Name = "FRcontador";
            Text = "FRcontador";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBcuenta;
        private Button BTinicio;
        private Button BTdetener;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer TMRcontador;
    }
}