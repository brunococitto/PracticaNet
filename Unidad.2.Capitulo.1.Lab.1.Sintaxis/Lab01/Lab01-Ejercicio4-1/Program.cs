using System;

namespace Lab01_Ejercicio4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int numero1 = Int16.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int numero2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma de {numero1} y {numero2} es {numero1 + numero2}");
        }
    }
}
