using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = -1.0;

            var fruitsDays = new Dictionary<string, double>
            {
                {"banana",  2.50},
                {"apple",  1.20},
                {"orange",  0.85},
                {"grapefruit",  1.45},
                {"kiwi",  2.70},
                {"pineapple",  5.50},
                {"grapes",  3.85},
            };
            var fruitsWeekend = new Dictionary<string, double>
            {
                {"banana",  2.70},
                {"apple",  1.25},
                {"orange",  0.90},
                {"grapefruit",  1.60},
                {"kiwi",  3.00},
                {"pineapple",  5.60},
                {"grapes",  4.20},
            };
            try
            {
                if (day == "monday") price = quantity * fruitsDays[fruit];
                else if (day == "tuesday") price = quantity * fruitsDays[fruit];
                else if (day == "wednesday") price = quantity * fruitsDays[fruit];
                else if (day == "thursday") price = quantity * fruitsDays[fruit];
                else if (day == "friday") price = quantity * fruitsDays[fruit];
                else if (day == "saturday") price = quantity * fruitsWeekend[fruit];
                else if (day == "sunday") price = quantity * fruitsWeekend[fruit];

                if (price >= 0)
                {
                    Console.WriteLine("{0:f2}", price);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            catch (KeyNotFoundException)
           
            {
                Console.WriteLine("error");
            }
        }
    }
}
