using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    public class Seccion : División
    {
        private List<Bloque> bloques;

        public List<Bloque> Bloques { get => bloques; set => bloques = value; }
    }
}
