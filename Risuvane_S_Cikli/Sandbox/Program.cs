using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sandPrice = double.Parse(Console.ReadLine());
            double plankPrice = double.Parse(Console.ReadLine());

            double sandSquare = (a - 0.4) * (b - 0.4);
            double totalArea = a * b;
            double plankArea = totalArea - sandSquare;
            double sandNeeded = Math.Ceiling(sandSquare * 20);
            double plankNeeded = Math.Ceiling(plankArea / (2.2 * 0.2));
            double totalSandPrice = sandNeeded * sandPrice;
            double totalPlankPrice = plankNeeded * plankPrice;
            double totalSum = totalPlankPrice + totalSandPrice;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
