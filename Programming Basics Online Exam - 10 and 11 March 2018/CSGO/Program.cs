using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemsNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            if(itemsNumber>7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
                return;
            }

            int sum = 0;
            for (int i = 0; i < itemsNumber; i++)
            {
                string weapon = Console.ReadLine();

                switch(weapon)
                {
                    case "ak47":
                        sum += 2700;
                        break;
                    case "awp":
                        sum += 4750;
                        break;
                    case "sg553":
                        sum += 3500;
                        break;
                    case "grenade":
                        sum += 300;
                        break;
                    case "flash":
                        sum += 250;
                        break;
                    case "glock":
                        sum += 500;
                        break;
                    case "bazooka":
                        sum += 5600;
                        break;

                }
            }
            if(sum>budget)
            {
                Console.WriteLine($"Not enough money! You need {sum-budget} more money.");
            }
            else
            {
                Console.WriteLine($"You bought all {itemsNumber} items! Get to work and defeat the bomb!");
            }

        }
    }
}
