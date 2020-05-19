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
                    Console.Write("Nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Rut: ");
                    string rut = Console.ReadLine();
                    empresas.Add(new Empresa(name, rut));
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
