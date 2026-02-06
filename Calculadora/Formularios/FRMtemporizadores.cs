using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FRMtemporizadores : Form
    {
        public FRMtemporizadores()
        {
            InitializeComponent();
        }

        

        private void TMRhora_Tick(object sender, EventArgs e)
        {
            LBLhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
