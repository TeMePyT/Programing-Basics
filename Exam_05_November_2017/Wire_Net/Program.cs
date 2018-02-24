using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int wightYard = int.Parse(Console.ReadLine());
            int heightYard = int.Parse(Console.ReadLine());
            double netHeight = double.Parse(Console.ReadLine());
            double netPrice = double.Parse(Console.ReadLine());
            double netWeightPerSqMeter = double.Parse(Console.ReadLine());

            int yardPerimeter = 2 * wightYard + 2 * heightYard;
            double totalNetPrice = yardPerimeter * netPrice;
            double totalNetArea = yardPerimeter * netHeight;
            double totalNetWeight = totalNetArea * netWeightPerSqMeter;

            Console.WriteLine(yardPerimeter);
            Console.WriteLine($"{totalNetPrice:F2}");
            Console.WriteLine($"{totalNetWeight:F3}");
        }
    }
}
