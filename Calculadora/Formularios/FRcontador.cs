using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FRcontador : Form
    {
        int contador = 0;
        public FRcontador()
        {
            InitializeComponent();
        }

        private void BTinicio_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            TMRcontador.Enabled = true;
            TMRcontador.Interval = trackBar1.Value * 200;
            TMRcontador.Start();
        }

        private void LBcuenta_Click(object sender, EventArgs e)
        {

        }

        private void BTdetener_Click(object sender, EventArgs e)
        {
            TMRcontador.Enabled = false;
            trackBar1.Enabled = false;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TMRcontador.Interval = trackBar1.Value * 200;
        }

        private void TMRcontador_Tick(object sender, EventArgs e)
        {
            contador++;
            LBcuenta.Text = contador.ToString();
        }
    }
}
