using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Escriba un programa que permita calcular las raíces de una ecuación de
segundo grado. La formula es: (- b  √b2 – 4 ac) / 2a. 

Nota: el programa también debe mostrar raíces complejas.
 
 */

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los coeficientes de la ecuación de segundo grado (ax^2 + bx + c = 0):");

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            // Calculamos el discriminante
            double discriminante = b * b - 4 * a * c;

            if (discriminante > 0)
            {
                // Dos raíces reales distintas
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las raíces son: " + raiz1 + " y " + raiz2);
            }
            else if (discriminante == 0)
            {
                // Raíces reales iguales
                double raiz = -b / (2 * a);
                Console.WriteLine("La única raíz es: " + raiz);
            }
            else
            {
                // Raíces complejas
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine("Las raíces son complejas:");
                Console.WriteLine("Raíz 1: " + parteReal + " + " + parteImaginaria + "i");
                Console.WriteLine("Raíz 2: " + parteReal + " - " + parteImaginaria + "i");
            }
        }
    }
}
