using System;
using Geometria;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            circulo.Radio = 3;
            Console.WriteLine("========== Círculo ==========");
            Console.WriteLine($"El perímetro del círculo de radio {circulo.Radio} es: {circulo.CalcularPerimetro()}");
            Console.WriteLine($"La superficie del círculo de radio {circulo.Radio} es: {circulo.CalcularSuperficie()}");
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = 3;
            triangulo.Lado2 = 4;
            triangulo.Lado3 = 5;
            Console.WriteLine("========== Triángulo ==========");
            Console.WriteLine($"El perímetro del triángulo es: {triangulo.CalcularPerimetro()}");
            Console.WriteLine($"La superficie del triángulo es: {triangulo.CalcularSuperficie()}");
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Lados1 = 4.5;
            rectangulo.Lados2 = 5.4;
            Console.WriteLine("========== Rectángulo ==========");
            Console.WriteLine($"El perímetro del rectángulo es: {rectangulo.CalcularPerimetro()}");
            Console.WriteLine($"La superficie del rectángulo es: {rectangulo.CalcularSuperficie()}");
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Lados = 3.5;
            Console.WriteLine("========== Cuadrado ==========");
            Console.WriteLine($"El perímetro del cuadrado es: {cuadrado.CalcularPerimetro()}");
            Console.WriteLine($"La superficie del cuadrado es: {cuadrado.CalcularSuperficie()}");
        }
    }
}
