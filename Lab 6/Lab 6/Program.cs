using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> empresas = new List<Empresa>();
            while (true)
            {
                Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?: \n (1) Sí \n (2) No");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    empresas = LoadE();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Escriba los datos de la empresa");
                    Console.Write("Nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Rut: ");
                    string rut = Console.ReadLine();
                    Empresa e = new Empresa(name, rut);
                    Persona Edepartamento = new Persona("A","A","19.639.828-5","Encargado Departamento");
                    Persona Eseccion = new Persona("B", "B", "19.689.587-8", "Encargado Sección");
                    Persona Ebloque1 = new Persona("C", "C", "20.881.887-4", "Encargado Bloque");
                    Persona Ebloque2 = new Persona("D", "D", "11.833.498-K", "Encargado Bloque");
                    Persona persona1 = new Persona("E", "E", "12.232.498-4", "Trabajador");
                    Persona persona2 = new Persona("F", "F", "8.107.074-3", "Trabajador");
                    Persona persona3 = new Persona("G", "G", "19.685.827-1", "Trabajador");
                    Persona persona4 = new Persona("H", "H", "20.463.389-4", "Trabajador");
                    Bloque bloque1 = new Bloque();
                    Bloque bloque2 = new Bloque();
                    Seccion seccion = new Seccion();
                    Departamento departamento = new Departamento();
                    bloque1.Personas.Add(persona1);
                    bloque1.Personas.Add(persona2);
                    bloque2.Personas.Add(persona3);
                    bloque2.Personas.Add(persona4);
                    bloque1.Encargado = Ebloque1;
                    bloque2.Encargado = Ebloque2;
                    seccion.Encargado = Eseccion;
                    departamento.Encargado = Edepartamento;
                    e.Divisiones.Add(bloque1);
                    e.Divisiones.Add(bloque2);
                    e.Divisiones.Add(seccion);
                    e.Divisiones.Add(departamento);
                    empresas.Add(e);
                    SaveE(empresas);
                }
            }
        }
        static private void SaveE(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }

        static private List<Empresa> LoadE()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresas;
        }
    }
}
