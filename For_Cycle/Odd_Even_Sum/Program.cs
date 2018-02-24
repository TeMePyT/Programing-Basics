using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for ( int i  = 0;  i < number; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += readNumber;
                }
                else
                {
                    oddSum += readNumber;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine( "Yes Sum = "+ oddSum);
            }
            else
            {
                int difference = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No Diff = "+difference);
            }
        }
    }
}
