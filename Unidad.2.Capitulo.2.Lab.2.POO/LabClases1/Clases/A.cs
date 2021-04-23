using System;

namespace Clases
{
    public class A
    {
        private string _NombreInstancia;
        public A ()
        {
            _NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            _NombreInstancia = nombre;
        }
        // se puede hacer como public string NombreInstancia { get; set; };
        public string NombreInstancia
        {
            get
            {
                return _NombreInstancia;
            }
            set
            {
                _NombreInstancia = value;
            }
        }
        public void MostrarNombre()
        {
            Console.WriteLine(_NombreInstancia);
        }
        public void M1()
        {
            Console.WriteLine("El método M1 fue invocado.");
        }
        public void M2()
        {
            Console.WriteLine("El método M2 fue invocado.");
        }
        public void M3()
        {
            Console.WriteLine("El método M2 fue invocado.");
        }
    }
}
