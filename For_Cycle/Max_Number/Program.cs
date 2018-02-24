using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int biggestNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                
                int readNumber = int.Parse(Console.ReadLine());
                
                if (readNumber>biggestNumber)
                {
                    biggestNumber = readNumber;
                }
                
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
