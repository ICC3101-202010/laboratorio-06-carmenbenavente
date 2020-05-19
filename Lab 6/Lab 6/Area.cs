using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Area : División
    {
        private List<Departamento> departamentos = new List<Departamento>();

        public Area(List<Departamento> departamentos, string name, Persona encargado, string tipo): base (name, encargado, tipo)
        {
            this.Departamentos = departamentos;
        }
        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }
        public override string ToString()
        {
            string s = "\n" + this.Tipo + " " + this.Name + "; " + this.Encargado.ToString();
            foreach (Departamento d in departamentos)
            {
                s = s + " " + d.ToString();
            }
            return s + "\n";
        }
    }
}

