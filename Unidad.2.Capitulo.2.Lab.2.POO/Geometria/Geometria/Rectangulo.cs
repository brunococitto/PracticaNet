using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private double m_lados1;
        private double m_lados2;
        public double Lados1 { get; set; }
        public double Lados2 { get; set; }
        public override double CalcularPerimetro()
        {
            return 2 * Lados1 + 2 * Lados2;
        }
        public override double CalcularSuperficie()
        {
            return Lados1 * Lados2;
        }
    }
}