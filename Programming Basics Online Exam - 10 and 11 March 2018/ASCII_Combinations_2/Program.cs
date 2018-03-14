using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Combinations_2
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

            string numbers = "";
            string smallLetters = "";
            string capitalLetters = "";
            string rest = "";

            for (int i = 0; i < n; i++)
            {
                char nextChar = Convert.ToChar(Console.ReadLine());
                if (nextChar >= '0' && nextChar <= '9')
                {
                    numberSum += nextChar;
                    numbers += nextChar;
                }

                else if (nextChar >= 'a' && nextChar <= 'z')
                {
                    smallLetters += nextChar;
                    smallSum += nextChar;
                }
                else if (nextChar >= 'A' && nextChar <= 'Z')
                {
                    capitalSum += nextChar;
                    capitalLetters += nextChar;
                }
                else
                {
                    restSum += nextChar;
                    rest += nextChar;
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
            else if (smallSum > numberSum && smallSum > capitalSum && smallSum >= restSum)
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
