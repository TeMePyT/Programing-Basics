using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = (int)(decimal.Parse(Console.ReadLine()) * 100);
            IList<int> coinTypes = new List<int> { 200, 100, 50, 20, 10, 5, 2, 1 };
            int coinCount = 0;

            foreach (int coinType in coinTypes)
            {
                if (input >= coinType)
                {
                    coinCount += input / coinType;
                    input -= (input / coinType) * coinType;
                }
            }

            Console.WriteLine(coinCount);
        }
    }
}
