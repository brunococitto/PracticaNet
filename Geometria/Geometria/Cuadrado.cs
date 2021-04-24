using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public double Lados
        {
            get
            {
                return Lados1;
            }
            set
            {
                Lados1 = value;
                Lados2 = value;
            }
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lados1;
        }
        public override double CalcularSuperficie()
        {
            return Math.Pow(Lados1, 2);
        }
    }
}