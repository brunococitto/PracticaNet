using System;

namespace Lab01_Ejercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el año deseado: ");
            int anoIngresado = Int16.Parse(Console.ReadLine());
            bool esBisiesto = false;
            if (anoIngresado % 4 == 0)
            {
                esBisiesto = true;
                if (anoIngresado % 100 == 0)
                {
                    esBisiesto = false;
                    if (anoIngresado % 400 == 0)
                    {
                        esBisiesto = true;
                    }    
                }
            }
            if (esBisiesto)
            {
                Console.WriteLine("El año ingresado sí es bisiesto.");
            } else
            {
                Console.WriteLine("El año ingresado no es bisiesto.");
            }
        }
    }
}
