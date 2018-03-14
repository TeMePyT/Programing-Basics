using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int chocolates = int.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());

            double chocolatesPrice = chocolates * 0.65;
            double milkPrice = milk * 2.70;
            double mandarinesPrice = (Math.Floor(chocolates - (chocolates * 0.35)) * 0.20);

            double totalCost = chocolatesPrice + milkPrice + mandarinesPrice;

            if (budget >= totalCost)
            {
                Console.WriteLine($"You got this, {budget - totalCost:f2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalCost-budget:F2} more!");
            }
        }
    }
}
