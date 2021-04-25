using System;

namespace _4___Clase_Persona
{
    public class Persona
    {
        private string m_nombre;
        private string m_apellido;
        private DateTime m_fechaNacimiento;
        private int m_dni;

        public Persona(string nombre, string apellido, string fechaNacimiento, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
            Console.WriteLine("Objeto persona creado correctamente.");
        }

        ~Persona()
        {
            Console.WriteLine("Objeto persona destruido correctamente.");
        }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public int DNI { get; set; }

        public string FechaNacimiento
        {
            get
            {
                return m_fechaNacimiento.ToShortDateString();
            }
            set
            {
                m_fechaNacimiento = Convert.ToDateTime(value);
            }
        }
        public string GetFullName()
        {
            return $"{Nombre} {Apellido}";
        }

        public int GetAge()
        {
            TimeSpan diferencia = DateTime.Now - m_fechaNacimiento;
            int edad = diferencia.Days / 365;
            return edad;
        }
    }
}
