using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Departamento : División
    {
        private List<Seccion> secciones = new List<Seccion>();

        public List<Seccion> Secciones { get => secciones; set => secciones = value; }
        public override string ToString()
        {
            string s = Tipo + " " + Name + "; " + Encargado.ToString();
            foreach (Seccion d in secciones)
            {
                s = s + " " + d.ToString();
            }
            return s;
        }
    }
}

