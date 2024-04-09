using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese las dos cadenas de texto
            Console.Write("Ingrese la primera cadena de texto: ");
            string cadena1 = Console.ReadLine();

            Console.Write("Ingrese la segunda cadena de texto: ");
            string cadena2 = Console.ReadLine();

            // Crear la tercera cadena intercalando los caracteres de las cadenas ingresadas
            string cadena3 = IntercalarCadenas(cadena1, cadena2);

            // Mostrar la tercera cadena resultante
            Console.WriteLine($"La tercera cadena intercalada es: {cadena3}");
        }

        // Función para intercalar los caracteres de dos cadenas
        static string IntercalarCadenas(string cadena1, string cadena2)
        {
            // Obtener la longitud de las cadenas
            int longitud1 = cadena1.Length;
            int longitud2 = cadena2.Length;

            // Calcular la longitud total de la tercera cadena
            int longitudTotal = longitud1 + longitud2;

            // Crear un arreglo de caracteres para la tercera cadena
            char[] caracteres = new char[longitudTotal];

            // Índices para recorrer las cadenas
            int indice1 = 0, indice2 = 0, indice3 = 0;

            // Iterar hasta que se haya recorrido toda la longitud total
            while (indice3 < longitudTotal)
            {
                // Si hay caracteres disponibles en la primera cadena
                if (indice1 < longitud1)
                {
                    caracteres[indice3] = cadena1[indice1];
                    indice1++;
                    indice3++;
                }

                // Si hay caracteres disponibles en la segunda cadena
                if (indice2 < longitud2)
                {
                    caracteres[indice3] = cadena2[indice2];
                    indice2++;
                    indice3++;
                }
            }

            // Convertir el arreglo de caracteres a una cadena y devolverla
            return new string(caracteres);
        }
    }
}
