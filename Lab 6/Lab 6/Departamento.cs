using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Departamento : División
    {
        private List<Seccion> secciones;

        public List<Seccion> Secciones { get => secciones; set => secciones = value; }
    }
}
