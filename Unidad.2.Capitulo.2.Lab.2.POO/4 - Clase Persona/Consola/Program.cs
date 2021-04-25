using System;
using _4___Clase_Persona;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Pepe", "Argento", "1970/06/12", 12123123);
            Console.WriteLine($"El nombre de la persona es {persona.Nombre} y el apellido es {persona.Apellido}");
            Console.WriteLine($"El nombre y apellido de la persona es {persona.GetFullName()}");
            Console.WriteLine($"La fecha de nacimiento de la persona es {persona.FechaNacimiento} y tiene {persona.GetAge()} años de edad");
            Console.WriteLine($"El número de documento de la persona es {persona.DNI}");
            Console.WriteLine("Programa finalizado.");
        }
    }
}
