using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)

        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerAmmount = double.Parse(Console.ReadLine());
            double wineAmmount = double.Parse(Console.ReadLine());
            double rakiaAmmount = double.Parse(Console.ReadLine());
            double whiskeyAmmount = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskeyPrice / 2;
            double winePrice =rakiaPrice - rakiaPrice * 0.40;
            double beerPrice =rakiaPrice - rakiaPrice * 0.80;

            double whiskeyTotal = whiskeyAmmount * whiskeyPrice;
            double beerTotal = beerAmmount * beerPrice;
            double wineTotal = wineAmmount * winePrice;
            double rakiaTotal = rakiaAmmount * rakiaPrice;

            double moneyNeeded = whiskeyTotal + beerTotal + wineTotal + rakiaTotal;

            Console.WriteLine("{0:F2}", moneyNeeded);


        }
    }
}
