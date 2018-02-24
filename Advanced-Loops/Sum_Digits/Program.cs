using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            while (number != 0)
            {
                result += number % 10;
                number = number / 10;
            } 
            Console.WriteLine(result);
        }
    }
}
