using System;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir y inicializar el arreglo 3x3
            int[,] arreglo = new int[,] { { 3, 5, 1 }, { 10, 1, 45 }, { 2, 4, 4 } };

            // 2.1 Listar el contenido de la tabla
            Console.WriteLine("Contenido de la tabla:");
            ImprimirTabla(arreglo);

            // 2.2 Mostrar los elementos de las diagonales
            Console.WriteLine("\nElementos de la diagonal principal:");
            ImprimirDiagonalPrincipal(arreglo);
            Console.WriteLine("\nElementos de la diagonal secundaria:");
            ImprimirDiagonalSecundaria(arreglo);

            // 2.3 Buscar un valor entero en el arreglo
            Console.Write("\nIngrese un valor entero a buscar en el arreglo: ");
            int valorBuscado = int.Parse(Console.ReadLine());
            BuscarValor(arreglo, valorBuscado);
        }

        // Función para imprimir el contenido de la tabla
        static void ImprimirTabla(int[,] arreglo)
        {
            int filas = arreglo.GetLength(0);
            int columnas = arreglo.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{arreglo[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        // Función para imprimir los elementos de la diagonal principal
        static void ImprimirDiagonalPrincipal(int[,] arreglo)
        {
            int dimension = Math.Min(arreglo.GetLength(0), arreglo.GetLength(1));

            for (int i = 0; i < dimension; i++)
            {
                Console.Write($"{arreglo[i, i]} ");
            }
        }

        // Función para imprimir los elementos de la diagonal secundaria
        static void ImprimirDiagonalSecundaria(int[,] arreglo)
        {
            int dimension = Math.Min(arreglo.GetLength(0), arreglo.GetLength(1));

            for (int i = 0; i < dimension; i++)
            {
                Console.Write($"{arreglo[i, dimension - 1 - i]} ");
            }
        }

        // Función para buscar un valor en el arreglo e imprimir su posición
        static void BuscarValor(int[,] arreglo, int valor)
        {
            int filas = arreglo.GetLength(0);
            int columnas = arreglo.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (arreglo[i, j] == valor)
                    {
                        Console.WriteLine($"Valor encontrado en posición {i},{j}");
                        return;
                    }
                }
            }
            Console.WriteLine("Valor no encontrado en el arreglo.");
        }
    }
}
