using System;

namespace IngresoTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Nombre: ");
            string strNombre;
            strNombre = Console.ReadLine();
            Console.WriteLine("Usted Ingreso: " + strNombre);
        }
    }
}
