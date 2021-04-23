using System;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A objeto_a_por_defecto = new A();
            A objeto_a_con_nombre = new A("Este a instancia sí tiene nombre");
            B objeto_b = new B();
            objeto_a_por_defecto.MostrarNombre();
            objeto_a_por_defecto.M1();
            objeto_a_por_defecto.M2();
            objeto_a_por_defecto.M3();
            objeto_a_con_nombre.MostrarNombre();
            objeto_b.MostrarNombre();
            objeto_b.M1();
            objeto_b.M4();
        }
    }
}
