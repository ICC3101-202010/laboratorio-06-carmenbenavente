using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Persona
    {
        private string name;
        private string lastname;
        private string rut;
        private string position;

        public Persona(string name, string lastname, string rut, string position)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Rut = rut;
            this.Position = position;
        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Position { get => position; set => position = value; }

        public override string ToString()
        {
            return name + " " + lastname + "; " + rut + " " + position;
        }
    }
}
