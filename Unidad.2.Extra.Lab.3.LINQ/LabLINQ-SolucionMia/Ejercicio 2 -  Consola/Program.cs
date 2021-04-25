using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Ejercicio_2____Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int lectura;
            do
            {
                Console.Write("Ingrese número a agregar a la lista, para finalizar ingrese '0': ");
                lectura = Convert.ToInt32(Console.ReadLine());
                if (lectura != 0)
                    numeros.Add(lectura);
            } while (lectura != 0);
            var consulta2 = from num in numeros
                            where num > 20
                            select num;
            foreach (int num in consulta2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
