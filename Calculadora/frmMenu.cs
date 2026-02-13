using Calculadora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnBurbuja burbuja = new frnBurbuja();
            burbuja.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMtemporizadores reloj = new FRMtemporizadores();
            reloj.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMeditor editor = new FRMeditor();
            editor.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRcontador contador = new FRcontador();
            contador.Show();
        }
    }
}
