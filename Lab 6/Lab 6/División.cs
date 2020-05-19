﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    [Serializable]
    public class División
    {
        private string name;
        private Persona encargado;
        private string tipo;

        public string Name { get => name; set => name = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        internal Persona Encargado { get => encargado; set => encargado = value; }
    }
}
