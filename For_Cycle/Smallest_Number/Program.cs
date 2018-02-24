using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int smallestNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {

                int readNumber = int.Parse(Console.ReadLine());

                if (readNumber > smallestNumber)
                {
                    smallestNumber = readNumber;
                }

            }
            Console.WriteLine(smallestNumber);
        }
    }
}
