using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Area : División
    {
        private List<Departamento> departamentos = new List<Departamento>();

        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }
        public override string ToString()
        {
            return Tipo + " " + Name + "; " + Encargado + " " + departamentos;
        }
    }
}

