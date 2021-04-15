using System;

namespace Lab01_Ejercicio4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 20;
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                if (i <= 1 )
                {
                    numeros[i] = 1;
                } else
                {
                    numeros[i] = numeros[i - 1] + numeros[i - 2];
                }
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
