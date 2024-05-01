using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carTypes = { "Ford", "BMW", "Mazda", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };

            foreach (int i in myInts)
                Console.WriteLine(i);
        }
    }
}
