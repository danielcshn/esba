using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Escribir un programa que permita el ingreso de tres números enteros e
informe cuál es el más grande. 

 */

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número entero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número entero:");
            int numero3 = int.Parse(Console.ReadLine());

            // Comprobar cuál es el número más grande
            int maximo = numero1; // Supongamos que el primer número es el más grande inicialmente

            if (numero2 > maximo)
            {
                maximo = numero2;
            }

            if (numero3 > maximo)
            {
                maximo = numero3;
            }

            // Mostrar el resultado
            Console.WriteLine("El número más grande es: " + maximo);
        }
    }
}
