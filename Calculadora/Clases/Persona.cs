using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Clases
{
    internal class Persona
    {
        private string nombre = "";
        private string apellido = "";
        private DateTime fechaNacimiento;
        private int edad;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get { return edad = DateTime.Now.Year - fechaNacimiento.Year; }
            set { edad = value; }
        }
    }


}
