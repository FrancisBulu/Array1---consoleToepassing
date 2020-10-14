using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1___consoleToepassing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 3 getallen in");

            double[] getal = new double[3];
            getal[0] = 0;
            getal[1] = 0;
            getal[2] = 0;

            for (int i = 0; i <= 2; i++)
            {
                getal[i] = Int64.Parse(Console.ReadLine());
                Console.WriteLine($"Jouw getal nummer {i + 1} is {getal[i]}");
            }
            double som = getal[0] + getal[1] + getal[2];
            Console.WriteLine($"De som van jouw getallen is: {som}");
        }
    }
}
