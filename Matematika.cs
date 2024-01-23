using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3, b = 4, c = 7, d = 2;
            double x = ((a * a) + (b * b) + (c * c) + (d * d)) / (((a + b) * (a + b)) + ((c + d) * (c + d)));
            Console.WriteLine("Rezultat: " + x);

            Console.ReadLine();
        }
    }
}
