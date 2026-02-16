using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Calculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> Personas = new List<Persona>();
        
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void verificarRegistro()
        {
            if (Personas.Count == 0)
            {
                BTNeliminar.Enabled = false;
            }
            else
            {
                BTNeliminar.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void BTregistrar_Click(object sender, EventArgs e)
        {
            Personas.Add(new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaNacimiento = dtpFecha.Value
            });

            MessageBox.Show("Persona registrada con éxito");
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFecha.Value = DateTime.Now;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex >= 1)
            {

                DTGregistro.DataSource = null;
                DTGregistro.DataSource = Personas;
                verificarRegistro();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            Personas.RemoveAt(DTGregistro.CurrentRow.Index);
            DTGregistro.DataSource = null;
            DTGregistro.DataSource = Personas;
            verificarRegistro();
        }
    }
}
