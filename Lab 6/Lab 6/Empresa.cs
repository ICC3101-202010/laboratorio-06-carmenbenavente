using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class Empresa
    {
        private string name;
        private string rut;
        private List<División> divisiones = new List<División>();

        public Empresa(string name, string rut)
        {
            this.name = name;
            this.rut = rut;
        }

        public Empresa(string name, string rut, List<División> divisiones)
        {
            this.Name = name;
            this.Rut = rut;
            this.Divisiones = divisiones;
        }

        public string Name { get => name; set => name = value; }
        public string Rut { get => rut; set => rut = value; }
        internal List<División> Divisiones { get => divisiones; set => divisiones = value; }

        public override string ToString()
        {
            string s = "Nombre Empresa: " + name + " Rut: " + rut;
            foreach (División d in divisiones)
            {
                s = s + " " + d.ToString() + "\n";
            }
            return s;
        }
    }
}
