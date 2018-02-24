using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToRead = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());
                sum += readNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
