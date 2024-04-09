using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];

            // Cargar el arreglo
            Console.WriteLine("Ingrese 10 números enteros:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            // 1.1 Averiguar el acumulado del arreglo
            int acumulado = 0;
            foreach (int num in arreglo)
            {
                acumulado += num;
            }
            Console.WriteLine($"Acumulado del arreglo: {acumulado}");

            // 1.2 Encontrar el elemento más grande
            int maximo = arreglo[0];
            foreach (int num in arreglo)
            {
                if (num > maximo)
                {
                    maximo = num;
                }
            }
            Console.WriteLine($"Elemento más grande: {maximo}");

            // 1.3 Encontrar el elemento más chico
            int minimo = arreglo[0];
            foreach (int num in arreglo)
            {
                if (num < minimo)
                {
                    minimo = num;
                }
            }
            Console.WriteLine($"Elemento más chico: {minimo}");

            // 1.4 Imprimir el arreglo desde el último elemento al primero
            Console.WriteLine("Arreglo en orden inverso:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
    }
}
