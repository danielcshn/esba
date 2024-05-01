using System;

// **Parcial: #1 de Técnicas Avanzadas de Programación**
// **Profesor: -**
// **Programa: Calcular la función exponencial (e^x) en C#**
// **Autor: danielcshn - https://github.com/danielcshn**
// **Fecha: 22/04/2024**

namespace Parcial_1
{
    class Program
    {
        // **Programa principal**
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                // Ingreso de x
                Console.WriteLine("\nIngrese el valor de x para calcular e^x:");
                double x = Convert.ToDouble(Console.ReadLine());
                // Cálculo de la función exponencial
                double result = CalcExpo(x);
                // Impresión del resultado
                Console.WriteLine($"\nEl valor de e^{x} es: {result}\n");

                // Preguntar si desea volver a calcular
                Console.WriteLine("¿Desea calcular otro número? (y/n)");
                string resp = Console.ReadLine();
                while (resp.ToLower() != "y" && resp.ToLower() != "n")
                {
                    Console.WriteLine("Por favor, ingrese 'y' para sí o 'n' para no:");
                    resp = Console.ReadLine();
                }
                if (resp.ToLower() != "y")
                {
                    cont = false;
                    Environment.Exit(0);
                }
            }
        }

        // **Función para calcular la exponencial (e^x)**
        static double CalcExpo(double x)
        {
            double r = 1.0;
            double t = 1.0;
            for (int i = 1; i <= 10; i++) {
                t *= x / i;
                r += t;
            }
            return r;
        }
    }
}
