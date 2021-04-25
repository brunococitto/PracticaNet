using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> provincias = new List<string> {
            "buenos aires", "catamarca", "chubut", "jujuy", "salta", "formosa", "santa fe", "tucuman", "la rioja",
            "san luis", "san juan", "rio negro", "neuquen", "tierra del fuego", "cordoba", "santiago del estero",
            "chaco", "corrientes", "entre rios", "la pampa", "mendoza", "santa cruz", "misiones"
            };
            var consulta = from prov in provincias
                           where prov[0] == 's' | prov[0] == 't'
                           select prov;
            foreach (string prov in consulta)
            {
                Console.WriteLine(prov);
            }
        }
    }

}
