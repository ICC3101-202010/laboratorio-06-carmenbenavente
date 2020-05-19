using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Bloque : División
    {
        private List<Persona> personas;

        public List<Persona> Personas { get => personas; set => personas = value; }
    }
}
