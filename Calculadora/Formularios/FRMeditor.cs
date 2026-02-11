using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formularios
{
    public partial class FRMeditor : Form
    {
        bool saver = false;
        String path = "";
        public FRMeditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFPeditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(OFPeditor.FileName))
                {
                    
                    
                        RTBeditor.Text = File.ReadAllText(OFPeditor.FileName);
                    

                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saver = false)
            {
                guardarjeje();
                saver= true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path)) 
                {
                    archivo.Write(RTBeditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            guardarjeje();
        }

        private void guardarjeje()
        {
            if (SFDeditor.ShowDialog() == DialogResult.OK)
            {
                path = SFDeditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(RTBeditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTBeditor.Clear();
            path = "";
            saver = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
