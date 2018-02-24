using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var ammount = double.Parse(Console.ReadLine());

            var price = 0.0;

            if(city=="sofia")
            {
                if(product=="coffee")
                {
                    price = 0.50;
                }
                else if(product=="water")
                {
                    price = 0.80;
                }
                else if(product=="beer")
                {
                    price = 1.20;
                }
                else if(product=="sweets")
                {
                    price = 1.45;
                }
                else
                {
                    price = 1.60;
                }
            }
            else if(city=="plovdiv")
            {
                if (product =="coffee")
                {
                    price = 0.40;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.30;
                }
                else
                {
                    price = 1.50;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.70;
                }
                else if (product == "beer")
                {
                    price = 1.10;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else
                {
                    price = 1.55;
                }
            }
            Console.WriteLine(ammount*price);
        
        }
    }
}
