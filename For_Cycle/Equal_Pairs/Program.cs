using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxDiff = 0;
            int prevSum = 0;
          
            for (int i = 0; i < n * 2; i += 2)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int currentSum = number1 + number2;
                if (i == 0)
                {
                    prevSum = currentSum;
                    sum = currentSum;
                    
                }
                else
                {
                    if (prevSum!=currentSum)
                    {
                        int currentMaxDiff = Math.Abs(prevSum-currentSum);
                        if(currentMaxDiff>maxDiff)
                        {
                            maxDiff = currentMaxDiff;
                        }

                    }
                  
                }
                prevSum = currentSum;
            }
            

            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
