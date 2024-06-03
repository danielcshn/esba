using System;

// **Parcial: #2 de Técnicas Avanzadas de Programación**
// **Profesor: -**
// **Programa: Diseñar una clase que mantenga un arreglo (vector) de enteros, class Enteros. Con los siguientes datos y funciones miembros.**
// **Autor: danielcshn - https://github.com/danielcshn**
// **Fecha: 03/06/2024**

namespace Parcial2
{
    class Program
    {
        // **Programa principal**
        static void Main(string[] args)
        {
            Enteros enteros = new Enteros();
            Random random = new Random();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Añadir 10 números aleatorios");
                Console.WriteLine("2. Obtener elemento en una posición específica");
                Console.WriteLine("3. Modificar elemento en una posición específica");
                Console.WriteLine("4. Eliminar todos los elementos");
                Console.WriteLine("5. Verificar si el arreglo está vacío");
                Console.WriteLine("6. Obtener la longitud del arreglo");
                Console.WriteLine("7. Mostrar todos los elementos");
                Console.WriteLine("8. Salir\n");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Verificar si hay suficiente espacio para agregar 10 números aleatorios
                            if (enteros.GetLenght() + 10 > 100)
                            {
                                Console.WriteLine("\nNo hay suficiente espacio en el arreglo para añadir 10 números más.");
                            }
                            else
                            {
                                // Añadir 10 números aleatorios al arreglo
                                for (int i = 0; i < 10; i++)
                                {
                                    int num = random.Next(0, 100); // Generar un número aleatorio entre 0 y 99
                                    enteros.Add(num);
                                }
                                Console.WriteLine("\nSe añadieron 10 números aleatorios al arreglo.");
                                Console.WriteLine("Cantidad total de elementos en el arreglo: " + enteros.GetLenght());
                            }
                            break;

                        case 2:
                            // Obtener elemento en una posición específica
                            Console.Write("\nIngrese la posición (0-" + (enteros.GetLenght()-1) + "): ");
                            int pos;
                            if (int.TryParse(Console.ReadLine(), out pos))
                            {
                                int elemento = enteros.GetAt(pos);
                                if (elemento != -1)
                                {
                                    Console.WriteLine($"\nElemento en la posición {pos}: {elemento}");
                                }
                            }
                            break;

                        case 3:
                            // Modificar elemento en una posición específica
                            Console.Write("\nIngrese la posición (0-" + (enteros.GetLenght() - 1) + "): ");
                            if (int.TryParse(Console.ReadLine(), out pos))
                            {
                                Console.Write("Ingrese el nuevo valor: ");
                                int valor;
                                if (int.TryParse(Console.ReadLine(), out valor))
                                {
                                    enteros.SetAt(valor, pos);
                                    Console.WriteLine($"Se ha modificado el elemento en la posición {pos}.");
                                }
                            }
                            break;

                        case 4:
                            // Eliminar todos los elementos
                            enteros.RemoveAll();
                            Console.WriteLine("\nTodos los elementos han sido eliminados.");
                            break;

                        case 5:
                            // Verificar si el arreglo está vacío
                            Console.WriteLine("\nEl arreglo está vacío: " + enteros.IsEmpty());
                            break;

                        case 6:
                            // Obtener la longitud del arreglo
                            Console.WriteLine("\nLongitud del arreglo: " + enteros.GetLenght());
                            break;

                        case 7:
                            // Mostrar todos los elementos
                            Console.WriteLine("\nElementos en el arreglo:");
                            for (int i = 0; i < enteros.GetLenght(); i++)
                            {
                                Console.WriteLine("Elemento en la posición " + i + ": " + enteros.GetAt(i));
                            }
                            break;

                        case 8:
                            // Salir
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("\nOpción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor, ingrese un número válido.");
                }
            }
        }
    }

    // **Enteros**
    public class Enteros
    {
        private const int MaxElementos = 100; // el arreglo interno de enteros que maneja la clase. MaxElementos es una constante: MaxElementos = 100.
        private int[] arreglo = new int[MaxElementos];
        private int CantidadElementos; // indica la cantidad de elementos actual de la lista.

        public Enteros()
        {
            CantidadElementos = 0; // El constructor lo inicializa en 0.
        }

        // Agrega, el elemento pasado como parámetro, al arreglo y retorna la posición. Verificar si aún hay lugar en en el arreglo.
        public int Add(int elemento)
        {
            if (CantidadElementos < MaxElementos)
            {
                arreglo[CantidadElementos] = elemento;
                CantidadElementos++;
                return CantidadElementos - 1; // Retorna la posición donde se añadió el elemento
            }
            else
            {
                Console.WriteLine("\nNo hay más espacio en el arreglo.");
                return -1; // Indica que no se pudo añadir el elemento
            }
        }

        // Devuelve el elemento ubicado en la posición dada por index. Verificar que index sea un índice válido del arreglo,
        // (no sea inferior a 0 o superior a MaxElementos), de lo contraio devuelve -1.
        public int GetAt(int index)
        {
            if (index >= 0 && index < CantidadElementos)
            {
                return arreglo[index];
            }
            else
            {
                Console.WriteLine("\nÍndice fuera de rango.");
                return -1; // Indica que el índice es inválido
            }
        }

        // Elimina todos los elementos del arreglo, (en realidad sólo hace CantidadElementos = 0).
        public void RemoveAll()
        {
            CantidadElementos = 0;
        }

        // Pone el 'elemento' en el arreglo en la posición indicada por index.
        public void SetAt(int elemento, int index)
        {
            if (index >= 0 && index < CantidadElementos)
            {
                arreglo[index] = elemento;
            }
            else
            {
                Console.WriteLine("\nÍndice fuera de rango.");
            }
        }

        // Devuelve la cantidad de elementos del arreglo, (o sea CantidadElementos).
        public int GetLenght()
        {
            return CantidadElementos;
        }

        // Devuelve true si el arreglo está vacío, de lo contrario false.
        public bool IsEmpty()
        {
            return CantidadElementos == 0;
        }
    }
}