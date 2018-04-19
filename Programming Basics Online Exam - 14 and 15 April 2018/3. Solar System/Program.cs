using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Solar_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string planetToVisit = Console.ReadLine();
            byte daysSpent = byte.Parse(Console.ReadLine());

            Dictionary<string, double> distance = new Dictionary<string, double>()
            {
                { "Mercury", 0.61 },
                {"Venus", 0.28 },
                { "Mars",0.52},
                {"Jupiter",  4.2},
                {"Saturn", 8.52 },
                {"Uranus", 18.21 },
                {"Neptune", 29.09 }
            };
            Dictionary<string, int> allowedDays = new Dictionary<string, int>()
            {
                { "Mercury", 7 },
                {"Venus", 14 },
                { "Mars",20},
                {"Jupiter", 5},
                {"Saturn", 3 },
                {"Uranus", 3 },
                {"Neptune", 2 }
            };
            double value;
            int value1;

            if (!distance.ContainsKey(planetToVisit))
            {
                Console.WriteLine("Invalid planet name!");
            }
            if (allowedDays.ContainsKey(planetToVisit))
            {
                allowedDays.TryGetValue(planetToVisit, out value1);

                if (daysSpent > value1)
                {
                    Console.WriteLine("Invalid number of days!");
                    return;
                }
               
            }
            if(distance.ContainsKey(planetToVisit))
            {
                distance.TryGetValue(planetToVisit, out value);

                double totaldistance = 2 * value;
                double days = 2 * (226 * value) + daysSpent;
                Console.WriteLine($"Distance: {totaldistance:f2}");
                Console.WriteLine($"Total number of days: {days:f2}");
            }


        }
    }
}
