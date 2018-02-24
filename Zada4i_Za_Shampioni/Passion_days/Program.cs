using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passion_days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal shoppingMoney = decimal.Parse(Console.ReadLine());

            int purchases = 0;

            string command = Console.ReadLine();

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    decimal price = 0;
                    if (action >= 'A' && action <= 'Z')
                    {
                        price = action * 0.5m;
                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        price = action * 0.3m;
                    }
                    else if (action == '%' && shoppingMoney > 0)
                    {
                        price = shoppingMoney / 2;
                    }
                    else if (action == '*')
                    {
                        shoppingMoney += 10;
                        continue;
                    }
                    else
                    {
                        price = action;
                    }
                    if (shoppingMoney < price)
                    {
                        continue;
                    }
                    shoppingMoney -= price;
                    purchases++;
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {shoppingMoney:F2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases} purchases. Money left: {shoppingMoney:F2} lv.");
            }
        }
    }
}
