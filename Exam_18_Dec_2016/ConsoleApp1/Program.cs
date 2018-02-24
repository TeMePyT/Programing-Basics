using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double moneySpared = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double tileSideA = double.Parse(Console.ReadLine());
            double tileSideB = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double workerSalary = double.Parse(Console.ReadLine());

            double bathArea = width * height;
            double tilearea = (tileSideA * tileSideB) / 2;
            double tilesNeeded = Math.Ceiling(bathArea / tilearea) + 5;
            double moneyNeeded = (tilesNeeded * pricePerTile) + workerSalary;

            if (moneyNeeded<=moneySpared)
            {
                Console.WriteLine($"{moneySpared-moneyNeeded:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {moneyNeeded-moneySpared:F2} lv more.");
            }
        }
    }
}
