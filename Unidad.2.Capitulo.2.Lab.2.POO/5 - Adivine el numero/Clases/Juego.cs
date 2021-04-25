using System;

namespace Clases
{
    public class Juego
    {
        private int _record;
        private int _Numeromaximo;
        private JugadaConAyuda _jugada;

        public Juego()
        {
            Record = 0;
            NumeroMaximo = 0;
        }

        ~Juego() {
            Console.WriteLine("Muchas gracias por jugar!");
        }

        public int Record { get; set; }

        private JugadaConAyuda Jugada { get; set; }

        private int NumeroMaximo { get; set; }

        public void ComenzarJuego()
        {
            // Esto podría ir en el constructor y usar el mismo máximo para todas las partidas
            PreguntarMaximo();
            Jugada = new JugadaConAyuda(NumeroMaximo);
            Intento();
        }

        private void Intento()
        {
            Jugada.Comparar(PreguntarNumero());
            Jugada.Intento++;
            if (Jugada.Adivino)
            {
                Console.WriteLine($"Acertaste el número! Este era {Jugada.Numero}, te llevó {Jugada.Intento} intentos.");
                CompararRecord();
                Continuar();
            }
            else
            {
                Console.WriteLine($"No acertaste el número! Llevas {Jugada.Intento} intentos.");
                Intento();
            }
        }

        private void CompararRecord()
        {
            if (Jugada.Intento < Record | Record == 0)
            {
                Record = Jugada.Intento;
                Console.WriteLine($"Estableciste un nuevo record de {Record} intentos!");
            }   
            else
                Console.WriteLine($"El record continúa siendo de {Record} intentos.");
        }

        private int PreguntarNumero()
        {
            int nroInput;
            do
            {
                Console.Write($"Ingrese un número entre 0 y {NumeroMaximo}: ");
                nroInput = Convert.ToInt32(Console.ReadLine());
                if (nroInput < 0 | nroInput > NumeroMaximo)
                    Console.WriteLine("El número ingresado está fuera del rango aceptado!");
            } while (nroInput < 0 | nroInput > NumeroMaximo);
            return nroInput;
        }
        private void PreguntarMaximo()
        {
            do
            {
                Console.Write($"Ingrese el número máximo deseado: ");
                NumeroMaximo = Convert.ToInt32(Console.ReadLine());
                if (NumeroMaximo <= 0)
                    Console.WriteLine("El número ingresado es menor o igual a 0!");
            } while (NumeroMaximo <= 0);
        }
        private void Continuar()
        {
            Console.Write("Desea jugar otra vez? si / no: ");
            if (Console.ReadLine().ToLower() == "si")
            {
                Console.Clear();
                ComenzarJuego();
            }
        }
    }
}
