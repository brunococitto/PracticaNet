using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su texto a continuación:");
            string inputTexto = Console.ReadLine();
            Console.WriteLine();
            if (inputTexto == "")
            {
                Console.WriteLine("No se ha ingresado ningún texto, saliendo de la aplicación...");
            } else
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1 - Mostrar el texto ingresado en mayúsculas");
                Console.WriteLine("2 - Mostrar el texto ingresado en minúsculas");
                Console.WriteLine("3 - Mostrar la cantidad de caracteres que tiene el texto ingresado");
                Console.Write("Ingrese la opción deseada: ");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Texto ingresado en mayúsculas: " + inputTexto.ToUpper());
                } else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Texto ingresado en minúsculas: " + inputTexto.ToLower());
                } else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Longitud del texto ingresado: " + inputTexto.Length);
                } else
                {
                    Console.WriteLine("La opción ingresada es incorrecta, saliendo de la aplicación...");
                }
            }
        }
    }
}
