using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int mazeNum = int.Parse(Console.ReadLine());
            int talkingToy = int.Parse(Console.ReadLine());
            int bearToy = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truckToy = int.Parse(Console.ReadLine());

            int totalToys = mazeNum + talkingToy + bearToy + minion + truckToy;

            double priceMaze = mazeNum * 2.60;
            double priceTalkingToy = talkingToy * 3;
            double priceBearToy = bearToy * 4.10;
            double priceMinion = minion * 8.20;
            double priceTruckToy = truckToy * 2;

            double Profit = priceBearToy + priceMaze + priceTalkingToy + priceMinion + priceTruckToy;
            double discountPrice = Profit - Profit * 0.25;

            if (totalToys >= 50)
            {
                double rent = discountPrice * 0.10;
                double finalProfit = discountPrice - rent;

                if (tripPrice <= finalProfit)
                {
                    Console.WriteLine("Yes! {0:F2} lv left.", finalProfit - tripPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:F2} lv needed.", tripPrice - finalProfit);
                }
            }
            else if (totalToys < 50)
            {
                double rent = Profit * 0.10;
                double finalProfit = Profit - rent;
                if (tripPrice <= finalProfit)
                {
                    Console.WriteLine("Yes! {0:F2} lv left.", finalProfit - tripPrice);
                }
                else
                {
                    Console.WriteLine("Not enough money! {0:F2} lv needed.", tripPrice - finalProfit);
                }
            }

        }
    }
}
