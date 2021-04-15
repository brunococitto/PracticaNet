using System;

namespace Lab01_Ejercicio4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            Console.Write("Ingrese el nombre del mes del que desee saber su número: ");
            string mes = Console.ReadLine().ToLower();
            for (int i = 0; i < meses.Length; i++)
            {
                if (mes == meses[i])
                {
                    Console.WriteLine($"El número del mes ingresado como parámetro, {mes}, es: {i + 1}");
                }
            }
        }
    }
}
