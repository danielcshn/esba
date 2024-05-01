using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Escribir un programa que pida el ingreso de cinco nombres de personas y
sus edades. El programa debe mostrar el promedio de edad de las
personas ingresadas.
 
 */

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables para almacenar los nombres y edades, así como para calcular el promedio
            string[] nombres = new string[5];
            int[] edades = new int[5];
            int sumaEdades = 0;

            // Solicitar al usuario que ingrese los nombres y edades
            Console.WriteLine("Ingrese los nombres y edades de cinco personas:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();

                Console.Write("Edad " + (i + 1) + ": ");
                edades[i] = Convert.ToInt32(Console.ReadLine());

                // Sumar las edades para calcular el promedio más tarde
                sumaEdades += edades[i];
            }

            // Calcular el promedio de edad
            double promedioEdad = (double)sumaEdades / 5;

            // Mostrar el promedio de edad
            Console.WriteLine("El promedio de edad de las personas ingresadas es: " + promedioEdad);

        }
    }
}
