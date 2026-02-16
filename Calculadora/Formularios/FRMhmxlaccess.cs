using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Calculadora.Formularios
{
    public partial class FRMhmxlaccess : Form
    {
        public FRMhmxlaccess()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Persona");
            xml.Add(new XElement("Persona"));

            for (int i = 0; i < DGpersona.Rows.Count; i++)
            {
                new XmlElement("Personas"),
                    new XAttribute("ID", DGpersona.Rows[i].Cells[0].Value),
                    new XElement("Nombre", DGpersona.Rows[i].Cells[1].Value),
                    new XElement("Telefono", DGpersona.Rows[i].Cells[2].Value
                ));
            }
        Xml.save("Personas.xml");
        }
    }
}
