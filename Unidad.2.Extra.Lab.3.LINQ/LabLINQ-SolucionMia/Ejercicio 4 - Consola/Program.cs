using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_4___Consola
{
    public class Empleado
    {
        public Empleado(int id, string nombre, decimal sueldo)
        {
            ID = id;
            Nombre = nombre;
            Sueldo = sueldo;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            int _id;
            do
            {
                Console.Write("Ingrese ID del empleado, para finalizar la carga ingrese '-1': ");
                _id = Convert.ToInt32(Console.ReadLine());
                if (_id != -1)
                {
                    Console.Write("Ingrese nombre del empleado: ");
                    string _nombre = Console.ReadLine();
                    Console.Write("Ingrese sueldo del empleado': ");
                    decimal _sueldo = Convert.ToDecimal(Console.ReadLine());
                    empleados.Add(new Empleado(_id, _nombre, _sueldo));
                }
            } while (_id != -1);
            Console.WriteLine("===== Lista de empleados ordenados por sueldo ascendente =====");
            var consulta = from Empleado emp in empleados
                           orderby emp.Sueldo ascending
                           select emp;
            foreach (Empleado emp in consulta)
            {
                Console.WriteLine($"ID:, {emp.ID}; Nombre: {emp.Nombre}; Sueldo: {emp.Sueldo}");
            }
            Console.WriteLine("===== Lista de empleados ordenados por sueldo descendente =====");
            consulta = from Empleado emp in empleados
                           orderby emp.Sueldo descending
                           select emp;
            foreach (Empleado emp in consulta)
            {
                Console.WriteLine($"ID:, {emp.ID}; Nombre: {emp.Nombre}; Sueldo: {emp.Sueldo}");
            }
        }
    }
}