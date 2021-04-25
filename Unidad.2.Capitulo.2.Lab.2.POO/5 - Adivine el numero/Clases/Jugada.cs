using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino { get; set; }

        public int Intento { get; set; }

        public int Numero { get; set; }

        public void Comparar(int numeroInput)
        {
            if (numeroInput == Numero)
                Adivino = true;
        }
    }
}
