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
        int contadorpalabras = 0;
        String texto;
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
                saver = true;
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

        private void TSstatus_TextChanged(object sender, EventArgs e)
        {


        }

        private void RTBeditor_TextChanged(object sender, EventArgs e)
        {
            texto = RTBeditor.Text;
            String[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            contadorpalabras = palabras.Length;
            TSstatus.Text = $"Palabras: {contadorpalabras}";
        }

        private void TSstatus_Click(object sender, EventArgs e)
        {
            String[] palabras = texto.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            String[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show($"\tEstadisticas " +
                $"\nPalabras: "
                + TSstatus.Text + "\nLetras: " + texto.Length
                + "\nParrafos: " + parrafos.Length
                + "\nNúmero de palabras: " + palabras.Length);

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FDeditor.ShowDialog() == DialogResult.OK)
            {
                RTBeditor.Font = FDeditor.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CDeditor.ShowDialog() == DialogResult.OK)
            {
                RTBeditor.ForeColor = CDeditor.Color;
            }
        }
    }
}
