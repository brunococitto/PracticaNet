using System;
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodo 1 - Lee byte por byte - Menos eficiente para estos archivos
            // FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            // while (lector.Length > lector.Position)
            // {
            //    Console.Write((char)lector.ReadByte());
            // }
            // lector.Close();
            //Console.WriteLine("Hello World!");

            // Metodo 2 - Lee linea por linea
            // Mostrado así derecho como sale del archivo
            // StreamReader lector = File.OpenText("agenda.txt");
            // string linea;
            // do
            // {
            //    linea = lector.readline();
            //    if (linea != null)
            //    {
            //        console.writeline(linea);
            //    }
            //} while (linea != null);
            //lector.close();

            // Mostrado más presentable
            leer();
            escribir();
        }
        private static void leer ()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\te-mail\t\t\tTelefono");
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine($"{valores[0]}\t{valores[1]}\t{valores[2]}\t{valores[3]}");
                }
            } while (linea != null);
            lector.Close();
        }
        private static void escribir ()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevos contactos");
            string rta = "S";
            while (rta == "S")
            {
                Console.Write("Ingrese nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese apellido:");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese e-mail:");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese telefono:");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine(nombre + ";" + apellido + ";" + email + ";" + telefono);

                Console.Write("¿Desea ingresar otro contacto? (S/N)");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
    }
}
