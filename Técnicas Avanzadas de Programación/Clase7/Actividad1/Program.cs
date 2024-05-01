using System;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            Cliente cliente1 = new Cliente(123456789, "Varg", "Abigail", "Calle Falsa 123", "11/07/1992", 1500.0);

            Console.WriteLine("Cliente: " + cliente1.ObtenerNombre() + " " + cliente1.ObtenerApellido());
            Console.WriteLine("Dirección: " + cliente1.ObtenerDireccion());
            Console.WriteLine("Fecha de Nacimiento: " + cliente1.ObtenerFechaNac());
            Console.WriteLine("Saldo inicial: $" + cliente1.ObtenerSaldo());

            // Depositar $500
            cliente1.Depositar(500);
            Console.WriteLine("Saldo después de depositar $500: $" + cliente1.ObtenerSaldo());

            // Retirar $200 (saldo suficiente)
            double nuevoSaldo = cliente1.Retirar(200);
            if (nuevoSaldo != -1)
            {
                Console.WriteLine("Saldo después de retirar $200: $" + nuevoSaldo);
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para retirar $200.");
            }

            // Intentar retirar $1500 (saldo insuficiente)
            nuevoSaldo = cliente1.Retirar(1500);
            if (nuevoSaldo != -1)
            {
                Console.WriteLine("Saldo después de retirar $1500: $" + nuevoSaldo);
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo para retirar $1500.");
            }
        }
    }
}
