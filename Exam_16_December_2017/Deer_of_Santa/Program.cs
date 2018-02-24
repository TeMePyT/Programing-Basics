using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAway = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double firstDeerFood = double.Parse(Console.ReadLine());
            double secondDeerFood = double.Parse(Console.ReadLine());
            double thirdDeerFood = double.Parse(Console.ReadLine());

            double totalFood = firstDeerFood * daysAway + secondDeerFood * daysAway + thirdDeerFood * daysAway;

            if (totalFood<=food)
            {
                Console.WriteLine($"{Math.Floor(food-totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood-food)} more kilos of food are needed.");
            }

        }
    }
}
