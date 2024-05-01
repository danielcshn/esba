using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

“Cacho y Marta Delicatessen” (altas confituras) desean un programa para
tomar pedidos. El programa pide por un producto y su precio. Además se
cobra envío de acuerdo a la siguiente consideración: pedidos menores a
$20 es de $2, superiores a $20 el costo es de $3. Si el pedido se realiza
después de medianoche se le suman $5 más.
Ejemplo de ejecución del programa:

Ingrese producto:
Pastafrola de dos pisos.
Precio:
12.00
Despues de medianoche (0==no, 1==yes)
1

Factura:
Pastafrola dos pisos 12.00
Envío 7.00
Total 11.50

 */

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicitar al usuario el producto y su precio
            Console.WriteLine("Ingrese el nombre del producto:");
            string producto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            double precio = Convert.ToDouble(Console.ReadLine());

            // Verificar si el pedido se realiza después de medianoche
            Console.WriteLine("¿El pedido se realiza después de medianoche? (0 == no, 1 == sí)");
            int despuesDeMedianoche = Convert.ToInt32(Console.ReadLine());

            // Calcular el costo de envío según el precio del pedido
            double costoEnvio = (precio < 20) ? 2.0 : 3.0;

            // Si es después de medianoche, sumar $5 al costo de envío
            if (despuesDeMedianoche == 1)
            {
                costoEnvio += 5.0;
            }

            // Calcular el total
            double total = precio + costoEnvio;

            // Mostrar la factura
            Console.WriteLine("Factura:");
            Console.WriteLine(producto + " " + precio.ToString("C2"));
            Console.WriteLine("Envío " + costoEnvio.ToString("C2"));
            Console.WriteLine("Total " + total.ToString("C2"));

        }
    }
}
