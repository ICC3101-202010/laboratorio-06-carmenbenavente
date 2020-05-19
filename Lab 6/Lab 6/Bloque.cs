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
            return Tipo + " " + Name + "; " + Encargado + " " + personas;
        }
    }
}
