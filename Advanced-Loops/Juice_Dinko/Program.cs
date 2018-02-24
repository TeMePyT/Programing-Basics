using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juice_Dinko
{
    class Program
    {
        static void Main(string[] args)
        {
            int raspberries = int.Parse(Console.ReadLine());
            int strawberries = int.Parse(Console.ReadLine());
            int cherries = int.Parse(Console.ReadLine());
            int juice = int.Parse(Console.ReadLine());

            int outRaspberries = 0;
            int outStrawberries = 0;
            int outCherries = 0;
            double biggestEver = 0;

            for (int i = 0; i <= cherries; i++)
            {
                for (int j = 0; j <= strawberries; j++)
                {
                    for (int k = 0; k <= raspberries; k++)
                    {
                        double temp = i *15 + j *7.5 + k * 4.5;
                        if (temp <= juice)
                        {
                            if (temp > biggestEver)
                            {
                                biggestEver = temp;
                            }

                            if (temp >= biggestEver)
                            {
                                outCherries = i;
                                outStrawberries = j;
                                outRaspberries = k;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{outRaspberries} Raspberries, {outStrawberries} Strawberries, {outCherries} Cherries. Juice: {biggestEver} ml.");
        }
    }
}
