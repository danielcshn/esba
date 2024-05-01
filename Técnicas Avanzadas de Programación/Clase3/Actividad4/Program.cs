using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Escribir un programa que pida el ingreso de un número entero positivo e
informe si el número es primo o no.

 */

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero positivo:");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
        }

        static bool EsPrimo(int numero)
        {
            // Los números menores o iguales a 1 no son primos
            if (numero <= 1)
            {
                return false;
            }

            // Verificar si el número es divisible por algún número entre 2 y la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false; // Si es divisible, no es primo
                }
            }

            return true; // Si no es divisible por ningún número, es primo
        }
    }
}
