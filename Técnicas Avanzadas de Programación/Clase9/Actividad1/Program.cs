using System;

namespace Clase9
{
    class Program
    {
        static void Main(string[] args)
        {
            Jefe jefe = new Jefe("Fabio", "Lione", 500000);

            Console.WriteLine("Nombre del jefe: " + jefe.GetNombre());
            Console.WriteLine("Apellido del jefe: " + jefe.GetApellido());
            Console.WriteLine("Sueldo del jefe: " + jefe.GetSueldo());

            Trabajador empleado1 = new Trabajador("Luca", "Turilli", 300000);
            Trabajador empleado2 = new Trabajador("Alex", "Holzwarth", 250000);
            Trabajador empleado3 = new Trabajador("Patrice", "Guers", 200000);

            jefe.AddEmpleado(empleado1);
            jefe.AddEmpleado(empleado2);
            jefe.AddEmpleado(empleado3);

            Console.WriteLine("\nEmpleados del jefe:");
            for (int i = 0; i < jefe.m_empleados.Count; i++)
            {
                Console.WriteLine("Nombre: " + jefe.GetEmpleado(i).GetNombre());
                Console.WriteLine("Apellido: " + jefe.GetEmpleado(i).GetApellido());
                Console.WriteLine("Sueldo: $" + jefe.GetEmpleado(i).GetSueldo());
                Console.WriteLine();
            }
        }
    }
}
