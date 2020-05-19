using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Departamento : División
    {
        private List<Seccion> secciones = new List<Seccion>();

        public List<Seccion> Secciones { get => secciones; set => secciones = value; }
        public override string ToString()
        {
            return Tipo + " " + Name + "; " + Encargado + " " + secciones;
        }
    }
}

