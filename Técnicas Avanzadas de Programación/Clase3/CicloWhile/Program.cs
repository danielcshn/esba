using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string userIsDone = "";
            // Atención: el ciclo checkea "si" en minúsculas
            while (userIsDone.ToLower() != "si")
            {
                Console.WriteLine("Dentro del ciclo while");
                Console.Write("¿Termina? [si] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
    }
}
