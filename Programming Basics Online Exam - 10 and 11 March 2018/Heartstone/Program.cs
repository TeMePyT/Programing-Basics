using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heartstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int breakTime = int.Parse(Console.ReadLine());
            double cardsPrice = double.Parse(Console.ReadLine());
            double adventurePrice = double.Parse(Console.ReadLine());
            double cofeePrice = double.Parse(Console.ReadLine());

            int breakLeft = breakTime - 15;
            double totalCardsPrice = cardsPrice * 3;
            double totalAdvPrice = 2 * adventurePrice;
            double totalMoneySpent = totalAdvPrice + totalCardsPrice + cofeePrice;

            Console.WriteLine("{0:f2}", totalMoneySpent);
            Console.WriteLine(breakLeft);
        }
    }
}
