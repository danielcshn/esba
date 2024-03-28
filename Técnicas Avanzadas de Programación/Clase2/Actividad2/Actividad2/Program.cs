using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Escribir un programa que calcule el área de un circulo. Se ingresa el radio
del circulo por teclado. Puede usar la constante PI de la clase Math,
haciendo Math.Pi.

La formula del área de un circulo es: π * r^2

Para calcular el cuadrado del radio pueden hacer Radio x Radio o bien usar
el método Pow de Math, haciendo:
Math.Pow(Radio, 2) → devuelve el resultado de Radio elevado al cuadrado. 

 */

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el radio del círculo
            Console.Write("Ingrese el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del círculo usando la fórmula A = π * r^2
            double area = Math.PI * Math.Pow(radio, 2);

            // Mostrar el resultado
            Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
        }
    }
}
