using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Bloque : División
    {
        private List<Persona> personas = new List<Persona>();

        public List<Persona> Personas { get => personas; set => personas = value; }
        public Bloque(List<Persona> departamentos, string name, Persona encargado, string tipo) : base(name, encargado, tipo)
        {
            this.Personas = departamentos;
        }
        public override string ToString()
        {
            string s = "\n" + this.Tipo + " " + this.Name + "; " + this.Encargado.ToString();
            foreach (Persona d in personas)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}
