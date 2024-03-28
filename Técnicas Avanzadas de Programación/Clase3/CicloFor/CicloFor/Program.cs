using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: "i" es solo visible dentro del ámbito del ciclo for.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Numero: {0} ", i);
            }
            // "i" no es visible aquí.
        }
    }
}
