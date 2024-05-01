using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Calcular a^b por productos sucesivos. 

 */

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            int b = int.Parse(Console.ReadLine());

            double resultado = Potencia(a, b);

            Console.WriteLine($"{a}^{b} = {resultado}");
        }

        static double Potencia(double a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else if (b < 0)
            {
                // Si b es negativo, calculamos la potencia de (1/a) con exponente positivo
                return 1 / Potencia(a, -b);
            }
            else
            {
                double result = 1;
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
                return result;
            }
        }
    }
}
