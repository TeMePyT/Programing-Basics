using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (num <=100)
            {
                bonusScore = 5;
            }
            else if (num > 1000)
            {
                bonusScore = num * 10 / 100.0;
            }
            else if (num > 100)
            {
                bonusScore = num * 20 / 100.0;
            }
            if (num % 2 ==0)
            {
                bonusScore += 1;
            }
            else if (num % 10 ==5)
            {
                bonusScore +=2;
            }
            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
