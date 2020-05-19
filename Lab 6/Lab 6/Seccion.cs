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
        public override string ToString()
        {
            string s = "\n" + Tipo + " " + Name + "; " + Encargado.ToString();
            foreach (Bloque d in bloques)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}

