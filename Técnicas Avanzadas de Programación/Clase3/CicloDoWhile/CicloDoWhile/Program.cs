using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("Dentro de un ciclo do/while");
                Console.Write("¿Termina? [si] [no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "si"); // Note el punto y coma!!
        }
    }
}
