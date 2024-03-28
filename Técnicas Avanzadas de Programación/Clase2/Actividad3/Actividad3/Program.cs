using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Una estación de servicio se encuentra ubicada en la ruta 51. No existe otra
estación expendedora de combustible en 200 km a la redonda. Escriba un
programa que permita averiguar si un vehículo necesita combustible para
llegar a la próxima estación. El programa pide la siguiente información:

- La capacidad de combustible del tanque.
- Cuánto indica la aguja del marcador de combustible en porcentaje.
- Los kilómetros por cada litro de consumo.

El programa debe imprimir en pantalla “Necesita combustible” o
“Combustible suficiente” dependiendo si el auto puede o no transitar los 200
km con el combustible existente en el tanque.
 
 */

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario la capacidad del tanque, el porcentaje de combustible y los km por litro
            Console.Write("Ingrese la capacidad del tanque de combustible en litros: ");
            double capacidadTanque = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de combustible en el tanque (0-100): ");
            double porcentajeCombustible = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese los kilómetros por litro de consumo: ");
            double kmPorLitro = Convert.ToDouble(Console.ReadLine());

            // Calcular la cantidad de combustible en litros en base al porcentaje
            double combustibleEnLitros = capacidadTanque * (porcentajeCombustible / 100);

            // Calcular la distancia que el vehículo puede recorrer con el combustible actual
            double distanciaPosible = combustibleEnLitros * kmPorLitro;

            // Verificar si la distancia posible es suficiente para llegar a la próxima estación
            if (distanciaPosible >= 200)
            {
                Console.WriteLine("Combustible suficiente. Puede transitar los 200 km.");
            }
            else
            {
                Console.WriteLine("Necesita combustible. No puede transitar los 200 km.");
            }
        }
    }
}
