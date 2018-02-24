using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());

            int leftSum = 0;
            for (int i = 0; i < numberToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                leftSum += readNumber;
            }

            int rightSum = 0;
            for (int i = 0; i < numberToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                rightSum += readNumber;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine( "No, diff = " + difference);
            }
        }
    }
}
