using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Ejercicio_3___Consola
{
    public class Ciudad
    {
        public Ciudad(string nombre, int codigoPostal)
        {
            Nombre = nombre;
            CodigoPostal = codigoPostal;
        }
        public string Nombre { get; set; }
        public int CodigoPostal { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList()
            {
                new Ciudad("Rosario", 2000),
                new Ciudad("Firmat", 2630),
                new Ciudad("Casilda", 2170),
                new Ciudad("Chabas", 2173),
                new Ciudad("San Lorenzo", 2200),
                new Ciudad("Villa Gobernador Galvez", 2124),
                new Ciudad("Carcarña", 2138),
                new Ciudad("Salto", 2741),
                new Ciudad("Venado Tuerto", 2600),
                new Ciudad("Santa Fe", 3000)
            };
            Console.Write("Ingrese 3 caracteres para buscar el código postal de la ciudad: ");
            string input = Console.ReadLine().ToLower();
            var consulta3 = from Ciudad ciu in ciudades
                            where ciu.Nombre.ToLower().Contains(input)
                            select ciu;
            if (consulta3.Count() > 0)
            {
                Console.WriteLine($"Usted ingresó los caracteres {input}, y la búsqueda dio los siguientes resultados:");
                foreach (Ciudad ciu in consulta3)
                {
                    Console.WriteLine($"El código postal de {ciu.Nombre} es {ciu.CodigoPostal}");
                }
            }
            else
                Console.WriteLine("Su búsqueda no arrojó ningun resultado :(");
        }
    }
}
