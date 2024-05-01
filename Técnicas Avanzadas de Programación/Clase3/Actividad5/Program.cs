using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Escribir un programa que liste todos los números primos entre 1 y un n
dado. (n entero positivo).
 
 */

namespace Actividad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero positivo:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Números primos entre 1 y {n}:");
            ListarNumerosPrimos(n);
        }

        static void ListarNumerosPrimos(int n)
        {
            for (int numero = 2; numero <= n; numero++)
            {
                if (EsPrimo(numero))
                {
                    Console.WriteLine(numero);
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
