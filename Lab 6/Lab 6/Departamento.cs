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
        public Departamento(List<Seccion> departamentos, string name, Persona encargado, string tipo) : base(name, encargado, tipo)
        {
            this.Secciones = departamentos;
        }
        public override string ToString()
        {
            string s = "\n" + this.Tipo + " " + this.Name + "; " + this.Encargado.ToString();
            foreach (Seccion d in secciones)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}

