using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private double m_lado1;
        private double m_lado2;
        private double m_lado3;

        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public double CalcularSuperficie()
        {
            double s = CalcularPerimetro() / 2; // Semiperimetro
            double area = Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
            return area;
        }
    }
}