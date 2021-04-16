using System;

namespace Lab01_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas deseadas: ");
            int numero_filas = Int16.Parse(Console.ReadLine());
            int cant_asteriscos = 1;
            int cant_espacios = numero_filas - 1;
            for (int i = 1; i <= numero_filas; i++)
            {
                for (int j = 1; j <= cant_espacios; j++)
                {
                    Console.Write(" ");
                }
                cant_espacios--;
                for (int j = 1; j <= cant_asteriscos; j++)
                {
                    Console.Write("*");
                }
                cant_asteriscos += 2;
                Console.Write("\n");
            }
        }
    }
}
