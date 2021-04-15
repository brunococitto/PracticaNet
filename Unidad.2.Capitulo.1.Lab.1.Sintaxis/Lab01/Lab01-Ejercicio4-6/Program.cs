using System;

namespace Lab01_Ejercicio4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglos auxiliares
            string[] millar = { "M", "MM", "MMM" };
            string[] centena = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] decena = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] unidad = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            Console.Write("Ingrese un número entero menor a 4000: ");
            int numero = Int16.Parse(Console.ReadLine());
            if (numero < 4000)
            {
                if (numero >= 1000)
                {
                    Console.Write(millar[numero/1000-1]);
                    numero = numero - Convert.ToInt32(numero / 1000) * 1000;
                }
                if (numero >= 100)
                {
                    Console.Write(centena[numero / 100 - 1]);
                    numero = numero - Convert.ToInt32(numero / 100) * 100;
                }
                if (numero >= 10)
                {
                    Console.Write(decena[numero / 10 - 1]);
                    numero = numero - Convert.ToInt32(numero / 10) * 10;
                }
                Console.WriteLine(unidad[numero - 1]);
            }
        }
    }
}
