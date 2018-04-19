using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char capitalLetter = Convert.ToChar(Console.ReadLine().ToUpper());
            char smallLetter = Convert.ToChar(Console.ReadLine().ToLower());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int count = 0;
            bool IsFound = false;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 'A'; j <= capitalLetter; j++)
                {
                    for (int k = 'a'; k <= smallLetter; k++)
                    {
                        for (int l = 1; l <= secondNumber; l++)
                        {
                            for (int m = 1; m <= thirdNumber; m++)
                            {
                                for (int n = 1; n <= fourthNumber; n++)
                                {
                                    count++;
                                    if (position == count)
                                    {

                                        Console.WriteLine($"{i}{Convert.ToChar(j)}{Convert.ToChar(k)}{l}{m}{n}");
                                        IsFound = true;
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!IsFound)
            {
                Console.WriteLine("No password on this position");
            }
        }
    }
}
