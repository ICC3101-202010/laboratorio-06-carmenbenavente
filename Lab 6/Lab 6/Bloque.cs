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
        public override string ToString()
        {
            string s = "\n" + Tipo + " " + Name + "; " + Encargado.ToString();
            foreach (Persona d in personas)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}
