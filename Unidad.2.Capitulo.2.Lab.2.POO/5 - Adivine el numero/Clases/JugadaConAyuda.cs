using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) {}
        public new void Comparar(int numeroInput)
        {
            if (numeroInput == Numero)
                Adivino = true;
            else
            {
                // Esto de la diferencia lo puse por porcentajes, entonces depende mucho del rango de números
                // Cumple pero se podría mejorar muchísimo más haciéndo que sea dinámico según el rango
                int diferencia = Math.Abs(Numero - numeroInput);
                if (diferencia > Numero * 0.5)
                    Console.WriteLine("Estás bastante lejos");
                else if (diferencia > Numero * 0.25)
                    Console.WriteLine("Estas lejos");
                else if (diferencia > Numero * 0.1)
                    Console.WriteLine("Estar cerca!");
                else
                    Console.WriteLine("Estas bastante cerca!");
            }
        }
    }
}