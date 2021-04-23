using System;

namespace Lab01_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas deseadas: ");
            int numero_filas = int.Parse(Console.ReadLine());
            int cant_asteriscos = 1;
            int cant_espacios = numero_filas - 1;
            for (int i = 1; i <= numero_filas; i++)
            {  
                // para no usar cant_espacios acá sería j <= numero_filas - i
                for (int j = 1; j <= cant_espacios; j++)
                {
                    Console.Write(" ");
                }
                cant_espacios--;
                // con esto se puede hacer sin usar las variables auxiliares
                // la condición del for seria j <= (1 + 2 * ( i - 1 )) o j <= (2 * i - 1)
                // Console.WriteLine($"i = {i}, Prueba: {i + (2 * (i - 1))}, Prueba 2: {1 + 2 * (i - 1)}, Prueba 3: {2* i - 1}");
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
