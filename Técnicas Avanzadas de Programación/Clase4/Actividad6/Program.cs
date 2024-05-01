using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
Re-escribir los 6 ejercicios de Actividades de la clase 3 pero usando métodos. Por
ejemplo, para el ejercicio que pedía el ingreso de tres números enteros e informar
cuál es el mayor, el algoritmo escrito que averiguaba qué número era el mayor que
este en un método (por ejemplo llamado Maximo ) que recibe tres enteros y
retorna un entero (el mayor).
Y así con todos los ejercicios de la Clase 3. Involucrar al menos un método en el
desarrollo del programa.

Supongamos que usted le debe $1000 a la compañía de la tarjeta de crédito
y los intereses son de 1.5% del saldo. Usted opta por dejar de usar la tarjeta
y pagar mensualmente una cantidad fija. Escriba un programa que permita
el ingreso de un monto y luego liste los saldos y el total pagado hasta que se
salde la deuda. Ejemplo de ejecución:

Ingrese pago:
100
Mes: 1 saldo: 915.0 total pagado: 100.0
Mes: 2 saldo: 828.725 total pagado: 200.0
Mes: 3 saldo: 741.155875 total pagado: 300.0
Mes: 4 saldo: 652.273213125 total pagado: 400.0
Mes: 5 saldo: 562.057311321875 total pagado: 500.0
Mes: 6 saldo: 470.4881709917031 total pagado: 600.0
Mes: 7 saldo: 377.54549355657866 total pagado: 700.0
Mes: 8 saldo: 283.20867595992735 total pagado: 800.0
Mes: 9 saldo: 187.4568060993263 total pagado: 900.0
Mes: 10 saldo: 90.26865819081618 total pagado: 1000.0
Mes: 11 saldo: -8.377311936321576 total pagado: 1100.0

 */

namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double deudaInicial = 1000.0;
            double tasaInteres = 0.015; // 1.5% de interés mensual
            double pagoMensual;

            Console.Write("Ingrese el pago mensual: ");
            pagoMensual = double.Parse(Console.ReadLine());

            SimularPagoDeuda(deudaInicial, tasaInteres, pagoMensual);
        }

        static void SimularPagoDeuda(double deudaInicial, double tasaInteres, double pagoMensual)
        {
            double saldo = deudaInicial;
            double totalPagado = 0.0;
            int mes = 1;

            while (saldo > 0)
            {
                double interes = saldo * tasaInteres;
                double abono = pagoMensual - interes;

                saldo -= abono;
                totalPagado += pagoMensual;

                Console.WriteLine($"Mes: {mes} saldo: {saldo:F6} total pagado: {totalPagado:F6}");
                mes++;
            }

            Console.WriteLine($"Mes: {mes} saldo: {saldo:F6} total pagado: {totalPagado:F6}");
        }
    }
}
