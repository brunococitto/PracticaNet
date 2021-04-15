using System;

namespace Lab01_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] datos = new string[cantIteraciones];
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write($"Ingrese valor para la posición {i+1}: ");
                datos[i] = Console.ReadLine();
            }
            for (int i = 0; i < cantIteraciones; i++)
            // Esto también se puede facer con un for (int i = cantIteraciones - 1; i >= 0; i--)
            {
                int posicion = cantIteraciones - i;
                Console.Write($"El valor de la posición {posicion} es: ");
                Console.WriteLine(datos[posicion - 1]); // Le resto 1 porque el índice empieza en 0
            }
        }
    }
}
