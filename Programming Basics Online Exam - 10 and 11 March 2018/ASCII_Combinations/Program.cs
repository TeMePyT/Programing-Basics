using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numberSum = 0;
            int capitalSum = 0;
            int smallSum = 0;
            int restSum = 0;

            StringBuilder numbers = new StringBuilder();
            StringBuilder smallLetters = new StringBuilder();
            StringBuilder capitalLetters = new StringBuilder();
            StringBuilder rest = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                char nextChar = Convert.ToChar(Console.ReadLine());
                if (Char.IsNumber(nextChar))
                {
                    numberSum += nextChar;
                    numbers.Append(nextChar);
                }

                else if (Char.IsLower(nextChar))
                {
                    smallLetters.Append(nextChar);
                    smallSum += nextChar;
                }
                else if (Char.IsUpper(nextChar))
                {
                    capitalSum += nextChar;
                    capitalLetters.Append(nextChar);
                }
                else
                {
                    restSum += nextChar;
                    rest.Append(nextChar);
                }
            }
            if (numberSum >= smallSum && numberSum >= capitalSum && numberSum >= restSum)
            {
                Console.WriteLine($"Biggest ASCII sum is:{numberSum}");
                Console.WriteLine($"Combination of characters is:{numbers}");
            }
            else if (capitalSum > numberSum && capitalSum >= smallSum && capitalSum >= restSum)
            {
                Console.WriteLine($"Biggest ASCII sum is:{capitalSum}");
                Console.WriteLine($"Combination of characters is:{capitalLetters}");
            }
            else if(smallSum>numberSum&&smallSum>capitalSum&&smallSum>=restSum)
            {
                Console.WriteLine($"Biggest ASCII sum is:{smallSum}");
                Console.WriteLine($"Combination of characters is:{smallLetters}");
            }
            else
            {
                Console.WriteLine($"Biggest ASCII sum is:{restSum}");
                Console.WriteLine($"Combination of characters is:{rest}");
            }
        }
    }
}
