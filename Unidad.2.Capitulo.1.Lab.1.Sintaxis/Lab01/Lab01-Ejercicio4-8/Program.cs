using System;

namespace Lab01_Ejercicio4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            string clave_correcta = "clave123";
            while (intentos < 4)
            {
                intentos++;
                Console.Write("Introduzca su clave: ");
                string clave_ingresada = Console.ReadLine();
                if (clave_ingresada == clave_correcta)
                {
                    Console.WriteLine("La clave ingresada es correcta!");
                    break;
                } else
                {
                    Console.WriteLine("La clave ingresada es incorrecta!");
                }
            }
        }
    }
}
