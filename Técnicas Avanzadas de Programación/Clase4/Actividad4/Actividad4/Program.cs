using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Re-escribir los 6 ejercicios de Actividades de la clase 3 pero usando métodos. Por
ejemplo, para el ejercicio que pedía el ingreso de tres números enteros e informar
cuál es el mayor, el algoritmo escrito que averiguaba qué número era el mayor que
este en un método (por ejemplo llamado Maximo ) que recibe tres enteros y
retorna un entero (el mayor).
Y así con todos los ejercicios de la Clase 3. Involucrar al menos un método en el
desarrollo del programa.

Escribir un programa que pida el ingreso de un número entero positivo e
informe si el número es primo o no.

 
 */

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número entero positivo
            Console.WriteLine("Ingrese un número entero positivo:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificar si el número ingresado es primo y mostrar el resultado
            if (EsPrimo(numero))
            {
                Console.WriteLine("{0} es un número primo.", numero);
            }
            else
            {
                Console.WriteLine("{0} no es un número primo.", numero);
            }
        }

        // Método para verificar si un número es primo
        static bool EsPrimo(int num)
        {
            // Si el número es menor o igual a 1, no es primo
            if (num <= 1)
            {
                return false;
            }

            // Verificar si el número es divisible por algún número entre 2 y la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // Si es divisible, no es primo
                }
            }

            return true; // Si no es divisible por ningún número, es primo
        }
    }
}
