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

 */

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicitar al usuario que ingrese tres números enteros
            Console.WriteLine("Ingrese el primer número entero:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número entero:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Llamar al método para encontrar el número más grande
            int max = EncontrarMaximo(num1, num2, num3);

            // Mostrar el número más grande
            Console.WriteLine("El número más grande es: " + max);

        }

        // Método para encontrar el número más grande entre tres números enteros
        static int EncontrarMaximo(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }
    }
}
