using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Area : División
    {
        private List<Departamento> departamentos;

        public List<Departamento> Departamentos { get => departamentos; set => departamentos = value; }
    }
}
