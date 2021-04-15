using System;

namespace Lab01_Ejercicio4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero <= 100)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
        }
    }
}
