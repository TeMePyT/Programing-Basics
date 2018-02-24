using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivanovi_s_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstGiftPrice = double.Parse(Console.ReadLine());
            double secondGiftPrice = double.Parse(Console.ReadLine());
            double thirdGiftPrice = double.Parse(Console.ReadLine());

            double totalPrice = firstGiftPrice + secondGiftPrice + thirdGiftPrice;
            double moneyLeft = budget - totalPrice;
            
            double taxedChange = moneyLeft - moneyLeft*0.1;
            

            Console.WriteLine($"{taxedChange:F2}");
        }
    }
}
