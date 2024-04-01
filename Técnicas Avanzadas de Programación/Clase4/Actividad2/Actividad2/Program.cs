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

Calcular ab por productos sucesivos.
 
 */

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese los coeficientes de la ecuación
            Console.WriteLine("Ingrese el coeficiente 'a':");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el coeficiente 'b':");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el coeficiente 'c':");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calcular las raíces de la ecuación
            CalcularRaices(a, b, c);
        }

        // Método para calcular las raíces de la ecuación de segundo grado
        static void CalcularRaices(double a, double b, double c)
        {
            // Calcular el discriminante
            double discriminante = b * b - 4 * a * c;

            // Si el discriminante es positivo, hay dos raíces reales y distintas
            if (discriminante > 0)
            {
                double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("Las raíces son: {0} y {1}", raiz1, raiz2);
            }
            // Si el discriminante es cero, hay dos raíces reales e iguales
            else if (discriminante == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("La raíz doble es: {0}", raiz);
            }
            // Si el discriminante es negativo, hay dos raíces complejas conjugadas
            else
            {
                double parteReal = -b / (2 * a);
                double parteImaginaria = Math.Sqrt(-discriminante) / (2 * a);
                Console.WriteLine("Las raíces son complejas: {0} + {1}i y {0} - {1}i", parteReal, parteImaginaria);
            }
        }
    }
}
