using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double startDough = double.Parse(Console.ReadLine());
            double breadGrams = double.Parse(Console.ReadLine());
            double breadPrice = double.Parse(Console.ReadLine());
            double breadSold = double.Parse(Console.ReadLine());
            double cakesSold = double.Parse(Console.ReadLine());

            double dayIncome = breadSold * breadPrice;
            double doughDayUsed = breadGrams * breadSold;
            double newDough = doughDayUsed;
            double cakePrice = (breadPrice * 0.25)+breadPrice;
            double cakegrams = breadGrams -( breadGrams * 0.20);
            double totalCakeDough = cakegrams * cakesSold; 
            double nightIncome = cakesSold * cakePrice;
            double totalDough = startDough + newDough;
            double totalDoughPrice = (totalDough / 1000) * 4;
            double totalPrice = dayIncome + nightIncome - totalDoughPrice;
            double doughUsed = doughDayUsed + totalCakeDough;

            Console.WriteLine($"Pure income: {totalPrice:F2} lv.");
            Console.WriteLine($"Dough used: {Math.Ceiling(doughUsed)} g.");

        }
    }
}
