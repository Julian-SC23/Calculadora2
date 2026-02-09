using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using CSCore.SoundOut;


namespace Calculadora.Formularios
{
    public partial class FRMtemporizadores : Form
    {
        string alarma = null;

        public FRMtemporizadores()
        {
            InitializeComponent();
        }

        private void TMRhora_Tick(object sender, EventArgs e)
        {
            LBLhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (LBLhora.Text == alarma)
            {
                SoundPlayer alarma = new SoundPlayer(@"C:\Users\salin\Downloads\dragon-studio-rooster-crowing-364473.wav");
                alarma.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma = Interaction.InputBox("Ingrese la hora para la alarma (hh:mm:ss tt)", "Sistema", "00:00:00 x.x");

        }

        private void LBLhora_Click(object sender, EventArgs e)
        {

        }
    }
}
