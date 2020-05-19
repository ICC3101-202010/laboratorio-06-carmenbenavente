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
            bool n = true;
            while (n)
            {
                Console.WriteLine("¿Quiere utilizar un archivo para cargar la información de la empresa?: \n (1) Sí \n (2) No \n (3) Cerrar programa");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    try
                    {
                        empresas = LoadE();
                        Console.WriteLine(empresas.ToString());
                    }
                    catch (FileNotFoundException exp)
                    {
                        Console.WriteLine("No se encontró el archivo, se creará uno nuevo.");
                        Console.WriteLine(exp.Message) ;
                        Console.WriteLine("Escriba los datos de la empresa");
                        Console.Write("Nombre: ");
                        string name = Console.ReadLine();
                        Console.Write("Rut: ");
                        string rut = Console.ReadLine();
                        Empresa e = new Empresa(name, rut);
                        Persona Edepartamento = new Persona("A", "A", "19.639.828-5", "Encargado Departamento");
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
                    catch (System.Runtime.Serialization.SerializationException exp1)
                    {
                        Console.WriteLine("El archivo está vacio, se creará uno nuevo.");
                        Console.WriteLine(exp1.Message);
                        Console.WriteLine("Escriba los datos de la empresa");
                        Console.Write("Nombre: ");
                        string name = Console.ReadLine();
                        Console.Write("Rut: ");
                        string rut = Console.ReadLine();
                        Empresa e = new Empresa(name, rut);
                        Persona Edepartamento = new Persona("A", "A", "19.639.828-5", "Encargado Departamento");
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
                        try
                        {
                            SaveE(empresas);
                        }
                        catch (System.IO.IOException exp2)
                        {
                            Console.WriteLine("No se logró guardar correctamente.");
                            Console.WriteLine(exp2.Message);
                        }
                    }
                    
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
                    try
                    {
                        SaveE(empresas);
                    }
                    catch (System.IO.IOException exp2)
                    {
                        Console.WriteLine("No se logró guardar correctamente.");
                        Console.WriteLine(exp2.Message);
                    }
                }
                else if (option == 3)
                {
                    n = false;
                }
            }
        }

        static private void SaveE(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
            Console.WriteLine("Se ha guardado correctamente");
        }

        static private List<Empresa> LoadE()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Se ha cargado correctamente");
            return empresas;
        }
    }
}
