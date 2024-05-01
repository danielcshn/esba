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

Calcular a^b por productos sucesivos.

 */

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese los valores de a y b
            Console.WriteLine("Ingrese el valor de a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Calcular a^b utilizando productos sucesivos
            int resultado = CalcularPotencia(a, b);

            // Mostrar el resultado
            Console.WriteLine("El resultado de {0}^{1} es: {2}", a, b, resultado);
        }

        // Método para calcular a^b utilizando productos sucesivos
        static int CalcularPotencia(int a, int b)
        {
            // Inicializar el resultado como 1
            int resultado = 1;

            // Realizar b veces la multiplicación de a
            for (int i = 0; i < b; i++)
            {
                resultado *= a;
            }

            return resultado;
        }
    }
}
