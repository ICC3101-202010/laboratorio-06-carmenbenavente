using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Seccion : División
    {
        private List<Bloque> bloques = new List<Bloque>();

        public List<Bloque> Bloques { get => bloques; set => bloques = value; }
        public Seccion(List<Bloque> departamentos, string name, Persona encargado, string tipo) : base(name, encargado, tipo)
        {
            this.Bloques = departamentos;
        }
        public override string ToString()
        {
            string s = "\n" + this.Tipo + " " + this.Name + "; " + this.Encargado.ToString();
            foreach (Bloque d in bloques)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}

