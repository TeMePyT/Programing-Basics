using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            string arena = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            string itemType = Console.ReadLine().ToLower();


            

            int item = 0;
            double discount = 0;

            if (arena == "nagrand" && day == "monday" || day == "wednesday")
            {
                discount = 0.05;
            }
            else if (arena == "gurubashi" && day == "tuesday" || day == "thursday")
            {
                discount = 0.10;
            }
            else if (arena == "dire maul" && day == "friday" || day == "saturday")
            {
                discount = 0.07;
            }
            if (itemType == "poor")
            {
                double poor = 7000 - (7000 * discount);
                double pricePerItem = poor / 5;
                while (item < 5 && points > pricePerItem)
                {
                    points -= pricePerItem;
                    item++;
                }
              
            }
            if (itemType == "normal")
            {
                double poor = 14000 - (14000 * discount);
                double pricePerItem = poor / 5;
                while (item < 5 && points > pricePerItem)
                {
                    points -= pricePerItem;
                    item++;
                }
               
            }
            if (itemType == "legendary")
            {
                double poor = 21000 - (21000 * discount);
                double pricePerItem = poor / 5;
                while (item < 5 && points > pricePerItem)
                {
                    points -= pricePerItem;
                    item++;
                }
                
            }
            if (item == 5)
            {
                Console.WriteLine($"Items bought: {item}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Success!");
            }
            else
            {

                Console.WriteLine($"Items bought: {item}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Failure!");
            }
        }
    }
}
